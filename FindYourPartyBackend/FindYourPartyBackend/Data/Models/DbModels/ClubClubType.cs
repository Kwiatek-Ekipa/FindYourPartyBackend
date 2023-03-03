namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ClubClubType
    {
        public int ClubTypeId { get; set; }
        public int ClubId { get; set; }

        public virtual ClubType ClubType { get; set; }
        public virtual Club Club { get; set; }
    }
}
