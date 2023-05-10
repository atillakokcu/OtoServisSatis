using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis:IEntitiy
    {

        public int Id { get; set; }
        [Display(Name = "Servise Geliş tarihi")]
        public DateTime ServisGelistarihi { get; set; }
        [Display(Name = "Araç Sorunu"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string AracSorunu { get; set; }
        [Display(Name = "Servis Ücreti")]
        public decimal ServisUcreti { get; set; }
        [Display(Name = "Servisden Çıkış Tarihi")]
        public DateTime ServsdenCikisTarihi { get; set; }
        [Display(Name = "Yapılan İşlemler")]
        public string? YapilanIslemler { get; set; }
        [Display(Name = "Garanti Kapsamında mı?")]
        public bool GaranriKapsamindami { get; set; }

        [StringLength(15),Display(Name = "Araç Plaka"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string AracPlaka { get; set; }

        [StringLength(20), Display(Name = "Marka"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Marka { get; set; }

        [StringLength(20), Display(Name = "Model")]
        public string? Model { get; set; }

        [StringLength(20), Display(Name = "Kasa Tipi")]
        public string? KasaTipi { get; set; }

        [StringLength(50), Display(Name = "Şase no")]
        public string? SaseNo { get; set; }

        [StringLength(500), Display(Name = "Notlar"), Required(ErrorMessage = "{0} Boş bırakılamaz")]
        public string Notlar { get; set; }


    }
}
