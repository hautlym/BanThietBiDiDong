using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class User : IdentityUser<Guid>
    {
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string FirstName { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        public string? Avatar {get; set;}
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }
        public bool Gender { get; set; }

        //public DateTime CreatedAt { get; set; }
        //public DateTime UpdatedAt { get; set; }
        //public DateTime? LastSigninedTime { get; set; }
    }
}
