using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema.Model;
namespace CinemaFormApp
{
    public partial class AddSeans : Form
    {
        private Form MainForm;
        private CinemaEntities db;
        public AddSeans(Form mainForm)
        {
            InitializeComponent();
            MainForm = mainForm;
            db = new CinemaEntities();
        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddSeans_Load(object sender, EventArgs e)
        {
            cmbFilms.DataSource = db.Films.ToList();
            cmbFilms.DisplayMember = "Title";
            cmbFilms.ValueMember = "Id";
            cmbHalls.DataSource = db.Halls.ToList();
            cmbHalls.DisplayMember = "Name";
            cmbHalls.ValueMember = "Id";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Sean sean = new Sean()
                {
                    FilmId = (int)cmbFilms.SelectedValue,
                    HallId = (byte)cmbHalls.SelectedValue,
                    Date = dtpDate.Value.Date,
                    Time = dtpTime.Value.TimeOfDay,
                    Price = Convert.ToDecimal(txtPrice.Text)
                };
                db.Seans.Add(sean);
                db.SaveChanges();
                this.Hide();
                MainForm.Show();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
                this.Hide();
                MainForm.Show();

            }
        }

        private void AddSeans_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.Show();
        }
    }
}
