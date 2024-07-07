
namespace MoviesSiteApi.Models
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Auto-increment
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Title { get; set; }=string.Empty;
        [Required, MaxLength(500)]
        public string Description { get; set; } = string.Empty;
        [Required, MaxLength(30)]
        public string Language { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public decimal Rating { get; set; }
        public int Seasons { get;set; }
        public ICollection<MovieCastMember> MovieCastMembers { get; set; } = default!;
        public ICollection<MovieGenre> MovieGenres { get; set; } = default!;
        public ICollection<MovieCompany> MovieCompanies { get; set; } = default!;


    }

}

