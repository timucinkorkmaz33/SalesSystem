namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADAY_CARI_HESAPLAR
    {
        [Key]
        public int adaycr_RECno { get; set; }

        public short adaycr_RECid_DBCno { get; set; }

        public int adaycr_RECid_RECno { get; set; }

        public int? adaycr_SpecRECno { get; set; }

        public bool? adaycr_iptal { get; set; }

        public short? adaycr_fileid { get; set; }

        public bool? adaycr_hidden { get; set; }

        public bool? adaycr_kilitli { get; set; }

        public bool? adaycr_degisti { get; set; }

        public int? adaycr_checksum { get; set; }

        public short? adaycr_create_user { get; set; }

        public DateTime? adaycr_create_date { get; set; }

        public short? adaycr_lastup_user { get; set; }

        public DateTime? adaycr_lastup_date { get; set; }

        [StringLength(4)]
        public string adaycr_special1 { get; set; }

        [StringLength(4)]
        public string adaycr_special2 { get; set; }

        [StringLength(4)]
        public string adaycr_special3 { get; set; }

        [StringLength(25)]
        public string adaycr_kod { get; set; }

        [StringLength(50)]
        public string adaycr_unvan1 { get; set; }

        [StringLength(50)]
        public string adaycr_unvan2 { get; set; }

        [StringLength(25)]
        public string adaycr_sektor_kodu { get; set; }

        [StringLength(25)]
        public string adaycr_bolge_kodu { get; set; }

        [StringLength(25)]
        public string adaycr_grup_kodu { get; set; }

        [StringLength(25)]
        public string adaycr_temsilci_kodu { get; set; }

        [StringLength(30)]
        public string adaycr_wwwadresi { get; set; }

        [StringLength(80)]
        public string adaycr_EMail { get; set; }

        [StringLength(50)]
        public string adaycr_adr1_cadde { get; set; }

        [StringLength(50)]
        public string adaycr_adr1_mahalle { get; set; }

        [StringLength(50)]
        public string adaycr_adr1_sokak { get; set; }

        [StringLength(25)]
        public string adaycr_adr1_Semt { get; set; }

        [StringLength(10)]
        public string adaycr_adr1_Apt_No { get; set; }

        [StringLength(10)]
        public string adaycr_adr1_Daire_No { get; set; }

        [StringLength(8)]
        public string adaycr_adr1_posta_kodu { get; set; }

        [StringLength(15)]
        public string adaycr_adr1_ilce { get; set; }

        [StringLength(15)]
        public string adaycr_adr1_il { get; set; }

        [StringLength(15)]
        public string adaycr_adr1_ulke { get; set; }

        [StringLength(10)]
        public string adaycr_adr1_adres_kodu { get; set; }

        [StringLength(5)]
        public string adaycr_adr1_tel_ulke_kodu { get; set; }

        [StringLength(5)]
        public string adaycr_adr1_tel_bolge_kodu { get; set; }

        [StringLength(10)]
        public string adaycr_adr1_tel_no1 { get; set; }

        [StringLength(50)]
        public string adaycr_adr2_cadde { get; set; }

        [StringLength(50)]
        public string adaycr_adr2_mahalle { get; set; }

        [StringLength(50)]
        public string adaycr_adr2_sokak { get; set; }

        [StringLength(25)]
        public string adaycr_adr2_Semt { get; set; }

        [StringLength(10)]
        public string adaycr_adr2_Apt_No { get; set; }

        [StringLength(10)]
        public string adaycr_adr2_Daire_No { get; set; }

        [StringLength(8)]
        public string adaycr_adr2_posta_kodu { get; set; }

        [StringLength(15)]
        public string adaycr_adr2_ilce { get; set; }

        [StringLength(15)]
        public string adaycr_adr2_il { get; set; }

        [StringLength(15)]
        public string adaycr_adr2_ulke { get; set; }

        [StringLength(10)]
        public string adaycr_adr2_adres_kodu { get; set; }

        [StringLength(5)]
        public string adaycr_adr2_tel_ulke_kodu { get; set; }

        [StringLength(5)]
        public string adaycr_adr2_tel_bolge_kodu { get; set; }

        [StringLength(10)]
        public string adaycr_adr2_tel_no1 { get; set; }

        [StringLength(60)]
        public string adaycr_yetkili1_isim { get; set; }

        [StringLength(5)]
        public string adaycr_yetkili1_dahili_telno { get; set; }

        [StringLength(50)]
        public string adaycr_yetkili1_email_adres { get; set; }

        [StringLength(17)]
        public string adaycr_yetkili1_cep_telno { get; set; }

        [StringLength(60)]
        public string adaycr_yetkili2_isim { get; set; }

        [StringLength(5)]
        public string adaycr_yetkili2_dahili_telno { get; set; }

        [StringLength(50)]
        public string adaycr_yetkili2_email_adres { get; set; }

        [StringLength(17)]
        public string adaycr_yetkili2_cep_telno { get; set; }

        [StringLength(60)]
        public string adaycr_yetkili3_isim { get; set; }

        [StringLength(5)]
        public string adaycr_yetkili3_dahili_telno { get; set; }

        [StringLength(50)]
        public string adaycr_yetkili3_email_adres { get; set; }

        [StringLength(17)]
        public string adaycr_yetkili3_cep_telno { get; set; }

        [StringLength(60)]
        public string adaycr_yetkili4_isim { get; set; }

        [StringLength(5)]
        public string adaycr_yetkili4_dahili_telno { get; set; }

        [StringLength(50)]
        public string adaycr_yetkili4_email_adres { get; set; }

        [StringLength(17)]
        public string adaycr_yetkili4_cep_telno { get; set; }

        [StringLength(60)]
        public string adaycr_yetkili5_isim { get; set; }

        [StringLength(5)]
        public string adaycr_yetkili5_dahili_telno { get; set; }

        [StringLength(50)]
        public string adaycr_yetkili5_email_adres { get; set; }

        [StringLength(17)]
        public string adaycr_yetkili5_cep_telno { get; set; }
    }
}
