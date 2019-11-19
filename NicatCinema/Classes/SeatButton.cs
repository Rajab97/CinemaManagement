using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaFormApp.Classes
{
    class SeatButton:Button
    {
        public int PosterId { get; set; }
        public int SeatId { get; set; }
        public SeatButton(int posterId , int seatId)
        {
            PosterId = posterId;
            SeatId = seatId;
        }
    }
}
