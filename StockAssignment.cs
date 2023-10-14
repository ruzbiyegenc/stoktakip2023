using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class StockAssignment
    {
        [Key]
        public int AssignID { get; set; }             // Zimmetleme Kimliği
        public int ProductId { get; set; }      // Ürün Kimliği
        public int UserId { get; set; }         // Kullanıcı Kimliği
        [Display(Name = "Adet")]
        public int Quantity { get; set; }       // Zimmetlenen Miktar
        [Display(Name = "Zimmetleme Tarihi")]
        public DateTime AssignmentDate { get; set; } // Zimmetleme Tarihi
        [Display(Name = "İade Tarihi")]
        public DateTime? ReturnDate { get; set; }    // İade Tarihi (null olabilir)
        [Display(Name = "İade Durumu")]
        public bool IsReturned { get; set; }    // İade Durumu
        [Display(Name = "Onay Durumu")]
        public bool IsAccepted { get; set; }    // Onay Durumu
        [Display(Name = "Notlar")]
        public string Notes { get; set; }       // Notlar
        public UserTable User { get; set; }             // Zimmeti yapan kullanıcı
        public Product Product { get; set; }       // Zimmetlenen ürün
    }
}
