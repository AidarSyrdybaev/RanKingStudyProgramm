using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RankingAppProject
{
    public partial class AuthorizationForm : Form
    {
        public bool LoginCheck { get; internal set; }
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void InputLoginButton_Click(object sender, EventArgs e)
        {
            if (NameLoginTextBox.Text == "TestName" && PasswordTextBox.Text == "TestPassword")
            {
                MainForm mainForm = new MainForm();
                LoginCheck = true;
                mainForm.Show();
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
