using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFiller.Data
{
    public partial class TagControl : UserControl
    {
        List<string> _tags;

        public TagControl(string labelText, List<string> tags)
        {
            InitializeComponent();
            this.lblTag.Text = labelText;
            this.lblClose.Click += LblClose_Click;
            _tags = tags;
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            _tags.RemoveAll(t => t == this.lblTag.Text);
            this.Dispose();
        }

        

        private void TagControl_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblTag_Click(object sender, EventArgs e)
        {

        }
    }
}
