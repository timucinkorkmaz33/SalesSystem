namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_MALIYIL_BILGILERI
    {
        [Key]
        public int fmy_RECno { get; set; }

        public short fmy_RECid_DBCno { get; set; }

        public int fmy_RECid_RECno { get; set; }

        public int? fmy_SpecRECno { get; set; }

        public bool? fmy_iptal { get; set; }

        public short? fmy_fileid { get; set; }

        public bool? fmy_hidden { get; set; }

        public bool? fmy_kilitli { get; set; }

        public bool? fmy_degisti { get; set; }

        public int? fmy_checksum { get; set; }

        public short? fmy_create_user { get; set; }

        public DateTime? fmy_create_date { get; set; }

        public short? fmy_lastup_user { get; set; }

        public DateTime? fmy_lastup_date { get; set; }

        [StringLength(4)]
        public string fmy_special1 { get; set; }

        [StringLength(4)]
        public string fmy_special2 { get; set; }

        [StringLength(4)]
        public string fmy_special3 { get; set; }

        public int? fmy_sirano { get; set; }

        public int? fmy_maliyil { get; set; }

        public DateTime? fmy_yevmiye_tarih { get; set; }

        public double? fmy_faiz_orani1 { get; set; }

        public double? fmy_faiz_orani2 { get; set; }

        public double? fmy_faiz_orani3 { get; set; }

        public double? fmy_faiz_orani4 { get; set; }

        public double? fmy_faiz_orani5 { get; set; }

        public double? fmy_faiz_orani6 { get; set; }

        public double? fmy_faiz_orani7 { get; set; }

        public double? fmy_faiz_orani8 { get; set; }

        public double? fmy_faiz_orani9 { get; set; }

        public double? fmy_faiz_orani10 { get; set; }

        public double? fmy_faiz_orani11 { get; set; }

        public double? fmy_faiz_orani12 { get; set; }

        public DateTime? fmy_evrak_ilk_tarih { get; set; }

        public DateTime? fmy_evrak_son_tarih { get; set; }

        [StringLength(25)]
        public string fmy_firma_muh_kodu { get; set; }

        public double? fmy_firmamuhucret { get; set; }

        [StringLength(25)]
        public string fmy_kapali_brut_meblag_kodu { get; set; }

        [StringLength(25)]
        public string fmy_acik_brut_meblag_kodu { get; set; }

        [StringLength(25)]
        public string fmy_kdv_kodu { get; set; }

        [StringLength(25)]
        public string fmy_net_meblag_kodu { get; set; }

        [StringLength(25)]
        public string fmy_stopaj_kodu { get; set; }

        [StringLength(25)]
        public string fmy_ssdf_kodu { get; set; }

        [StringLength(25)]
        public string fmy_isletme_kodu { get; set; }

        public double? fmy_stopaj_orani { get; set; }

        public double? fmy_ssdf_orani { get; set; }

        public double? fmy_kdv_orani { get; set; }

        [StringLength(40)]
        public string fmy_satistevkifatmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alistevkifatmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_karyuvarlamamuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_zararyuvarlamamuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_otvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_istisnaotvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_iadeotvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_damgapulumuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_mustahsilborsamuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_mustahsilbagkurmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_mustahsildigermuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvemsdfmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvehamalmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvestopajmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvekomkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_halkomisyonmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_halnavlunmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_halnavlunkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_halsandikrehinmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_halsandikrehinkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_rusummuhkodu { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari1 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari2 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari3 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari4 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari5 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari6 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari7 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari8 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari9 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari10 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari11 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari12 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari13 { get; set; }

        [StringLength(25)]
        public string fmy_yansitma_hesaplari14 { get; set; }

        [StringLength(25)]
        public string fmy_odeme_emri_masraf1_kodu { get; set; }

        [StringLength(25)]
        public string fmy_odeme_emri_masraf2_kodu { get; set; }

        [StringLength(40)]
        public string fmy_alis_irs_mal_bed_muhkodu { get; set; }

        [StringLength(40)]
        public string fmy_satis_irs_mal_bed_muhkodu { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvehamalkdvmuhkodu { get; set; }

        [StringLength(25)]
        public string fmy_ebeyankullanici { get; set; }

        [StringLength(127)]
        public string fmy_ebeyanparola { get; set; }

        [StringLength(127)]
        public string fmy_ebeyansifre { get; set; }

        [StringLength(25)]
        public string fmy_eVDkullanici { get; set; }

        [StringLength(127)]
        public string fmy_eVDparola { get; set; }

        [StringLength(127)]
        public string fmy_eVDsifre { get; set; }

        [StringLength(40)]
        public string fmy_oivmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_istisnaoivmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_iadeoivmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alisOIVmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alisIadeOIVmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alisOTVmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alisIadeOTVmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_tevkifat_kodu { get; set; }

        [StringLength(25)]
        public string fmy_TevkifatliFirma_muh_kodu { get; set; }

        public byte? fmy_TevkifatUygulama { get; set; }

        [StringLength(40)]
        public string fmy_mustahsilborsamuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_mustahsilbagkurmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_mustahsildigermuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvemsdfmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvehamalmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvehamalkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvestopajmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_halkomisyonmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvekomkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_halnavlunmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_halnavlunkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_halsandikrehinmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_halsandikrehinkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_rusummuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_kazanilmisfaizgelirimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_gerceklesmisfaizgiderimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_alacaksenedireeskontmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_borcsenedireeskontmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_kapasitemaliyetbirikimmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_stokdegerdusuklugumuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_stokdegerdusuklugugiderimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_izingiderimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_izinkarsiligimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_tazminatgiderimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_tazminatkarsiligimuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_rusumkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_rusumkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvedigermuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_sebzemeyvedigerkdvmuhkodu_s { get; set; }

        [StringLength(40)]
        public string fmy_tecilotvmuhkodu { get; set; }

        [StringLength(25)]
        public string fmy_arge_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmy_pazarlama_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmy_yonetim_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmy_finansman_gider_hesapkodu { get; set; }

        [StringLength(40)]
        public string fmy_alisotvtevkifatmuhkodu { get; set; }

        [StringLength(40)]
        public string fmy_satisotvtevkifatmuhkodu { get; set; }

        [StringLength(25)]
        public string fmy_odeme_emri_karsiliksiz_masraf_kodu { get; set; }

        [StringLength(50)]
        public string fmy_beyanname_dosya_yolu { get; set; }
    }
}
