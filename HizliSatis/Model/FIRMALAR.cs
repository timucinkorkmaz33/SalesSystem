namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FIRMALAR")]
    public partial class FIRMALAR
    {
        [Key]
        public int fir_RECno { get; set; }

        public short fir_RECid_DBCno { get; set; }

        public int fir_RECid_RECno { get; set; }

        public int? fir_SpecRECno { get; set; }

        public bool? fir_iptal { get; set; }

        public short? fir_fileid { get; set; }

        public bool? fir_hidden { get; set; }

        public bool? fir_kilitli { get; set; }

        public bool? fir_degisti { get; set; }

        public int? fir_checksum { get; set; }

        public short? fir_create_user { get; set; }

        public DateTime? fir_create_date { get; set; }

        public short? fir_lastup_user { get; set; }

        public DateTime? fir_lastup_date { get; set; }

        [StringLength(4)]
        public string fir_special1 { get; set; }

        [StringLength(4)]
        public string fir_special2 { get; set; }

        [StringLength(4)]
        public string fir_special3 { get; set; }

        public int? fir_sirano { get; set; }

        [StringLength(127)]
        public string fir_unvan { get; set; }

        [StringLength(127)]
        public string fir_unvan2 { get; set; }

        [StringLength(15)]
        public string fir_TCkimlik { get; set; }

        [StringLength(10)]
        public string fir_Yazisma { get; set; }

        [StringLength(10)]
        public string fir_Bordro { get; set; }

        [StringLength(30)]
        public string fir_FHesapNo { get; set; }

        [StringLength(10)]
        public string fir_FVergiDaire { get; set; }

        [StringLength(20)]
        public string fir_FVergiNo { get; set; }

        [StringLength(20)]
        public string fir_FBolgeNo { get; set; }

        public bool? fir_Muhtasar { get; set; }

        public bool? fir_Isci { get; set; }

        public DateTime? fir_BasTar { get; set; }

        [StringLength(40)]
        public string fir_Istigal { get; set; }

        public bool? fir_Defter { get; set; }

        [StringLength(25)]
        public string fir_TicSicilNo { get; set; }

        public bool? fir_IslIzn1 { get; set; }

        public bool? fir_IslIzn2 { get; set; }

        public bool? fir_IslIzn3 { get; set; }

        public bool? fir_IslIzn4 { get; set; }

        public bool? fir_IslIzn5 { get; set; }

        public bool? fir_IslIzn6 { get; set; }

        public bool? fir_IslIzn7 { get; set; }

        public bool? fir_IslIzn8 { get; set; }

        public bool? fir_IslIzn9 { get; set; }

        public bool? fir_IslIzn10 { get; set; }

        public bool? fir_IslIzn11 { get; set; }

        public bool? fir_IslIzn12 { get; set; }

        public bool? fir_IslIzn13 { get; set; }

        public bool? fir_IslIzn14 { get; set; }

        public bool? fir_IslIzn15 { get; set; }

        public byte? fir_SmmEntegrasyon { get; set; }

        public bool? fir_Mali_Mus_firmasi { get; set; }

        [StringLength(15)]
        public string fir_Iso_no { get; set; }

        [StringLength(25)]
        public string fir_maasBankaKod { get; set; }

        public DateTime? fir_baslangic_tarihi { get; set; }

        public bool? fir_OTVden_muaf { get; set; }

        public double? fir_krediriskyuzde1 { get; set; }

        public byte? fir_krediriskneolacak1 { get; set; }

        public byte? fir_kredirisklimityuzde1hesap { get; set; }

        public double? fir_kredirisklimityuzde1 { get; set; }

        public byte? fir_kredirisklimittipi1 { get; set; }

        public double? fir_krediriskyuzde2 { get; set; }

        public byte? fir_krediriskneolacak2 { get; set; }

        public byte? fir_kredirisklimityuzde2hesap { get; set; }

        public double? fir_kredirisklimityuzde2 { get; set; }

        public byte? fir_kredirisklimittipi2 { get; set; }

        public double? fir_krediriskyuzde3 { get; set; }

        public byte? fir_krediriskneolacak3 { get; set; }

        public byte? fir_kredirisklimityuzde3hesap { get; set; }

        public double? fir_kredirisklimityuzde3 { get; set; }

        public byte? fir_kredirisklimittipi3 { get; set; }

        public double? fir_krediriskyuzde4 { get; set; }

        public byte? fir_krediriskneolacak4 { get; set; }

        public byte? fir_kredirisklimityuzde4hesap { get; set; }

        public double? fir_kredirisklimityuzde4 { get; set; }

        public byte? fir_kredirisklimittipi4 { get; set; }

        public double? fir_krediriskyuzde5 { get; set; }

        public byte? fir_krediriskneolacak5 { get; set; }

        public byte? fir_kredirisklimityuzde5hesap { get; set; }

        public double? fir_kredirisklimityuzde5 { get; set; }

        public byte? fir_kredirisklimittipi5 { get; set; }

        public double? fir_krediriskyuzde6 { get; set; }

        public byte? fir_krediriskneolacak6 { get; set; }

        public byte? fir_kredirisklimityuzde6hesap { get; set; }

        public double? fir_kredirisklimityuzde6 { get; set; }

        public byte? fir_kredirisklimittipi6 { get; set; }

        public double? fir_krediriskyuzde7 { get; set; }

        public byte? fir_krediriskneolacak7 { get; set; }

        public byte? fir_kredirisklimityuzde7hesap { get; set; }

        public double? fir_kredirisklimityuzde7 { get; set; }

        public byte? fir_kredirisklimittipi7 { get; set; }

        public double? fir_krediriskyuzde8 { get; set; }

        public byte? fir_krediriskneolacak8 { get; set; }

        public byte? fir_kredirisklimityuzde8hesap { get; set; }

        public double? fir_kredirisklimityuzde8 { get; set; }

        public byte? fir_kredirisklimittipi8 { get; set; }

        public double? fir_krediriskyuzde9 { get; set; }

        public byte? fir_krediriskneolacak9 { get; set; }

        public byte? fir_kredirisklimityuzde9hesap { get; set; }

        public double? fir_kredirisklimityuzde9 { get; set; }

        public byte? fir_kredirisklimittipi9 { get; set; }

        public double? fir_krediriskyuzde10 { get; set; }

        public byte? fir_krediriskneolacak10 { get; set; }

        public byte? fir_kredirisklimityuzde10hesap { get; set; }

        public double? fir_kredirisklimityuzde10 { get; set; }

        public byte? fir_kredirisklimittipi10 { get; set; }

        [StringLength(25)]
        public string fir_def_kasakodu { get; set; }

        public byte? fir_isletmetipi { get; set; }

        [StringLength(20)]
        public string fir_isletmefaliyetturu { get; set; }

        public bool? fir_kdvucaylik { get; set; }

        [StringLength(7)]
        public string fir_EAN_kodu { get; set; }

        public byte? fir_mukellefiyet { get; set; }

        [StringLength(25)]
        public string fir_kan_kab_ed_gider_kodu { get; set; }

        [StringLength(50)]
        public string fir_web_sayfasi { get; set; }

        [StringLength(20)]
        public string fir_web_kullanici_adi { get; set; }

        [StringLength(127)]
        public string fir_web_kullanici_sifresi { get; set; }

        [StringLength(20)]
        public string fir_web_musteri_no { get; set; }

        public bool? fir_OIVden_muaf { get; set; }

        [StringLength(25)]
        public string fir_maassistemikodu { get; set; }

        [StringLength(80)]
        public string fir_genel_email { get; set; }

        [StringLength(25)]
        public string fir_nace_kodu { get; set; }

        [StringLength(127)]
        public string fir_mali_muhur_sifre { get; set; }

        public int? fir_zaman_damgasi_kullanici { get; set; }

        [StringLength(127)]
        public string fir_zaman_damgasi_sifre { get; set; }

        [StringLength(127)]
        public string fir_edefter_sube_adi { get; set; }

        public int? fir_edefter_sube_no { get; set; }

        public DateTime? fir_edefter_baslangic { get; set; }

        public int? fir_edefter_max_boyut { get; set; }

        public byte? fir_edefter_doviz_tipi { get; set; }

        public byte? fir_edefter_aktif_grup { get; set; }

        [StringLength(20)]
        public string fir_tuik_isyerikayitno { get; set; }

        public DateTime? fir_efatura_baslangic { get; set; }

        public DateTime? fir_earsiv_baslangic { get; set; }

        [StringLength(80)]
        public string fir_KEP_adresi { get; set; }

        [StringLength(4)]
        public string fir_Ticaret_Sicil_Mudurlugu { get; set; }

        [StringLength(25)]
        public string fir_edefter_smm_kodu { get; set; }

        [StringLength(25)]
        public string fir_edefter_ymm_kodu { get; set; }

        [StringLength(80)]
        public string fir_edefter_nace_kodu { get; set; }

        public DateTime? fir_TasfiyeTarihi { get; set; }

        [StringLength(25)]
        public string fir_muhasebe_yetkilisi { get; set; }

        [StringLength(25)]
        public string fir_edefter_yetkilisi { get; set; }

        public byte? fir_mali_muhur_tipi { get; set; }

        [StringLength(127)]
        public string fir_mali_muhur_surucusu { get; set; }

        public bool? fir_edefter_sube_defteri_mi { get; set; }

        [StringLength(40)]
        public string fir_mikro_web_servis_kodu { get; set; }

        [StringLength(40)]
        public string fir_uyelik_hopi_firma_kodu { get; set; }

        [StringLength(40)]
        public string fir_uyelik_hopi_kullanici { get; set; }

        [StringLength(127)]
        public string fir_uyelik_hopi_sifre { get; set; }

        public bool? fir_tasfiye_hali_firmasi_mi { get; set; }

        [StringLength(127)]
        public string fir_smtp_host { get; set; }

        public int? fir_smtp_port { get; set; }

        public bool? fir_smtp_enable_ssl { get; set; }

        [StringLength(127)]
        public string fir_smtp_username { get; set; }

        [StringLength(127)]
        public string fir_smtp_sifre { get; set; }

        public byte? fir_BaslangicTarihiTipi { get; set; }

        public byte? fir_BitisTarihiTipi { get; set; }

        public byte? fir_VergiDetayTipi { get; set; }
    }
}
