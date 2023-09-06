using System.Runtime.Serialization;

namespace BanThietBiDiDong.API.Data.Enums
{
    public enum StatusProduct
    {
        [EnumMember(Value = "In Stock")]
        Stock,
        [EnumMember(Value = "Out of Stock")]
        SoldOut
    }
}
