namespace HizliSatis.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CariSepet")]
    public partial class CariSepet
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Carikodu { get; set; }

        [StringLength(50)]
        public string SepetAdi { get; set; }
        [StringLength(50)]
        public string Fiyat { get; set; }
       
        public DateTime? Tarih { get; set; }
        [StringLength(50)]
        public string Durum { get; set; }
    }
}
