using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Kullanici:IEntitiy
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(50)]
        public string Soyadi { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string Sifre  { get; set; }
        public bool AktifMi { get; set; }
        public DateTime? EklemeTarihi { get; set; } = DateTime.Now; // ? işareti ile nullable yaptık ve otomatik olarak bu günün tarihi oalcak şekilde ayarlardık.
        public int  RolId { get; set; }
        public virtual Rol? Rol { get; set; }



    }
}
