using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesSiteApi.Models
{
    public enum Gender
    {
        Male=0,
        Female=1
    }

    public enum Role
    {
        Actor=0,
        Actress=1,
        Director=2,
        Producer=3,
        Writer=4,
        Other=5
    }

    public class CastMember
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime BirthDate { get; set; } = default!;

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; } // Use the Gender enum

        [Required]
        public string Nationality { get; set; } = string.Empty;

        [Required]
        [EnumDataType(typeof(Role))]

        public Role Role { get; set; } // Use the Role enum

        public ICollection<MovieCastMember> MovieCastMembers { get; set; } = default!;
    }
}
