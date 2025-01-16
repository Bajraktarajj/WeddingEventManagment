namespace Domain.Models
{
   
    public abstract class Wedding
    {
        public int Id { get; set; }

        public string BrideName { get; set; }

        public string GroomName { get; set; }

        public DateTime DateReservation { get; set; }

        public string Type { get; set; }
    }
}
