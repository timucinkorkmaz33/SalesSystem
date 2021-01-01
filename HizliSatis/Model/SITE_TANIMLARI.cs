namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SITE_TANIMLARI
    {
        [Key]
        public int site_RECno { get; set; }

        public short site_RECid_DBCno { get; set; }

        public int site_RECid_RECno { get; set; }

        public int? site_SpecRECno { get; set; }

        public bool? site_iptal { get; set; }

        public short? site_fileid { get; set; }

        public bool? site_hidden { get; set; }

        public bool? site_kilitli { get; set; }

        public bool? site_degisti { get; set; }

        public int? site_checksum { get; set; }

        public short? site_create_user { get; set; }

        public DateTime? site_create_date { get; set; }

        public short? site_lastup_user { get; set; }

        public DateTime? site_lastup_date { get; set; }

        [StringLength(4)]
        public string site_special1 { get; set; }

        [StringLength(4)]
        public string site_special2 { get; set; }

        [StringLength(4)]
        public string site_special3 { get; set; }

        [StringLength(25)]
        public string site_kod { get; set; }

        [StringLength(90)]
        public string site_ismi { get; set; }

        public double? site_otoparkacikalan { get; set; }

        public double? site_otoparkkapalialan { get; set; }

        public double? site_toplamacikalan { get; set; }

        public double? site_toplamkapalialan { get; set; }
    }
}
