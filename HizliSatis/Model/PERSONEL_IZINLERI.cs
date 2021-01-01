namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_IZINLERI
    {
        [Key]
        public int pz_RECno { get; set; }

        public short pz_RECid_DBCno { get; set; }

        public int pz_RECid_RECno { get; set; }

        public int? pz_SpecRECno { get; set; }

        public bool? pz_iptal { get; set; }

        public short? pz_fileid { get; set; }

        public bool? pz_hidden { get; set; }

        public bool? pz_kilitli { get; set; }

        public bool? pz_degisti { get; set; }

        public int? pz_checksum { get; set; }

        public short? pz_create_user { get; set; }

        public DateTime? pz_create_date { get; set; }

        public short? pz_lastup_user { get; set; }

        public DateTime? pz_lastup_date { get; set; }

        [StringLength(4)]
        public string pz_special1 { get; set; }

        [StringLength(4)]
        public string pz_special2 { get; set; }

        [StringLength(4)]
        public string pz_special3 { get; set; }

        public short? pz_izin_yil { get; set; }

        [StringLength(25)]
        public string pz_pers_kod { get; set; }

        public int? pz_izin_no { get; set; }

        public byte? pz_izin_tipi { get; set; }

        public byte? pz_gun_sayisi { get; set; }

        public byte? pz_yol_izni { get; set; }

        public DateTime? pz_baslangictarih { get; set; }

        public short? pz_bagli_talep_DBCno { get; set; }

        public int? pz_bagli_talep_RECno { get; set; }

        [StringLength(50)]
        public string pz_izin_aciklama { get; set; }

        public DateTime? pz_gerceklesen_donus_tarihi { get; set; }

        public byte? pz_izin_detay_tipi { get; set; }
    }
}
