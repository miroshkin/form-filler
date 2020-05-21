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
            this.rtbProfile = new System.Windows.Forms.RichTextBox();
            this.lblProfile = new System.Windows.Forms.Label();
            this.txtbxTag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTag = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
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
            this.FirstName.Location = new System.Drawing.Point(12, 122);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(42, 17);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "Anton";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(62, 122);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(63, 17);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Miroshkin";
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // rtbProfile
            // 
            this.rtbProfile.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.rtbProfile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbProfile.Font = new System.Drawing.Font("Calibri", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtbProfile.Location = new System.Drawing.Point(12, 180);
            this.rtbProfile.Name = "rtbProfile";
            this.rtbProfile.Size = new System.Drawing.Size(571, 83);
            this.rtbProfile.TabIndex = 4;
            this.rtbProfile.Text = resources.GetString("rtbProfile.Text");
            this.rtbProfile.Click += new System.EventHandler(this.rtbProfile_Click);
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Location = new System.Drawing.Point(12, 160);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(44, 17);
            this.lblProfile.TabIndex = 5;
            this.lblProfile.Text = "Profile";
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
            this.lblEmail.Location = new System.Drawing.Point(131, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(171, 17);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "anton.miroshkin@gmail.com";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(308, 122);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(104, 17);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "+7 916 163 18 67";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(425, 122);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(104, 17);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "+7 916 163 18 67";
            this.lblLocation.Click += new System.EventHandler(this.lblLocation_Click);
            // 
            // CVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(595, 842);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnAddTag);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxTag);
            this.Controls.Add(this.lblProfile);
            this.Controls.Add(this.rtbProfile);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CVForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.RichTextBox rtbProfile;
        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.TextBox txtbxTag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTag;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLocation;
    }
}

