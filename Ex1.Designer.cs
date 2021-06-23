
namespace WinFormsApp1
{
    partial class Ex1
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
            this.Resume = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resume
            // 
            this.Resume.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Resume.Location = new System.Drawing.Point(249, 120);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(75, 23);
            this.Resume.TabIndex = 0;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = true;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 280);
            this.Controls.Add(this.Resume);
            this.Name = "Ex1";
            this.Text = "Ex1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Resume;
    }
}