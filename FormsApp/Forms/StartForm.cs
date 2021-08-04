using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.Forms
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        int progressBarStartPoint = 0;
       private void progressBarTimer_Tick(object sender, EventArgs e)
        {
            progressBarStartPoint += 1;
            appProgressBar.Value = progressBarStartPoint;
            if (appProgressBar.Value == 100)
            {
                appProgressBar.Value = 0;
                progressBarTimer.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            progressBarTimer.Start();
        }
    }
}
