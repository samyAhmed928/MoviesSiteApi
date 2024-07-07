namespace MoviesSiteApi.Models
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public Country Country { get; set; } = default!;
        public ICollection<MovieCompany> MovieCompanies { get; set; } = default!;

    }
}
