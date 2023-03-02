using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReservationDomain_
{
    public class Reservation
    {
        public Guid Id { get; set; }
        public Guid IdCustomer { get; set; }
        public Guid IdEvent { get; set; }
        public DateTimeOffset Date { get; set; }
        public Customer Customer { get; set; }
        public Event Event { get; set; }
    }
}
