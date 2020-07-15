namespace CVFiller
{
    partial class SummaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummaryForm));
            this.lblPitch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.BackColor = System.Drawing.Color.Transparent;
            this.lblPitch.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPitch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPitch.Location = new System.Drawing.Point(0, 0);
            this.lblPitch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPitch.MaximumSize = new System.Drawing.Size(700, 0);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(699, 105);
            this.lblPitch.TabIndex = 21;
            this.lblPitch.Text = resources.GetString("lblPitch.Text");
            this.lblPitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.lblPitch);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPitch;
    }
}