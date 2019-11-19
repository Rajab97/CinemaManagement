using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaFormApp.Classes;
using Cinema.Model;
namespace CinemaFormApp
{
    public partial class BuyTicket : Form
    {
        private byte HallId;
        private int PosterId;
        private Form MainForm;
        private Form AboutForm;
        private CinemaEntities db;
        private byte Count;
        private int Price;
        private List<SeatButton> SelectedSeats;
        public BuyTicket(Form mainForm ,Form aboutForm, byte hallId , int posterId)
        {
            InitializeComponent();
            this.MainForm = mainForm;
            this.AboutForm = aboutForm;
            this.HallId = hallId;
            this.PosterId = posterId;
            this.Count = 0;
            this.Price = 0;
            this.db = new CinemaEntities();
            SelectedSeats = new List<SeatButton>();
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            lblHallName.Text = db.Halls.FirstOrDefault(m => m.Id == HallId).Name;
            AddSeats(HallId , PosterId , pnlSeats);
        }
        private void AddSeats(byte hallId , int posterId , Panel panel)
        {
            Hall hall = db.Halls.FirstOrDefault(m => m.Id == hallId);
            if(hall != null)
            {
                int randomRowIdOfHall = db.Rows.First(m => m.HallId == hall.Id).Id;
                byte countOfRandomRowSeats = (byte)db.Seats.Where(k => k.RowId == randomRowIdOfHall).Count();
                int MarginFromLeftAndRight = 5;
                int MarginFromTop = 5;
                int TopPosition = MarginFromTop;
                int LeftPosition = MarginFromLeftAndRight;
                byte WidthOfOneSeat = (panel != null) ? (byte)((panel.Width - countOfRandomRowSeats * MarginFromLeftAndRight - 15)/ countOfRandomRowSeats) : (byte)10;
                byte HeightOfOneSeat = WidthOfOneSeat;

                foreach (Row row in db.Rows.Where(m => m.HallId == hallId).OrderBy(m=>m.Number))
                {
                    foreach (Seat seat in db.Seats.Where(k => k.RowId == row.Id).OrderBy(k => k.Number))
                    {
                        SeatButton seatButton = new SeatButton(posterId, seat.Id)
                        {
                            Left = LeftPosition,
                            Top = TopPosition,
                            Width = WidthOfOneSeat,
                            Height = HeightOfOneSeat,
                            Text = seat.Number.ToString(),
                            BackColor = (db.Tickets.Any(m => m.SeatId == seat.Id && m.SeansId == posterId))?Color.Black:Color.LightGray,
                            Enabled = (db.Tickets.Any(m => m.SeatId == seat.Id && m.SeansId == posterId))?false:true
                        };
                        seatButton.Click += new EventHandler(SelectSeat);
                        panel.Controls.Add(seatButton);
                        LeftPosition += WidthOfOneSeat + MarginFromLeftAndRight;
                    }
                    LeftPosition = MarginFromLeftAndRight;
                    TopPosition += HeightOfOneSeat + MarginFromTop*2;
                }
                Button ekran = new Button()
                {
                    Width = panel.Width - 15 - MarginFromLeftAndRight * 2,
                    Height = 50,
                    Text = "Ekran",
                    Left = LeftPosition,
                    Top = TopPosition,
                };
                panel.Controls.Add(ekran);
            }
            else
            {
                MessageBox.Show("Tekniki seflik bash vermishdir . Bir daha daxil olmaga calishin .");
                this.Hide();
                AboutForm.Show();
            }
            
        }

        private void SelectSeat(object sender, EventArgs e)
        {
            SeatButton seatButton = sender as SeatButton;
            if (!SelectedSeats.Any(m => m == seatButton))
            {
                seatButton.BackColor = Color.Red;
                SelectedSeats.Add(seatButton);
                Count++;
                Price += (int)db.Seans.FirstOrDefault(m => m.Id == PosterId).Price;
                lblCount.Text = Count.ToString();
                lblPrice.Text = Price.ToString() + " azn";
            }
            else
            {
                Count--;
                Price -= (int)db.Seans.FirstOrDefault(m => m.Id == PosterId).Price;
                lblCount.Text = Count.ToString();
                lblPrice.Text = Price.ToString() + " azn";
                seatButton.BackColor = Color.LightGray;
                SelectedSeats.Remove(seatButton);
            }
        }

        private void BuyTicket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AboutForm.Show();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            foreach (SeatButton item in SelectedSeats)
            {
                Ticket ticket = new Ticket()
                {
                    SeansId = item.PosterId,
                    SeatId = item.SeatId
                };
                db.Tickets.Add(ticket);
            }
            db.SaveChanges();
            this.Hide();
            AboutForm.Show();
        }
    }
}
