﻿namespace MoviesSiteApi.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required,MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        ICollection<Company> Companies { get; set; } = default!;

    }
}
