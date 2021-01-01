namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_DEPO_DETAYLARI
    {
        [Key]
        public int sdp_RECno { get; set; }

        public short sdp_RECid_DBCno { get; set; }

        public int sdp_RECid_RECno { get; set; }

        public int? sdp_SpecRECno { get; set; }

        public bool? sdp_iptal { get; set; }

        public short? sdp_fileid { get; set; }

        public bool? sdp_hidden { get; set; }

        public bool? sdp_kilitli { get; set; }

        public bool? sdp_degisti { get; set; }

        public int? sdp_checksum { get; set; }

        public short? sdp_create_user { get; set; }

        public DateTime? sdp_create_date { get; set; }

        public short? sdp_lastup_user { get; set; }

        public DateTime? sdp_lastup_date { get; set; }

        [StringLength(4)]
        public string sdp_special1 { get; set; }

        [StringLength(4)]
        public string sdp_special2 { get; set; }

        [StringLength(4)]
        public string sdp_special3 { get; set; }

        [StringLength(25)]
        public string sdp_depo_kod { get; set; }

        public int? sdp_depo_no { get; set; }

        public double? sdp_kar_orani { get; set; }

        public double? sdp_min_stok { get; set; }

        public double? sdp_sip_stok { get; set; }

        public double? sdp_max_stok { get; set; }

        public byte? sdp_ver_sipbirimpntr { get; set; }

        public byte? sdp_al_sipbirimpntr { get; set; }

        public short? sdp_sipsure { get; set; }

        [StringLength(10)]
        public string sdp_yerkodu { get; set; }

        public byte? sdp_satisdursun { get; set; }

        public byte? sdp_sipdursun { get; set; }

        public byte? sdp_malkabuldursun { get; set; }

        public bool? sdp_MalKabulGun1 { get; set; }

        public bool? sdp_MalKabulGun2 { get; set; }

        public bool? sdp_MalKabulGun3 { get; set; }

        public bool? sdp_MalKabulGun4 { get; set; }

        public bool? sdp_MalKabulGun5 { get; set; }

        public bool? sdp_MalKabulGun6 { get; set; }

        public bool? sdp_MalKabulGun7 { get; set; }

        public bool? sdp_siparisGun1 { get; set; }

        public bool? sdp_siparisGun2 { get; set; }

        public bool? sdp_siparisGun3 { get; set; }

        public bool? sdp_siparisGun4 { get; set; }

        public bool? sdp_siparisGun5 { get; set; }

        public bool? sdp_siparisGun6 { get; set; }

        public bool? sdp_siparisGun7 { get; set; }

        public bool? sdp_IskontoYapilamaz { get; set; }

        public bool? sdp_Tasfiyede_Fl { get; set; }

        public bool? sdp_Pasif_fl { get; set; }

        [StringLength(25)]
        public string sdp_sat_cari_kod { get; set; }

        public double? sdpKasaIskontoOrani { get; set; }

        public double? sdpKasaIskontoTutari { get; set; }

        public bool? sdp_eksiyedusebilir_fl { get; set; }

        [StringLength(25)]
        public string sdp_UrunSorumlusuKodu { get; set; }

        public bool? sdp_KasadaTaksitlenebilir_fl { get; set; }

        public byte? sdp_siparisyeri { get; set; }

        [StringLength(10)]
        public string sdp_muhkod_artikeli { get; set; }

        [StringLength(25)]
        public string sdp_pozisyonbayrak_kodu { get; set; }

        public short? sdp_min_stok_belirleme_gun { get; set; }

        public short? sdp_sip_stok_belirleme_gun { get; set; }

        public short? sdp_max_stok_belirleme_gun { get; set; }

        public bool? sdp_sev_bel_opr_degerlendime_fl { get; set; }
    }
}
