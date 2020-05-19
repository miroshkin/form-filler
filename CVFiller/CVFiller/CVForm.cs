using CVFiller.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFiller
{
    public partial class CVForm : Form
    {
        private IDictionary <string, string> _data;

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

            int id = 0;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.Control, Keys.Oem3.GetHashCode());

            id = 1;     // The id of the hotkey. 
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.Escape.GetHashCode());

            
            LoadData();
        }

        private void LoadData()
        {
            _data = new Dictionary<string, string>();

            CurriculumVitae cv = new CurriculumVitae();
            cv.FirstName = "Anton";
            cv.LastName = "Miroshkin";
            cv.PhoneNumber = "+79161631867";
            cv.Email = "anton.miroshkin@gmail.com";

            _data.Add("FirstName", cv.FirstName);
            _data.Add("LastName", cv.LastName);
            _data.Add("PhoneNumber", cv.PhoneNumber);
            _data.Add("Email", cv.Email);
        
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
                    this.Show();
                }
                else if(id == 1)
                {
                    this.Hide();
                }

            }
        }

        private void CVForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
            UnregisterHotKey(this.Handle, 1);       // Unregister hotkey with id 0 before closing the form. You might want to call this more than once with different id values if you are planning to register more than one hotkey.
        }

        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            comboBox1.Items.Clear();
            var selection = _data.Where(c => c.Key.Contains(comboBox1.Text)).Select(s => $"{s.Key} | {s.Value}").Take(5).ToArray();
            comboBox1.Items.AddRange(selection);
            if (selection.Length > 0)
            {
                comboBox1.DroppedDown = true;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Clipboard.SetText("Test string");
            this.Hide();
        }

        private void richTextBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(richTextBox2.Text);
            this.Hide();
        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
            this.Hide();
        }
    }
}
