namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PERSONELLER")]
    public partial class PERSONELLER
    {
        [Key]
        public int per_RECno { get; set; }

        public short per_RECid_DBCno { get; set; }

        public int per_RECid_RECno { get; set; }

        public int? per_SpecRECno { get; set; }

        public bool? per_iptal { get; set; }

        public short? per_fileid { get; set; }

        public bool? per_hidden { get; set; }

        public bool? per_kilitli { get; set; }

        public bool? per_degisti { get; set; }

        public int? per_checksum { get; set; }

        public short? per_create_user { get; set; }

        public DateTime? per_create_date { get; set; }

        public short? per_lastup_user { get; set; }

        public DateTime? per_lastup_date { get; set; }

        [StringLength(4)]
        public string per_special1 { get; set; }

        [StringLength(4)]
        public string per_special2 { get; set; }

        [StringLength(4)]
        public string per_special3 { get; set; }

        [StringLength(25)]
        public string per_kod { get; set; }

        [StringLength(50)]
        public string per_adi { get; set; }

        [StringLength(50)]
        public string per_soyadi { get; set; }

        [StringLength(80)]
        public string per_orjdildeadisoyadi { get; set; }

        [StringLength(25)]
        public string per_sicil_no { get; set; }

        public int? per_firma_no { get; set; }

        public int? per_sube_no { get; set; }

        [StringLength(25)]
        public string per_caripers_kodu { get; set; }

        public byte? per_tip { get; set; }

        [StringLength(25)]
        public string per_dept_kod { get; set; }

        public byte? per_is_grup { get; set; }

        public DateTime? per_giris_tar { get; set; }

        public DateTime? per_cikis_tar { get; set; }

        [StringLength(40)]
        public string per_cikis_neden { get; set; }

        [StringLength(40)]
        public string per_muh_kod { get; set; }

        public byte? per_kim_tahsil { get; set; }

        [StringLength(20)]
        public string per_kim_meslek { get; set; }

        [StringLength(25)]
        public string per_kim_gorev { get; set; }

        public byte? per_kim_sakat_derece { get; set; }

        public byte? per_kim_gocmen { get; set; }

        public byte? per_kim_gorev_kod { get; set; }

        public byte? per_kim_SGK_kod { get; set; }

        public byte? per_kim_cocuk { get; set; }

        public byte? per_kim_okuloncesi { get; set; }

        public byte? per_kim_ilkokul { get; set; }

        public byte? per_kim_ortaokul { get; set; }

        public byte? per_kim_lise { get; set; }

        public byte? per_kim_yuksek { get; set; }

        [StringLength(15)]
        public string per_nuf_uyruk { get; set; }

        public byte? per_nuf_cinsiyet { get; set; }

        public byte? per_nuf_medeni_hal { get; set; }

        [StringLength(15)]
        public string per_nuf_din { get; set; }

        public DateTime? per_nuf_dogum_tarih { get; set; }

        [StringLength(40)]
        public string per_nuf_dogum_yer { get; set; }

        public byte? per_nuf_kangrup { get; set; }

        [StringLength(15)]
        public string per_nuf_seri_no { get; set; }

        [StringLength(20)]
        public string per_nuf_il { get; set; }

        [StringLength(20)]
        public string per_nuf_ilce { get; set; }

        [StringLength(20)]
        public string per_nuf_mahalle { get; set; }

        [StringLength(20)]
        public string per_nuf_koy { get; set; }

        [StringLength(10)]
        public string per_nuf_ciltno { get; set; }

        [StringLength(10)]
        public string per_nuf_sayfano { get; set; }

        [StringLength(10)]
        public string per_nuf_kutukno { get; set; }

        [StringLength(20)]
        public string per_nuf_ver_neden { get; set; }

        [StringLength(20)]
        public string per_nuf_ver_yer { get; set; }

        public DateTime? per_nuf_ver_tarih { get; set; }

        [StringLength(15)]
        public string per_nuf_cuz_kayitno { get; set; }

        public byte? per_ucr_tip { get; set; }

        public double? per_ucret { get; set; }

        public byte? per_Brut_net { get; set; }

        public byte? per_ucr_send_durum { get; set; }

        public byte? per_ucr_send { get; set; }

        public int? per_ucr_PSSK_sube { get; set; }

        [StringLength(30)]
        public string per_ucr_hesapno { get; set; }

        public byte? per_ucr_sig_yuzde_gr { get; set; }

        public byte? per_ucr_bode_yapilma { get; set; }

        [StringLength(14)]
        public string per_ucr_vdaire { get; set; }

        [StringLength(12)]
        public string per_ucr_vkarneno { get; set; }

        public DateTime? per_ucr_vkarne_tarih { get; set; }

        public byte? per_ucr_konutfon { get; set; }

        public short? per_ucr_onceod { get; set; }

        public double? per_ozelavansorani { get; set; }

        public byte? per_yard_yol { get; set; }

        public byte? per_yard_yemek { get; set; }

        public byte? per_yard_yakacak { get; set; }

        public byte? per_yard_bayram { get; set; }

        public byte? per_yard_cocuk { get; set; }

        public byte? per_yard_aile { get; set; }

        public byte? per_yard_ozelindirim { get; set; }

        [StringLength(50)]
        public string per_adr_cadde { get; set; }

        [StringLength(50)]
        public string per_adr_mahalle { get; set; }

        [StringLength(50)]
        public string per_adr_sokak { get; set; }

        [StringLength(25)]
        public string per_adr_semt { get; set; }

        [StringLength(10)]
        public string per_adr_apartman_no { get; set; }

        [StringLength(10)]
        public string per_adr_daire_no { get; set; }

        [StringLength(8)]
        public string per_adr_posta_kod { get; set; }

        [StringLength(15)]
        public string per_adr_ilce { get; set; }

        [StringLength(15)]
        public string per_adr_il { get; set; }

        [StringLength(15)]
        public string per_adr_ulke { get; set; }

        [StringLength(10)]
        public string per_adr_adres_kodu { get; set; }

        [StringLength(5)]
        public string per_tel_ulke_kod { get; set; }

        [StringLength(5)]
        public string per_tel_bolge_kod { get; set; }

        [StringLength(10)]
        public string per_tel_no1 { get; set; }

        [StringLength(10)]
        public string per_tel_no2 { get; set; }

        [StringLength(10)]
        public string per_tel_faxno { get; set; }

        [StringLength(10)]
        public string per_tel_cepno { get; set; }

        public byte? per_doviz_cinsi { get; set; }

        [StringLength(25)]
        public string per_muh_grpkod { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc1 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc2 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc3 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc4 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc5 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc6 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc7 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc8 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc9 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc10 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc11 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc12 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc13 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc14 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc15 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc16 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc17 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc18 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc19 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc20 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc21 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc22 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc23 { get; set; }

        [StringLength(40)]
        public string per_muh_ozelc24 { get; set; }

        public double? per_old_ucret { get; set; }

        public DateTime? per_old_tarih { get; set; }

        public byte? per_maas_ikramiye { get; set; }

        [StringLength(12)]
        public string per_ozel_not { get; set; }

        public bool? per_VkfKesOd_fl { get; set; }

        public DateTime? per_Kidem_Tarih { get; set; }

        public byte? per_iszlksig { get; set; }

        public byte? per_Calismatipi { get; set; }

        public bool? per_dil1 { get; set; }

        public bool? per_dil2 { get; set; }

        public bool? per_dil3 { get; set; }

        public bool? per_dil4 { get; set; }

        public bool? per_dil5 { get; set; }

        public bool? per_dil6 { get; set; }

        public bool? per_dil7 { get; set; }

        public bool? per_dil8 { get; set; }

        public bool? per_dil9 { get; set; }

        public bool? per_dil10 { get; set; }

        public bool? per_dil11 { get; set; }

        public bool? per_dil12 { get; set; }

        public byte? per_mevsim { get; set; }

        public byte? per_kapsam { get; set; }

        public bool? per_asgari_ucretli { get; set; }

        public byte? Per_PerCariCins1 { get; set; }

        public byte? Per_PerCariCins2 { get; set; }

        public byte? Per_PerCariCins3 { get; set; }

        public byte? Per_PerCariCins4 { get; set; }

        public byte? Per_PerCariCins5 { get; set; }

        public byte? Per_PerCariCins6 { get; set; }

        public byte? Per_PerCariCins7 { get; set; }

        public byte? Per_PerCariCins8 { get; set; }

        public byte? Per_PerCariCins9 { get; set; }

        public byte? Per_PerCariCins10 { get; set; }

        public byte? Per_PerCariCins11 { get; set; }

        public byte? Per_PerCariCins12 { get; set; }

        public byte? Per_PerCariCins13 { get; set; }

        public byte? Per_PerCariCins14 { get; set; }

        public byte? Per_PerCariCins15 { get; set; }

        public byte? Per_PerCariCins16 { get; set; }

        public byte? Per_PerCariCins17 { get; set; }

        public byte? Per_PerCariCins18 { get; set; }

        public byte? Per_PerCariCins19 { get; set; }

        public byte? Per_PerCariCins20 { get; set; }

        public byte? Per_PerCariCins21 { get; set; }

        public byte? Per_PerCariCins22 { get; set; }

        public byte? Per_PerCariCins23 { get; set; }

        public byte? Per_PerCariCins24 { get; set; }

        public byte? Per_PerCariCins_grupno1 { get; set; }

        public byte? Per_PerCariCins_grupno2 { get; set; }

        public byte? Per_PerCariCins_grupno3 { get; set; }

        public byte? Per_PerCariCins_grupno4 { get; set; }

        public byte? Per_PerCariCins_grupno5 { get; set; }

        public byte? Per_PerCariCins_grupno6 { get; set; }

        public byte? Per_PerCariCins_grupno7 { get; set; }

        public byte? Per_PerCariCins_grupno8 { get; set; }

        public byte? Per_PerCariCins_grupno9 { get; set; }

        public byte? Per_PerCariCins_grupno10 { get; set; }

        public byte? Per_PerCariCins_grupno11 { get; set; }

        public byte? Per_PerCariCins_grupno12 { get; set; }

        public byte? Per_PerCariCins_grupno13 { get; set; }

        public byte? Per_PerCariCins_grupno14 { get; set; }

        public byte? Per_PerCariCins_grupno15 { get; set; }

        public byte? Per_PerCariCins_grupno16 { get; set; }

        public byte? Per_PerCariCins_grupno17 { get; set; }

        public byte? Per_PerCariCins_grupno18 { get; set; }

        public byte? Per_PerCariCins_grupno19 { get; set; }

        public byte? Per_PerCariCins_grupno20 { get; set; }

        public byte? Per_PerCariCins_grupno21 { get; set; }

        public byte? Per_PerCariCins_grupno22 { get; set; }

        public byte? Per_PerCariCins_grupno23 { get; set; }

        public byte? Per_PerCariCins_grupno24 { get; set; }

        [StringLength(11)]
        public string Per_TcKimlikNo { get; set; }

        [StringLength(50)]
        public string Per_PersMailAddress { get; set; }

        public double? Per_Aylik_calisma_saati { get; set; }

        [StringLength(25)]
        public string Per_Muh_Grup_Kodu { get; set; }

        [StringLength(25)]
        public string per_bolge_kodu { get; set; }

        [StringLength(40)]
        public string per_okul_ad { get; set; }

        [StringLength(25)]
        public string per_IdariAmirKodu { get; set; }

        [StringLength(25)]
        public string per_TeknikAmirKodu { get; set; }

        public byte? per_CikisSebebiSecimli { get; set; }

        [StringLength(25)]
        public string per_ilksoyad { get; set; }

        public byte? per_tabiioldugukanun { get; set; }

        public bool? per_semada_gosterme_fl { get; set; }

        [StringLength(20)]
        public string per_Ehl_Bel_No { get; set; }

        public DateTime? per_Ehl_Bel_Tar { get; set; }

        [StringLength(10)]
        public string per_Ehl_Sinif { get; set; }

        public DateTime? per_Ehl_Ver_Tar { get; set; }

        [StringLength(25)]
        public string per_Ehl_Ver_Il { get; set; }

        [StringLength(25)]
        public string per_Ehl_Ver_Ilce { get; set; }

        [StringLength(20)]
        public string per_Ehl_Kart_No { get; set; }

        [StringLength(20)]
        public string per_Pasaprot_No { get; set; }

        public DateTime? per_Pas_Alindigi_Tar { get; set; }

        public DateTime? per_Pas_Gec_Tar { get; set; }

        [StringLength(20)]
        public string per_nuf_asker_cuzdan { get; set; }

        public DateTime? per_nuf_asker_bastarih { get; set; }

        public DateTime? per_nuf_asker_bittarih { get; set; }

        public byte? per_nuf_asker_durum { get; set; }

        [StringLength(20)]
        public string per_Isy_KimlikNo { get; set; }

        public double? per_boyu { get; set; }

        public double? per_kilo { get; set; }

        [StringLength(10)]
        public string per_gomlek_bed { get; set; }

        [StringLength(10)]
        public string per_pant_bed { get; set; }

        [StringLength(10)]
        public string per_etek_bed { get; set; }

        [StringLength(10)]
        public string per_ayak_no { get; set; }

        [StringLength(10)]
        public string per_sapka_bed { get; set; }

        [StringLength(10)]
        public string per_onluk_bed { get; set; }

        [StringLength(10)]
        public string per_diger_bed1 { get; set; }

        [StringLength(10)]
        public string per_diger_bed2 { get; set; }

        [StringLength(10)]
        public string per_diger_bed3 { get; set; }

        public int? per_UserNo { get; set; }

        [StringLength(50)]
        public string per_uye_dernek { get; set; }

        [StringLength(25)]
        public string per_uye_dernek_sicil_no { get; set; }

        public bool? per_sinyority_uygulamasi_fl { get; set; }

        public bool? per_izinparasi_uygulamasi_fl { get; set; }

        [StringLength(30)]
        public string per_YemekKarti_ID { get; set; }

        public byte? per_srmmrkbaglanti_tip { get; set; }

        [StringLength(25)]
        public string per_srmmrkdaganah_kodu { get; set; }

        public byte? per_maas_banka { get; set; }

        [StringLength(25)]
        public string per_calisma_kodu { get; set; }

        [StringLength(25)]
        public string per_meslek_kodu { get; set; }

        [StringLength(60)]
        public string per_servis_guzergahi { get; set; }

        [StringLength(25)]
        public string per_vize_no { get; set; }

        public DateTime? per_vize_alindigi_tarih { get; set; }

        public DateTime? per_vize_tarihi { get; set; }

        public byte? per_sskbelge_turu { get; set; }

        public byte? per_agine_tabii { get; set; }

        public bool? per_ozur_5763_kont_dahili_fl { get; set; }

        [StringLength(30)]
        public string per_yabanci_ulke { get; set; }

        public byte? per_sigortalilik_turu { get; set; }

        [StringLength(25)]
        public string per_eski_sicil_no { get; set; }

        public byte? per_tabiioldugukanun2 { get; set; }

        public byte? per_maaskiminhesabina { get; set; }

        [StringLength(25)]
        public string per_maassistemikodu { get; set; }

        [StringLength(25)]
        public string per_is_grup_kodu { get; set; }

        [StringLength(25)]
        public string per_unvan_kodu { get; set; }

        [StringLength(25)]
        public string per_raporlama_yapacagi_per_kod { get; set; }

        [StringLength(25)]
        public string per_okul_kodu { get; set; }

        [StringLength(25)]
        public string per_okul_bolum_kodu { get; set; }

        [StringLength(25)]
        public string per_bolum_kodu { get; set; }

        [StringLength(25)]
        public string per_alt_dept_kod { get; set; }

        public DateTime? per_kanun_gecerlilik_tarihi { get; set; }

        public byte? per_tabiioldugukanun3 { get; set; }

        public short? per_mezuniyetyili { get; set; }

        [StringLength(25)]
        public string per_proje_kodu { get; set; }

        public bool? per_hazine_destegine_tabi_fl { get; set; }

        [StringLength(80)]
        public string per_KEP_adresi { get; set; }

        public bool? per_sigara_fl { get; set; }

        public bool? per_otobes_fl { get; set; }

        public byte? per_otobes_sigorta { get; set; }

        public double? per_otobes_orani { get; set; }

        [StringLength(30)]
        public string per_otobes_hesap_no { get; set; }

        [StringLength(25)]
        public string per_otobes_grup_sozlesme_no { get; set; }

        public byte? per_otobes_fon_tercihi { get; set; }

        public DateTime? per_otobes_giris { get; set; }

        public DateTime? per_otobes_ayrilis { get; set; }
    }
}
