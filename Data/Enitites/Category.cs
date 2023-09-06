using BanThietBiDiDong.API.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class Category:IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string CategoryName { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
