using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace OtoServisSatis.Entities
{
    public class Satis:IEntitiy
    {
        public int Id { get; set; }

        [Display(Name = "Araç")]
        public int  AracId { get; set; }
        [Display(Name = "Müşteri")]
        public int MusteriId { get; set; }
        [Display(Name = "Satış Fiyatı")]
        public decimal SatisFiyati { get; set; }
        [Display(Name = "Satış Tarihi")]
        public DateTime SatisTarihi { get; set; }
        public virtual Arac? Arac { get; set; }
        public virtual Musteri? Musteri { get; set; }


    }
}
