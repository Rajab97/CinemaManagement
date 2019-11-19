using Cinema.Model;
using CinemaFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class SignIn : Form
    {
        CinemaEntities db;
        public SignIn()
        {
            InitializeComponent();
            db = new CinemaEntities();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form signUpForm = new SignUp(this);
            signUpForm.Show();
            this.Hide();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;

            User user = db.Users.FirstOrDefault(m => m.Email == email);
            if (user == null)
            {
                MessageBox.Show("This email is not valid");
                return;
            }
            if (!Helper.CheckPassword(password,user.Password))
            {
                MessageBox.Show("Password is incorrect");
                return;
            }
            Helper.CurrentUser = user;
            Form Seans = new Main(this);
            this.Hide();
            Seans.Show();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
