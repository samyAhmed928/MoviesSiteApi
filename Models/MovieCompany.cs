namespace MoviesSiteApi.Models
{
    public class MovieCompany
    {
        public int MovieId { get; set; }
        public int CompanyId { get; set; }
        public Movie Movie { get; set; } = default!;
        public Company Company { get; set; } = default!;
    }
}
