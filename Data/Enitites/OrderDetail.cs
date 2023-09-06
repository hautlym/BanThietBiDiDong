using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BanThietBiDiDong.API.Data.Enitites
{
    public class OrderDetail
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int OrderId { get; set; }
        
        public Order Order { get; set; }
        public Product Products { get; set; }
    }
}
