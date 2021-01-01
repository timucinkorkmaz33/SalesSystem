namespace HizliSatis.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KullaniciBilgileri")]
    public partial class KullaniciBilgileri
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string AdiSoyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(50)]
        public string Sifre { get; set; }

        public DateTime? Tarih { get; set; }

        public string Adres { get; set; }

        [StringLength(50)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(50)]
        public string Rol { get; set; }
    }
}
