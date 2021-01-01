namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANKALAR")]
    public partial class BANKALAR
    {
        [Key]
        public int ban_RECno { get; set; }

        public short ban_RECid_DBCno { get; set; }

        public int ban_RECid_RECno { get; set; }

        public int? ban_SpecRECNo { get; set; }

        public bool? ban_iptal { get; set; }

        public short? ban_fileid { get; set; }

        public bool? ban_hidden { get; set; }

        public bool? ban_kilitli { get; set; }

        public bool? ban_degisti { get; set; }

        public int? ban_CheckSum { get; set; }

        public short? ban_create_user { get; set; }

        public DateTime? ban_create_date { get; set; }

        public short? ban_lastup_user { get; set; }

        public DateTime? ban_lastup_date { get; set; }

        [StringLength(4)]
        public string ban_special1 { get; set; }

        [StringLength(4)]
        public string ban_special2 { get; set; }

        [StringLength(4)]
        public string ban_special3 { get; set; }

        [StringLength(25)]
        public string ban_kod { get; set; }

        [StringLength(50)]
        public string ban_ismi { get; set; }

        [StringLength(50)]
        public string ban_sube { get; set; }

        [StringLength(25)]
        public string ban_SwiftKodu { get; set; }

        [StringLength(40)]
        public string ban_IBANKodu { get; set; }

        [StringLength(30)]
        public string ban_hesapno { get; set; }

        public int? ban_firma_no { get; set; }

        public byte? ban_hesap_tip { get; set; }

        public byte? ban_mevduat_tip { get; set; }

        public byte? ban_kredi_tip { get; set; }

        [StringLength(40)]
        public string ban_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ver_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_tah_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_tah_sen_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_tem_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_tem_sen_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_mus_krdrkart_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_frm_krdrkart_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_must_havale_sozu_muh_kodu { get; set; }

        [StringLength(40)]
        public string ban_firma_havale_emri_muh_kodu { get; set; }

        [StringLength(40)]
        public string ban_tem_muh_kod { get; set; }

        public byte? ban_doviz_cinsi { get; set; }

        public double? ban_vade_fark_yuzde { get; set; }

        public double? ban_kredi_tavan { get; set; }

        public double? ban_risk_tavan { get; set; }

        public bool? ban_nakakincelenmesi { get; set; }

        [StringLength(4)]
        public string ban_TCMB_Kodu { get; set; }

        [StringLength(8)]
        public string ban_TCMB_Sube_Kodu { get; set; }

        [StringLength(3)]
        public string ban_TCMB_Il_kodu { get; set; }

        [StringLength(30)]
        public string ban_musteri_no { get; set; }

        public byte? ban_Ayni_banka_tahsil_suresi { get; set; }

        public byte? ban_baska_banka_tahsil_suresi { get; set; }

        public byte? ban_odul_katkisi_hesap_cinsi { get; set; }

        [StringLength(25)]
        public string ban_odul_katkisi_hesabi { get; set; }

        public byte? ban_servis_komisyon_hesap_cinsi { get; set; }

        [StringLength(25)]
        public string ban_servis_komisyon_hesabi { get; set; }

        public byte? ban_erken_odm_faiz_hesap_cinsi { get; set; }

        [StringLength(25)]
        public string ban_erken_odm_faiz_hesabi { get; set; }

        [StringLength(25)]
        public string ban_pos_tahsilat_cari_hesabi { get; set; }

        [StringLength(50)]
        public string ban_adr_cadde { get; set; }

        [StringLength(50)]
        public string ban_adr_mahalle { get; set; }

        [StringLength(50)]
        public string ban_adr_sokak { get; set; }

        [StringLength(25)]
        public string ban_adr_Semt { get; set; }

        [StringLength(10)]
        public string ban_adr_Apt_No { get; set; }

        [StringLength(10)]
        public string ban_adr_Daire_No { get; set; }

        [StringLength(8)]
        public string ban_adr_posta_kodu { get; set; }

        [StringLength(15)]
        public string ban_adr_ilce { get; set; }

        [StringLength(15)]
        public string ban_adr_il { get; set; }

        [StringLength(15)]
        public string ban_adr_ulke { get; set; }

        [StringLength(10)]
        public string ban_adr_adres_kodu { get; set; }

        [StringLength(5)]
        public string ban_tel_ulke_kodu { get; set; }

        [StringLength(5)]
        public string ban_tel_bolge_kodu { get; set; }

        [StringLength(10)]
        public string ban_tel_no1 { get; set; }

        [StringLength(10)]
        public string ban_tel_no2 { get; set; }

        [StringLength(10)]
        public string ban_tel_faxno { get; set; }

        [StringLength(10)]
        public string ban_tel_modem { get; set; }

        [StringLength(50)]
        public string ban_temsilci { get; set; }

        [StringLength(80)]
        public string ban_temsilci_email { get; set; }

        [StringLength(40)]
        public string ban_ufrs_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_ver_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_tah_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_tah_sen_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_tem_cek_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_tem_sen_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_mus_krdrkart_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_frm_krdrkart_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_must_havale_sozu_muh_kodu { get; set; }

        [StringLength(40)]
        public string ban_ufrs_firma_havale_emri_muh_kodu { get; set; }

        [StringLength(40)]
        public string ban_ufrs_ver_cek_sinif_muh_kod { get; set; }

        [StringLength(40)]
        public string ban_ufrs_frm_hav_emri_sinif_muh_kodu { get; set; }

        [StringLength(40)]
        public string ban_ufrs_tem_muh_kod { get; set; }
    }
}
