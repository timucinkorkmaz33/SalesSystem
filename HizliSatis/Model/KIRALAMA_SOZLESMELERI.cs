namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_SOZLESMELERI
    {
        [Key]
        public int ksoz_RECno { get; set; }

        public short ksoz_RECid_DBCno { get; set; }

        public int ksoz_RECid_RECno { get; set; }

        public int? ksoz_SpecRECno { get; set; }

        public bool? ksoz_iptal { get; set; }

        public short? ksoz_fileid { get; set; }

        public bool? ksoz_hidden { get; set; }

        public bool? ksoz_kilitli { get; set; }

        public bool? ksoz_degisti { get; set; }

        public int? ksoz_checksum { get; set; }

        public short? ksoz_create_user { get; set; }

        public DateTime? ksoz_create_date { get; set; }

        public short? ksoz_lastup_user { get; set; }

        public DateTime? ksoz_lastup_date { get; set; }

        [StringLength(4)]
        public string ksoz_special1 { get; set; }

        [StringLength(4)]
        public string ksoz_special2 { get; set; }

        [StringLength(4)]
        public string ksoz_special3 { get; set; }

        [StringLength(25)]
        public string ksoz_kodu { get; set; }

        public DateTime? ksoz_tarihi { get; set; }

        [StringLength(25)]
        public string ksoz_carikodu { get; set; }

        public DateTime? ksoz_bastar { get; set; }

        public DateTime? ksoz_bittar { get; set; }
    }
}
