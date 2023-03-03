namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class MusicType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string? IconName { get; set; }

        public virtual List<ClubMusicType> ClubMusicTypes { get; set; }
    }
}
