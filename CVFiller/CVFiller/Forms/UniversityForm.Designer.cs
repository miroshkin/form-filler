namespace CVFiller.Forms
{
    partial class UniversityForm
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
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.lblEducationStartDate = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMajor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMajor.Location = new System.Drawing.Point(0, 38);
            this.lblMajor.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblMajor.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Padding = new System.Windows.Forms.Padding(15, 7, 5, 7);
            this.lblMajor.Size = new System.Drawing.Size(700, 38);
            this.lblMajor.TabIndex = 21;
            this.lblMajor.Text = "Electrical System And Networks";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEndDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEndDate.Location = new System.Drawing.Point(0, 152);
            this.lblEndDate.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblEndDate.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Padding = new System.Windows.Forms.Padding(15, 7, 5, 7);
            this.lblEndDate.Size = new System.Drawing.Size(700, 38);
            this.lblEndDate.TabIndex = 23;
            this.lblEndDate.Text = "2009";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSchoolName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSchoolName.Location = new System.Drawing.Point(0, 0);
            this.lblSchoolName.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblSchoolName.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Padding = new System.Windows.Forms.Padding(15, 7, 5, 7);
            this.lblSchoolName.Size = new System.Drawing.Size(700, 38);
            this.lblSchoolName.TabIndex = 19;
            this.lblSchoolName.Text = "Moscow Power Engineering Institute (Technical University)";
            // 
            // lblEducationStartDate
            // 
            this.lblEducationStartDate.AutoSize = true;
            this.lblEducationStartDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEducationStartDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEducationStartDate.Location = new System.Drawing.Point(0, 114);
            this.lblEducationStartDate.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblEducationStartDate.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblEducationStartDate.Name = "lblEducationStartDate";
            this.lblEducationStartDate.Padding = new System.Windows.Forms.Padding(15, 7, 5, 7);
            this.lblEducationStartDate.Size = new System.Drawing.Size(700, 38);
            this.lblEducationStartDate.TabIndex = 22;
            this.lblEducationStartDate.Text = "2003";
            // 
            // lblDegree
            // 
            this.lblDegree.AutoSize = true;
            this.lblDegree.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDegree.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDegree.Location = new System.Drawing.Point(0, 76);
            this.lblDegree.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblDegree.MinimumSize = new System.Drawing.Size(700, 0);
            this.lblDegree.Name = "lblDegree";
            this.lblDegree.Padding = new System.Windows.Forms.Padding(15, 7, 5, 7);
            this.lblDegree.Size = new System.Drawing.Size(700, 38);
            this.lblDegree.TabIndex = 20;
            this.lblDegree.Text = "Master Of Science In Engineering";
            // 
            // EducationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(682, 553);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblEducationStartDate);
            this.Controls.Add(this.lblDegree);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblSchoolName);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.Name = "EducationForm";
            this.Text = "EducationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label lblEducationStartDate;
        private System.Windows.Forms.Label lblDegree;
    }
}