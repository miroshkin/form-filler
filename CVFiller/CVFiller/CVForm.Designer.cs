﻿namespace FormFiller
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
            this.lblChangeColorScheme = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnContacts = new System.Windows.Forms.Button();
            this.panelContacts = new System.Windows.Forms.Panel();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnPersonalData = new System.Windows.Forms.Button();
            this.btnAddress = new System.Windows.Forms.Button();
            this.btnSocialLinks = new System.Windows.Forms.Button();
            this.btnEducation = new System.Windows.Forms.Button();
            this.panelEducation = new System.Windows.Forms.Panel();
            this.btnAdditionalCourses = new System.Windows.Forms.Button();
            this.btnUniversity = new System.Windows.Forms.Button();
            this.btnExperience = new System.Windows.Forms.Button();
            this.panelExperience = new System.Windows.Forms.Panel();
            this.btnJobs = new System.Windows.Forms.Button();
            this.btnFiles = new System.Windows.Forms.Button();
            this.panelFiles = new System.Windows.Forms.Panel();
            this.btnCoverLetters = new System.Windows.Forms.Button();
            this.btnResumes = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnTags = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelContacts.SuspendLayout();
            this.panelEducation.SuspendLayout();
            this.panelExperience.SuspendLayout();
            this.panelFiles.SuspendLayout();
            this.panelSearch.SuspendLayout();
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
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // btnContacts
            // 
            this.btnContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnContacts.Location = new System.Drawing.Point(0, 100);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnContacts.Size = new System.Drawing.Size(229, 45);
            this.btnContacts.TabIndex = 1;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // panelContacts
            // 
            this.panelContacts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelContacts.Controls.Add(this.btnSocialLinks);
            this.panelContacts.Controls.Add(this.btnAddress);
            this.panelContacts.Controls.Add(this.btnPersonalData);
            this.panelContacts.Controls.Add(this.btnSummary);
            this.panelContacts.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelContacts.Location = new System.Drawing.Point(0, 145);
            this.panelContacts.Name = "panelContacts";
            this.panelContacts.Size = new System.Drawing.Size(229, 185);
            this.panelContacts.TabIndex = 2;
            // 
            // btnSummary
            // 
            this.btnSummary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSummary.FlatAppearance.BorderSize = 0;
            this.btnSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSummary.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSummary.Location = new System.Drawing.Point(0, 0);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSummary.Size = new System.Drawing.Size(229, 40);
            this.btnSummary.TabIndex = 0;
            this.btnSummary.Text = "Summary";
            this.btnSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSummary.UseVisualStyleBackColor = true;
            // 
            // btnPersonalData
            // 
            this.btnPersonalData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPersonalData.FlatAppearance.BorderSize = 0;
            this.btnPersonalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonalData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPersonalData.Location = new System.Drawing.Point(0, 40);
            this.btnPersonalData.Name = "btnPersonalData";
            this.btnPersonalData.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPersonalData.Size = new System.Drawing.Size(229, 40);
            this.btnPersonalData.TabIndex = 1;
            this.btnPersonalData.Text = "Personal data";
            this.btnPersonalData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPersonalData.UseVisualStyleBackColor = true;
            // 
            // btnAddress
            // 
            this.btnAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddress.FlatAppearance.BorderSize = 0;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddress.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddress.Location = new System.Drawing.Point(0, 80);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAddress.Size = new System.Drawing.Size(229, 40);
            this.btnAddress.TabIndex = 2;
            this.btnAddress.Text = "Address";
            this.btnAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddress.UseVisualStyleBackColor = true;
            // 
            // btnSocialLinks
            // 
            this.btnSocialLinks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSocialLinks.FlatAppearance.BorderSize = 0;
            this.btnSocialLinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSocialLinks.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSocialLinks.Location = new System.Drawing.Point(0, 120);
            this.btnSocialLinks.Name = "btnSocialLinks";
            this.btnSocialLinks.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSocialLinks.Size = new System.Drawing.Size(229, 40);
            this.btnSocialLinks.TabIndex = 3;
            this.btnSocialLinks.Text = "Social links";
            this.btnSocialLinks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSocialLinks.UseVisualStyleBackColor = true;
            // 
            // btnEducation
            // 
            this.btnEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEducation.FlatAppearance.BorderSize = 0;
            this.btnEducation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEducation.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEducation.Location = new System.Drawing.Point(0, 330);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnEducation.Size = new System.Drawing.Size(229, 45);
            this.btnEducation.TabIndex = 3;
            this.btnEducation.Text = "Education";
            this.btnEducation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEducation.UseVisualStyleBackColor = true;
            this.btnEducation.Click += new System.EventHandler(this.btnEducation_Click);
            // 
            // panelEducation
            // 
            this.panelEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelEducation.Controls.Add(this.btnAdditionalCourses);
            this.panelEducation.Controls.Add(this.btnUniversity);
            this.panelEducation.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEducation.Location = new System.Drawing.Point(0, 375);
            this.panelEducation.Name = "panelEducation";
            this.panelEducation.Size = new System.Drawing.Size(229, 99);
            this.panelEducation.TabIndex = 4;
            // 
            // btnAdditionalCourses
            // 
            this.btnAdditionalCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdditionalCourses.FlatAppearance.BorderSize = 0;
            this.btnAdditionalCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdditionalCourses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdditionalCourses.Location = new System.Drawing.Point(0, 40);
            this.btnAdditionalCourses.Name = "btnAdditionalCourses";
            this.btnAdditionalCourses.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAdditionalCourses.Size = new System.Drawing.Size(229, 40);
            this.btnAdditionalCourses.TabIndex = 1;
            this.btnAdditionalCourses.Text = "Additional courses";
            this.btnAdditionalCourses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdditionalCourses.UseVisualStyleBackColor = true;
            // 
            // btnUniversity
            // 
            this.btnUniversity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUniversity.FlatAppearance.BorderSize = 0;
            this.btnUniversity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUniversity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUniversity.Location = new System.Drawing.Point(0, 0);
            this.btnUniversity.Name = "btnUniversity";
            this.btnUniversity.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnUniversity.Size = new System.Drawing.Size(229, 40);
            this.btnUniversity.TabIndex = 0;
            this.btnUniversity.Text = "University";
            this.btnUniversity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUniversity.UseVisualStyleBackColor = true;
            // 
            // btnExperience
            // 
            this.btnExperience.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExperience.FlatAppearance.BorderSize = 0;
            this.btnExperience.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExperience.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExperience.Location = new System.Drawing.Point(0, 474);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnExperience.Size = new System.Drawing.Size(229, 45);
            this.btnExperience.TabIndex = 5;
            this.btnExperience.Text = "Experience";
            this.btnExperience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExperience.UseVisualStyleBackColor = true;
            this.btnExperience.Click += new System.EventHandler(this.btnExperience_Click);
            // 
            // panelExperience
            // 
            this.panelExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelExperience.Controls.Add(this.btnJobs);
            this.panelExperience.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelExperience.Location = new System.Drawing.Point(0, 519);
            this.panelExperience.Name = "panelExperience";
            this.panelExperience.Size = new System.Drawing.Size(229, 56);
            this.panelExperience.TabIndex = 6;
            // 
            // btnJobs
            // 
            this.btnJobs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnJobs.FlatAppearance.BorderSize = 0;
            this.btnJobs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJobs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnJobs.Location = new System.Drawing.Point(0, 0);
            this.btnJobs.Name = "btnJobs";
            this.btnJobs.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnJobs.Size = new System.Drawing.Size(229, 40);
            this.btnJobs.TabIndex = 0;
            this.btnJobs.Text = "Jobs";
            this.btnJobs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJobs.UseVisualStyleBackColor = true;
            // 
            // btnFiles
            // 
            this.btnFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFiles.FlatAppearance.BorderSize = 0;
            this.btnFiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiles.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFiles.Location = new System.Drawing.Point(0, 575);
            this.btnFiles.Name = "btnFiles";
            this.btnFiles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnFiles.Size = new System.Drawing.Size(229, 45);
            this.btnFiles.TabIndex = 7;
            this.btnFiles.Text = "Files";
            this.btnFiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiles.UseVisualStyleBackColor = true;
            this.btnFiles.Click += new System.EventHandler(this.btnFiles_Click);
            // 
            // panelFiles
            // 
            this.panelFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelFiles.Controls.Add(this.btnCoverLetters);
            this.panelFiles.Controls.Add(this.btnResumes);
            this.panelFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFiles.Location = new System.Drawing.Point(0, 620);
            this.panelFiles.Name = "panelFiles";
            this.panelFiles.Size = new System.Drawing.Size(229, 99);
            this.panelFiles.TabIndex = 8;
            // 
            // btnCoverLetters
            // 
            this.btnCoverLetters.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoverLetters.FlatAppearance.BorderSize = 0;
            this.btnCoverLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoverLetters.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCoverLetters.Location = new System.Drawing.Point(0, 40);
            this.btnCoverLetters.Name = "btnCoverLetters";
            this.btnCoverLetters.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCoverLetters.Size = new System.Drawing.Size(229, 40);
            this.btnCoverLetters.TabIndex = 1;
            this.btnCoverLetters.Text = "Cover letters";
            this.btnCoverLetters.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoverLetters.UseVisualStyleBackColor = true;
            // 
            // btnResumes
            // 
            this.btnResumes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResumes.FlatAppearance.BorderSize = 0;
            this.btnResumes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResumes.Location = new System.Drawing.Point(0, 0);
            this.btnResumes.Name = "btnResumes";
            this.btnResumes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnResumes.Size = new System.Drawing.Size(229, 40);
            this.btnResumes.TabIndex = 0;
            this.btnResumes.Text = "Resumes";
            this.btnResumes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResumes.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(0, 719);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSearch.Size = new System.Drawing.Size(229, 45);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelSearch.Controls.Add(this.btnTags);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 764);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(229, 49);
            this.panelSearch.TabIndex = 10;
            // 
            // btnTags
            // 
            this.btnTags.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTags.Location = new System.Drawing.Point(0, 0);
            this.btnTags.Name = "btnTags";
            this.btnTags.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTags.Size = new System.Drawing.Size(229, 40);
            this.btnTags.TabIndex = 0;
            this.btnTags.Text = "Tags";
            this.btnTags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTags.UseVisualStyleBackColor = true;
            // 
            // CVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.lblChangeColorScheme);
            this.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "CVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CVForm_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CVForm_MouseDown);
            this.panelSideMenu.ResumeLayout(false);
            this.panelContacts.ResumeLayout(false);
            this.panelEducation.ResumeLayout(false);
            this.panelExperience.ResumeLayout(false);
            this.panelFiles.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSocialLinks;
        private System.Windows.Forms.Button btnAddress;
        private System.Windows.Forms.Button btnPersonalData;
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
        private System.Windows.Forms.Button btnAdditionalCourses;
        private System.Windows.Forms.Button btnUniversity;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Button btnSearch;
    }
}

