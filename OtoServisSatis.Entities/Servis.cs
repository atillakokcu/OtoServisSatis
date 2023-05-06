using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Servis:IEntitiy
    {

        public int Id { get; set; }
        public DateTime ServisGelistarihi { get; set; }
        public string AracSorunu { get; set; }
        public decimal ServisUcreti { get; set; }
        public DateTime ServsdenCikisTarihi { get; set; }
        public string? YapilanIslemler { get; set; }
        public bool GaranriKapsamindami { get; set; }

        [StringLength(15)]
        public string AracPlaka { get; set; }

        [StringLength(20)]
        public string Marka { get; set; }

        [StringLength(20)]
        public string? Model { get; set; }

        [StringLength(20)]
        public string? KasaTipi { get; set; }

        [StringLength(50)]
        public string? SaseNo { get; set; }
        public string Notlar { get; set; }


    }
}
