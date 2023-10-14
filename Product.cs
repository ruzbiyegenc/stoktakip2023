using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Display(Name="Ürün Adı")]
        public string Name { get; set; }
        [Display(Name = "Ürün Açıklaması")]
        public string Description { get; set; }
        [Display(Name = "Stok Adeti")]
        public int UnitsInStock { get; set; }
        public List<StockAssignment> Assignments { get; set; } // Ürünün Zimmetleri
    }
}
