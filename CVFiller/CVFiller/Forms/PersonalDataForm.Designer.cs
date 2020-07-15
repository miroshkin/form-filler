namespace CVFiller.Forms
{
    partial class PersonalDataForm
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
            this.lblCountryCode = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCountryCode
            // 
            this.lblCountryCode.AutoSize = true;
            this.lblCountryCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCountryCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountryCode.Location = new System.Drawing.Point(12, 72);
            this.lblCountryCode.Name = "lblCountryCode";
            this.lblCountryCode.Size = new System.Drawing.Size(30, 24);
            this.lblCountryCode.TabIndex = 20;
            this.lblCountryCode.Text = "+7";
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDateOfBirth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 136);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 24);
            this.lblDateOfBirth.TabIndex = 19;
            this.lblDateOfBirth.Text = "26.02.1986";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstName.Location = new System.Drawing.Point(12, 9);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(62, 24);
            this.FirstName.TabIndex = 3;
            this.FirstName.Text = "Anton";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastName.Location = new System.Drawing.Point(80, 9);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(94, 24);
            this.LastName.TabIndex = 2;
            this.LastName.Text = "Miroshkin";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLocation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLocation.Location = new System.Drawing.Point(12, 102);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(79, 24);
            this.lblLocation.TabIndex = 18;
            this.lblLocation.Text = "Moscow";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEmail.Location = new System.Drawing.Point(12, 41);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(251, 24);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "anton.miroshkin@gmail.com";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(45, 72);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(110, 24);
            this.lblPhone.TabIndex = 17;
            this.lblPhone.Text = "9161631867";
            // 
            // PersonalDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(768, 725);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.lblCountryCode);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PersonalDataForm";
            this.Text = "PersonalDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCountryCode;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
    }
}