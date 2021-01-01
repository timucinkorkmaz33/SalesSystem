namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SINAV_SORULARI
    {
        [Key]
        public int pss_RECno { get; set; }

        public short pss_RECid_DBCno { get; set; }

        public int pss_RECid_RECno { get; set; }

        public int? pss_SpecRECno { get; set; }

        public bool? pss_iptal { get; set; }

        public short? pss_fileid { get; set; }

        public bool? pss_hidden { get; set; }

        public bool? pss_kilitli { get; set; }

        public bool? pss_degisti { get; set; }

        public int? pss_checksum { get; set; }

        public short? pss_create_user { get; set; }

        public DateTime? pss_create_date { get; set; }

        public short? pss_lastup_user { get; set; }

        public DateTime? pss_lastup_date { get; set; }

        [StringLength(4)]
        public string pss_special1 { get; set; }

        [StringLength(4)]
        public string pss_special2 { get; set; }

        [StringLength(4)]
        public string pss_special3 { get; set; }

        public byte? pss_tipi { get; set; }

        [StringLength(25)]
        public string pss_kodu { get; set; }

        [StringLength(25)]
        public string pss_sorukodu { get; set; }

        public double? pss_puan { get; set; }

        [StringLength(25)]
        public string pss_olculennitelik { get; set; }
    }
}
