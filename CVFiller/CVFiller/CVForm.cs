using CVFiller.Data;
using FormFiller.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFiller
{
    public partial class CVForm : Form
    {
        public List<Article> _data;
        public List<string> _tags;

        public const string Application = "Application.docx";
        public const string CV = "CV.docx";

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }


        public CVForm()
        {
            InitializeComponent();
            AddNotifyIconMenu();
            SetShortCuts();

            LoadData();
            SetHandleClickMethodForControls();

            SetFormTransparency(this);

            

        }

        private void SetFormTransparency(Form form)
        {
            form.BackColor = Color.LimeGreen;
            form.TransparencyKey = Color.LimeGreen;
        }

        private void SetHandleClickMethodForControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name == "lblChangeColorScheme")
                {
                    continue;
                }
                SetHandleClickForControl(control);
            }
        }

        private void SetHandleClickForControl(Control control)
        {
            if (control.GetType() == typeof(Label))
            {
                control.Click += Label_Click;
                control.MouseEnter += OnMouseEnter;
                control.MouseLeave += OnMouseLeave;
            }
            else if (control.GetType() == typeof(RichTextBox))
            {
                control.Click += RichTextBox_Click;
            }
            else if (control.HasChildren)
            {
                foreach (Control c in control.Controls)
                {
                    SetHandleClickForControl(c);
                }
            }
            else
            {
                return;
            }
        }

        private void OnMouseEnter(object sender, EventArgs e)
        {
            HandleHover(sender);
        }

        private void HandleHover(object sender)
        {
            if (sender is Label)
            {
                var label = sender as Label;
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Underline | FontStyle.Bold);
            }
        }

        private void HandleUnhover(object sender)
        {
            if (sender is Label)
            {
                var label = sender as Label;
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Regular);
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            HandleUnhover(sender);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            HandleClick(sender);
        }

        private void RichTextBox_Click(object sender, EventArgs e)
        {
            HandleClick(sender);
        }

        private void SetShortCuts()
        {
            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.Oem3.GetHashCode());

            id = 1;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.Escape.GetHashCode());

            id = 2;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D1.GetHashCode());

            id = 3;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D2.GetHashCode());

            id = 4;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D3.GetHashCode());

            id = 5;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D4.GetHashCode());


        }

        private void AddNotifyIconMenu()
        {
            this.notifyIcon.ContextMenuStrip = new System.Windows.Forms.ContextMenuStrip();
            this.notifyIcon.ContextMenuStrip.Items.Add("Settings", null, this.MenuSettings_Click);
            this.notifyIcon.ContextMenuStrip.Items.Add("Exit", null, this.MenuExit_Click);
        }

        private void MenuSettings_Click(object sender, EventArgs e)
        {
            this.HideForm();
            MessageBox.Show("Здесь будут настройки");
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static List<Control> GetControl(Control.ControlCollection controlCollection, Predicate<Control> match)
        {
            var list = new List<Control>();
            
            foreach (Control control in controlCollection)
            {
                if (match(control))
                {
                    list.Add(control);
                }
            }

            return list;
        }

        private void LoadData()
        {
            _data = new List<Article>();
            _tags = new List<string>();

            CurriculumVitae cv = new CurriculumVitae();
            cv.FirstName = "Anton";
            cv.LastName = "Miroshkin";
            cv.PhoneNumber = "+79161631867";
            cv.Email = "anton.miroshkin@gmail.com";

            _data.Add(new Article() { Value = cv.FirstName, Tags = new List<string>() { "contacts", "first", "name" } });
            _data.Add(new Article() { Value = cv.Email, Tags = new List<string>() { "contacts", "email" } });
            _data.Add(new Article() { Value = cv.PhoneNumber, Tags = new List<string>() { "contacts", "phone" } });
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                /* Note that the three lines below are not needed if you only want to register one hotkey.
                 * The below lines are useful in case you want to register multiple keys, which you can use a switch with the id as argument, or if you want to know which key/modifier was pressed for some particular reason. */

                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);                  // The key of the hotkey that was pressed.
                KeyModifier modifier = (KeyModifier)((int)m.LParam & 0xFFFF);       // The modifier of the hotkey that was pressed.
                int id = m.WParam.ToInt32();                                        // The id of the hotkey that was pressed.


                //MessageBox.Show("Hotkey has been pressed!");
                // do something

                if (id == 0)
                {
                    if (this.Visible)
                    {
                        HideForm();
                    }
                    else
                    {
                        ShowForm();
                    }
                }
                else if(id == 1)
                {
                    HideForm();
                }
                else if (id == 2)
                {
                    tbctrlCV.SelectedIndex = 0;
                }
                else if (id == 3)
                {
                    tbctrlCV.SelectedIndex = 1;
                }
                else if (id == 4)
                {
                    tbctrlCV.SelectedIndex = 2;
                }
                else if (id == 5)
                {
                    tbctrlCV.SelectedIndex = 3;
                }
            }
        }

        private void CVForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 1);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 2);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 3);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 4);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 5);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            notifyIcon.Icon.Dispose();
            notifyIcon.Dispose();
        }

        /// <summary>
        /// Handles mouse click on selected control
        /// </summary>
        /// <param name="sender"></param>
        private void HandleClick(object sender)
        {
            CopyToClipboard(sender);
            HideForm();
            PasteData();
        }

        /// <summary>
        /// Pastes copied data using programmatically Ctrl + V combination
        /// </summary>
        private void PasteData()
        {
            SendKeys.Send("^v");
        }

        /// <summary>
        /// Hides form on Esc button click
        /// </summary>
        private void HideForm()
        {
            this.Hide();
        }

        /// <summary>
        /// Copies data from sender to clipboard
        /// </summary>
        /// <param name="sender"></paravm>
        private static void CopyToClipboard(object sender)
        {
            if (sender is Label)
            {
                Clipboard.SetText((sender as Label).Text);
            }
            else if (sender is RichTextBox)
            {
                Clipboard.SetText((sender as RichTextBox).Text);
            }
        }
     
        private void btnAddTag_Click(object sender, EventArgs e)
        {
            LinkLabel linkLabel = new LinkLabel();
            linkLabel.BackColor = Color.White;
            linkLabel.Text = $"#{txtbxTag.Text}";
            linkLabel.Size = new Size(50, 25);

            this.Controls.Add(linkLabel);
        }

        private void btnAddTag_Click_1(object sender, EventArgs e)
        {
            string tag = txtbxTag.Text.ToLower();
            _tags.Add(tag);
            var tagControl = new TagControl(tag, _tags);
            tagControl.Anchor = AnchorStyles.Left;
            tagControl.Width = tag.Count() * 9 + 20;
            this.flowLayoutPanel1.Controls.Add(tagControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = _data;

            foreach (var tag in _tags)
            {
                result = result.Where(t => t.Tags.Contains(tag)).ToList();
            }

            string s = string.Empty;
            result.ForEach(i => s += "\n" + i.Value);

            MessageBox.Show(s);
        }

        private void btnCV_Click(object sender, EventArgs e)
        {
            CopyFileToClipboard(CV);
            HideForm();
            PasteData();
        }

        private static void CopyFileToClipboard(string fileName)
        {
            var paths = new StringCollection();
            paths.Add(System.AppDomain.CurrentDomain.BaseDirectory + $"\\Resources\\{fileName}");
            Clipboard.SetFileDropList(paths);
        }

        private static void CopyFileToClipboard(List<string> fileNames)
        {
            var paths = new StringCollection();
            fileNames.ForEach(fn => paths.Add(System.AppDomain.CurrentDomain.BaseDirectory + $"\\Resources\\{fn}"));
            Clipboard.SetFileDropList(paths);
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            CopyFileToClipboard(Application);
            HideForm();
            PasteData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CopyFileToClipboard(new List<string>() { Application, CV });
            HideForm();
            PasteData();
        }

        private void lblChangeColorScheme_Click(object sender, EventArgs e)
        {
            this.BackColor = this.BackColor == Color.Black? Color.White : Color.Black;
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                ShowForm();
            }
        }

        private void ShowForm()
        {
            this.Show();
        }
    }
}

