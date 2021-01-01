namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_IZIN_TALEPLERI
    {
        [Key]
        public int pit_RECno { get; set; }

        public short pit_RECid_DBCno { get; set; }

        public int pit_RECid_RECno { get; set; }

        public int? pit_SpecRECno { get; set; }

        public bool? pit_iptal { get; set; }

        public short? pit_fileid { get; set; }

        public bool? pit_hidden { get; set; }

        public bool? pit_kilitli { get; set; }

        public bool? pit_degisti { get; set; }

        public int? pit_checksum { get; set; }

        public short? pit_create_user { get; set; }

        public DateTime? pit_create_date { get; set; }

        public short? pit_lastup_user { get; set; }

        public DateTime? pit_lastup_date { get; set; }

        [StringLength(4)]
        public string pit_special1 { get; set; }

        [StringLength(4)]
        public string pit_special2 { get; set; }

        [StringLength(4)]
        public string pit_special3 { get; set; }

        [StringLength(25)]
        public string pit_pers_kod { get; set; }

        public int? pit_mali_yil { get; set; }

        public int? pit_satir_no { get; set; }

        public DateTime? pit_talep_tarihi { get; set; }

        public byte? pit_izin_tipi { get; set; }

        public byte? pit_gun_sayisi { get; set; }

        public byte? pit_yol_izni { get; set; }

        public DateTime? pit_baslangictarih { get; set; }

        public byte? pit_izin_durum { get; set; }

        public int? pit_onaylayan_kullanici { get; set; }

        [StringLength(50)]
        public string pit_cadde { get; set; }

        [StringLength(50)]
        public string pit_mahalle { get; set; }

        [StringLength(50)]
        public string pit_sokak { get; set; }

        [StringLength(25)]
        public string pit_Semt { get; set; }

        [StringLength(10)]
        public string pit_Apt_No { get; set; }

        [StringLength(10)]
        public string pit_Daire_No { get; set; }

        [StringLength(8)]
        public string pit_posta_kodu { get; set; }

        [StringLength(15)]
        public string pit_ilce { get; set; }

        [StringLength(15)]
        public string pit_il { get; set; }

        [StringLength(15)]
        public string pit_ulke { get; set; }

        [StringLength(10)]
        public string pit_adres_kodu { get; set; }

        [StringLength(15)]
        public string pit_tel1 { get; set; }

        [StringLength(15)]
        public string pit_tel2 { get; set; }

        [StringLength(50)]
        public string pit_email { get; set; }

        [StringLength(50)]
        public string pit_amac { get; set; }

        [StringLength(50)]
        public string pit_aciklama1 { get; set; }

        [StringLength(50)]
        public string pit_aciklama2 { get; set; }
    }
}
