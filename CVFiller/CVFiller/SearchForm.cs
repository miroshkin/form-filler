using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormFiller.Data;
using FormFiller.Helpers;

namespace FormFiller
{
    public partial class SearchForm : Form
    {
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

        private List<Article> _dictionary = new List<Article>()
        {
            new Article("last name", "Miroshkin", new List<string>(){"#name"}),
            new Article("first name", "Anton", new List<string>(){"#name"}),
            new Article("gmail email", "anton.miroshkin@gmail.com", new List<string>(){"#email", "#google"}),
            new Article("summary", "developer summary", new List<string>(){"#summary", "#google"}),
        };

        public SearchForm()
        {
            InitializeComponent();
        }

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

                var listStr = new List<string>();

                foreach (var record in records)
                {
                    listStr.Add($"{record.Value}\t[{record.Key}  {String.Join(" ", record.HashTags.ToArray())}]");
                }
                listBox1.DataSource = listStr;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            ClipboardHelper.Copy(sender);
            this.Hide();
            ClipboardHelper.Paste();
        }
    }
}
