namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class Event
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string EventHours { get; set; }

        public int ClubId { get; set; }
        public virtual Club Club { get; set; }
    }
}
