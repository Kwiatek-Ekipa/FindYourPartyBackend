using FindYourPartyBackend.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class Club
    {
        public int ClubId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        [Required]
        public ClubSizeEnum? ClubSize { get; set; }
        [Required]
        public NumberOfRoomsEnum? NumberOfRooms { get; set; }
        public string? Links { get; set; }
        public string? PhoneNumber { get; set; }

        public virtual ClubAddress Address { get; set; }
        public virtual ClubOpeningHours OpeningHours { get; set; }
        public virtual List<Event> Events { get; set; }
        public virtual List<ClubClubType> ClubClubTypes { get; set;}
        public virtual List<ClubMusicType> ClubMusicTypes { get; set;}
    }
}
