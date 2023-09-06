using BanThietBiDiDong.API.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class Brand:IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string BrandName { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        public string logo { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string description { get; set; }
        public List<Product> products { get; set; }
    }
}
