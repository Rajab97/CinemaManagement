using CinemaFormApp.Classes;
using Cinema.Model;
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

namespace CinemaFormApp
{
    public partial class AddFilm : Form
    {
        private Form MainForm;
        private Panel FilmPanel;
        private string FileName;
        private string FilePath;
        private CinemaEntities db;
        public AddFilm(Form mainForm , Panel posterPanel)
        {
            InitializeComponent();
            MainForm = mainForm;
            FilmPanel = posterPanel;
            db = new CinemaEntities();
        }
        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                FileName = DateTime.Now.ToString("yyyyMMddHHmmssffff")+openFileDialog.SafeFileName;
                FilePath = openFileDialog.FileName;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    Duration = Convert.ToInt32(txtDuration.Text),
                    StartDate = dtpStartDAte.Value.Date,
                    LanguageId = (byte)cmbLanguages.SelectedValue,
                    RestrictionId = (byte)cmbRestriction.SelectedValue,
                    PhotoName = FileName
                };
                db.Films.Add(film);
                db.SaveChanges();
                File.Copy(FilePath, Path.Combine(Helper.GetPathToProjectFolder("Uploads"), FileName));
                this.Hide();
                Helper.AddPostersToPanel(FilmPanel,MainForm,db);
                MainForm.Show();
            }
            catch (Exception d)
            {
                MessageBox.Show(d.Message);
                this.Hide();
                MainForm.Show();
            }
        }

        private void AddFilm_Load(object sender, EventArgs e)
        {
            cmbLanguages.DataSource = db.Languages.ToList();
            cmbLanguages.DisplayMember = "Name";
            cmbLanguages.ValueMember = "Id";
            cmbRestriction.DataSource = db.Restrictions.ToList();
            cmbRestriction.DisplayMember = "Name";
            cmbRestriction.ValueMember = "Id";
        }

        private void AddFilm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            MainForm.Show();
        }
    }
}
