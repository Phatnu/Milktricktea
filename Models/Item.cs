using System.ComponentModel.DataAnnotations;

namespace ShopeeShop_web.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}