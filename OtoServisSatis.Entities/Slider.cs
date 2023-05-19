﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OtoServisSatis.Entities
{
    public class Slider : IEntitiy
    {
        public int Id { get; set; }
        [StringLength(150),DisplayName("Başlık")]
        public string? Baslik { get; set; }
        [StringLength(500), DisplayName("Açıklama")]
        public string? Aciklama { get; set; }
        [StringLength(100)]
        public string? Resim { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }
    }
}
