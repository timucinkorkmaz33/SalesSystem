namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_HAREKETLERI_EK
    {
        [Key]
        public int chaek_RECno { get; set; }

        public short chaek_RECid_DBCno { get; set; }

        public int chaek_RECid_RECno { get; set; }

        public int? chaek_SpecRecNo { get; set; }

        public bool? chaek_iptal { get; set; }

        public short? chaek_fileid { get; set; }

        public bool? chaek_hidden { get; set; }

        public bool? chaek_kilitli { get; set; }

        public bool? chaek_degisti { get; set; }

        public int? chaek_CheckSum { get; set; }

        public short? chaek_create_user { get; set; }

        public DateTime? chaek_create_date { get; set; }

        public short? chaek_lastup_user { get; set; }

        public DateTime? chaek_lastup_date { get; set; }

        [StringLength(4)]
        public string chaek_special1 { get; set; }

        [StringLength(4)]
        public string chaek_special2 { get; set; }

        [StringLength(4)]
        public string chaek_special3 { get; set; }

        public short? chaek_related_DBCno { get; set; }

        public int? chaek_related_RECno { get; set; }

        public double? cha_mustahsil_borsa { get; set; }

        public double? cha_mustahsil_bagkur { get; set; }

        public double? cha_mustahsil_diger { get; set; }

        public double? cha_HalMSDF { get; set; }

        public double? cha_HalHamaliye { get; set; }

        public double? cha_HalStopaj { get; set; }

        public double? cha_HalKomisyonu { get; set; }

        public double? cha_HalRusum { get; set; }

        public double? cha_HalNavlunTut { get; set; }

        public double? cha_HalRehinFuture { get; set; }

        public double? cha_HalKomisyon { get; set; }

        public double? cha_HalRehinSandikmiktari { get; set; }

        public double? cha_HalSandikVrMiktar { get; set; }

        public double? cha_HalSandikTutari { get; set; }

        public double? cha_HalSandikKDVTutari { get; set; }

        public double? cha_HalrehinSandikTutari { get; set; }

        public double? cha_HalHamaliyeKdv { get; set; }

        public bool? cha_HalHamaliyeVergisiz_fl { get; set; }

        public double? cha_HalRusumKdv { get; set; }

        public double? cha_HalDiger { get; set; }

        public double? cha_HalDigerKdv { get; set; }

        public bool? cha_HalDigerVergisiz_fl { get; set; }

        public bool? cha_HalrusumVergisiz_fl { get; set; }

        public bool? cha_Halrusumsuz_fl { get; set; }

        public short? cha_sozlesme_DBCno { get; set; }

        public int? cha_sozlesme_RECno { get; set; }

        public short? cha_ciroprim_DBCno { get; set; }

        public int? cha_ciroprim_RECno { get; set; }

        public short? cha_bakimhar_DBCno { get; set; }

        public int? cha_bakimhar_RECno { get; set; }

        public short? cha_avanstalep_DBCno { get; set; }

        public int? cha_avanstalep_RECno { get; set; }

        public short? cha_gidkatsoz_recid_dbcno { get; set; }

        public int? cha_gidkatsoz_recid_recno { get; set; }

        public byte? cha_Tevkifat_turu { get; set; }

        public double? cha_tevkifat1Yok { get; set; }

        public double? cha_tevkifat131 { get; set; }

        public double? cha_tevkifat191 { get; set; }

        public double? cha_tevkifat121 { get; set; }

        public double? cha_tevkifat132 { get; set; }

        public double? cha_tevkifat161 { get; set; }

        public double? cha_tevkifat145 { get; set; }

        public double? cha_tevkifat1Tam { get; set; }

        public double? cha_tevkifat1102 { get; set; }

        public double? cha_tevkifat1105 { get; set; }

        public double? cha_tevkifat1107 { get; set; }

        public double? cha_tevkifat2Yok { get; set; }

        public double? cha_tevkifat231 { get; set; }

        public double? cha_tevkifat291 { get; set; }

        public double? cha_tevkifat221 { get; set; }

        public double? cha_tevkifat232 { get; set; }

        public double? cha_tevkifat261 { get; set; }

        public double? cha_tevkifat245 { get; set; }

        public double? cha_tevkifat2Tam { get; set; }

        public double? cha_tevkifat2102 { get; set; }

        public double? cha_tevkifat2105 { get; set; }

        public double? cha_tevkifat2107 { get; set; }

        public double? cha_tevkifat3Yok { get; set; }

        public double? cha_tevkifat331 { get; set; }

        public double? cha_tevkifat391 { get; set; }

        public double? cha_tevkifat321 { get; set; }

        public double? cha_tevkifat332 { get; set; }

        public double? cha_tevkifat361 { get; set; }

        public double? cha_tevkifat345 { get; set; }

        public double? cha_tevkifat3Tam { get; set; }

        public double? cha_tevkifat3102 { get; set; }

        public double? cha_tevkifat3105 { get; set; }

        public double? cha_tevkifat3107 { get; set; }

        public double? cha_tevkifat4Yok { get; set; }

        public double? cha_tevkifat431 { get; set; }

        public double? cha_tevkifat491 { get; set; }

        public double? cha_tevkifat421 { get; set; }

        public double? cha_tevkifat432 { get; set; }

        public double? cha_tevkifat461 { get; set; }

        public double? cha_tevkifat445 { get; set; }

        public double? cha_tevkifat4Tam { get; set; }

        public double? cha_tevkifat4102 { get; set; }

        public double? cha_tevkifat4105 { get; set; }

        public double? cha_tevkifat4107 { get; set; }

        public double? cha_tevkifat5Yok { get; set; }

        public double? cha_tevkifat531 { get; set; }

        public double? cha_tevkifat591 { get; set; }

        public double? cha_tevkifat521 { get; set; }

        public double? cha_tevkifat532 { get; set; }

        public double? cha_tevkifat561 { get; set; }

        public double? cha_tevkifat545 { get; set; }

        public double? cha_tevkifat5Tam { get; set; }

        public double? cha_tevkifat5102 { get; set; }

        public double? cha_tevkifat5105 { get; set; }

        public double? cha_tevkifat5107 { get; set; }

        public double? cha_tevkifat6Yok { get; set; }

        public double? cha_tevkifat631 { get; set; }

        public double? cha_tevkifat691 { get; set; }

        public double? cha_tevkifat621 { get; set; }

        public double? cha_tevkifat632 { get; set; }

        public double? cha_tevkifat661 { get; set; }

        public double? cha_tevkifat645 { get; set; }

        public double? cha_tevkifat6Tam { get; set; }

        public double? cha_tevkifat6102 { get; set; }

        public double? cha_tevkifat6105 { get; set; }

        public double? cha_tevkifat6107 { get; set; }

        public double? cha_tevkifat7Yok { get; set; }

        public double? cha_tevkifat731 { get; set; }

        public double? cha_tevkifat791 { get; set; }

        public double? cha_tevkifat721 { get; set; }

        public double? cha_tevkifat732 { get; set; }

        public double? cha_tevkifat761 { get; set; }

        public double? cha_tevkifat745 { get; set; }

        public double? cha_tevkifat7Tam { get; set; }

        public double? cha_tevkifat7102 { get; set; }

        public double? cha_tevkifat7105 { get; set; }

        public double? cha_tevkifat7107 { get; set; }

        public double? cha_tevkifat8Yok { get; set; }

        public double? cha_tevkifat831 { get; set; }

        public double? cha_tevkifat891 { get; set; }

        public double? cha_tevkifat821 { get; set; }

        public double? cha_tevkifat832 { get; set; }

        public double? cha_tevkifat861 { get; set; }

        public double? cha_tevkifat845 { get; set; }

        public double? cha_tevkifat8Tam { get; set; }

        public double? cha_tevkifat8102 { get; set; }

        public double? cha_tevkifat8105 { get; set; }

        public double? cha_tevkifat8107 { get; set; }

        public double? cha_tevkifat9Yok { get; set; }

        public double? cha_tevkifat931 { get; set; }

        public double? cha_tevkifat991 { get; set; }

        public double? cha_tevkifat921 { get; set; }

        public double? cha_tevkifat932 { get; set; }

        public double? cha_tevkifat961 { get; set; }

        public double? cha_tevkifat945 { get; set; }

        public double? cha_tevkifat9Tam { get; set; }

        public double? cha_tevkifat9102 { get; set; }

        public double? cha_tevkifat9105 { get; set; }

        public double? cha_tevkifat9107 { get; set; }

        public double? cha_tevkifat10Yok { get; set; }

        public double? cha_tevkifat1031 { get; set; }

        public double? cha_tevkifat1091 { get; set; }

        public double? cha_tevkifat1021 { get; set; }

        public double? cha_tevkifat1032 { get; set; }

        public double? cha_tevkifat1061 { get; set; }

        public double? cha_tevkifat1045 { get; set; }

        public double? cha_tevkifat10Tam { get; set; }

        public double? cha_tevkifat10102 { get; set; }

        public double? cha_tevkifat10105 { get; set; }

        public double? cha_tevkifat10107 { get; set; }

        [StringLength(5)]
        public string cha_Istisna1 { get; set; }

        [StringLength(5)]
        public string cha_Istisna2 { get; set; }

        [StringLength(5)]
        public string cha_Istisna3 { get; set; }

        [StringLength(5)]
        public string cha_Istisna4 { get; set; }

        [StringLength(5)]
        public string cha_Istisna5 { get; set; }

        [StringLength(5)]
        public string cha_Istisna6 { get; set; }

        [StringLength(5)]
        public string cha_Istisna7 { get; set; }

        [StringLength(5)]
        public string cha_Istisna8 { get; set; }

        [StringLength(5)]
        public string cha_Istisna9 { get; set; }

        [StringLength(5)]
        public string cha_Istisna10 { get; set; }

        public byte? cha_otv_tevkifat_turu { get; set; }

        public double? cha_otv_tevkifat_tam { get; set; }

        public short? cha_servishar_recid_dbcno { get; set; }

        public int? cha_servishar_recid_recno { get; set; }

        [StringLength(5)]
        public string cha_ozel_matrah_kodu { get; set; }

        public short? cha_periyodik_recid_dbcno { get; set; }

        public int? cha_periyodik_recid_recno { get; set; }

        public int? cha_periyodik_donem_no { get; set; }

        public short? cha_vergifonid_1 { get; set; }

        public double? cha_vergifontutari_1 { get; set; }

        public short? cha_vergifonid_2 { get; set; }

        public double? cha_vergifontutari_2 { get; set; }

        public short? cha_vergifonid_3 { get; set; }

        public double? cha_vergifontutari_3 { get; set; }

        public short? cha_vergifonid_4 { get; set; }

        public double? cha_vergifontutari_4 { get; set; }

        public short? cha_vergifonid_5 { get; set; }

        public double? cha_vergifontutari_5 { get; set; }

        [StringLength(25)]
        public string cha_yolcuberaber_kodu { get; set; }

        [StringLength(25)]
        public string cha_yetkiliaracikurumkodu { get; set; }

        public short? cha_icraodeme_recid_dbcno { get; set; }

        public int? cha_icraodeme_recid_recno { get; set; }
    }
}
