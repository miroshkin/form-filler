using FormFiller;
using FormFiller.Data;
using FormFiller.Forms;
using FormFiller.Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using FormFiller.Helpers;
using Newtonsoft.Json;

namespace FormFiller
{
    public partial class MainForm : Form
    {
        private List<Article> _dictionary = new List<Article>();
        //{
        //    new Article("last name", "Miroshkin", new List<string>(){"#name"}),
        //    new Article("first name", "Anton", new List<string>(){"#name"}),
        //    new Article("gmail email", "anton.miroshkin@gmail.com", new List<string>(){"#email", "#google", "#contacts"}),
        //    new Article("mobile phone", "+79161631867", new List<string>(){"#mobile", "#phone", "#contacts"}),
        //    new Article("summary", "developer summary", new List<string>(){"#summary", "#google"}),
        //};

        // Class variable to keep track of which row is currently selected:
        int hoveredIndex = -1;

        private void listBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // See which row is currently under the mouse:
            int newHoveredIndex = listBox1.IndexFromPoint(e.Location);

            // If the row has changed since last moving the mouse:
            if (hoveredIndex != newHoveredIndex)
            {
                // Change the variable for the next time we move the mouse:
                hoveredIndex = newHoveredIndex;

                // If over a row showing data (rather than blank space):
                if (hoveredIndex > -1)
                {
                    //Set tooltip text for the row now under the mouse:
                    toolTip1.Active = false;
                    toolTip1.SetToolTip(listBox1, listBox1.Items[hoveredIndex].ToString());
                    toolTip1.Active = true;
                }
            }
        }

        private void txtbxSearch_TextChanged(object sender, EventArgs e)
        {
            var text = txtbxSearch.Text;
            var records = _dictionary.Where(c => c.Key.Contains(text)
                                                 || c.Value.Contains(text)
                                                 || c.HashTags.Any(i => i.Contains(text))
                                                 || c.ShortenedKey.Contains(text));

            //var listStr = new List<string>();

            //foreach (var record in records)
            //{
            //    listStr.Add($"{record.Value}\t[{record.Key}  {String.Join(" ", record.HashTags.ToArray())}]");
            //}
            //listBox1.DataSource = GetDataSource(records.ToList());
            listBox1.DataSource = records.ToList();
            listBox1.DisplayMember = "Value";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ClipboardHelper.Copy(sender);
            this.Hide();
            ClipboardHelper.Paste();
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        private List<Button> _buttons;

        public MainForm()
        {
            InitializeComponent();
            AddNotifyIconMenu();
            SetShortCuts();
            SetHandleClickMethodForControls();
            SetFormTransparency(this);
            SetDictionary();
        }

        private void SetDictionary()
        {
            listBox1.DataSource = GetDataSource(_dictionary);
        }

        private object GetDataSource(List<Article> dictionary)
        {
            List<string> list = new List<string>();
            foreach (var record in dictionary)
            {
                list.Add($"{record.Value} ({record.Key}) [{String.Join(" ", record.HashTags.ToArray())}]");
            }

            return list;
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

        private void SetHandleClickMethodForControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
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
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints);
                label.ForeColor = Color.Black;
                label.BackColor = Color.FromArgb(255, 215, 0);
            }
        }

        private void HandleUnhover(object sender)
        {
            if (sender is Label)
            {
                var label = sender as Label;
                label.Font = new Font(label.Font.Name, label.Font.SizeInPoints, FontStyle.Regular);
                label.ForeColor = Color.Gainsboro;
                label.BackColor = Color.Transparent;
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

            id = 1;     
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.Escape.GetHashCode());

            id = 2;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D1.GetHashCode());

            id = 3;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D2.GetHashCode());

            id = 4;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D3.GetHashCode());

            id = 5;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Alt, Keys.D4.GetHashCode());

            id = 6;
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.MButton.GetHashCode());
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

                if (id == 0 || id == 6)
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
                    //tbctrlCV.SelectedIndex = 0;
                }
                else if (id == 3)
                {
                    //tbctrlCV.SelectedIndex = 1;
                }
                else if (id == 4)
                {
                    //tbctrlCV.SelectedIndex = 2;
                }
                else if (id == 5)
                {
                    //tbctrlCV.SelectedIndex = 3;
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon.Icon.Dispose();
            notifyIcon.Dispose();
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 1);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 2);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 3);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 4);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 5);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
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
     
       

        

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        
        /// <summary>
        /// Enables to move window without border
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
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
            this.txtbxSearch.Focus();
            this.txtbxSearch.SelectAll();
            this.Show();
        }

        private Form _activeForm = null;

        private void OpenChildForm(Form childForm)
        {

            SuspendLayout();
            if (_activeForm != null)
            {
                _activeForm.Close();
            }
            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Padding = new Padding(5, 3, 5, 3);
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.AutoScroll = true;
            childForm.BringToFront();
            childForm.Show();
            SetHandleClickMethodForControls(childForm);
            ResumeLayout();
        }

        private void panelLogo_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.SizeAll;
        }

        private void panelLogo_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void txtbxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & listBox1.SelectedItem != null)
            {
                listBox1_DoubleClick(listBox1, EventArgs.Empty);
            }
            if (e.KeyCode == Keys.Down)
            {
                listBox1.Focus();
                
                if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                {
                    listBox1.SelectedIndex += 1;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetDataFromFile();
        }

        private void GetDataFromFile()
        {
            var articles = JsonConvert.DeserializeObject<List<Article>>(File.ReadAllText($"{Directory.GetCurrentDirectory()}/data.json"));
            FillOutFields(articles);
            _dictionary = articles;
        }

        private void FillOutFields(List<Article> articles)
        {
            foreach (var article in articles)
            {
                if (String.IsNullOrEmpty(article.ShortenedKey))
                {
                    article.ShortenedKey = Article.GetShortenedKey(article.Key);
                } 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedArticle = (Article) listBox1.SelectedItem;
            textBox1.Text = selectedArticle.Key;
            listBox2.DataSource = selectedArticle.HashTags;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & listBox1.SelectedItem != null)
            {
                listBox1_DoubleClick(listBox1, EventArgs.Empty);
            }
        }
    }
}

