
namespace gtscoliar.formes
{
    partial class Form3
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
            this.gtstgView1 = new gtscoliar.Views.gtstgView.gtstgView();
            this.SuspendLayout();
            // 
            // gtstgView1
            // 
            this.gtstgView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gtstgView1.Location = new System.Drawing.Point(0, 0);
            this.gtstgView1.Name = "gtstgView1";
            this.gtstgView1.Size = new System.Drawing.Size(800, 450);
            this.gtstgView1.TabIndex = 0;
            this.gtstgView1.Load += new System.EventHandler(this.gtstgView1_Load);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gtstgView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.gtstgView.gtstgView gtstgView1;
    }
}