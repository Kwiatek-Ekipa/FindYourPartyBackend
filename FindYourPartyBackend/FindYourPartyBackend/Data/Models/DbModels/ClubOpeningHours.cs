using System.ComponentModel.DataAnnotations;

namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ClubOpeningHours
    {
        public int ClubId { get; set; }
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set;}
        public string Friday { get; set;}
        public string Saturday { get;set; }
        public string Sunday { get; set; }

        public virtual Club Club { get; set; }
    }
}
