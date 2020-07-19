namespace FormFiller
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblChangeColorScheme = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnTags = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.btnCoverLetters = new System.Windows.Forms.Button();
            this.btnResumes = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.panelExperience = new System.Windows.Forms.Panel();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnExperience = new System.Windows.Forms.Button();
            this.panelEducation = new System.Windows.Forms.Panel();
            this.btnUniversity = new System.Windows.Forms.Button();
            this.btnEducation = new System.Windows.Forms.Button();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.panelExperience.SuspendLayout();
            this.panelEducation.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "FormFiller(Press Alt + ~ to activate)";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // lblChangeColorScheme
            // 
            this.lblChangeColorScheme.AutoSize = true;
            this.lblChangeColorScheme.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeColorScheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblChangeColorScheme.Font = new System.Drawing.Font("Calibri", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChangeColorScheme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(116)))), ((int)(((byte)(166)))));
            this.lblChangeColorScheme.Location = new System.Drawing.Point(493, 591);
            this.lblChangeColorScheme.Name = "lblChangeColorScheme";
            this.lblChangeColorScheme.Size = new System.Drawing.Size(91, 13);
            this.lblChangeColorScheme.TabIndex = 30;
            this.lblChangeColorScheme.Text = "Change color scheme";
            this.lblChangeColorScheme.Click += new System.EventHandler(this.lblChangeColorScheme_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panelSideMenu.Controls.Add(this.panelSearch);
            this.panelSideMenu.Controls.Add(this.btnSearch);
            this.panelSideMenu.Controls.Add(this.panelFiles);
            this.panelSideMenu.Controls.Add(this.btnFiles);
            this.panelSideMenu.Controls.Add(this.panelExperience);
            this.panelSideMenu.Controls.Add(this.btnExperience);
            this.panelSideMenu.Controls.Add(this.panelEducation);
            this.panelSideMenu.Controls.Add(this.btnEducation);
            this.panelSideMenu.Controls.Add(this.panelContacts);
            this.panelSideMenu.Controls.Add(this.btnContacts);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(250, 600);
            this.panelSideMenu.TabIndex = 33;
            this.panelSideMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelSearch.Controls.Add(this.btnTags);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 525);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(250, 40);
            this.panelSearch.TabIndex = 10;
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTags.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTags.Location = new System.Drawing.Point(0, 0);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(250, 40);
            this.btnTags.TabIndex = 0;
            this.btnTags.Text = "Tags";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(0, 480);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(250, 45);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelFiles.Controls.Add(this.btnCoverLetters);
            this.panelFiles.Controls.Add(this.btnResumes);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiles.Location = new System.Drawing.Point(0, 400);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(250, 80);
            this.panelFiles.TabIndex = 8;
            // 
            // btnCoverLetters
            // 
            this.btnCoverLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoverLetters.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnCoverLetters.FlatAppearance.BorderSize = 0;
            this.btnCoverLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoverLetters.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoverLetters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoverLetters.Location = new System.Drawing.Point(0, 40);
            this.btnCoverLetters.Name = "btnCoverLetters";
            this.btnCoverLetters.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCoverLetters.Size = new System.Drawing.Size(250, 40);
            this.btnCoverLetters.TabIndex = 1;
            this.btnCoverLetters.Text = "Cover letters";
            this.btnCoverLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoverLetters.UseVisualStyleBackColor = true;
            this.btnCoverLetters.Click += new System.EventHandler(this.btnCoverLetters_Click);
            // 
            // btnResumes
            // 
            this.btnResumes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResumes.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnResumes.FlatAppearance.BorderSize = 0;
            this.btnResumes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumes.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnResumes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResumes.Location = new System.Drawing.Point(0, 0);
            this.btnResumes.Name = "btnResumes";
            this.btnResumes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnResumes.Size = new System.Drawing.Size(250, 40);
            this.btnResumes.TabIndex = 0;
            this.btnResumes.Text = "Resumes";
            this.btnResumes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumes.UseVisualStyleBackColor = true;
            this.btnResumes.Click += new System.EventHandler(this.btnResumes_Click);
            // 
            // btnFiles
            // 
            this.btnFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiles.Enabled = false;
            this.btnFiles.FlatAppearance.BorderSize = 0;
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiles.Location = new System.Drawing.Point(0, 355);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFiles.Size = new System.Drawing.Size(250, 45);
            this.btnFiles.TabIndex = 7;
            this.btnFiles.Text = "Files";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // panelExperience
            // 
            this.panelExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelExperience.Controls.Add(this.btnJobs);
            this.panelExperience.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExperience.Location = new System.Drawing.Point(0, 315);
            this.panelExperience.Name = "panelExperience";
            this.panelExperience.Size = new System.Drawing.Size(250, 40);
            this.panelExperience.TabIndex = 6;
            // 
            // btnJobs
            // 
            this.btnJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobs.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnJobs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJobs.Location = new System.Drawing.Point(0, 0);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnJobs.Size = new System.Drawing.Size(250, 40);
            this.btnJobs.TabIndex = 0;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobs.UseVisualStyleBackColor = true;
            this.btnJobs.Click += new System.EventHandler(this.btnJobs_Click);
            // 
            // btnExperience
            // 
            this.btnExperience.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExperience.FlatAppearance.BorderSize = 0;
            this.btnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperience.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExperience.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExperience.Location = new System.Drawing.Point(0, 270);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExperience.Size = new System.Drawing.Size(250, 45);
            this.btnExperience.TabIndex = 5;
            this.btnExperience.Text = "Experience";
            this.btnExperience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExperience.UseVisualStyleBackColor = true;
            this.btnExperience.Click += new System.EventHandler(this.btnExperience_Click);
            // 
            // panelEducation
            // 
            this.panelEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelEducation.Controls.Add(this.btnUniversity);
            this.panelEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEducation.Location = new System.Drawing.Point(0, 230);
            this.panelEducation.Name = "panelEducation";
            this.panelEducation.Size = new System.Drawing.Size(250, 40);
            this.panelEducation.TabIndex = 4;
            // 
            // btnUniversity
            // 
            this.btnUniversity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUniversity.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnUniversity.FlatAppearance.BorderSize = 0;
            this.btnUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniversity.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUniversity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUniversity.Location = new System.Drawing.Point(0, 0);
            this.btnUniversity.Name = "btnUniversity";
            this.btnUniversity.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUniversity.Size = new System.Drawing.Size(250, 40);
            this.btnUniversity.TabIndex = 0;
            this.btnUniversity.Text = "University";
            this.btnUniversity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniversity.UseVisualStyleBackColor = true;
            this.btnUniversity.Click += new System.EventHandler(this.btnUniversity_Click);
            // 
            // btnEducation
            // 
            this.btnEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEducation.FlatAppearance.BorderSize = 0;
            this.btnEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEducation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEducation.Location = new System.Drawing.Point(0, 185);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEducation.Size = new System.Drawing.Size(250, 45);
            this.btnEducation.TabIndex = 3;
            this.btnEducation.Text = "Education";
            this.btnEducation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEducation.UseVisualStyleBackColor = true;
            this.btnEducation.Click += new System.EventHandler(this.btnEducation_Click);
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelContacts.Controls.Add(this.btnSummary);
            this.panelContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContacts.Location = new System.Drawing.Point(0, 145);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(250, 40);
            this.panelContacts.TabIndex = 2;
            // 
            // btnSummary
            // 
            this.btnSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummary.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSummary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSummary.Location = new System.Drawing.Point(0, 0);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSummary.Size = new System.Drawing.Size(250, 40);
            this.btnSummary.TabIndex = 0;
            this.btnSummary.Text = "Summary";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.UseVisualStyleBackColor = false;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContacts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContacts.Location = new System.Drawing.Point(0, 100);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContacts.Size = new System.Drawing.Size(250, 45);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panelLogo.MouseLeave += new System.EventHandler(this.panelLogo_MouseLeave);
            this.panelLogo.MouseHover += new System.EventHandler(this.panelLogo_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 600);
            this.panelContainer.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.lblChangeColorScheme);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panelSideMenu.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.panelExperience.ResumeLayout(false);
            this.panelEducation.ResumeLayout(false);
            this.panelContacts.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Label lblChangeColorScheme;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContacts;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Panel panelFiles;
        private System.Windows.Forms.Button btnCoverLetters;
        private System.Windows.Forms.Button btnResumes;
        private System.Windows.Forms.Button btnFiles;
        private System.Windows.Forms.Panel panelExperience;
        private System.Windows.Forms.Button btnJobs;
        private System.Windows.Forms.Button btnExperience;
        private System.Windows.Forms.Panel panelEducation;
        private System.Windows.Forms.Button btnUniversity;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

