namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_HESAPLARI
    {
        [Key]
        public int hiz_RECno { get; set; }

        public short hiz_RECid_DBCno { get; set; }

        public int hiz_RECid_RECno { get; set; }

        public int? hiz_SpecRecno { get; set; }

        public bool? hiz_iptal { get; set; }

        public short? hiz_fileid { get; set; }

        public bool? hiz_hidden { get; set; }

        public bool? hiz_kilitli { get; set; }

        public bool? hiz_degisti { get; set; }

        public int? hiz_checksum { get; set; }

        public short? hiz_create_user { get; set; }

        public DateTime? hiz_create_date { get; set; }

        public short? hiz_lastup_user { get; set; }

        public DateTime? hiz_lastup_date { get; set; }

        [StringLength(4)]
        public string hiz_special1 { get; set; }

        [StringLength(4)]
        public string hiz_special2 { get; set; }

        [StringLength(4)]
        public string hiz_special3 { get; set; }

        public byte? hiz_tip { get; set; }

        [StringLength(25)]
        public string hiz_kod { get; set; }

        [StringLength(40)]
        public string hiz_isim { get; set; }

        [StringLength(50)]
        public string hiz_yabanci_isim { get; set; }

        [StringLength(25)]
        public string hiz_tipkod { get; set; }

        [StringLength(25)]
        public string hiz_sinifkod { get; set; }

        [StringLength(25)]
        public string hiz_grupkod { get; set; }

        [StringLength(40)]
        public string hiz_sat_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_sat_iade_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_mal_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_sat_mal_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_mal_yan_muh_kod { get; set; }

        public double? hiz_fiyat { get; set; }

        public byte? hiz_doviz_cinsi { get; set; }

        [StringLength(4)]
        public string hiz_isk_grup { get; set; }

        public byte? hiz_KDV { get; set; }

        [StringLength(40)]
        public string hiz_muh_sat_isk_kod { get; set; }

        [StringLength(40)]
        public string hiz_muh_aIiskmuhkod { get; set; }

        [StringLength(40)]
        public string hiz_ilavemasmuhkod { get; set; }

        public int? hiz_operasyon_suresi { get; set; }

        public byte? hiz_oivuygulama { get; set; }

        public double? hiz_oivtutar { get; set; }

        public byte? hiz_oivturu { get; set; }

        [StringLength(40)]
        public string hiz_sat_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_sat_iade_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_mal_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_sat_mal_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_mal_yan_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string hiz_muh_sat_ufrs_fark_isk_kod { get; set; }

        [StringLength(40)]
        public string hiz_muh_aIiskufrs_fark_muhkod { get; set; }

        [StringLength(40)]
        public string hiz_ilavemasufrs_fark_muhkod { get; set; }

        [StringLength(10)]
        public string hiz_birim_ad { get; set; }

        public byte? hiz_bsbayadahil { get; set; }

        public short? hiz_vergifonid_1 { get; set; }

        public short? hiz_vergifonid_2 { get; set; }

        public short? hiz_vergifonid_3 { get; set; }

        public short? hiz_vergifonid_4 { get; set; }

        public short? hiz_vergifonid_5 { get; set; }
    }
}
