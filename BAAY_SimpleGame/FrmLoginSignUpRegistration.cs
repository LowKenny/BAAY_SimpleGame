using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BAAY_SimpleGame
{
    public partial class FrmLoginSignUpRegistration : Form
    {
        public FrmLoginSignUpRegistration()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            new FrmIntro().Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
           //Declaration
            string LoginUsername = txtUsername.Text;
            string Password = txtPassword.Text;

            if  (clsSignUp.signup.ContainsKey("usernameS") && clsSignUp.signup["usernameS"] == LoginUsername &&
                     clsSignUp.signup.ContainsKey("Cpassword") && clsSignUp.signup["Cpassword"] == Password)
            {
                this.Hide();
                MessageBox.Show("Successfully Logged in", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new FrmHomepage().Show();
            }  
            //if (txtUsername.Text == clsSignUp.signup.ContainsKey(txtUserNameSignUp) && txtPassword.Text == clsSignUp.signup.ContainsKey(txtConfirmPassword))
            else if (txtUsername.Text == "baaykenny" && txtPassword.Text == "abc123456?")
            {
                this.Hide();
                new FrmHomepage().Show();
            }
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill the space provided", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnlRegister.Height = pnlSideLogin.Height;
            pnlSideLogin.Location = new Point(42,25);
            PnlLeftSideDisplay.Location = new Point(450,20);
        }
        private void pnlSideLogin_Paint(object sender, PaintEventArgs e)
        {
        }
        private void pnlRegister_Paint(object sender, PaintEventArgs e)
        {
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Creating and confirming account with a password of 8 characters with 1 special sysmbol

            string UserName = txtUserNameSignUp.Text;
            string CreatePassword = txtCreatePassword.Text;
            string ConfirmPassword = txtConfirmPassword.Text;
            
            
            if (txtUserNameSignUp.Text == "" && txtCreatePassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Fill in the spaces provided", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(UserName) || string.IsNullOrEmpty(CreatePassword) || string.IsNullOrEmpty(ConfirmPassword))
            {
                MessageBox.Show("Please input username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CreatePassword.Length < 8 || !ConfirmPassword.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Password must contain at least 8 characters and at least 1 symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCreatePassword.Clear();
                txtConfirmPassword.Clear();
                return;
            }

            if (CreatePassword != ConfirmPassword)
            {
                MessageBox.Show("Password don't match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                string usernameS = txtUserNameSignUp.Text;  
                string passwordS = txtCreatePassword.Text;
                string Cpassword = txtConfirmPassword.Text;

                clsSignUp.signup.Add("usernameS", usernameS);
                clsSignUp.signup.Add("passwordS", passwordS);
                clsSignUp.signup.Add("Cpassword", Cpassword);

                MessageBox.Show("Registration complete!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
                //switch

             pnlRegister.Height = 0;
             pnlSideLogin.Location = new Point(470,20);
             PnlLeftSideDisplay.Location= new Point(35,25);
            }
            


        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
