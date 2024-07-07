namespace MoviesSiteApi.Models
{
    public class MovieCastMember
    {
        public int MovieId { get; set; }
        public int MemberId { get; set; }
        public Movie Movie { get; set; } = default!;
        public CastMember Member { get; set; } = default!;
    }
}
