using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class GuestsModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address {  get; set; }
        public string PostCode { get; set; }

        public string EmailAddress { get; set; }

        public string PhoneNumber { get; set; }

        public List<BookingsModel> bookings { get; set; }
    }
}
