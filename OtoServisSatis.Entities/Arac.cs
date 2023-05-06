﻿using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Arac : IEntitiy
    {
        public int Id { get; set; }
        public int MarkaId { get; set; }

        [StringLength(50)]
        public string Renk { get; set; }
        public decimal Fiyati { get; set; }

        [StringLength(50)]
        public string Modeli { get; set; }

        [StringLength(50)]
        public string KasaTipi { get; set; }
        public int ModelYili { get; set; }
        public bool Satistami { get; set; }
        public string Notlar { get; set; }
        public virtual Marka? Marka { get; set; }

    }
}
