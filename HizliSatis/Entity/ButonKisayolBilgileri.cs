

namespace HizliSatis.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ButonKisayolBilgileri")]
    public partial class ButonKisayolBilgileri
    {
        public int Id { get; set; }

        public double? B_Fiyat { get; set; }

        [StringLength(50)]
        public string Barkod { get; set; }
        [StringLength(50)]
        public string Vergiyuzdesi { get; set; }
  
        [StringLength(50)]
        public string Urunadi { get; set; }
        [StringLength(50)]
        public string Stokkodu { get; set; }
        
        public string ButonAdi { get; set; }

        public string ButonResim { get; set; }
    }
}
