using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class RatingProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public double NumberRating { get; set; }
        [MaxLength(250)]
        [Column(TypeName = "varchar(250)")]
        public string Content { get; set; }
        public int productId { get; set; }
        public Product product { get; set; }
    }
}
