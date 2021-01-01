namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_CARI_ISKONTO_TANIMLARI
    {
        [Key]
        public int isk_RECno { get; set; }

        public short isk_RECid_DBCno { get; set; }

        public int isk_RECid_RECno { get; set; }

        public int? isk_SpecRecno { get; set; }

        public bool? isk_iptal { get; set; }

        public short? isk_fileid { get; set; }

        public bool? isk_hidden { get; set; }

        public bool? isk_kilitli { get; set; }

        public bool? isk_degisti { get; set; }

        public int? isk_checksum { get; set; }

        public short? isk_create_user { get; set; }

        public DateTime? isk_create_date { get; set; }

        public short? isk_lastup_user { get; set; }

        public DateTime? isk_lastup_date { get; set; }

        [StringLength(4)]
        public string isk_special1 { get; set; }

        [StringLength(4)]
        public string isk_special2 { get; set; }

        [StringLength(4)]
        public string isk_special3 { get; set; }

        [StringLength(4)]
        public string isk_stok_kod { get; set; }

        [StringLength(4)]
        public string isk_cari_kod { get; set; }

        [StringLength(50)]
        public string isk_isim { get; set; }

        public int? isk_uygulama_odeme_plani { get; set; }

        public double? isk_bedelsiz_referans_miktar { get; set; }

        [StringLength(20)]
        public string isk_isk1_aciklama { get; set; }

        public byte? isk_isk1_uygulama { get; set; }

        public double? isk_isk1_yuzde { get; set; }

        [StringLength(20)]
        public string isk_isk2_aciklama { get; set; }

        public byte? isk_isk2_uygulama { get; set; }

        public double? isk_isk2_yuzde { get; set; }

        [StringLength(20)]
        public string isk_isk3_aciklama { get; set; }

        public byte? isk_isk3_uygulama { get; set; }

        public double? isk_isk3_yuzde { get; set; }

        [StringLength(20)]
        public string isk_isk4_aciklama { get; set; }

        public byte? isk_isk4_uygulama { get; set; }

        public double? isk_isk4_yuzde { get; set; }

        [StringLength(20)]
        public string isk_isk5_aciklama { get; set; }

        public byte? isk_isk5_uygulama { get; set; }

        public double? isk_isk5_yuzde { get; set; }

        [StringLength(20)]
        public string isk_isk6_aciklama { get; set; }

        public byte? isk_isk6_uygulama { get; set; }

        public double? isk_isk6_yuzde { get; set; }

        [StringLength(20)]
        public string isk_mas1_aciklama { get; set; }

        public byte? isk_mas1_uygulama { get; set; }

        public double? isk_mas1_yuzde { get; set; }

        [StringLength(20)]
        public string isk_mas2_aciklama { get; set; }

        public byte? isk_mas2_uygulama { get; set; }

        public double? isk_mas2_yuzde { get; set; }

        [StringLength(20)]
        public string isk_mas3_aciklama { get; set; }

        public byte? isk_mas3_uygulama { get; set; }

        public double? isk_mas3_yuzde { get; set; }

        [StringLength(20)]
        public string isk_mas4_aciklama { get; set; }

        public byte? isk_mas4_uygulama { get; set; }

        public double? isk_mas4_yuzde { get; set; }
    }
}
