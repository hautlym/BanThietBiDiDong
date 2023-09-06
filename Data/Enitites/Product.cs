using BanThietBiDiDong.API.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class Product:IDateTracking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ProductName { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string ProductDescription { get; set; }
        public int BrandId { get; set; }
        public double Discount { get; set; }
        public bool isActived { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public int SpecifyCationId { get; set; }
        public Brand brand { get; set; }
        public Category category { get; set; }
        public List<ProductImage> productImgs { get; set; }
        public List<RatingProduct> ratingProducts { get; set; }
        public List<OrderDetail> orderDetails { get; set; }
    }
}
