using FormFiller;
using FormFiller.Data;
using FormFiller.Forms;
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
    public partial class MainForm : Form
    {
        

        public const string Application = "Application.docx";
        public const string CV = "CV.docx";

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
            SetControlsVisibility();
            AddNotifyIconMenu();
            SetShortCuts();

            SetHandleClickMethodForControls();

            SetFormTransparency(this);

            _buttons = new List<Button>();
            _buttons.AddRange(panelContacts.Controls.OfType<Button>().ToList());
            _buttons.AddRange(panelEducation.Controls.OfType<Button>().ToList());
            _buttons.AddRange(panelExperience.Controls.OfType<Button>().ToList());
            _buttons.AddRange(panelFiles.Controls.OfType<Button>().ToList());
            _buttons.AddRange(panelSearch.Controls.OfType<Button>().ToList());
        }

        private void SetControlsVisibility()
        {
            panelContacts.Visible = false;
            panelEducation.Visible = false;
            panelExperience.Visible = false;
            panelFiles.Visible = false;
            panelSearch.Visible = false;
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
                //label.BackColor = Color.FromArgb(88,88,88);
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

        private void btnContacts_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelContacts);
        }

        private void btnEducation_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelEducation);
        }

        private void btnExperience_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelExperience);
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelFiles);
        }

        private void ShowSubMenu (Panel submenu)
        {
            if (submenu.Visible == false)
            {
                HideSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private void HideSubMenu()
        {
            if (panelContacts.Visible) panelContacts.Visible = false;
            if (panelEducation.Visible) panelEducation.Visible = false;
            if (panelExperience.Visible) panelExperience.Visible = false;
            if (panelFiles.Visible) panelFiles.Visible = false;
            if (panelSearch.Visible) panelSearch.Visible = false;
        }

        private void HighlightMenuItem(Button button)
        {
            foreach (var item in _buttons)
            {
                if (item == button)
                {
                    item.FlatAppearance.BorderSize = 1;
                    item.BackColor = Color.FromArgb(66,66,66);
                }
                else
                {
                    item.FlatAppearance.BorderSize = 0;
                    item.BackColor = Color.FromArgb(99, 99, 99);

                }
            }

            
            
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SummaryForm());
            HighlightMenuItem (sender as Button);
        }

        private void btnPersonalData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PersonalDataForm());
            HighlightMenuItem(sender as Button);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddressForm());
            HighlightMenuItem(sender as Button);

        }

        private void btnSocialLinks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SocialLinksForm());
            HighlightMenuItem(sender as Button);

        }

        private void btnUniversity_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UniversityForm());
            HighlightMenuItem(sender as Button);

        }

        private void btnAdditionalCourses_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HighlightMenuItem(sender as Button);

        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            OpenChildForm(new JobsForm());
            HighlightMenuItem(btnJobs);
        }

        private void btnResumes_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            HighlightMenuItem(btnResumes);
        }

        private void btnCoverLetters_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnCoverLetters);
        }

        private void btnTags_Click(object sender, EventArgs e)
        {
            HighlightMenuItem(btnTags);
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
    }
}

