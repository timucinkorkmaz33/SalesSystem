namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YASAL_PARAMETRELER
    {
        [Key]
        public int ysl_RECno { get; set; }

        public short ysl_RECid_DBCno { get; set; }

        public int ysl_RECid_RECno { get; set; }

        public int? ysl_SpecRECno { get; set; }

        public bool? ysl_iptal { get; set; }

        public short? ysl_fileid { get; set; }

        public bool? ysl_hidden { get; set; }

        public bool? ysl_kilitli { get; set; }

        public bool? ysl_degisti { get; set; }

        public int? ysl_checksum { get; set; }

        public short? ysl_create_user { get; set; }

        public DateTime? ysl_create_date { get; set; }

        public short? ysl_lastup_user { get; set; }

        public DateTime? ysl_lastup_date { get; set; }

        [StringLength(4)]
        public string ysl_special1 { get; set; }

        [StringLength(4)]
        public string ysl_special2 { get; set; }

        [StringLength(4)]
        public string ysl_special3 { get; set; }

        public DateTime? ysl_gecerlilik_tarihi { get; set; }

        public double? ysl_gunluk_cal_saati { get; set; }

        public short? ysl_ver_muaf_cocuk_adedi { get; set; }

        public double? ysl_cocuk_yard_muafiyeti { get; set; }

        public bool? ysl_subat_sskgun_esit_calgun { get; set; }

        public bool? ysl_ay_basinda_girene_kf_yok { get; set; }

        public bool? ysl_ver_firma_top_yuvarla { get; set; }

        public bool? ysl_ssk_matrahi_31_gunden { get; set; }

        public bool? ysl_ssk_matrahi_31_gunden1 { get; set; }

        public bool? ysl_ssk_matrahi_31_gunden2 { get; set; }

        public bool? ysl_tutarlari_brut_goster { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi1 { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi2 { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi3 { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi4 { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi5 { get; set; }

        [StringLength(20)]
        public string ysl_kazanc_aciklamasi6 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi1 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi2 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi3 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi4 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi5 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi6 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi7 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi8 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi9 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi10 { get; set; }

        [StringLength(20)]
        public string ysl_ek_kazanc_aciklamasi11 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi1 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi2 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi3 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi4 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi5 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi6 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi7 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi8 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi9 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi10 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi11 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi12 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi13 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi14 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi15 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi16 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi17 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi18 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi19 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi20 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi21 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi22 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi23 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi24 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi25 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi26 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi27 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi28 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi29 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi30 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi31 { get; set; }

        [StringLength(20)]
        public string ysl_sosyal_yardim_aciklamasi32 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi1 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi2 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi3 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi4 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi5 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi6 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi7 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi8 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi9 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi10 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi11 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi12 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi13 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi14 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi15 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi16 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi17 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi18 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi19 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi20 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi21 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi22 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi23 { get; set; }

        [StringLength(20)]
        public string ysl_kesinti_aciklamasi24 { get; set; }

        public bool? ysl_sosyal_yar_netten_hesapla { get; set; }

        public double? ysl_vakif_aidat_tavani { get; set; }

        public double? ysl_vakif_tavan_ustu_aidat { get; set; }

        public double? ysl_vakif_aidat_orani { get; set; }

        public byte? ysl_tah_ucret_hesabi_30_gunden { get; set; }

        public bool? ysl_ogrencide_dv_hesapla { get; set; }

        public bool? ysl_hastada_tutar_hesapla { get; set; }

        public bool? ysl_issizlik_sigortasi_var { get; set; }

        public double? ysl_issizlik_sigortasi_per_payi { get; set; }

        public double? ysl_issizlik_sigortasi_isv_payi { get; set; }

        public bool? ysl_isz_pers_pay_vergi_matr_dus { get; set; }

        public bool? ysl_maz_izin_kaz_sskya_dahil { get; set; }

        public bool? ysl_hasta_izn_kazanc_ssk_dahil { get; set; }

        public byte? ysl_net_ucret_yuvarlama_sekli { get; set; }

        public double? ysl_net_yuvarlama_limiti { get; set; }

        public bool? ysl_oncekiay_kusurati_ilave { get; set; }

        public byte? ysl_tahakkuk_yuvarlama_tipi { get; set; }

        public bool? ysl_banka_bil_sskdan_okunsun { get; set; }

        public bool? ysl_izin_mat_taban_tavandan { get; set; }

        public bool? ysl_tahakkukta_netmaas_goster { get; set; }

        public bool? ysl_kazanci_ekkazanca_dagit { get; set; }

        public byte? ysl_ssk_gun_kabulu { get; set; }

        public bool? ysl_subat_pergorev_kod_ssk_gun { get; set; }

        public bool? ysl_gecmis_yil_izin_hesapla { get; set; }

        public bool? ysl_kesin_olmayan_puantaj_uyar { get; set; }

        public bool? ysl_ekkazanc_limit_faz_sos_yaz { get; set; }

        public bool? ysl_puantaj_eksik_cal_neden_sor { get; set; }

        public double? ysl_ssk_matrah_yuvarlama_limiti { get; set; }

        public byte? ysl_ssk_matrah_yuvarlama_sekli { get; set; }

        public byte? ysl_serzarf_dokum_adres_tipi { get; set; }

        public bool? ysl_tahakkuk_uyari_listele { get; set; }

        public byte? ysl_ozel_Ind_nete_eklensin { get; set; }

        public byte? ysl_dvergi_ind_nete_eklensin { get; set; }

        public byte? ysl_sakat_ind_nete_eklensin { get; set; }

        public byte? ysl_gocmen_ind_nete_eklensin { get; set; }

        public byte? ysl_digsigisv_ind_nete_eklensin { get; set; }

        public byte? ysl_digsigcls_ind_nete_eklensin { get; set; }

        public byte? ysl_birsigisv_ind_nete_eklensin { get; set; }

        public byte? ysl_birsigcls_ind_nete_eklensin { get; set; }

        public byte? ysl_askerlik_ind_nete_eklensin { get; set; }

        public bool? ysl_hakedis_once_yil_izin { get; set; }

        public byte? ysl_hakedis_kideme_gore_hesapla { get; set; }

        public double? ysl_avans_yuvarlama_limiti { get; set; }

        public byte? ysl_avans_yuvarlama_sekli { get; set; }

        public byte? ysl_ikramiye_yuvarlama_sekli { get; set; }

        public double? ysl_ikramiye_yuvarlama_limiti { get; set; }

        public double? ysl_normal_asgari_ucret { get; set; }

        public double? ysl_kucuk16_asgari_ucre { get; set; }

        public double? ysl_yillik_asgari_ucret { get; set; }

        public double? ysl_kidem_tazminat_tavani { get; set; }

        public short? ysl_ihbar_baslangic_ayi1 { get; set; }

        public short? ysl_ihbar_bitis_ayi1 { get; set; }

        public short? ysl_ihbar_ihbar_gun1 { get; set; }

        public short? ysl_ihbar_baslangic_ayi2 { get; set; }

        public short? ysl_ihbar_bitis_ayi2 { get; set; }

        public short? ysl_ihbar_ihbar_gun2 { get; set; }

        public short? ysl_ihbar_baslangic_ayi3 { get; set; }

        public short? ysl_ihbar_bitis_ayi3 { get; set; }

        public short? ysl_ihbar_ihbar_gun3 { get; set; }

        public short? ysl_ihbar_baslangic_ayi4 { get; set; }

        public short? ysl_ihbar_bitis_ayi4 { get; set; }

        public short? ysl_ihbar_ihbar_gun4 { get; set; }

        public short? ysl_ihbar_baslangic_ayi5 { get; set; }

        public short? ysl_ihbar_bitis_ayi5 { get; set; }

        public short? ysl_ihbar_ihbar_gun5 { get; set; }

        public double? ysl_diger_sigorta_yuzdesi { get; set; }

        public double? ysl_bireysel_sigorta_yuzdesi { get; set; }

        public bool? ysl_vizite_ekkaz_sosyar_yaz { get; set; }

        public bool? ysl_tab_tav_hes_kaz_hesapla { get; set; }

        public byte? ysl_tab_tav_hes_tah_no { get; set; }

        public bool? ysl_ihbar_kidem_tum_sos_hesapla { get; set; }

        public double? ysl_aylik_ayni_odeme { get; set; }

        public short? ysl_kont_sakatlik1 { get; set; }

        public short? ysl_kont_eskihuk1 { get; set; }

        public short? ysl_kont_terormuc1 { get; set; }

        public short? ysl_kont_sakatlik2 { get; set; }

        public short? ysl_kont_eskihuk2 { get; set; }

        public short? ysl_kont_terormuc2 { get; set; }

        public double? ysl_ozel_indirim_normal { get; set; }

        public double? ysl_gocmen_indirimi { get; set; }

        public double? ysl_sakatlik1_indirimi { get; set; }

        public double? ysl_sakatlik2_indirimi { get; set; }

        public double? ysl_sakatlik3_indirimi { get; set; }

        [StringLength(1)]
        public string ysl_ind_uyg_aylik_gunluk { get; set; }

        public double? ysl_aylik_fazla_mesai_limiti { get; set; }

        public double? ysl_kucuk16_matrah_tabani { get; set; }

        public double? ysl_kucuk16_matrah_tavani { get; set; }

        public double? ysl_normal_matrah_tabani { get; set; }

        public double? ysl_normal_matrah_tavani { get; set; }

        public double? ysl_damga_vergisi_orani { get; set; }

        public double? ysl_ver_iad_dv_orani { get; set; }

        public double? ysl_ozel_indirim_kalk_onc { get; set; }

        public bool? ysl_asgariucret_fark_hazine_ode { get; set; }

        public double? ysl_yilik_fazla_mesai_limiti { get; set; }

        public byte? ysl_tahno_kazanc1 { get; set; }

        public byte? ysl_tahno_kazanc2 { get; set; }

        public byte? ysl_tahno_ekkazanc1 { get; set; }

        public byte? ysl_tahno_ekkazanc2 { get; set; }

        public byte? ysl_tahno_sosyard1 { get; set; }

        public byte? ysl_tahno_sosyard2 { get; set; }

        public byte? ysl_tahno_ozelkes1 { get; set; }

        public byte? ysl_tahno_ozelkes2 { get; set; }

        public byte? ysl_tah_kur_tarihi_nereden { get; set; }

        public double? ysl_gelirver_gustsinir1 { get; set; }

        public double? ysl_gelirver_gveror1 { get; set; }

        public double? ysl_gelirver_gelirver1 { get; set; }

        public bool? ysl_gelirver_kademesiz1 { get; set; }

        public double? ysl_gelirver_gustsinir2 { get; set; }

        public double? ysl_gelirver_gveror2 { get; set; }

        public double? ysl_gelirver_gelirver2 { get; set; }

        public bool? ysl_gelirver_kademesiz2 { get; set; }

        public double? ysl_gelirver_gustsinir3 { get; set; }

        public double? ysl_gelirver_gveror3 { get; set; }

        public double? ysl_gelirver_gelirver3 { get; set; }

        public bool? ysl_gelirver_kademesiz3 { get; set; }

        public double? ysl_gelirver_gustsinir4 { get; set; }

        public double? ysl_gelirver_gveror4 { get; set; }

        public double? ysl_gelirver_gelirver4 { get; set; }

        public bool? ysl_gelirver_kademesiz4 { get; set; }

        public double? ysl_gelirver_gustsinir5 { get; set; }

        public double? ysl_gelirver_gveror5 { get; set; }

        public double? ysl_gelirver_gelirver5 { get; set; }

        public bool? ysl_gelirver_kademesiz5 { get; set; }

        public double? ysl_gelirver_gustsinir6 { get; set; }

        public double? ysl_gelirver_gveror6 { get; set; }

        public double? ysl_gelirver_gelirver6 { get; set; }

        public bool? ysl_gelirver_kademesiz6 { get; set; }

        public double? ysl_gelirver_gustsinir7 { get; set; }

        public double? ysl_gelirver_gveror7 { get; set; }

        public double? ysl_gelirver_gelirver7 { get; set; }

        public bool? ysl_gelirver_kademesiz7 { get; set; }

        public double? ysl_gelirver_gustsinir8 { get; set; }

        public double? ysl_gelirver_gveror8 { get; set; }

        public double? ysl_gelirver_gelirver8 { get; set; }

        public bool? ysl_gelirver_kademesiz8 { get; set; }

        public double? ysl_vergi_iade_tutar1 { get; set; }

        public double? ysl_vergi_iade_yuzde1 { get; set; }

        public double? ysl_vergi_iade_tutar2 { get; set; }

        public double? ysl_vergi_iade_yuzde2 { get; set; }

        public double? ysl_vergi_iade_tutar3 { get; set; }

        public double? ysl_vergi_iade_yuzde3 { get; set; }

        public byte? ysl_digersigisv_sosyar_index { get; set; }

        public byte? ysl_digersigisv_kesinti_index { get; set; }

        public byte? ysl_bireysigisv_sosyar_index { get; set; }

        public byte? ysl_bireysigisv_kesinti_index { get; set; }

        public bool? ysl_izinmatrahi_toplamsskdan_fl { get; set; }

        public bool? ysl_eksikgun_aykacgun_tahgun_fl1 { get; set; }

        public bool? ysl_eksikgun_aykacgun_tahgun_fl2 { get; set; }

        public bool? ysl_eksikgun_aykacgun_tahgun_fl3 { get; set; }

        public bool? ysl_sakat_ind_ay_top_deger_fl1 { get; set; }

        public bool? ysl_sakat_ind_ay_top_deger_fl2 { get; set; }

        public bool? ysl_sakat_ind_ay_top_deger_fl3 { get; set; }

        public byte? ysl_sinyority_sosyalyardim_index { get; set; }

        public byte? ysl_izinparasi_sosyalyardim_index { get; set; }

        [StringLength(25)]
        public string ysl_personel_sicilno_kodyapisi { get; set; }

        public byte? ysl_cari_pers_veri_aktar_fl0 { get; set; }

        public byte? ysl_cari_pers_veri_aktar_fl1 { get; set; }

        public byte? ysl_cari_pers_veri_aktar_fl2 { get; set; }

        public byte? ysl_cari_pers_veri_aktar_fl3 { get; set; }

        public byte? ysl_cari_pers_veri_aktar_fl4 { get; set; }

        public bool? ysl_odeme_haric_vizite_yaziile_fl { get; set; }

        public byte? ysl_izin_talep_bilgilendirme { get; set; }

        public byte? ysl_avans_talep_bilgilendirme { get; set; }

        public bool? ysl_digerindnetekle_sosyar_gec_fl { get; set; }

        public bool? ysl_sigorindnetekle_sosyar_gec_fl { get; set; }

        public bool? ysl_tum_gecmis_yil_izin_hesapla { get; set; }

        public bool? ysl_digs_sy_sinirustuvergilendir { get; set; }

        public bool? ysl_birs_sy_sinirustuvergilendir { get; set; }

        public bool? ysl_digs_sosyar_kazancdisi_fl { get; set; }

        public bool? ysl_birs_sosyar_kazancdisi_fl { get; set; }

        public bool? ysl_asgarigecimindirimi_aktif_fl { get; set; }

        public double? ysl_asggecimindorani_calisan { get; set; }

        public double? ysl_asggecimindorani_es { get; set; }

        public double? ysl_asggecimindorani_2cocuk { get; set; }

        public double? ysl_asggecimindorani_3cocuk { get; set; }

        public double? ysl_asggecimindorani_digercocuklar { get; set; }

        public double? ysl_asggecimind_asgariucret { get; set; }

        public byte? ysl_asggecimind_nete_eklensin { get; set; }

        public bool? ysl_tahakkukta_SSK_sorulsun_fl { get; set; }

        public double? ysl_asggecimind_aylikmaxtutar { get; set; }

        public byte? ysl_personeldokum_formtipi { get; set; }

        public bool? ysl_kapicida_dv_hesapla { get; set; }

        public double? ysl_arge_5746_doktora_gv_muafiyet { get; set; }

        public double? ysl_arge_5746_diger_gv_muafiyet { get; set; }

        public double? ysl_arge_5746_isvhis_muafiyet { get; set; }

        public bool? ysl_arge_5746_GVind_nete_eklensin { get; set; }

        public bool? ysl_arge_5746_DV_hesaplanmasin { get; set; }

        public double? ysl_ist_5763_kdoz_isvhis_muafiyet { get; set; }

        public double? ysl_ist_5763_kfoz_isvhis_muafiyet { get; set; }

        public double? ysl_ist_5763_yasli_olum_muafiyet { get; set; }

        public bool? ysl_ucr_izin_kv_sig_kolu_kesilsin { get; set; }

        public byte? ysl_calisma_yoksa_sgk_matrahi { get; set; }

        public double? ysl_cocuk_yard_muafiyeti_0_6 { get; set; }

        public double? ysl_gunluk_yemek_gv_muafiyeti { get; set; }

        public double? ysl_kultur_5225_yat_gv_muafiyet { get; set; }

        public double? ysl_kultur_5225_isl_gv_muafiyet { get; set; }

        public bool? ysl_kultur_5225_GVind_nete_eklensin { get; set; }

        public bool? ysl_gecmis_yil_izin_eksi_devir { get; set; }

        public byte? ysl_hazine_kanunu_uygulama_5084 { get; set; }

        public byte? ysl_hazine_kanunu_uygulama_5350 { get; set; }

        public byte? ysl_hazine_kanunu_uygulama_5615 { get; set; }

        public byte? ysl_digsigisv_ind_isverene_yansit { get; set; }

        public byte? ysl_birsigisv_ind_isverene_yansit { get; set; }

        public byte? ysl_5746_tesvik_disi_sgk_hesabi { get; set; }

        public byte? ysl_5763_tesvik_disi_sgk_hesabi { get; set; }

        public byte? ysl_5921_tesvik_disi_sgk_hesabi { get; set; }

        public double? ysl_gelirver_muafiyet1 { get; set; }

        public double? ysl_gelirver_muafiyet2 { get; set; }

        public double? ysl_gelirver_muafiyet3 { get; set; }

        public double? ysl_gelirver_muafiyet4 { get; set; }

        public double? ysl_gelirver_muafiyet5 { get; set; }

        public double? ysl_gelirver_muafiyet6 { get; set; }

        public double? ysl_gelirver_muafiyet7 { get; set; }

        public double? ysl_gelirver_muafiyet8 { get; set; }

        public byte? ysl_verindnetihesaplamatipi { get; set; }

        public byte? ysl_6111_tesvik_disi_sgk_hesabi { get; set; }

        public byte? ysl_5763_tesvike_ilave_indirim { get; set; }

        public double? ysl_yarim_isgunu_calisma_saati { get; set; }

        public byte? ysl_sosyal_yardim_hesabi { get; set; }

        public byte? ysl_ekkazanc_ucret_hesabi { get; set; }

        public byte? ysl_6322_kanun_uygulama { get; set; }

        public byte? ysl_gv_muafiyeti_nete_eklensin { get; set; }

        public byte? ysl_dv_muafiyeti_nete_eklensin { get; set; }

        public byte? ysl_6322_tesvik_disi_sgk_hesabi { get; set; }

        public double? ysl_55225_isvhis_muafiyet { get; set; }

        public double? ysl_25225_isvhis_muafiyet { get; set; }

        public byte? ysl_5225_tesvik_disi_sgk_hesabi { get; set; }

        public bool? ysl_izin1_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin2_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin3_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin4_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin5_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin6_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin7_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin8_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin9_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin10_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin11_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin12_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin13_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin14_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin15_kazanc_ssk_dahil { get; set; }

        public bool? ysl_izin16_kazanc_ssk_dahil { get; set; }

        public byte? ysl_haysigisv_ind_nete_eklensin { get; set; }

        public byte? ysl_haysigcls_ind_nete_eklensin { get; set; }

        public double? ysl_hayat_sigorta_yuzdesi { get; set; }

        public byte? ysl_hayatsigisv_sosyar_index { get; set; }

        public byte? ysl_hayatsigisv_kesinti_index { get; set; }

        public bool? ysl_hays_sy_sinirustuvergilendir { get; set; }

        public bool? ysl_hays_sosyar_kazancdisi_fl { get; set; }

        public byte? ysl_haysigisv_ind_isverene_yansit { get; set; }

        public byte? ysl_kidemtazminati_sosyar_index { get; set; }

        public byte? ysl_ihbartazminati_sosyar_index { get; set; }

        public byte? ysl_huzurhakki_sosyar_index { get; set; }

        public double? ysl_isv_sig_sgk_ind_tutari { get; set; }

        public byte? ysl_kanun_gv_ind_isverene_yansit { get; set; }

        public double? ysl_6486_isvhis_muafiyet { get; set; }

        public double? ysl_06486_isvhis_muafiyet { get; set; }

        public byte? ysl_donserm_ekodeme_sosyar_index { get; set; }

        public double? ysl_hazine_gunluk_ust_brut { get; set; }

        public double? ysl_hazine_gunluk_destek { get; set; }

        public byte? ysl_hazine_kanunu_uygulama_6645 { get; set; }

        public short? ysl_ogrenci_muhtasar_kodu { get; set; }

        public byte? ysl_icrakesinti_Index { get; set; }

        public double? ysl_max_icraorani { get; set; }

        public double? ysl_max_kamuicraorani { get; set; }

        public double? ysl_arge_5746_ylisans_gv_muafiyet { get; set; }

        public byte? ysl_cocukadeti_hesaplama_sekli { get; set; }

        public double? ysl_ilave_agi_konusu_min_net_ucret { get; set; }

        public double? ysl_ilave_agi_konusu_max_brut_ucret { get; set; }

        public DateTime? ysl_otobes_baslangic_tarihi { get; set; }

        public double? ysl_otobes_orani { get; set; }

        public double? ysl_otobes_min_tutar { get; set; }

        public double? ysl_otobes_max_tutar { get; set; }

        public bool? ysl_yillik_izin_sgk_tesvik_kapsaminda { get; set; }

        public double? ysl_gecici_madde_17_gunluk_destek { get; set; }

        public byte? ysl_sendika_ind_nete_eklensin { get; set; }

        public short? ysl_sgk_muaf_cocuk_adedi { get; set; }
    }
}
