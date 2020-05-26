using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFiller.Data
{
    public partial class TagControl : UserControl
    {
        public TagControl(string labelText)
        {
            InitializeComponent();
            this.lblTag.Text = labelText;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
