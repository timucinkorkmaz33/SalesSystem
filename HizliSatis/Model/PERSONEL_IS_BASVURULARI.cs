namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_IS_BASVURULARI
    {
        [Key]
        public int bas_RECno { get; set; }

        public short bas_RECid_DBCno { get; set; }

        public int bas_RECid_RECno { get; set; }

        public int? bas_SpecRECno { get; set; }

        public bool? bas_iptal { get; set; }

        public short? bas_fileid { get; set; }

        public bool? bas_hidden { get; set; }

        public bool? bas_kilitli { get; set; }

        public bool? bas_degisti { get; set; }

        public int? bas_checksum { get; set; }

        public short? bas_create_user { get; set; }

        public DateTime? bas_create_date { get; set; }

        public short? bas_lastup_user { get; set; }

        public DateTime? bas_lastup_date { get; set; }

        [StringLength(4)]
        public string bas_special1 { get; set; }

        [StringLength(4)]
        public string bas_special2 { get; set; }

        [StringLength(4)]
        public string bas_special3 { get; set; }

        [StringLength(25)]
        public string bas_kodu { get; set; }

        [StringLength(50)]
        public string bas_adi { get; set; }

        [StringLength(50)]
        public string bas_soyadi { get; set; }

        public DateTime? bas_tarih { get; set; }

        public byte? bas_cinsiyet { get; set; }

        public byte? bas_medeni_hal { get; set; }

        public DateTime? bas_dogum_tarih { get; set; }

        [StringLength(40)]
        public string bas_dogum_yer { get; set; }

        public byte? bas_tahsil_tipi { get; set; }

        public byte? bas_askerlik { get; set; }

        public byte? bas_tecil { get; set; }

        public byte? bas_ehliyet { get; set; }

        [StringLength(80)]
        public string bas_hobi { get; set; }

        [StringLength(80)]
        public string bas_ekbilgi { get; set; }

        [StringLength(50)]
        public string bas_ulas_cadde { get; set; }

        [StringLength(50)]
        public string bas_ulas_mahalle { get; set; }

        [StringLength(50)]
        public string bas_ulas_sokak { get; set; }

        [StringLength(25)]
        public string bas_ulas_Semt { get; set; }

        [StringLength(10)]
        public string bas_ulas_Apt_No { get; set; }

        [StringLength(10)]
        public string bas_ulas_Daire_No { get; set; }

        [StringLength(8)]
        public string bas_ulas_posta_kod { get; set; }

        [StringLength(15)]
        public string bas_ulas_ilce { get; set; }

        [StringLength(15)]
        public string bas_ulas_il { get; set; }

        [StringLength(15)]
        public string bas_ulas_ulke { get; set; }

        [StringLength(10)]
        public string bas_ulas_adres_kodu { get; set; }

        [StringLength(5)]
        public string bas_ulas_tel1_ulke_kod { get; set; }

        [StringLength(5)]
        public string bas_ulas_tel1_bolge_kod { get; set; }

        [StringLength(10)]
        public string bas_ulas_tel1_no { get; set; }

        [StringLength(5)]
        public string bas_ulas_tel2_ulke_kod { get; set; }

        [StringLength(5)]
        public string bas_ulas_tel2_bolge_kod { get; set; }

        [StringLength(10)]
        public string bas_ulas_tel2_no { get; set; }

        [StringLength(5)]
        public string bas_ulas_fax_ulke_kod { get; set; }

        [StringLength(5)]
        public string bas_ulas_fax_bolge_kod { get; set; }

        [StringLength(10)]
        public string bas_ulas_fax_no { get; set; }

        [StringLength(50)]
        public string bas_ulas_mail { get; set; }

        public byte? bas_okul1_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul1_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul1_adi { get; set; }

        [StringLength(25)]
        public string bas_okul1_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul1_bolumu { get; set; }

        public short? bas_okul1_mezyil { get; set; }

        public double? bas_okul1_derece { get; set; }

        public byte? bas_okul2_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul2_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul2_adi { get; set; }

        [StringLength(25)]
        public string bas_okul2_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul2_bolumu { get; set; }

        public short? bas_okul2_mezyil { get; set; }

        public double? bas_okul2_derece { get; set; }

        public byte? bas_okul3_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul3_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul3_adi { get; set; }

        [StringLength(25)]
        public string bas_okul3_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul3_bolumu { get; set; }

        public short? bas_okul3_mezyil { get; set; }

        public double? bas_okul3_derece { get; set; }

        public byte? bas_okul4_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul4_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul4_adi { get; set; }

        [StringLength(25)]
        public string bas_okul4_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul4_bolumu { get; set; }

        public short? bas_okul4_mezyil { get; set; }

        public double? bas_okul4_derece { get; set; }

        public byte? bas_okul5_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul5_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul5_adi { get; set; }

        [StringLength(25)]
        public string bas_okul5_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul5_bolumu { get; set; }

        public short? bas_okul5_mezyil { get; set; }

        public double? bas_okul5_derece { get; set; }

        public byte? bas_okul6_tipi { get; set; }

        [StringLength(25)]
        public string bas_okul6_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul6_adi { get; set; }

        [StringLength(25)]
        public string bas_okul6_bolum_kodu { get; set; }

        [StringLength(40)]
        public string bas_okul6_bolumu { get; set; }

        public short? bas_okul6_mezyil { get; set; }

        public double? bas_okul6_derece { get; set; }

        public byte? bas_dil1_tipi { get; set; }

        public byte? bas_dil1_seviye { get; set; }

        public byte? bas_dil1_konusma { get; set; }

        public byte? bas_dil2_tipi { get; set; }

        public byte? bas_dil2_seviye { get; set; }

        public byte? bas_dil2_konusma { get; set; }

        public byte? bas_dil3_tipi { get; set; }

        public byte? bas_dil3_seviye { get; set; }

        public byte? bas_dil3_konusma { get; set; }

        public byte? bas_dil4_tipi { get; set; }

        public byte? bas_dil4_seviye { get; set; }

        public byte? bas_dil4_konusma { get; set; }

        public byte? bas_dil5_tipi { get; set; }

        public byte? bas_dil5_seviye { get; set; }

        public byte? bas_dil5_konusma { get; set; }

        [StringLength(40)]
        public string bas_kurs1_konusu { get; set; }

        [StringLength(40)]
        public string bas_kurs1_kurumu { get; set; }

        public short? bas_kurs1_yil { get; set; }

        [StringLength(80)]
        public string bas_kurs1_aciklama { get; set; }

        [StringLength(25)]
        public string bas_kurs1_egitim_kodu { get; set; }

        public bool? bas_kurs1_sertifika_fl { get; set; }

        [StringLength(40)]
        public string bas_kurs2_konusu { get; set; }

        [StringLength(40)]
        public string bas_kurs2_kurumu { get; set; }

        public short? bas_kurs2_yil { get; set; }

        [StringLength(80)]
        public string bas_kurs2_aciklama { get; set; }

        [StringLength(25)]
        public string bas_kurs2_egitim_kodu { get; set; }

        public bool? bas_kurs2_sertifika_fl { get; set; }

        [StringLength(40)]
        public string bas_kurs3_konusu { get; set; }

        [StringLength(40)]
        public string bas_kurs3_kurumu { get; set; }

        public short? bas_kurs3_yil { get; set; }

        [StringLength(80)]
        public string bas_kurs3_aciklama { get; set; }

        [StringLength(25)]
        public string bas_kurs3_egitim_kodu { get; set; }

        public bool? bas_kurs3_sertifika_fl { get; set; }

        [StringLength(40)]
        public string bas_kurs4_konusu { get; set; }

        [StringLength(40)]
        public string bas_kurs4_kurumu { get; set; }

        public short? bas_kurs4_yil { get; set; }

        [StringLength(80)]
        public string bas_kurs4_aciklama { get; set; }

        [StringLength(25)]
        public string bas_kurs4_egitim_kodu { get; set; }

        public bool? bas_kurs4_sertifika_fl { get; set; }

        [StringLength(40)]
        public string bas_kurs5_konusu { get; set; }

        [StringLength(40)]
        public string bas_kurs5_kurumu { get; set; }

        public short? bas_kurs5_yil { get; set; }

        [StringLength(80)]
        public string bas_kurs5_aciklama { get; set; }

        [StringLength(25)]
        public string bas_kurs5_egitim_kodu { get; set; }

        public bool? bas_kurs5_sertifika_fl { get; set; }

        [StringLength(40)]
        public string bas_sirk1_adi { get; set; }

        [StringLength(40)]
        public string bas_sirk1_gorevi { get; set; }

        public DateTime? bas_sirk1_girisyil { get; set; }

        public DateTime? bas_sirk1_cikisyil { get; set; }

        [StringLength(40)]
        public string bas_sirk1_cikissebebi { get; set; }

        public double? bas_sirk1_ucret { get; set; }

        public byte? bas_sirk1_cikissebepsecimli { get; set; }

        [StringLength(40)]
        public string bas_sirk2_adi { get; set; }

        [StringLength(40)]
        public string bas_sirk2_gorevi { get; set; }

        public DateTime? bas_sirk2_girisyil { get; set; }

        public DateTime? bas_sirk2_cikisyil { get; set; }

        [StringLength(40)]
        public string bas_sirk2_cikissebebi { get; set; }

        public double? bas_sirk2_ucret { get; set; }

        public byte? bas_sirk2_cikissebepsecimli { get; set; }

        [StringLength(40)]
        public string bas_sirk3_adi { get; set; }

        [StringLength(40)]
        public string bas_sirk3_gorevi { get; set; }

        public DateTime? bas_sirk3_girisyil { get; set; }

        public DateTime? bas_sirk3_cikisyil { get; set; }

        [StringLength(40)]
        public string bas_sirk3_cikissebebi { get; set; }

        public double? bas_sirk3_ucret { get; set; }

        public byte? bas_sirk3_cikissebepsecimli { get; set; }

        [StringLength(40)]
        public string bas_sirk4_adi { get; set; }

        [StringLength(40)]
        public string bas_sirk4_gorevi { get; set; }

        public DateTime? bas_sirk4_girisyil { get; set; }

        public DateTime? bas_sirk4_cikisyil { get; set; }

        [StringLength(40)]
        public string bas_sirk4_cikissebebi { get; set; }

        public double? bas_sirk4_ucret { get; set; }

        public byte? bas_sirk4_cikissebepsecimli { get; set; }

        [StringLength(40)]
        public string bas_sirk5_adi { get; set; }

        [StringLength(40)]
        public string bas_sirk5_gorevi { get; set; }

        public DateTime? bas_sirk5_girisyil { get; set; }

        public DateTime? bas_sirk5_cikisyil { get; set; }

        [StringLength(40)]
        public string bas_sirk5_cikissebebi { get; set; }

        public double? bas_sirk5_ucret { get; set; }

        public byte? bas_sirk5_cikissebepsecimli { get; set; }

        [StringLength(40)]
        public string bas_refr1_adi { get; set; }

        [StringLength(40)]
        public string bas_refr1_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr1_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr2_adi { get; set; }

        [StringLength(40)]
        public string bas_refr2_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr2_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr3_adi { get; set; }

        [StringLength(40)]
        public string bas_refr3_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr3_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr4_adi { get; set; }

        [StringLength(40)]
        public string bas_refr4_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr4_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr5_adi { get; set; }

        [StringLength(40)]
        public string bas_refr5_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr5_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr6_adi { get; set; }

        [StringLength(40)]
        public string bas_refr6_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr6_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr7_adi { get; set; }

        [StringLength(40)]
        public string bas_refr7_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr7_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr8_adi { get; set; }

        [StringLength(40)]
        public string bas_refr8_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr8_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr9_adi { get; set; }

        [StringLength(40)]
        public string bas_refr9_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr9_iletisim { get; set; }

        [StringLength(40)]
        public string bas_refr10_adi { get; set; }

        [StringLength(40)]
        public string bas_refr10_meslek { get; set; }

        [StringLength(40)]
        public string bas_refr10_iletisim { get; set; }

        [StringLength(25)]
        public string bas_bvis1_depkodu { get; set; }

        [StringLength(25)]
        public string bas_bvis1_gorkodu { get; set; }

        [StringLength(80)]
        public string bas_bvis1_aciklama { get; set; }

        [StringLength(25)]
        public string bas_bvis1_kadrokodu { get; set; }

        [StringLength(25)]
        public string bas_bvis1_isilankodu { get; set; }

        [StringLength(25)]
        public string bas_bvis2_depkodu { get; set; }

        [StringLength(25)]
        public string bas_bvis2_gorkodu { get; set; }

        [StringLength(80)]
        public string bas_bvis2_aciklama { get; set; }

        [StringLength(25)]
        public string bas_bvis2_kadrokodu { get; set; }

        [StringLength(25)]
        public string bas_bvis2_isilankodu { get; set; }

        [StringLength(25)]
        public string bas_bvis3_depkodu { get; set; }

        [StringLength(25)]
        public string bas_bvis3_gorkodu { get; set; }

        [StringLength(80)]
        public string bas_bvis3_aciklama { get; set; }

        [StringLength(25)]
        public string bas_bvis3_kadrokodu { get; set; }

        [StringLength(25)]
        public string bas_bvis3_isilankodu { get; set; }

        [StringLength(25)]
        public string bas_bvis4_depkodu { get; set; }

        [StringLength(25)]
        public string bas_bvis4_gorkodu { get; set; }

        [StringLength(80)]
        public string bas_bvis4_aciklama { get; set; }

        [StringLength(25)]
        public string bas_bvis4_kadrokodu { get; set; }

        [StringLength(25)]
        public string bas_bvis4_isilankodu { get; set; }

        public double? bas_ucret_talep { get; set; }

        public byte? bas_ucret_talep_doviz { get; set; }

        public byte? bas_ucret_talep_tip { get; set; }

        public byte? bas_ucret_talep_brutnet { get; set; }

        public double? bas_ucret_oneri { get; set; }

        public byte? bas_ucret_oneri_doviz { get; set; }

        public byte? bas_ucret_oneri_tip { get; set; }

        public byte? bas_ucret_oneri_brutnet { get; set; }

        public byte? bas_durum { get; set; }

        [StringLength(25)]
        public string bas_iskurno { get; set; }

        public bool? bas_ozurlu { get; set; }

        public byte? bas_ozurderecesi { get; set; }

        public byte? bas_ozurgrubu { get; set; }

        public byte? bas_sigortagrubu { get; set; }

        public byte? bas_kapsam { get; set; }

        [StringLength(25)]
        public string bas_perskodu { get; set; }

        [StringLength(11)]
        public string bas_tckimlikno { get; set; }

        [StringLength(25)]
        public string bas_nitelik1_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik2_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik3_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik4_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik5_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik6_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik7_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik8_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik9_kodu { get; set; }

        [StringLength(25)]
        public string bas_nitelik10_kodu { get; set; }

        public short? bas_talep_recid_dbcno { get; set; }

        public int? bas_talep_recid_recno { get; set; }

        [StringLength(25)]
        public string bas_kabul_isilankodu { get; set; }

        public bool? bas_sigara_fl { get; set; }
    }
}
