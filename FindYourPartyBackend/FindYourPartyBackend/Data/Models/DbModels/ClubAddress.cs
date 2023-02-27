using System.ComponentModel.DataAnnotations;

namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ClubAddress
    {
        public int ClubId { get; set; }
        [Required]
        public string City { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string PostCode { get; set; }

        public virtual Club Club { get; set; }
    }
}
