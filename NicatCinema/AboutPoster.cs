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
    public partial class AboutPoster : Form
    {
        private Form MainForm;
        private int FilmId;
        private CinemaEntities db;
        public AboutPoster(Form mainForm , int filmId)
        {
            InitializeComponent();
            this.MainForm = mainForm;
            this.FilmId = filmId;
            db = new CinemaEntities();
        }

        private void AboutPoster_Load(object sender, EventArgs e)
        {
            string path = Helper.GetPathToProjectFolder("Uploads");
            Film film = db.Films.FirstOrDefault(m => m.Id == FilmId);
            FilmTitle.Text = film.Title;
            FilmDescription.Text = film.Description;
            FilmDuration.Text = film.Duration + " deq";
            FilmDate.Text = film.StartDate.ToShortDateString();
            FilmLanguage.Text = film.Language.Name;
            FilmRestriction.Text = film.Restriction.Name;
            FilmRestriction.Width = 200;
            FilmBigPhoto.Image = Image.FromFile(Path.Combine(path, film.PhotoName));

            List<Sean> seans = db.Seans.Where(m => m.FilmId == FilmId).ToList();
            int counter = 1;
            foreach (Sean item in seans)
            {

                

                SeansOfFilm.Rows.Add(item.Id ,item.HallId, counter, item.Hall.Name , item.Date.ToShortDateString() , item.Time.ToString("hh\\:mm") , "Buy");

              

                counter++;
            }
        }

        private void AboutPoster_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }

        private void SeansOfFilm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv != null && dgv.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
            {
                this.Hide();
                BuyTicket tickets = new BuyTicket(MainForm ,this, (byte)dgv.Rows[e.RowIndex].Cells["HallId"].Value , (int)dgv.Rows[e.RowIndex].Cells["Id"].Value);
                tickets.Show();
            }
        }
    }
}
