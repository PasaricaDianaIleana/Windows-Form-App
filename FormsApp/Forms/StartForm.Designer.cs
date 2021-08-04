
namespace FormsApp.Forms
{
    partial class StartForm
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
            this.loginLabel1 = new System.Windows.Forms.Label();
            this.appProgressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progressBarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loginLabel1
            // 
            this.loginLabel1.AutoSize = true;
            this.loginLabel1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginLabel1.ForeColor = System.Drawing.Color.Transparent;
            this.loginLabel1.Location = new System.Drawing.Point(105, 99);
            this.loginLabel1.Name = "loginLabel1";
            this.loginLabel1.Size = new System.Drawing.Size(403, 34);
            this.loginLabel1.TabIndex = 4;
            this.loginLabel1.Text = "Market Management System";
            // 
            // appProgressBar
            // 
            this.appProgressBar.Location = new System.Drawing.Point(-2, 319);
            this.appProgressBar.Name = "appProgressBar";
            this.appProgressBar.ProgressColor = System.Drawing.Color.White;
            this.appProgressBar.ProgressColor2 = System.Drawing.Color.White;
            this.appProgressBar.ShadowDecoration.Parent = this.appProgressBar;
            this.appProgressBar.Size = new System.Drawing.Size(605, 10);
            this.appProgressBar.TabIndex = 5;
            this.appProgressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // progressBarTimer
            // 
            this.progressBarTimer.Tick += new System.EventHandler(this.progressBarTimer_Tick);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(595, 328);
            this.Controls.Add(this.appProgressBar);
            this.Controls.Add(this.loginLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLabel1;
        private Guna.UI2.WinForms.Guna2ProgressBar appProgressBar;
        private System.Windows.Forms.Timer progressBarTimer;
    }
}