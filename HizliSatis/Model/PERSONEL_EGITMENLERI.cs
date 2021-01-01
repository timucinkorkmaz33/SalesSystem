namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITMENLERI
    {
        [Key]
        public int egm_RECno { get; set; }

        public short egm_RECid_DBCno { get; set; }

        public int egm_RECid_RECno { get; set; }

        public int? egm_SpecRECno { get; set; }

        public bool? egm_iptal { get; set; }

        public short? egm_fileid { get; set; }

        public bool? egm_hidden { get; set; }

        public bool? egm_kilitli { get; set; }

        public bool? egm_degisti { get; set; }

        public int? egm_checksum { get; set; }

        public short? egm_create_user { get; set; }

        public DateTime? egm_create_date { get; set; }

        public short? egm_lastup_user { get; set; }

        public DateTime? egm_lastup_date { get; set; }

        [StringLength(4)]
        public string egm_special1 { get; set; }

        [StringLength(4)]
        public string egm_special2 { get; set; }

        [StringLength(4)]
        public string egm_special3 { get; set; }

        [StringLength(25)]
        public string egm_kodu { get; set; }

        [StringLength(40)]
        public string egm_adi { get; set; }

        [StringLength(40)]
        public string egm_firma { get; set; }

        [StringLength(25)]
        public string egm_bagli_cari_kodu { get; set; }

        [StringLength(25)]
        public string egm_bagli_pers_kodu { get; set; }

        public byte? egm_tipi { get; set; }

        [StringLength(50)]
        public string egm_mailadres { get; set; }

        public double? egm_Ucret { get; set; }

        public byte? egm_Ucret_tipi { get; set; }

        public byte? egm_doviz_cinsi { get; set; }

        [StringLength(25)]
        public string egm_konu_kodu { get; set; }
    }
}
