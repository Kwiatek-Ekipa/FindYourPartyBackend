using FindYourPartyBackend.Data.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.OpenApi.Writers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class Club
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        [Column(TypeName = "jsonb")]
        public List<string>? ClubType { get; set; }
        public ClubSizeEnum? ClubSize { get; set; }
        public NumberOfRoomsEnum? NumberOfRooms { get; set; }
        [Column(TypeName = "jsonb")]
        public List<string>? MusicType { get; set; }
        [Column(TypeName = "jsonb")]
        public List<string>? Links { get; set; }

        public virtual ClubAddress Address { get; set; }
        public virtual ClubOpeningHours OpeningHours { get; set; }
        public virtual List<Event> Events { get; set; }
    }
}
