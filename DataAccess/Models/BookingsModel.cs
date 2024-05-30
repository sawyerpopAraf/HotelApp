using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class BookingsModel
    {
        public int Id { get; set; }
        public int RoomId {  get; set; }
        public int GuestId {  get; set; }
        public string StartData { get; set; }

        public string EndData { get; set; }
        public bool CheckedIn {  get; set; }
        public double TotalCose { get; set; }


    }
}
