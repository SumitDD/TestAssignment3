namespace Test_Assignment_3.Models
{
    public class Booking
    {
        public int id { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public DateTime Start{ get; set; }
        public DateTime End { get; set; }

    }
}
