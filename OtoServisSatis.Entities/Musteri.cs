using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Musteri:IEntitiy
    {
        public int Id { get; set; }
        [Display(Name = "Araç")]
        public int AracId { get; set; }

        [StringLength(50), Display(Name = "Adı"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Adi { get; set; }
        [StringLength(50), Display(Name = "Soyadı"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Soyadi { get; set; }
        [StringLength(11)]
        public string? TcNo { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(450)]
        public string? Adres { get; set; }
        [StringLength(20)]
        public string? Telefon { get; set; }
        
        public string? Notlar { get; set; }
        [Display(Name = "Araç")]
        public virtual Arac? Arac { get; set; }


    }
}
