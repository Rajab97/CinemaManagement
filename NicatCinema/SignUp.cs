using Cinema.Model;
using CinemaFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class SignUp : Form
    {
        Form MainForm;
        CinemaEntities db;
        public SignUp(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            db = new CinemaEntities();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs ex)
        {
            string email = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirm.Text;

            if (password == confirmPassword)
            {
                if (String.IsNullOrEmpty(email) || !email.Contains("@"))
                {
                    MessageBox.Show("This email is not correct");
                    return;
                }
                    User user = new User();
                    user.Email = email;
                    user.Password = Helper.Encrypt(password);
                    user.UserTypeId = 2;
                    db.Users.Add(user);
                    db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Password is not confirmed");
                return;
            }
            
            this.Close();
        }
    }
}
