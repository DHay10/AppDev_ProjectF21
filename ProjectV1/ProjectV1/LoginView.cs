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
            // If press enter either goes to passwordTB if usernameTB is focused or logs in if passwordTB is selected
            if (e.KeyCode == Keys.Enter)
            {
                if (usernameTB.Focused)
                {
                    passwordTB.Focus();
                }
                else if (usernameTB.Text == "user" && passwordTB.Text == "pass")
                {
                    // Hides the login form once logged in and it will close upon the closing of the dashboard form
                    this.Hide();
                    DashboardView mainMenu = new DashboardView();
                    mainMenu.FormClosed += (s, args) => this.Close();
                    mainMenu.Show();
                }
                else
                {
                    // If the username or pass word is wrong, it will display error message
                    MessageBox.Show("Please enter a valid username and/or password", "Wrong username/password", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                // To disable the sound from pressing enter since its single line text boxes.
                e.Handled = true;       // Makes the event handled
                e.SuppressKeyPress = true;  // Makes the key press not active in the end
            }
        }
    }
}
