namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_CALISMA_TANIMLARI
    {
        [Key]
        public int PC_RECno { get; set; }

        public short? PC_RECid_DBCno { get; set; }

        public int PC_RECid_RECno { get; set; }

        public int? PC_SpecRECno { get; set; }

        public bool? PC_iptal { get; set; }

        public short? PC_fileid { get; set; }

        public bool? PC_hidden { get; set; }

        public bool? PC_kilitli { get; set; }

        public bool? PC_degisti { get; set; }

        public int? PC_checksum { get; set; }

        public short? PC_create_user { get; set; }

        public DateTime? PC_create_date { get; set; }

        public short? PC_lastup_user { get; set; }

        public DateTime? PC_lastup_date { get; set; }

        [StringLength(4)]
        public string PC_special1 { get; set; }

        [StringLength(4)]
        public string PC_special2 { get; set; }

        [StringLength(4)]
        public string PC_special3 { get; set; }

        [StringLength(25)]
        public string PC_Kodu { get; set; }

        [StringLength(50)]
        public string PC_Ismi { get; set; }

        public byte? PC_Doviz_Cinsi { get; set; }

        public double? PC_Gun_Calis_Saat { get; set; }

        public bool? PC_Ikr_Aylari1 { get; set; }

        public bool? PC_Ikr_Aylari2 { get; set; }

        public bool? PC_Ikr_Aylari3 { get; set; }

        public bool? PC_Ikr_Aylari4 { get; set; }

        public bool? PC_Ikr_Aylari5 { get; set; }

        public bool? PC_Ikr_Aylari6 { get; set; }

        public bool? PC_Ikr_Aylari7 { get; set; }

        public bool? PC_Ikr_Aylari8 { get; set; }

        public bool? PC_Ikr_Aylari9 { get; set; }

        public bool? PC_Ikr_Aylari10 { get; set; }

        public bool? PC_Ikr_Aylari11 { get; set; }

        public bool? PC_Ikr_Aylari12 { get; set; }

        public bool? PC_Yak_Aylari1 { get; set; }

        public bool? PC_Yak_Aylari2 { get; set; }

        public bool? PC_Yak_Aylari3 { get; set; }

        public bool? PC_Yak_Aylari4 { get; set; }

        public bool? PC_Yak_Aylari5 { get; set; }

        public bool? PC_Yak_Aylari6 { get; set; }

        public bool? PC_Yak_Aylari7 { get; set; }

        public bool? PC_Yak_Aylari8 { get; set; }

        public bool? PC_Yak_Aylari9 { get; set; }

        public bool? PC_Yak_Aylari10 { get; set; }

        public bool? PC_Yak_Aylari11 { get; set; }

        public bool? PC_Yak_Aylari12 { get; set; }

        public bool? PC_Bay_Aylari1 { get; set; }

        public bool? PC_Bay_Aylari2 { get; set; }

        public bool? PC_Bay_Aylari3 { get; set; }

        public bool? PC_Bay_Aylari4 { get; set; }

        public bool? PC_Bay_Aylari5 { get; set; }

        public bool? PC_Bay_Aylari6 { get; set; }

        public bool? PC_Bay_Aylari7 { get; set; }

        public bool? PC_Bay_Aylari8 { get; set; }

        public bool? PC_Bay_Aylari9 { get; set; }

        public bool? PC_Bay_Aylari10 { get; set; }

        public bool? PC_Bay_Aylari11 { get; set; }

        public bool? PC_Bay_Aylari12 { get; set; }

        public double? PC_Ikr_Yuzde { get; set; }

        public byte? PC_Ikr_hesap_sekli { get; set; }

        public bool? PC_Ikr_Kes_At { get; set; }

        public short? PC_Ong_Izin_Gunu0 { get; set; }

        public short? PC_Ong_Izin_Gunu1 { get; set; }

        public short? PC_Ong_Izin_Gunu2 { get; set; }

        public short? PC_Ong_Izin_Gunu3 { get; set; }

        public short? PC_Ong_Izin_Gunu4 { get; set; }

        public double? PC_Av_Maas_Oran { get; set; }

        public byte? PC_Av_Hesap_Sekli { get; set; }

        public short? PC_Sinyority_AltSinirGunu1 { get; set; }

        public short? PC_Sinyority_UstSinirGunu1 { get; set; }

        public double? PC_Sinyority_Oran1 { get; set; }

        public short? PC_Sinyority_AltSinirGunu2 { get; set; }

        public short? PC_Sinyority_UstSinirGunu2 { get; set; }

        public double? PC_Sinyority_Oran2 { get; set; }

        public short? PC_Sinyority_AltSinirGunu3 { get; set; }

        public short? PC_Sinyority_UstSinirGunu3 { get; set; }

        public double? PC_Sinyority_Oran3 { get; set; }

        public short? PC_Sinyority_AltSinirGunu4 { get; set; }

        public short? PC_Sinyority_UstSinirGunu4 { get; set; }

        public double? PC_Sinyority_Oran4 { get; set; }

        public short? PC_Sinyority_AltSinirGunu5 { get; set; }

        public short? PC_Sinyority_UstSinirGunu5 { get; set; }

        public double? PC_Sinyority_Oran5 { get; set; }

        public short? PC_IzinPara_HakedisGun { get; set; }

        public double? PC_IzinPara_Orani { get; set; }

        public short? PC_IzinPara_KacGunSonraOdeme { get; set; }

        public bool? PC_CocukEgitimYardimiBir { get; set; }

        public bool? PC_IkramiyeKazancHesabi30gun { get; set; }

        [StringLength(4)]
        public string PC_Vardiya_Takvim { get; set; }

        public short? PC_Ong_Yillik_Izin_Gunu { get; set; }

        public short? PC_Ong_Ucretli_Izin_Gunu { get; set; }

        public short? PC_Ong_Hastalik_Izin_Gunu { get; set; }

        public short? PC_Ong_Askerlik_Izin_Gunu { get; set; }

        public short? PC_Ong_Zorunluluk_Izin_Gunu { get; set; }

        public short? PC_Ong_Devamsizlik_Izin_Gunu { get; set; }

        public short? PC_Ong_Araverme_Izin_Gunu { get; set; }

        public short? PC_Ong_Diger_Izin_Gunu { get; set; }

        public short? PC_Ong_Ucretsiz_Izin_Gunu { get; set; }

        public short? PC_Ong_Sua_Izin_Gunu { get; set; }

        public short? PC_Ong_Evlilik_Izin_Gunu { get; set; }

        public short? PC_Ong_Dogum_Izin_Gunu { get; set; }

        public short? PC_Ong_Babalik_Izin_Gunu { get; set; }

        public short? PC_Ong_Sut_Izin_Gunu { get; set; }

        public short? PC_Ong_Olum_Izin_Gunu { get; set; }

        public short? PC_Ong_IsArama_Izin_Gunu { get; set; }

        public bool? PC_DKS_Puantaja_Aktarilmasin { get; set; }

        public byte? PC_DKS_PuantajHesaplamaSekli { get; set; }

        public byte? PC_DKS_Toplam_Ise_EkKazancNo { get; set; }

        public double? PC_YarimIsGunu_Calisma_Saati { get; set; }

        public double? PC_Hastalik_Oran0 { get; set; }

        public double? PC_Hastalik_Oran1 { get; set; }

        public double? PC_Hastalik_Oran2 { get; set; }

        public double? PC_Hastalik_Oran3 { get; set; }

        public byte? PC_IzinHesaplamaSekli { get; set; }

        public byte? PC_HastalikHesaplamaSekli { get; set; }

        public double? PC_IkramiyeAyindaTaksitArtisOrani { get; set; }

        public double? PC_damga_vergisi_orani { get; set; }

        public byte? PC_kazanc_hesabi { get; set; }

        public byte? PC_ekkazanc_hesabi { get; set; }

        public byte? PC_sosyal_yardim_hesabi { get; set; }

        public byte? PC_aktarimda_eksik_gun_izin { get; set; }

        public byte? PC_aktarimda_eksik_gun_izin_tip { get; set; }
    }
}
