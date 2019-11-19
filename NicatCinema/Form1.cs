using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaFormApp.Classes;
using Cinema.Model;
namespace CinemaFormApp
{
    public partial class Main : Form
    {
        private CinemaEntities db;
        private Form MainForm;
        public Main(Form mainForm)
        {
            InitializeComponent();
            db = new CinemaEntities();
            Helper.AddPostersToPanel(Posters,this,db);
            MainForm = mainForm;
            lblUserName.Text = Helper.CurrentUser.Email;
        }

     

      

        private void btnAddFilm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddFilm addFilm = new AddFilm(this, Posters);
            addFilm.Show();
        }

        private void btsAddSeans_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSeans addSeans = new AddSeans(this);
            addSeans.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }
    }
}
