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
            DBSystem.initData(); //initializing database system
        }

        //login button method
        private void loginButton_Click(object sender, EventArgs e)
        {
            //if user enters correct username and password, goes to dashboard
            if (usernameTB.Text == "user" && passwordTB.Text == "pass")
            {
                this.Hide();//hides login page
                DashboardView mainMenu = new DashboardView();
                //if close main menu, close whole system
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
            //if press enter either goes to net textbox or logs in
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
