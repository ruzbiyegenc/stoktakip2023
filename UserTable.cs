using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class UserTable
    {
        [Key]
        public int UserID { get; set; }
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Display(Name="Üye Adı")]
        public string Name { get; set; }
        [Display(Name = "Şifre")]
        public string Password { get; set; }
        [Display(Name="Rol")]
        public string Role { get; set; }
        public List<StockAssignment> Assignments { get; set; } // Kullanıcının Zimmetleri
    }
}
