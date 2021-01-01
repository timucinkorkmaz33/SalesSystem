namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SSK_TANIMLARI
    {
        [Key]
        public int ssk_RECno { get; set; }

        public short ssk_RECid_DBCno { get; set; }

        public int ssk_RECid_RECno { get; set; }

        public int? ssk_SpecRECno { get; set; }

        public bool? ssk_iptal { get; set; }

        public short? ssk_fileid { get; set; }

        public bool? ssk_hidden { get; set; }

        public bool? ssk_kilitli { get; set; }

        public bool? ssk_degisti { get; set; }

        public int? ssk_checksum { get; set; }

        public short? ssk_create_user { get; set; }

        public DateTime? ssk_create_date { get; set; }

        public short? ssk_lastup_user { get; set; }

        public DateTime? ssk_lastup_date { get; set; }

        [StringLength(4)]
        public string ssk_special1 { get; set; }

        [StringLength(4)]
        public string ssk_special2 { get; set; }

        [StringLength(4)]
        public string ssk_special3 { get; set; }

        public int? ssk_Sira_No { get; set; }

        [StringLength(25)]
        public string ssk_ismi { get; set; }

        public byte? ssk_TehlikeDerecesi { get; set; }

        public double? ssk_KazaYuzdesi { get; set; }

        [StringLength(2)]
        public string ssk_subekodu { get; set; }

        [StringLength(20)]
        public string ssk_BolCalDosNo { get; set; }

        [StringLength(50)]
        public string ssk_cadde { get; set; }

        [StringLength(50)]
        public string ssk_mahalle { get; set; }

        [StringLength(50)]
        public string ssk_sokak { get; set; }

        [StringLength(25)]
        public string ssk_Adr_Semt { get; set; }

        [StringLength(10)]
        public string ssk_Apt_No { get; set; }

        [StringLength(10)]
        public string ssk_Daire_No { get; set; }

        [StringLength(8)]
        public string ssk_posta_kodu { get; set; }

        [StringLength(15)]
        public string ssk_ilce { get; set; }

        [StringLength(15)]
        public string ssk_il { get; set; }

        [StringLength(15)]
        public string ssk_ulke { get; set; }

        [StringLength(10)]
        public string ssk_adres_kodu { get; set; }

        public byte? ssk_iysinifi { get; set; }

        [StringLength(5)]
        public string ssk_iykapino { get; set; }

        [StringLength(25)]
        public string ssk_maasbankakodu { get; set; }

        [StringLength(1)]
        public string ssk_sskno_Mahiyet { get; set; }

        [StringLength(4)]
        public string ssk_sskno_Iskolu { get; set; }

        [StringLength(2)]
        public string ssk_sskno_SubeKodu { get; set; }

        [StringLength(2)]
        public string ssk_sskno_TehlikeKodu { get; set; }

        [StringLength(7)]
        public string ssk_sskno_SiraNo { get; set; }

        [StringLength(3)]
        public string ssk_sskno_IlKodu { get; set; }

        [StringLength(2)]
        public string ssk_sskno_Ilce { get; set; }

        [StringLength(2)]
        public string ssk_sskno_Kontrol_No { get; set; }

        [StringLength(3)]
        public string ssk_AraciKodu { get; set; }

        [StringLength(3)]
        public string ssk_BolgeMudurlukNo { get; set; }

        public int? ssk_Iskur_Sno { get; set; }

        [StringLength(25)]
        public string ssk_Semt { get; set; }

        public double? ssk_N_SSK_Yuzde { get; set; }

        public double? ssk_E_SSK_Yuzde { get; set; }

        public double? ssk_C_SSK_Yuzde { get; set; }

        public double? ssk_Y_SSK_Yuzde { get; set; }

        public double? ssk_Ana_Sig { get; set; }

        public double? ssk_N_Hast_Sig { get; set; }

        public double? ssk_C_Hast_Sig { get; set; }

        public double? ssk_Yas_Ol_Sig { get; set; }

        public double? ssk_SGDP_Orani { get; set; }

        [StringLength(25)]
        public string ssk_Calisma_Kodu { get; set; }

        [StringLength(50)]
        public string ssk_FirmaUnvani { get; set; }

        [StringLength(50)]
        public string ssk_FirmaUnvani2 { get; set; }

        [StringLength(11)]
        public string ssk_ebildirge_username { get; set; }

        [StringLength(4)]
        public string ssk_ebildirge_isyerikod { get; set; }

        [StringLength(127)]
        public string ssk_ebildirge_password { get; set; }

        [StringLength(127)]
        public string ssk_ebildirge_isyerisifre { get; set; }

        public double? ssk_yasolum_itibarihizmet { get; set; }

        public byte? ssk_isverentipi { get; set; }

        public double? ssk_genel_saglik_sigortasi { get; set; }

        public double? ssk_malulluk_muafiyet { get; set; }

        public byte? ssk_5225BelgeTuru { get; set; }

        public DateTime? ssk_5225BelgeTarihi { get; set; }

        [StringLength(25)]
        public string ssk_5225BelgeSayisi { get; set; }

        public DateTime? ssk_GVK80BelgeTarih { get; set; }

        [StringLength(10)]
        public string ssk_GVK80BelgeNo { get; set; }

        public byte? ssk_iskolukodu { get; set; }

        public bool? ssk_Pasif_fl { get; set; }

        public DateTime? ssk_AcilisTarihi { get; set; }

        public DateTime? ssk_KapanisTarihi { get; set; }

        [StringLength(50)]
        public string ssk_muhtasarisyeri_adi { get; set; }

        public byte? ssk_muhtasarisyeri_turu { get; set; }

        [StringLength(10)]
        public string ssk_muhtasarisyeri_kodu { get; set; }

        public byte? ssk_muhtasarisyeri_mulkiyet { get; set; }

        [StringLength(25)]
        public string ssk_Ticaret_Sicil_No { get; set; }

        [StringLength(4)]
        public string ssk_Ticaret_Sicil_Mudurlugu { get; set; }

        [StringLength(25)]
        public string ssk_Nace_Kodu { get; set; }

        public int? ssk_FirmaNo { get; set; }

        public int? ssk_SubeNo { get; set; }

        public double? ssk_gecici_madde_17_gunluk_destek { get; set; }
    }
}
