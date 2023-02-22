using FindYourPartyBackend.Data.Models.DbModels;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace FindYourPartyBackend.Data.Models.Dto.DtoModels
{
    public class ClubDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? ClubType { get; set; }

        public virtual ClubAddressDto Address { get; set; }
    }
}
