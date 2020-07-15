namespace FormFiller
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
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.Label();
            this.grpbxContacts = new System.Windows.Forms.GroupBox();
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.grpbxSocialNetworks = new System.Windows.Forms.GroupBox();
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblPersonalWebsite = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.grpbxAddress = new System.Windows.Forms.GroupBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.grpbxEducation = new System.Windows.Forms.GroupBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblEducationStartDate = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.grpbxEmexExperience = new System.Windows.Forms.GroupBox();
            this.lblEmExDescription = new System.Windows.Forms.Label();
            this.lblEmExLocation = new System.Windows.Forms.Label();
            this.lblEmExEndDate = new System.Windows.Forms.Label();
            this.lblEmExName = new System.Windows.Forms.Label();
            this.lblEmExStartDate = new System.Windows.Forms.Label();
            this.lblEmExPosition = new System.Windows.Forms.Label();
            this.grpbxRZDExperience = new System.Windows.Forms.GroupBox();
            this.lblRZDDescription = new System.Windows.Forms.Label();
            this.lblRZDLocation = new System.Windows.Forms.Label();
            this.lblRZDEndDate = new System.Windows.Forms.Label();
            this.lblRZDName = new System.Windows.Forms.Label();
            this.lblRZDStartDate = new System.Windows.Forms.Label();
            this.lblRZDPosition = new System.Windows.Forms.Label();
            this.grpbxNTCExperience = new System.Windows.Forms.GroupBox();
            this.lblNTCDescription = new System.Windows.Forms.Label();
            this.lblNTCLocation = new System.Windows.Forms.Label();
            this.lblNTCEndDate = new System.Windows.Forms.Label();
            this.lblNTCName = new System.Windows.Forms.Label();
            this.lblNTCStartDate = new System.Windows.Forms.Label();
            this.lblNTCPosition = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbxTag = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCV = new System.Windows.Forms.Button();
            this.btnApplication = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblChangeColorScheme = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbctrlCV = new System.Windows.Forms.TabControl();
            this.tabContacts = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPitch = new System.Windows.Forms.Label();
            this.tabEducation = new System.Windows.Forms.TabPage();
            this.tabExperience = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabFiles = new System.Windows.Forms.TabPage();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.grpbxContacts.SuspendLayout();
            this.grpbxSocialNetworks.SuspendLayout();
            this.grpbxAddress.SuspendLayout();
            this.grpbxEducation.SuspendLayout();
            this.grpbxEmexExperience.SuspendLayout();
            this.grpbxRZDExperience.SuspendLayout();
            this.grpbxNTCExperience.SuspendLayout();
            this.tbctrlCV.SuspendLayout();
            this.tabContacts.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabEducation.SuspendLayout();
            this.tabExperience.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabFiles.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FormFiller(Press Alt + ~ to activate)";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstName.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(14, 22);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(42, 17);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "Anton";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastName.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(62, 22);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(63, 17);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Miroshkin";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(131, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "anton.miroshkin@gmail.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(334, 22);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "9161631867";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.Location = new System.Drawing.Point(418, 22);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(55, 17);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Moscow";
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLinkedIn.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkedIn.Location = new System.Drawing.Point(17, 25);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(195, 17);
            this.lblLinkedIn.TabIndex = 12;
            this.lblLinkedIn.Text = "linkedin.com/in/miroshkin-anton/";
            // 
            // grpbxContacts
            // 
            this.grpbxContacts.BackColor = System.Drawing.Color.Transparent;
            this.grpbxContacts.Controls.Add(this.lblCountryCode);
            this.grpbxContacts.Controls.Add(this.lblDateOfBirth);
            this.grpbxContacts.Controls.Add(this.FirstName);
            this.grpbxContacts.Controls.Add(this.LastName);
            this.grpbxContacts.Controls.Add(this.lblLocation);
            this.grpbxContacts.Controls.Add(this.lblEmail);
            this.grpbxContacts.Controls.Add(this.lblPhone);
            this.grpbxContacts.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbxContacts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxContacts.Location = new System.Drawing.Point(9, 138);
            this.grpbxContacts.Name = "grpbxContacts";
            this.grpbxContacts.Size = new System.Drawing.Size(556, 54);
            this.grpbxContacts.TabIndex = 13;
            this.grpbxContacts.TabStop = false;
            this.grpbxContacts.Text = "Contacts";
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountryCode.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountryCode.Location = new System.Drawing.Point(308, 22);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(22, 17);
            this.lblCountryCode.TabIndex = 13;
            this.lblCountryCode.Text = "+7";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(479, 22);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(72, 17);
            this.lblDateOfBirth.TabIndex = 12;
            this.lblDateOfBirth.Text = "26.02.1986";
            // 
            // grpbxSocialNetworks
            // 
            this.grpbxSocialNetworks.BackColor = System.Drawing.Color.Transparent;
            this.grpbxSocialNetworks.Controls.Add(this.lblGithub);
            this.grpbxSocialNetworks.Controls.Add(this.lblPersonalWebsite);
            this.grpbxSocialNetworks.Controls.Add(this.lblFacebook);
            this.grpbxSocialNetworks.Controls.Add(this.lblLinkedIn);
            this.grpbxSocialNetworks.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbxSocialNetworks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxSocialNetworks.Location = new System.Drawing.Point(9, 258);
            this.grpbxSocialNetworks.Name = "grpbxSocialNetworks";
            this.grpbxSocialNetworks.Size = new System.Drawing.Size(556, 92);
            this.grpbxSocialNetworks.TabIndex = 14;
            this.grpbxSocialNetworks.TabStop = false;
            this.grpbxSocialNetworks.Text = "Social Networks And Links";
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGithub.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGithub.Location = new System.Drawing.Point(222, 51);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(173, 17);
            this.lblGithub.TabIndex = 15;
            this.lblGithub.Text = "https://github.com/miroshkin";
            // 
            // lblPersonalWebsite
            // 
            this.lblPersonalWebsite.AutoSize = true;
            this.lblPersonalWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonalWebsite.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalWebsite.Location = new System.Drawing.Point(17, 51);
            this.lblPersonalWebsite.Name = "lblPersonalWebsite";
            this.lblPersonalWebsite.Size = new System.Drawing.Size(163, 17);
            this.lblPersonalWebsite.TabIndex = 14;
            this.lblPersonalWebsite.Text = "https://miroshkin.github.io/";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFacebook.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacebook.Location = new System.Drawing.Point(222, 25);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(188, 17);
            this.lblFacebook.TabIndex = 13;
            this.lblFacebook.Text = "facebook.com/miroshkin.anton/";
            // 
            // grpbxAddress
            // 
            this.grpbxAddress.BackColor = System.Drawing.Color.Transparent;
            this.grpbxAddress.Controls.Add(this.lblAddress);
            this.grpbxAddress.Controls.Add(this.lblCity);
            this.grpbxAddress.Controls.Add(this.lblPostCode);
            this.grpbxAddress.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxAddress.Location = new System.Drawing.Point(10, 198);
            this.grpbxAddress.Name = "grpbxAddress";
            this.grpbxAddress.Size = new System.Drawing.Size(555, 54);
            this.grpbxAddress.TabIndex = 15;
            this.grpbxAddress.TabStop = false;
            this.grpbxAddress.Text = "Address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAddress.Location = new System.Drawing.Point(153, 24);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 17);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Tomilinskaya 13-21";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCity.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(69, 24);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(78, 17);
            this.lblCity.TabIndex = 13;
            this.lblCity.Text = "Dzerzhinskiy";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPostCode.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPostCode.Location = new System.Drawing.Point(13, 24);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(50, 17);
            this.lblPostCode.TabIndex = 12;
            this.lblPostCode.Text = "140093";
            // 
            // grpbxEducation
            // 
            this.grpbxEducation.BackColor = System.Drawing.Color.Transparent;
            this.grpbxEducation.Controls.Add(this.lblMajor);
            this.grpbxEducation.Controls.Add(this.lblEndDate);
            this.grpbxEducation.Controls.Add(this.lblSchoolName);
            this.grpbxEducation.Controls.Add(this.lblEducationStartDate);
            this.grpbxEducation.Controls.Add(this.lblDegree);
            this.grpbxEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxEducation.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpbxEducation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxEducation.Location = new System.Drawing.Point(16, 6);
            this.grpbxEducation.Name = "grpbxEducation";
            this.grpbxEducation.Size = new System.Drawing.Size(546, 85);
            this.grpbxEducation.TabIndex = 16;
            this.grpbxEducation.TabStop = false;
            this.grpbxEducation.Text = "Education";
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMajor.Location = new System.Drawing.Point(217, 51);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(185, 17);
            this.lblMajor.TabIndex = 16;
            this.lblMajor.Text = "Electrical System And Networks";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(402, 25);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(36, 17);
            this.lblEndDate.TabIndex = 18;
            this.lblEndDate.Text = "2009";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSchoolName.Location = new System.Drawing.Point(17, 25);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(337, 17);
            this.lblSchoolName.TabIndex = 14;
            this.lblSchoolName.Text = "Moscow Power Engineering Institute (Technical University)";
            // 
            // lblEducationStartDate
            // 
            this.lblEducationStartDate.AutoSize = true;
            this.lblEducationStartDate.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEducationStartDate.Location = new System.Drawing.Point(360, 25);
            this.lblEducationStartDate.Name = "lblEducationStartDate";
            this.lblEducationStartDate.Size = new System.Drawing.Size(36, 17);
            this.lblEducationStartDate.TabIndex = 17;
            this.lblEducationStartDate.Text = "2003";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDegree.Location = new System.Drawing.Point(17, 51);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Size = new System.Drawing.Size(194, 17);
            this.lblDegree.TabIndex = 15;
            this.lblDegree.Text = "Master Of Science In Engineering";
            // 
            // grpbxEmexExperience
            // 
            this.grpbxEmexExperience.BackColor = System.Drawing.Color.Transparent;
            this.grpbxEmexExperience.Controls.Add(this.lblEmExDescription);
            this.grpbxEmexExperience.Controls.Add(this.lblEmExLocation);
            this.grpbxEmexExperience.Controls.Add(this.lblEmExEndDate);
            this.grpbxEmexExperience.Controls.Add(this.lblEmExName);
            this.grpbxEmexExperience.Controls.Add(this.lblEmExStartDate);
            this.grpbxEmexExperience.Controls.Add(this.lblEmExPosition);
            this.grpbxEmexExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpbxEmexExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxEmexExperience.Location = new System.Drawing.Point(6, 6);
            this.grpbxEmexExperience.Name = "grpbxEmexExperience";
            this.grpbxEmexExperience.Size = new System.Drawing.Size(556, 124);
            this.grpbxEmexExperience.TabIndex = 19;
            this.grpbxEmexExperience.TabStop = false;
            this.grpbxEmexExperience.Text = "EmEx Experience";
            // 
            // lblEmExDescription
            // 
            this.lblEmExDescription.AutoSize = true;
            this.lblEmExDescription.Location = new System.Drawing.Point(17, 45);
            this.lblEmExDescription.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblEmExDescription.Name = "lblEmExDescription";
            this.lblEmExDescription.Size = new System.Drawing.Size(534, 105);
            this.lblEmExDescription.TabIndex = 19;
            this.lblEmExDescription.Text = resources.GetString("lblEmExDescription.Text");
            // 
            // lblEmExLocation
            // 
            this.lblEmExLocation.AutoSize = true;
            this.lblEmExLocation.Location = new System.Drawing.Point(449, 19);
            this.lblEmExLocation.Name = "lblEmExLocation";
            this.lblEmExLocation.Size = new System.Drawing.Size(69, 21);
            this.lblEmExLocation.TabIndex = 16;
            this.lblEmExLocation.Text = "Moscow";
            // 
            // lblEmExEndDate
            // 
            this.lblEmExEndDate.AutoSize = true;
            this.lblEmExEndDate.Location = new System.Drawing.Point(393, 19);
            this.lblEmExEndDate.Name = "lblEmExEndDate";
            this.lblEmExEndDate.Size = new System.Drawing.Size(61, 21);
            this.lblEmExEndDate.TabIndex = 18;
            this.lblEmExEndDate.Text = "current";
            // 
            // lblEmExName
            // 
            this.lblEmExName.AutoSize = true;
            this.lblEmExName.Location = new System.Drawing.Point(236, 19);
            this.lblEmExName.Name = "lblEmExName";
            this.lblEmExName.Size = new System.Drawing.Size(135, 21);
            this.lblEmExName.TabIndex = 14;
            this.lblEmExName.Text = "JSC \"Emex Group\"";
            // 
            // lblEmExStartDate
            // 
            this.lblEmExStartDate.AutoSize = true;
            this.lblEmExStartDate.Location = new System.Drawing.Point(351, 19);
            this.lblEmExStartDate.Name = "lblEmExStartDate";
            this.lblEmExStartDate.Size = new System.Drawing.Size(46, 21);
            this.lblEmExStartDate.TabIndex = 17;
            this.lblEmExStartDate.Text = "2016";
            // 
            // lblEmExPosition
            // 
            this.lblEmExPosition.AutoSize = true;
            this.lblEmExPosition.Location = new System.Drawing.Point(17, 19);
            this.lblEmExPosition.Name = "lblEmExPosition";
            this.lblEmExPosition.Size = new System.Drawing.Size(250, 21);
            this.lblEmExPosition.TabIndex = 15;
            this.lblEmExPosition.Text = "Full Stack .NET Software Developer";
            // 
            // grpbxRZDExperience
            // 
            this.grpbxRZDExperience.Controls.Add(this.lblRZDDescription);
            this.grpbxRZDExperience.Controls.Add(this.lblRZDLocation);
            this.grpbxRZDExperience.Controls.Add(this.lblRZDEndDate);
            this.grpbxRZDExperience.Controls.Add(this.lblRZDName);
            this.grpbxRZDExperience.Controls.Add(this.lblRZDStartDate);
            this.grpbxRZDExperience.Controls.Add(this.lblRZDPosition);
            this.grpbxRZDExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxRZDExperience.Location = new System.Drawing.Point(7, 136);
            this.grpbxRZDExperience.Name = "grpbxRZDExperience";
            this.grpbxRZDExperience.Size = new System.Drawing.Size(555, 79);
            this.grpbxRZDExperience.TabIndex = 20;
            this.grpbxRZDExperience.TabStop = false;
            this.grpbxRZDExperience.Text = "RZD Experience";
            // 
            // lblRZDDescription
            // 
            this.lblRZDDescription.AutoSize = true;
            this.lblRZDDescription.Location = new System.Drawing.Point(16, 42);
            this.lblRZDDescription.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblRZDDescription.Name = "lblRZDDescription";
            this.lblRZDDescription.Size = new System.Drawing.Size(538, 63);
            this.lblRZDDescription.TabIndex = 19;
            this.lblRZDDescription.Text = "My responsibilities in chief designer department were the support and development" +
    " of SCADA system modules and electronic documentation web application.";
            // 
            // lblRZDLocation
            // 
            this.lblRZDLocation.AutoSize = true;
            this.lblRZDLocation.Location = new System.Drawing.Point(449, 19);
            this.lblRZDLocation.Name = "lblRZDLocation";
            this.lblRZDLocation.Size = new System.Drawing.Size(69, 21);
            this.lblRZDLocation.TabIndex = 16;
            this.lblRZDLocation.Text = "Moscow";
            // 
            // lblRZDEndDate
            // 
            this.lblRZDEndDate.AutoSize = true;
            this.lblRZDEndDate.Location = new System.Drawing.Point(393, 19);
            this.lblRZDEndDate.Name = "lblRZDEndDate";
            this.lblRZDEndDate.Size = new System.Drawing.Size(46, 21);
            this.lblRZDEndDate.TabIndex = 18;
            this.lblRZDEndDate.Text = "2016";
            // 
            // lblRZDName
            // 
            this.lblRZDName.AutoSize = true;
            this.lblRZDName.Location = new System.Drawing.Point(210, 19);
            this.lblRZDName.Name = "lblRZDName";
            this.lblRZDName.Size = new System.Drawing.Size(171, 21);
            this.lblRZDName.TabIndex = 14;
            this.lblRZDName.Text = "JSC \"Russian Railroads\"";
            // 
            // lblRZDStartDate
            // 
            this.lblRZDStartDate.AutoSize = true;
            this.lblRZDStartDate.Location = new System.Drawing.Point(351, 19);
            this.lblRZDStartDate.Name = "lblRZDStartDate";
            this.lblRZDStartDate.Size = new System.Drawing.Size(46, 21);
            this.lblRZDStartDate.TabIndex = 17;
            this.lblRZDStartDate.Text = "2014";
            // 
            // lblRZDPosition
            // 
            this.lblRZDPosition.AutoSize = true;
            this.lblRZDPosition.Location = new System.Drawing.Point(16, 19);
            this.lblRZDPosition.Name = "lblRZDPosition";
            this.lblRZDPosition.Size = new System.Drawing.Size(236, 21);
            this.lblRZDPosition.TabIndex = 15;
            this.lblRZDPosition.Text = "Full Stack C# Software Developer";
            // 
            // grpbxNTCExperience
            // 
            this.grpbxNTCExperience.Controls.Add(this.lblNTCDescription);
            this.grpbxNTCExperience.Controls.Add(this.lblNTCLocation);
            this.grpbxNTCExperience.Controls.Add(this.lblNTCEndDate);
            this.grpbxNTCExperience.Controls.Add(this.lblNTCName);
            this.grpbxNTCExperience.Controls.Add(this.lblNTCStartDate);
            this.grpbxNTCExperience.Controls.Add(this.lblNTCPosition);
            this.grpbxNTCExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.grpbxNTCExperience.Location = new System.Drawing.Point(8, 221);
            this.grpbxNTCExperience.Name = "grpbxNTCExperience";
            this.grpbxNTCExperience.Size = new System.Drawing.Size(554, 126);
            this.grpbxNTCExperience.TabIndex = 21;
            this.grpbxNTCExperience.TabStop = false;
            this.grpbxNTCExperience.Text = "NTC Experience";
            // 
            // lblNTCDescription
            // 
            this.lblNTCDescription.AutoSize = true;
            this.lblNTCDescription.Location = new System.Drawing.Point(15, 64);
            this.lblNTCDescription.MaximumSize = new System.Drawing.Size(536, 0);
            this.lblNTCDescription.Name = "lblNTCDescription";
            this.lblNTCDescription.Size = new System.Drawing.Size(500, 42);
            this.lblNTCDescription.TabIndex = 19;
            this.lblNTCDescription.Text = "The main part of my work in the power networks department was the development and" +
    " support expert system prototypes for industrial use.";
            // 
            // lblNTCLocation
            // 
            this.lblNTCLocation.AutoSize = true;
            this.lblNTCLocation.Location = new System.Drawing.Point(241, 19);
            this.lblNTCLocation.Name = "lblNTCLocation";
            this.lblNTCLocation.Size = new System.Drawing.Size(69, 21);
            this.lblNTCLocation.TabIndex = 16;
            this.lblNTCLocation.Text = "Moscow";
            // 
            // lblNTCEndDate
            // 
            this.lblNTCEndDate.AutoSize = true;
            this.lblNTCEndDate.Location = new System.Drawing.Point(199, 19);
            this.lblNTCEndDate.Name = "lblNTCEndDate";
            this.lblNTCEndDate.Size = new System.Drawing.Size(46, 21);
            this.lblNTCEndDate.TabIndex = 18;
            this.lblNTCEndDate.Text = "2014";
            // 
            // lblNTCName
            // 
            this.lblNTCName.AutoSize = true;
            this.lblNTCName.Location = new System.Drawing.Point(15, 36);
            this.lblNTCName.Name = "lblNTCName";
            this.lblNTCName.Size = new System.Drawing.Size(650, 21);
            this.lblNTCName.TabIndex = 14;
            this.lblNTCName.Text = "JSC \"Research And Development Center At Federal Grid Company Of Unified Energy Sy" +
    "stem\"";
            // 
            // lblNTCStartDate
            // 
            this.lblNTCStartDate.AutoSize = true;
            this.lblNTCStartDate.Location = new System.Drawing.Point(151, 19);
            this.lblNTCStartDate.Name = "lblNTCStartDate";
            this.lblNTCStartDate.Size = new System.Drawing.Size(46, 21);
            this.lblNTCStartDate.TabIndex = 17;
            this.lblNTCStartDate.Text = "2013";
            // 
            // lblNTCPosition
            // 
            this.lblNTCPosition.AutoSize = true;
            this.lblNTCPosition.Location = new System.Drawing.Point(15, 19);
            this.lblNTCPosition.Name = "lblNTCPosition";
            this.lblNTCPosition.Size = new System.Drawing.Size(101, 21);
            this.lblNTCPosition.TabIndex = 15;
            this.lblNTCPosition.Text = "C# Developer";
            // 
            // btnAddTag
            // 
            this.btnAddTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnAddTag.Location = new System.Drawing.Point(484, 11);
            this.btnAddTag.Name = "btnAddTag";
            this.btnAddTag.Size = new System.Drawing.Size(48, 23);
            this.btnAddTag.TabIndex = 25;
            this.btnAddTag.Text = "Add";
            this.btnAddTag.UseVisualStyleBackColor = true;
            this.btnAddTag.Click += new System.EventHandler(this.btnAddTag_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(314, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "#";
            // 
            // txtbxTag
            // 
            this.txtbxTag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.txtbxTag.Location = new System.Drawing.Point(330, 12);
            this.txtbxTag.Name = "txtbxTag";
            this.txtbxTag.Size = new System.Drawing.Size(148, 28);
            this.txtbxTag.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 29);
            this.comboBox1.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.button1.Location = new System.Drawing.Point(10, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCV
            // 
            this.btnCV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnCV.Location = new System.Drawing.Point(6, 6);
            this.btnCV.Name = "btnCV";
            this.btnCV.Size = new System.Drawing.Size(75, 26);
            this.btnCV.TabIndex = 27;
            this.btnCV.Text = "CV";
            this.btnCV.UseVisualStyleBackColor = true;
            this.btnCV.Click += new System.EventHandler(this.btnCV_Click);
            // 
            // btnApplication
            // 
            this.btnApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.btnApplication.Location = new System.Drawing.Point(87, 6);
            this.btnApplication.Name = "btnApplication";
            this.btnApplication.Size = new System.Drawing.Size(85, 26);
            this.btnApplication.TabIndex = 28;
            this.btnApplication.Text = "Application";
            this.btnApplication.UseVisualStyleBackColor = true;
            this.btnApplication.Click += new System.EventHandler(this.btnApplication_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.button2.Location = new System.Drawing.Point(427, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 26);
            this.button2.TabIndex = 29;
            this.button2.Text = "Copy all files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblChangeColorScheme
            // 
            this.lblChangeColorScheme.AutoSize = true;
            this.lblChangeColorScheme.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeColorScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChangeColorScheme.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChangeColorScheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.lblChangeColorScheme.Location = new System.Drawing.Point(228, 591);
            this.lblChangeColorScheme.Name = "lblChangeColorScheme";
            this.lblChangeColorScheme.Size = new System.Drawing.Size(91, 13);
            this.lblChangeColorScheme.TabIndex = 30;
            this.lblChangeColorScheme.Text = "Change color scheme";
            this.lblChangeColorScheme.Click += new System.EventHandler(this.lblChangeColorScheme_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 71);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 81);
            this.flowLayoutPanel1.TabIndex = 31;
            // 
            // tbctrlCV
            // 
            this.tbctrlCV.Controls.Add(this.tabContacts);
            this.tbctrlCV.Controls.Add(this.tabEducation);
            this.tbctrlCV.Controls.Add(this.tabExperience);
            this.tbctrlCV.Controls.Add(this.tabFiles);
            this.tbctrlCV.Controls.Add(this.tabSearch);
            this.tbctrlCV.Location = new System.Drawing.Point(204, 21);
            this.tbctrlCV.Name = "tbctrlCV";
            this.tbctrlCV.SelectedIndex = 0;
            this.tbctrlCV.Size = new System.Drawing.Size(571, 576);
            this.tbctrlCV.TabIndex = 32;
            // 
            // tabContacts
            // 
            this.tabContacts.Controls.Add(this.groupBox2);
            this.tabContacts.Controls.Add(this.grpbxContacts);
            this.tabContacts.Controls.Add(this.grpbxAddress);
            this.tabContacts.Controls.Add(this.grpbxSocialNetworks);
            this.tabContacts.Location = new System.Drawing.Point(4, 30);
            this.tabContacts.Name = "tabContacts";
            this.tabContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tabContacts.Size = new System.Drawing.Size(563, 542);
            this.tabContacts.TabIndex = 0;
            this.tabContacts.Text = "Contacts";
            this.tabContacts.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblPitch);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.groupBox2.Location = new System.Drawing.Point(10, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(556, 126);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Summary";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.BackColor = System.Drawing.Color.Transparent;
            this.lblPitch.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPitch.Location = new System.Drawing.Point(6, 19);
            this.lblPitch.MaximumSize = new System.Drawing.Size(550, 0);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(550, 85);
            this.lblPitch.TabIndex = 20;
            this.lblPitch.Text = resources.GetString("lblPitch.Text");
            // 
            // tabEducation
            // 
            this.tabEducation.Controls.Add(this.grpbxEducation);
            this.tabEducation.Location = new System.Drawing.Point(4, 24);
            this.tabEducation.Name = "tabEducation";
            this.tabEducation.Padding = new System.Windows.Forms.Padding(3);
            this.tabEducation.Size = new System.Drawing.Size(568, 548);
            this.tabEducation.TabIndex = 1;
            this.tabEducation.Text = "Education";
            this.tabEducation.UseVisualStyleBackColor = true;
            // 
            // tabExperience
            // 
            this.tabExperience.Controls.Add(this.groupBox1);
            this.tabExperience.Controls.Add(this.grpbxNTCExperience);
            this.tabExperience.Controls.Add(this.grpbxEmexExperience);
            this.tabExperience.Controls.Add(this.grpbxRZDExperience);
            this.tabExperience.Location = new System.Drawing.Point(4, 24);
            this.tabExperience.Name = "tabExperience";
            this.tabExperience.Padding = new System.Windows.Forms.Padding(3);
            this.tabExperience.Size = new System.Drawing.Size(568, 548);
            this.tabExperience.TabIndex = 3;
            this.tabExperience.Text = "Experience";
            this.tabExperience.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 353);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 126);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NTC Experience";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 64);
            this.label2.MaximumSize = new System.Drawing.Size(536, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 63);
            this.label2.TabIndex = 19;
            this.label2.Text = "As a researcher, I investigated and founded new ways for artificial intelligence " +
    "and natural language processing implementation for decision support systems in h" +
    "igh voltage substations.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Moscow";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "2013";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(650, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "JSC \"Research And Development Center At Federal Grid Company Of Unified Energy Sy" +
    "stem\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "2009";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 15;
            this.label7.Text = "Researcher";
            // 
            // tabFiles
            // 
            this.tabFiles.Controls.Add(this.btnCV);
            this.tabFiles.Controls.Add(this.btnApplication);
            this.tabFiles.Controls.Add(this.button2);
            this.tabFiles.Location = new System.Drawing.Point(4, 24);
            this.tabFiles.Name = "tabFiles";
            this.tabFiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabFiles.Size = new System.Drawing.Size(568, 548);
            this.tabFiles.TabIndex = 4;
            this.tabFiles.Text = "Files";
            this.tabFiles.UseVisualStyleBackColor = true;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.flowLayoutPanel1);
            this.tabSearch.Controls.Add(this.comboBox1);
            this.tabSearch.Controls.Add(this.txtbxTag);
            this.tabSearch.Controls.Add(this.label1);
            this.tabSearch.Controls.Add(this.button1);
            this.tabSearch.Controls.Add(this.btnAddTag);
            this.tabSearch.Location = new System.Drawing.Point(4, 24);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(568, 548);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "Search";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(202, 609);
            this.panelSideMenu.TabIndex = 33;
            // 
            // CVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(870, 609);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.tbctrlCV);
            this.Controls.Add(this.lblChangeColorScheme);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CVForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CVForm_MouseDown);
            this.grpbxContacts.ResumeLayout(false);
            this.grpbxContacts.PerformLayout();
            this.grpbxSocialNetworks.ResumeLayout(false);
            this.grpbxSocialNetworks.PerformLayout();
            this.grpbxAddress.ResumeLayout(false);
            this.grpbxAddress.PerformLayout();
            this.grpbxEducation.ResumeLayout(false);
            this.grpbxEducation.PerformLayout();
            this.grpbxEmexExperience.ResumeLayout(false);
            this.grpbxEmexExperience.PerformLayout();
            this.grpbxRZDExperience.ResumeLayout(false);
            this.grpbxRZDExperience.PerformLayout();
            this.grpbxNTCExperience.ResumeLayout(false);
            this.grpbxNTCExperience.PerformLayout();
            this.tbctrlCV.ResumeLayout(false);
            this.tabContacts.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabEducation.ResumeLayout(false);
            this.tabExperience.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabFiles.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
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
        private System.Windows.Forms.GroupBox grpbxEmexExperience;
        private System.Windows.Forms.Label lblEmExLocation;
        private System.Windows.Forms.Label lblEmExEndDate;
        private System.Windows.Forms.Label lblEmExName;
        private System.Windows.Forms.Label lblEmExStartDate;
        private System.Windows.Forms.Label lblEmExPosition;
        private System.Windows.Forms.GroupBox grpbxRZDExperience;
        private System.Windows.Forms.Label lblRZDDescription;
        private System.Windows.Forms.Label lblRZDLocation;
        private System.Windows.Forms.Label lblRZDEndDate;
        private System.Windows.Forms.Label lblRZDName;
        private System.Windows.Forms.Label lblRZDStartDate;
        private System.Windows.Forms.Label lblRZDPosition;
        private System.Windows.Forms.Label lblEmExDescription;
        private System.Windows.Forms.GroupBox grpbxNTCExperience;
        private System.Windows.Forms.Label lblNTCDescription;
        private System.Windows.Forms.Label lblNTCLocation;
        private System.Windows.Forms.Label lblNTCEndDate;
        private System.Windows.Forms.Label lblNTCName;
        private System.Windows.Forms.Label lblNTCStartDate;
        private System.Windows.Forms.Label lblNTCPosition;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbxTag;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCV;
        private System.Windows.Forms.Button btnApplication;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblChangeColorScheme;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tbctrlCV;
        private System.Windows.Forms.TabPage tabContacts;
        private System.Windows.Forms.TabPage tabEducation;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabExperience;
        private System.Windows.Forms.TabPage tabFiles;
        private System.Windows.Forms.Label lblPersonalWebsite;
        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblCountryCode;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelSideMenu;
    }
}

