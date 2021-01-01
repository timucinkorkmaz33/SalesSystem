namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MASRAF_HESAPLARI
    {
        [Key]
        public int his_RECno { get; set; }

        public short his_RECid_DBCno { get; set; }

        public int his_RECid_RECno { get; set; }

        public int? his_Spec_Rec_no { get; set; }

        public bool? his_iptal { get; set; }

        public short? his_fileid { get; set; }

        public bool? his_hidden { get; set; }

        public bool? his_kilitli { get; set; }

        public bool? his_degisti { get; set; }

        public int? his_checksum { get; set; }

        public short? his_create_user { get; set; }

        public DateTime? his_create_date { get; set; }

        public short? his_lastup_user { get; set; }

        public DateTime? his_lastup_date { get; set; }

        [StringLength(4)]
        public string his_special1 { get; set; }

        [StringLength(4)]
        public string his_special2 { get; set; }

        [StringLength(4)]
        public string his_special3 { get; set; }

        [StringLength(25)]
        public string his_kod { get; set; }

        [StringLength(40)]
        public string his_isim { get; set; }

        [StringLength(50)]
        public string his_yabanci_isim { get; set; }

        [StringLength(25)]
        public string his_tipkod { get; set; }

        [StringLength(25)]
        public string his_sinifkod { get; set; }

        [StringLength(25)]
        public string his_grupkod { get; set; }

        [StringLength(40)]
        public string his_muhkod { get; set; }

        [StringLength(40)]
        public string his_mal_yan_muhkod { get; set; }

        [StringLength(40)]
        public string his_gel_tablo_muhkod { get; set; }

        public byte? his_dovcinsi { get; set; }

        [StringLength(40)]
        public string his_muh_sat_isk_kod { get; set; }

        [StringLength(40)]
        public string his_muh_aIiskmuhkod { get; set; }

        [StringLength(40)]
        public string his_ilavemasmuhkod { get; set; }

        public byte? his_oivuygulama { get; set; }

        public double? his_oivtutar { get; set; }

        public byte? his_oivturu { get; set; }

        [StringLength(40)]
        public string his_ufrs_fark_muhkod { get; set; }

        [StringLength(40)]
        public string his_mal_yan_ufrs_fark_muhkod { get; set; }

        [StringLength(40)]
        public string his_gel_tablo_ufrs_fark_muhkod { get; set; }

        [StringLength(40)]
        public string his_muh_sat_isk_ufrs_fark_kod { get; set; }

        [StringLength(40)]
        public string his_muh_aIiskufrs_fark_muhkod { get; set; }

        [StringLength(40)]
        public string his_ilavemasufrs_fark_muhkod { get; set; }

        [StringLength(10)]
        public string his_birim_ad { get; set; }

        public byte? his_bsbayadahil { get; set; }

        public short? his_vergifonid_1 { get; set; }

        public short? his_vergifonid_2 { get; set; }

        public short? his_vergifonid_3 { get; set; }

        public short? his_vergifonid_4 { get; set; }

        public short? his_vergifonid_5 { get; set; }
    }
}
