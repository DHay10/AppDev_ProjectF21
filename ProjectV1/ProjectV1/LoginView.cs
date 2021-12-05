using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectV1
{
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
            DBSystem.initData();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameTB.Text == "user" && passwordTB.Text == "pass")
            {
                this.Hide();
                DashboardView mainMenu = new DashboardView();
                mainMenu.FormClosed += (s, args) => this.Close();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Please enter a valid username and/or password", "Wrong username/password",MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void OnKeyEnterDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (usernameTB.Focused)
                {
                    passwordTB.Focus();
                }
                else if (usernameTB.Text == "user" && passwordTB.Text == "pass")
                {
                    this.Hide();
                    DashboardView mainMenu = new DashboardView();
                    mainMenu.FormClosed += (s, args) => this.Close();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Please enter a valid username and/or password", "Wrong username/password", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
