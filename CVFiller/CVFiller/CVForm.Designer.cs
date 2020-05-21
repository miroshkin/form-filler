namespace CVFiller
{
    partial class CVForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CVForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.txtbxTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.Label();
            this.grpbxContacts = new System.Windows.Forms.GroupBox();
            this.grpbxSocialNetworks = new System.Windows.Forms.GroupBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.grpbxAddress = new System.Windows.Forms.GroupBox();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.grpbxEducation = new System.Windows.Forms.GroupBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblEducationStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CV = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpbxContacts.SuspendLayout();
            this.grpbxSocialNetworks.SuspendLayout();
            this.grpbxAddress.SuspendLayout();
            this.grpbxEducation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.CV.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(347, 23);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(6, 22);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(42, 17);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "Anton";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(56, 22);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(63, 17);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Miroshkin";
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // txtbxTag
            // 
            this.txtbxTag.Location = new System.Drawing.Point(381, 12);
            this.txtbxTag.Name = "txtbxTag";
            this.txtbxTag.Size = new System.Drawing.Size(148, 23);
            this.txtbxTag.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "#";
            // 
            // btnAddTag
            // 
            this.btnAddTag.Location = new System.Drawing.Point(535, 11);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(48, 23);
            this.btnAddTag.TabIndex = 8;
            this.btnAddTag.Text = "Add";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(137, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "anton.miroshkin@gmail.com";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(323, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(104, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "+7 916 163 18 67";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(433, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(55, 17);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Moscow";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Location = new System.Drawing.Point(6, 19);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(195, 17);
            this.lblLinkedIn.TabIndex = 12;
            this.lblLinkedIn.Text = "linkedin.com/in/miroshkin-anton/";
            this.lblLinkedIn.Click += new System.EventHandler(this.lblLinkedIn_Click);
            // 
            // grpbxContacts
            // 
            this.grpbxContacts.Controls.Add(this.FirstName);
            this.grpbxContacts.Controls.Add(this.LastName);
            this.grpbxContacts.Controls.Add(this.lblLocation);
            this.grpbxContacts.Controls.Add(this.lblEmail);
            this.grpbxContacts.Controls.Add(this.lblPhone);
            this.grpbxContacts.Location = new System.Drawing.Point(8, 6);
            this.grpbxContacts.Name = "grpbxContacts";
            this.grpbxContacts.Size = new System.Drawing.Size(555, 53);
            this.grpbxContacts.TabIndex = 13;
            this.grpbxContacts.TabStop = false;
            this.grpbxContacts.Text = "Contacts";
            // 
            // grpbxSocialNetworks
            // 
            this.grpbxSocialNetworks.Controls.Add(this.lblFacebook);
            this.grpbxSocialNetworks.Controls.Add(this.lblLinkedIn);
            this.grpbxSocialNetworks.Location = new System.Drawing.Point(8, 120);
            this.grpbxSocialNetworks.Name = "grpbxSocialNetworks";
            this.grpbxSocialNetworks.Size = new System.Drawing.Size(555, 60);
            this.grpbxSocialNetworks.TabIndex = 14;
            this.grpbxSocialNetworks.TabStop = false;
            this.grpbxSocialNetworks.Text = "Social Networks";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(207, 19);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(188, 17);
            this.lblFacebook.TabIndex = 13;
            this.lblFacebook.Text = "facebook.com/miroshkin.anton/";
            this.lblFacebook.Click += new System.EventHandler(this.lblFacebook_Click);
            // 
            // grpbxAddress
            // 
            this.grpbxAddress.Controls.Add(this.lblAddress);
            this.grpbxAddress.Controls.Add(this.lblCity);
            this.grpbxAddress.Controls.Add(this.lblPostCode);
            this.grpbxAddress.Location = new System.Drawing.Point(8, 65);
            this.grpbxAddress.Name = "grpbxAddress";
            this.grpbxAddress.Size = new System.Drawing.Size(555, 49);
            this.grpbxAddress.TabIndex = 15;
            this.grpbxAddress.TabStop = false;
            this.grpbxAddress.Text = "Address";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(6, 19);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(50, 17);
            this.lblPostCode.TabIndex = 12;
            this.lblPostCode.Text = "140093";
            this.lblPostCode.Click += new System.EventHandler(this.lblPostCode_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(69, 19);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(78, 17);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "Dzerzhinskiy";
            this.lblCity.Click += new System.EventHandler(this.lblCity_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(153, 19);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Tomilinskaya 13-21";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // grpbxEducation
            // 
            this.grpbxEducation.Controls.Add(this.tableLayoutPanel1);
            this.grpbxEducation.Location = new System.Drawing.Point(8, 186);
            this.grpbxEducation.Name = "grpbxEducation";
            this.grpbxEducation.Size = new System.Drawing.Size(555, 151);
            this.grpbxEducation.TabIndex = 16;
            this.grpbxEducation.TabStop = false;
            this.grpbxEducation.Text = "Education";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(3, 0);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(127, 50);
            this.lblSchoolName.TabIndex = 14;
            this.lblSchoolName.Text = "Moscow Power Engineering Institute (Technical University)";
            this.lblSchoolName.Click += new System.EventHandler(this.lblSchoolName_Click);
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Location = new System.Drawing.Point(136, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(127, 34);
            this.lblDegree.TabIndex = 15;
            this.lblDegree.Text = "Master Of Science In Engineering";
            this.lblDegree.Click += new System.EventHandler(this.lblDegree_Click);
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(269, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(131, 34);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "Electrical System And Networks";
            this.lblMajor.Click += new System.EventHandler(this.lblMajor_Click);
            // 
            // lblEducationStartDate
            // 
            this.lblEducationStartDate.AutoSize = true;
            this.lblEducationStartDate.Location = new System.Drawing.Point(3, 50);
            this.lblEducationStartDate.Name = "lblEducationStartDate";
            this.lblEducationStartDate.Size = new System.Drawing.Size(36, 17);
            this.lblEducationStartDate.TabIndex = 17;
            this.lblEducationStartDate.Text = "2003";
            this.lblEducationStartDate.Click += new System.EventHandler(this.lblEducationStartDate_Click);
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(136, 50);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(36, 17);
            this.lblEndDate.TabIndex = 18;
            this.lblEndDate.Text = "2009";
            this.lblEndDate.Click += new System.EventHandler(this.lblEndDate_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.tableLayoutPanel1.Controls.Add(this.lblMajor, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblSchoolName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEndDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEducationStartDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDegree, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 100);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CV);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 788);
            this.tabControl1.TabIndex = 18;
            // 
            // CV
            // 
            this.CV.Controls.Add(this.grpbxContacts);
            this.CV.Controls.Add(this.grpbxEducation);
            this.CV.Controls.Add(this.grpbxAddress);
            this.CV.Controls.Add(this.grpbxSocialNetworks);
            this.CV.Location = new System.Drawing.Point(4, 24);
            this.CV.Name = "CV";
            this.CV.Padding = new System.Windows.Forms.Padding(3);
            this.CV.Size = new System.Drawing.Size(569, 760);
            this.CV.TabIndex = 0;
            this.CV.Text = "CV";
            this.CV.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(569, 760);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Application";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(595, 842);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTag);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CVForm_FormClosing);
            this.grpbxContacts.ResumeLayout(false);
            this.grpbxContacts.PerformLayout();
            this.grpbxSocialNetworks.ResumeLayout(false);
            this.grpbxSocialNetworks.PerformLayout();
            this.grpbxAddress.ResumeLayout(false);
            this.grpbxAddress.PerformLayout();
            this.grpbxEducation.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.CV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox txtbxTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblLinkedIn;
        private System.Windows.Forms.GroupBox grpbxContacts;
        private System.Windows.Forms.GroupBox grpbxSocialNetworks;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.GroupBox grpbxAddress;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox grpbxEducation;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblEducationStartDate;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CV;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

