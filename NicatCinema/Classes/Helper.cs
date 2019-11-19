using CinemaFormApp;
using CinemaFormApp.Classes;
using Cinema.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CinemaFormApp

{
    public static class Helper
    {
        public static User CurrentUser;
        public static string GetPathToProjectFolder(string folderPathFromMainFolder)
        {
            string uploadPath = Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "NicatCinema");
            return Path.Combine(uploadPath, folderPathFromMainFolder);

        }
        private static Form PanelForm { get; set; }
        public static void AddPostersToPanel(Panel panel , Form currentForm , CinemaEntities db)
        {
            List<Film> films = db.Films.ToList();
            PanelForm = currentForm;
            panel.Controls.Clear();

            int leftPosition = 10;
            int topPosition = 10;
            byte countForEachRow = 3;
            int widthOfOnePoster = panel.Width / countForEachRow - leftPosition * 2;
            int counter = 1;
            string imagePath = string.Empty;
            foreach (Film item in films)
            {
                imagePath = Path.Combine(Helper.GetPathToProjectFolder("Uploads"), item.PhotoName);
                PosterPictureBox pictureBox = new PosterPictureBox
                {
                    Cursor = Cursors.Hand,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Image = Image.FromFile(imagePath),
                    Left = leftPosition,
                    Top = topPosition,
                    Width = widthOfOnePoster,
                    Height = 300,
                    FilmId = item.Id
                };
                pictureBox.Click += new EventHandler(posterClick);
                panel.Controls.Add(pictureBox);
                leftPosition += widthOfOnePoster + 10;
                if (counter == countForEachRow)
                {
                    counter = 0;
                    topPosition += pictureBox.Height + 10;
                    leftPosition = 10;
                }
                counter++;
            }
        }
        private static void posterClick(object sender, EventArgs e)
        {
            PosterPictureBox pictureBox = sender as PosterPictureBox;
            AboutPoster aboutPoster = new AboutPoster(PanelForm, pictureBox.FilmId);
            PanelForm.Hide();
            aboutPoster.Show();
        }
        public static string Encrypt(string value)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        public static bool CheckPassword(string plainText , string encryptedText)
        {
            //Using MD5 to encrypt a string
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                //Hash data
                byte[] data = md5.ComputeHash(utf8.GetBytes(plainText));
                return Convert.ToBase64String(data) == encryptedText;
            }
        }
    }
}
