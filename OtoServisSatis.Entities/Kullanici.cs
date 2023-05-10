using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Kullanici:IEntitiy
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Adi { get; set; }

        [StringLength(50), Display(Name = "Soyadı"),Required(ErrorMessage ="{0} Boş bırakılamaz")]// hata mesajını özelleştiriyoruz
        public string Soyadi { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Email { get; set; }

        [StringLength(20)]
        public string? Telefon { get; set; } // zorunlu olmaması için soruı işareti koyuyoruz

        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string KullaniciAdi { get; set; }

        [StringLength(50), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Sifre  { get; set; }
        public bool AktifMi { get; set; }

        [Display(Name="Eklenme tarihi"),ScaffoldColumn(false)] // html ekranda bu property için bir alan oluşturmaz
        public DateTime? EklemeTarihi { get; set; } = DateTime.Now; // ? işareti ile nullable yaptık ve otomatik olarak bu günün tarihi oalcak şekilde ayarlardık.

        [Display(Name = "Kullanıcı Rolü")]
        public int  RolId { get; set; }

        [Display(Name = "Kullanıcı Rolü")]
        public virtual Rol? Rol { get; set; }



    }
}
