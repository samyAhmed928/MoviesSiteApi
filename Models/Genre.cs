namespace MoviesSiteApi.Models
{
    public class Genre
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; }=string.Empty;
        public ICollection<MovieGenre> MovieGenres { get; set; } = default!;

    }
}
