namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("URUNLER")]
    public partial class URUNLER
    {
        [Key]
        public int uru_RECno { get; set; }

        public short uru_RECid_DBCno { get; set; }

        public int uru_RECid_RECno { get; set; }

        public int? uru_SpecRECno { get; set; }

        public bool? uru_iptal { get; set; }

        public short? uru_fileid { get; set; }

        public bool? uru_hidden { get; set; }

        public bool? uru_kilitli { get; set; }

        public bool? uru_degisti { get; set; }

        public int? uru_checksum { get; set; }

        public short? uru_create_user { get; set; }

        public DateTime? uru_create_date { get; set; }

        public short? uru_lastup_user { get; set; }

        public DateTime? uru_lastup_date { get; set; }

        [StringLength(4)]
        public string uru_special1 { get; set; }

        [StringLength(4)]
        public string uru_special2 { get; set; }

        [StringLength(4)]
        public string uru_special3 { get; set; }

        [StringLength(25)]
        public string uru_stok_kod { get; set; }

        public double? uru_gider1 { get; set; }

        public double? uru_gider2 { get; set; }

        public double? uru_gider3 { get; set; }

        public double? uru_gider4 { get; set; }

        public double? uru_gider5 { get; set; }

        public byte? uru_tip { get; set; }

        public double? uru_max_fire_yuz { get; set; }

        public double? uru_min_fire_yuz { get; set; }

        public double? uru_fasonmaliyet { get; set; }

        public double? uru_partimiktari { get; set; }

        [StringLength(1)]
        public string uru_isemriID { get; set; }

        public double? uru_uretimortakcarpani { get; set; }

        public byte? uru_uretimsekli { get; set; }

        [StringLength(50)]
        public string uru_formdosyaadi { get; set; }

        [StringLength(50)]
        public string uru_excdosyaadi { get; set; }

        public int? uru_ongorulendepo { get; set; }

        public double? uru_gider6 { get; set; }

        public double? uru_gider7 { get; set; }

        public double? uru_gider8 { get; set; }

        public double? uru_gider9 { get; set; }

        public double? uru_gider10 { get; set; }

        public byte? uru_ozel_tipi { get; set; }

        public double? uru_sabitmlyt_anauruncarpan { get; set; }

        [StringLength(25)]
        public string uru_masterrecete { get; set; }

        [StringLength(25)]
        public string uru_SorumlulukMerkezi { get; set; }

        [StringLength(25)]
        public string uru_varsayilanismerkezi { get; set; }

        [StringLength(25)]
        public string uru_Muhgrup_kodu { get; set; }

        [StringLength(25)]
        public string uru_masterkalip_kodu { get; set; }

        [StringLength(15)]
        public string uru_recete_ismi1 { get; set; }

        [StringLength(15)]
        public string uru_recete_ismi2 { get; set; }

        [StringLength(15)]
        public string uru_recete_ismi3 { get; set; }

        [StringLength(15)]
        public string uru_recete_ismi4 { get; set; }

        [StringLength(15)]
        public string uru_recete_ismi5 { get; set; }

        [StringLength(25)]
        public string uru_varsayilan_recete_tanim_kodu { get; set; }

        public byte? uru_varsayilan_recete_cins { get; set; }
    }
}
