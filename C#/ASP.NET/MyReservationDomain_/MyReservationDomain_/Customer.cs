namespace MyReservationDomain_
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
    }
}