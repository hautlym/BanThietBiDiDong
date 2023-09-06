using BanThietBiDiDong.API.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ShipName { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ShipAddress { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string ShipEmail { get; set; }
        [MaxLength(200)]
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string ShipNumberPhone { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string ShipDescription { get; set; }
        public OrderStatus status { get; set; }  = OrderStatus.Pending;
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public User user { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
