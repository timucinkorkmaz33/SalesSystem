namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRA_TANIMLARI
    {
        [Key]
        public int kr_RECno { get; set; }

        public short kr_RECid_DBCno { get; set; }

        public int kr_RECid_RECno { get; set; }

        public int? kr_SpecRECno { get; set; }

        public bool? kr_iptal { get; set; }

        public short? kr_fileid { get; set; }

        public bool? kr_hidden { get; set; }

        public bool? kr_kilitli { get; set; }

        public bool? kr_degisti { get; set; }

        public int? kr_checksum { get; set; }

        public short? kr_create_user { get; set; }

        public DateTime? kr_create_date { get; set; }

        public short? kr_lastup_user { get; set; }

        public DateTime? kr_lastup_date { get; set; }

        [StringLength(4)]
        public string kr_special1 { get; set; }

        [StringLength(4)]
        public string kr_special2 { get; set; }

        [StringLength(4)]
        public string kr_special3 { get; set; }

        public int? kr_firma_no { get; set; }

        public int? kr_sube_no { get; set; }

        public int? kr_kira_no { get; set; }

        [StringLength(25)]
        public string kr_muhtasar_grup_kodu { get; set; }

        [StringLength(50)]
        public string kr_unvan { get; set; }

        [StringLength(25)]
        public string kr_hesap_kodu { get; set; }

        public double? kr_tutar { get; set; }

        public byte? kr_isltip { get; set; }

        [StringLength(25)]
        public string kr_ozel_mah_kodu { get; set; }

        [StringLength(25)]
        public string kr_vergi_kimlik_no { get; set; }

        [StringLength(50)]
        public string kr_cadde { get; set; }

        [StringLength(50)]
        public string kr_mahalle { get; set; }

        [StringLength(50)]
        public string kr_sokak { get; set; }

        [StringLength(25)]
        public string kr_Semt { get; set; }

        [StringLength(10)]
        public string kr_Apt_No { get; set; }

        [StringLength(10)]
        public string kr_Daire_No { get; set; }

        [StringLength(8)]
        public string kr_posta_kodu { get; set; }

        [StringLength(15)]
        public string kr_ilce { get; set; }

        [StringLength(15)]
        public string kr_il { get; set; }

        [StringLength(15)]
        public string kr_ulke { get; set; }

        [StringLength(10)]
        public string kr_adres_no { get; set; }

        [StringLength(10)]
        public string kr_vergi_dairesi_kodu { get; set; }

        public double? kr_vergi_orani { get; set; }

        [StringLength(11)]
        public string kr_tckimlik_no { get; set; }

        public DateTime? kr_baslangictarihi { get; set; }

        public DateTime? kr_bitistarihi { get; set; }
    }
}
