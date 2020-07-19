using FormFiller.Data;
using FormFiller.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFiller
{
    public partial class ChildFormTab : Form
    {

        public List<string> _tags;
        public List<Article> _data;


        public ChildFormTab()
        {
            InitializeComponent();
            LoadData();

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

        private void btnCV_Click(object sender, EventArgs e)
        {

        }

        private void btnApplication_Click(object sender, EventArgs e)
        {

        }
    }
}
