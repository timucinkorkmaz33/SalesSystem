namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPOLAR")]
    public partial class DEPOLAR
    {
        [Key]
        public int dep_RECno { get; set; }

        public short dep_RECid_DBCno { get; set; }

        public int dep_RECid_RECno { get; set; }

        public int? dep_SpecRECno { get; set; }

        public bool? dep_iptal { get; set; }

        public short? dep_fileid { get; set; }

        public bool? dep_hidden { get; set; }

        public bool? dep_kilitli { get; set; }

        public bool? dep_degisti { get; set; }

        public int? dep_checksum { get; set; }

        public short? dep_create_user { get; set; }

        public DateTime? dep_create_date { get; set; }

        public short? dep_lastup_user { get; set; }

        public DateTime? dep_lastup_date { get; set; }

        [StringLength(4)]
        public string dep_special1 { get; set; }

        [StringLength(4)]
        public string dep_special2 { get; set; }

        [StringLength(4)]
        public string dep_special3 { get; set; }

        public int? dep_firmano { get; set; }

        public int? dep_subeno { get; set; }

        public int? dep_no { get; set; }

        [StringLength(50)]
        public string dep_adi { get; set; }

        [StringLength(25)]
        public string dep_grup_kodu { get; set; }

        public byte? dep_tipi { get; set; }

        public byte? dep_DepoSevkOtoFiyat { get; set; }

        public byte? dep_hareket_tipi { get; set; }

        [StringLength(10)]
        public string dep_muh_kodu { get; set; }

        [StringLength(25)]
        public string dep_sor_mer_kodu { get; set; }

        [StringLength(25)]
        public string dep_proje_kodu { get; set; }

        public int? dep_DepoSevkUygFiyat { get; set; }

        public DateTime? dep_KilitTarihi { get; set; }

        [StringLength(50)]
        public string dep_cadde { get; set; }

        [StringLength(50)]
        public string dep_mahalle { get; set; }

        [StringLength(50)]
        public string dep_sokak { get; set; }

        [StringLength(25)]
        public string dep_Semt { get; set; }

        [StringLength(10)]
        public string dep_Apt_No { get; set; }

        [StringLength(10)]
        public string dep_Daire_No { get; set; }

        [StringLength(8)]
        public string dep_posta_Kodu { get; set; }

        [StringLength(15)]
        public string dep_Ilce { get; set; }

        [StringLength(15)]
        public string dep_Il { get; set; }

        [StringLength(15)]
        public string dep_Ulke { get; set; }

        [StringLength(10)]
        public string dep_Adres_kodu { get; set; }

        public double? dep_gps_enlem { get; set; }

        public double? dep_gps_boylam { get; set; }

        public double? dep_alani { get; set; }

        public double? dep_rafhacmi { get; set; }

        [StringLength(50)]
        public string dep_yetkili_email { get; set; }

        public double? dep_satis_alani { get; set; }

        public double? dep_sergi_alani { get; set; }

        public double? dep_otopark_alani { get; set; }

        public int? dep_otopark_kapasite { get; set; }

        public int? dep_kasa_sayisi { get; set; }

        public double? dep_kamyon_kasa_hacmi { get; set; }

        public double? dep_kamyon_istiab_haddi { get; set; }

        [StringLength(50)]
        public string dep_dizin_adi { get; set; }

        [StringLength(5)]
        public string dep_tel_ulke_kodu { get; set; }

        [StringLength(5)]
        public string dep_tel_bolge_kodu { get; set; }

        [StringLength(10)]
        public string dep_tel_no1 { get; set; }

        [StringLength(10)]
        public string dep_tel_no2 { get; set; }

        [StringLength(10)]
        public string dep_tel_faxno { get; set; }

        [StringLength(10)]
        public string dep_tel_modem { get; set; }

        public bool? dep_envanter_harici_fl { get; set; }

        public byte? dep_detay_takibi { get; set; }

        [StringLength(50)]
        public string dep_barkod_yazici_yolu { get; set; }

        [StringLength(25)]
        public string dep_fason_sor_mer_kodu { get; set; }

        public byte? dep_EksiyeDusurenStkHar { get; set; }

        public byte? dep_BagliOrtakliklaraSatisUygFiyat { get; set; }

        [StringLength(25)]
        public string dep_bolge_kodu { get; set; }

        public byte? dep_NakliyefisiSatisFiyatTipi { get; set; }
    }
}
