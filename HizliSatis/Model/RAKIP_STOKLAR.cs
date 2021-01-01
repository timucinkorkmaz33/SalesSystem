namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RAKIP_STOKLAR
    {
        [Key]
        public int raks_RECno { get; set; }

        public short raks_RECid_DBCno { get; set; }

        public int raks_RECid_RECno { get; set; }

        public int? raks_SpecRECno { get; set; }

        public bool? raks_iptal { get; set; }

        public short? raks_fileid { get; set; }

        public bool? raks_hidden { get; set; }

        public bool? raks_kilitli { get; set; }

        public bool? raks_degisti { get; set; }

        public int? raks_checksum { get; set; }

        public short? raks_create_user { get; set; }

        public DateTime? raks_create_date { get; set; }

        public short? raks_lastup_user { get; set; }

        public DateTime? raks_lastup_date { get; set; }

        [StringLength(4)]
        public string raks_special1 { get; set; }

        [StringLength(4)]
        public string raks_special2 { get; set; }

        [StringLength(4)]
        public string raks_special3 { get; set; }

        [StringLength(25)]
        public string raks_kod { get; set; }

        [StringLength(50)]
        public string raks_isim { get; set; }

        [StringLength(25)]
        public string raks_sat_cari_kod { get; set; }

        public byte? raks_cins { get; set; }

        public byte? raks_doviz_cinsi { get; set; }

        [StringLength(10)]
        public string raks_birim1_ad { get; set; }

        public double? raks_birim1_katsayi { get; set; }

        public double? raks_birim1_agirlik { get; set; }

        public double? raks_birim1_en { get; set; }

        public double? raks_birim1_boy { get; set; }

        public double? raks_birim1_yuksekli { get; set; }

        public double? raks_birim1_dara { get; set; }

        [StringLength(10)]
        public string raks_birim2_ad { get; set; }

        public double? raks_birim2_katsayi { get; set; }

        public double? raks_birim2_agirlik { get; set; }

        public double? raks_birim2_en { get; set; }

        public double? raks_birim2_boy { get; set; }

        public double? raks_birim2_yuksekli { get; set; }

        public double? raks_birim2_dara { get; set; }

        [StringLength(10)]
        public string raks_birim3_ad { get; set; }

        public double? raks_birim3_katsayi { get; set; }

        public double? raks_birim3_agirlik { get; set; }

        public double? raks_birim3_en { get; set; }

        public double? raks_birim3_boy { get; set; }

        public double? raks_birim3_yuksekli { get; set; }

        public double? raks_birim3_dara { get; set; }

        [StringLength(10)]
        public string raks_birim4_ad { get; set; }

        public double? raks_birim4_katsayi { get; set; }

        public double? raks_birim4_agirlik { get; set; }

        public double? raks_birim4_en { get; set; }

        public double? raks_birim4_boy { get; set; }

        public double? raks_birim4_yuksekli { get; set; }

        public double? raks_birim4_dara { get; set; }

        public double? raks_karorani { get; set; }

        [StringLength(25)]
        public string raks_reyon_kodu { get; set; }

        [StringLength(25)]
        public string raks_ambalaj_kodu { get; set; }

        [StringLength(25)]
        public string raks_biz_stok_kodu { get; set; }

        public double? raks_satisfiat { get; set; }

        public byte? raks_fiat_doviz { get; set; }

        public int? raks_fiat_opno { get; set; }

        [StringLength(4)]
        public string raks_fiat_iskonto { get; set; }

        public bool? raks_kdvdahil { get; set; }
    }
}
