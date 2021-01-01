namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_YETKILILERI
    {
        [Key]
        public int mye_RECno { get; set; }

        public short mye_RECid_DBCno { get; set; }

        public int mye_RECid_RECno { get; set; }

        public int? mye_SpecRECno { get; set; }

        public bool? mye_iptal { get; set; }

        public short? mye_fileid { get; set; }

        public bool? mye_hidden { get; set; }

        public bool? mye_kilitli { get; set; }

        public bool? mye_degisti { get; set; }

        public int? mye_checksum { get; set; }

        public short? mye_create_user { get; set; }

        public DateTime? mye_create_date { get; set; }

        public short? mye_lastup_user { get; set; }

        public DateTime? mye_lastup_date { get; set; }

        [StringLength(4)]
        public string mye_special1 { get; set; }

        [StringLength(4)]
        public string mye_special2 { get; set; }

        [StringLength(4)]
        public string mye_special3 { get; set; }

        [StringLength(25)]
        public string mye_cari_kod { get; set; }

        public int? mye_adres_no { get; set; }

        [StringLength(30)]
        public string mye_isim { get; set; }

        [StringLength(30)]
        public string mye_soyisim { get; set; }

        public DateTime? mye_dogum_tarihi { get; set; }

        public DateTime? mye_evlilik_tarihi { get; set; }

        [StringLength(30)]
        public string mye_es_isim { get; set; }

        public DateTime? mye_es_dogum_tarihi { get; set; }

        public byte? mye_unvan { get; set; }

        public byte? mye_hitap { get; set; }

        public byte? mye_hisse { get; set; }

        public byte? mye_tahsil { get; set; }

        [StringLength(5)]
        public string mye_dahili_telno { get; set; }

        [StringLength(50)]
        public string mye_email_adres { get; set; }

        [StringLength(17)]
        public string mye_cep_telno { get; set; }

        [StringLength(20)]
        public string mye_tc_kimlikno { get; set; }

        [StringLength(20)]
        public string mye_vergi_dairesi { get; set; }

        [StringLength(20)]
        public string mye_vergi_kimlikno { get; set; }

        [StringLength(30)]
        public string mye_dogum_yeri { get; set; }

        [StringLength(50)]
        public string mye_ev_cadde { get; set; }

        [StringLength(50)]
        public string mye_ev_mahalle { get; set; }

        [StringLength(50)]
        public string mye_ev_sokak { get; set; }

        [StringLength(25)]
        public string mye_ev_Semt { get; set; }

        [StringLength(10)]
        public string mye_ev_Apt_No { get; set; }

        [StringLength(10)]
        public string mye_ev_Daire_No { get; set; }

        [StringLength(8)]
        public string mye_ev_posta_kodu { get; set; }

        [StringLength(15)]
        public string mye_ev_ilce { get; set; }

        [StringLength(15)]
        public string mye_ev_il { get; set; }

        [StringLength(15)]
        public string mye_ev_ulke { get; set; }

        [StringLength(10)]
        public string mye_ev_adres_kodu { get; set; }

        [StringLength(17)]
        public string mye_is_telno { get; set; }

        [StringLength(17)]
        public string mye_ev_telno { get; set; }

        [StringLength(80)]
        public string mye_KEP_adresi { get; set; }

        public bool? mye_mutabakat_yetkilisi_fl { get; set; }
    }
}
