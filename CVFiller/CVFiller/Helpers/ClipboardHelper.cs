using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFiller.Helpers
{
    class ClipboardHelper
    {
        /// <summary>
        /// Copies data from sender to clipboard
        /// </summary>
        /// <param name="sender"></paravm>
        public static void Copy(object sender)
        {
            if (sender is Label)
            {
                Clipboard.SetText((sender as Label).Text);
            }
            else if (sender is RichTextBox)
            {
                Clipboard.SetText((sender as RichTextBox).Text);
            }
            else if (sender is ListBox)
            {
                Clipboard.SetText((sender as ListBox).SelectedItem.ToString().Split(' ')[0]);
            }
        }

        public static void Paste()
        {
            SendKeys.Send("^v");
        }
    }
}
