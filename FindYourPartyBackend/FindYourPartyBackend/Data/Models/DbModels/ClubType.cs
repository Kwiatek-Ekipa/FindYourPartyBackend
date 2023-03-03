namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ClubType
    {
        public int Id { get; set; } 
        public string TypeName { get; set; }
        public string? IconName { get; set; }

        public virtual List<ClubClubType> ClubClubTypes { get; set; }
    }
}
