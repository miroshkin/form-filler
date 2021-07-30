namespace FormFiller.Forms
{
    partial class SocialLinksForm
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
            this.lblGithub = new System.Windows.Forms.Label();
            this.lblPersonalWebsite = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.lblLinkedIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGithub
            // 
            this.lblGithub.AutoSize = true;
            this.lblGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGithub.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGithub.Location = new System.Drawing.Point(12, 117);
            this.lblGithub.Name = "lblGithub";
            this.lblGithub.Size = new System.Drawing.Size(259, 24);
            this.lblGithub.TabIndex = 19;
            this.lblGithub.Text = "https://github.com/miroshkin";
            // 
            // lblPersonalWebsite
            // 
            this.lblPersonalWebsite.AutoSize = true;
            this.lblPersonalWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPersonalWebsite.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPersonalWebsite.Location = new System.Drawing.Point(12, 80);
            this.lblPersonalWebsite.Name = "lblPersonalWebsite";
            this.lblPersonalWebsite.Size = new System.Drawing.Size(245, 24);
            this.lblPersonalWebsite.TabIndex = 18;
            this.lblPersonalWebsite.Text = "https://miroshkin.github.io/";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFacebook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFacebook.Location = new System.Drawing.Point(12, 43);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(280, 24);
            this.lblFacebook.TabIndex = 17;
            this.lblFacebook.Text = "facebook.com/miroshkin.anton/";
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLinkedIn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLinkedIn.Location = new System.Drawing.Point(12, 9);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(295, 24);
            this.lblLinkedIn.TabIndex = 16;
            this.lblLinkedIn.Text = "linkedin.com/in/miroshkin-anton/";
            // 
            // SocialLinksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(767, 726);
            this.Controls.Add(this.lblGithub);
            this.Controls.Add(this.lblPersonalWebsite);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.lblLinkedIn);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SocialLinksForm";
            this.Text = "SocialLinksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGithub;
        private System.Windows.Forms.Label lblPersonalWebsite;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Label lblLinkedIn;
    }
}