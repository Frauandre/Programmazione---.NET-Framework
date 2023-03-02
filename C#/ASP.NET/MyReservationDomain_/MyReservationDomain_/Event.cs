using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReservationDomain_
{
    public class Event
    {
        public Guid Id { get; set; }
        public Guid IdLocation { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
        public Location Location { get; set; }
    }
}
