namespace FindYourPartyBackend.Data.Models.DbModels
{
    public class ClubMusicType
    {
        public int MusicTypeId { get; set; }
        public int ClubId { get; set; }

        public virtual MusicType MusicType { get; set; }
        public virtual Club Club { get; set; }
    }
}
