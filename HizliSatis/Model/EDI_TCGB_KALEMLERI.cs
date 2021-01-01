namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EDI_TCGB_KALEMLERI
    {
        [Key]
        public int est_RECno { get; set; }

        public short est_RECid_DBCno { get; set; }

        public int est_RECid_RECno { get; set; }

        public int? est_SpecRECno { get; set; }

        public bool? est_iptal { get; set; }

        public short? est_fileid { get; set; }

        public bool? est_hidden { get; set; }

        public bool? est_kilitli { get; set; }

        public bool? est_degisti { get; set; }

        public int? est_checksum { get; set; }

        public short? est_create_user { get; set; }

        public DateTime? est_create_date { get; set; }

        public short? est_lastup_user { get; set; }

        public DateTime? est_lastup_date { get; set; }

        [StringLength(4)]
        public string est_special1 { get; set; }

        [StringLength(4)]
        public string est_special2 { get; set; }

        [StringLength(4)]
        public string est_special3 { get; set; }

        public short? est_DRECid_DBCno { get; set; }

        public int? est_DRECid_RECno { get; set; }

        [StringLength(25)]
        public string est_kalemkodu { get; set; }

        [StringLength(4)]
        public string est_olcukod { get; set; }

        [StringLength(5)]
        public string est_kapcinsi { get; set; }

        [StringLength(15)]
        public string est_kapnumarasi { get; set; }

        public double? est_kapadedi { get; set; }

        [StringLength(30)]
        public string est_kapmarkasi { get; set; }

        public int? est_odemeadresi { get; set; }

        [StringLength(25)]
        public string est_imalatci { get; set; }

        [StringLength(25)]
        public string est_muafiyetkod1 { get; set; }

        [StringLength(12)]
        public string est_muafiyetref1 { get; set; }

        [StringLength(30)]
        public string est_muafiyetaciklama1 { get; set; }

        [StringLength(25)]
        public string est_muafiyetkod2 { get; set; }

        [StringLength(12)]
        public string est_muafiyetref2 { get; set; }

        [StringLength(30)]
        public string est_muafiyetaciklama2 { get; set; }

        [StringLength(25)]
        public string est_muafiyetkod3 { get; set; }

        [StringLength(12)]
        public string est_muafiyetref3 { get; set; }

        [StringLength(30)]
        public string est_muafiyetaciklama3 { get; set; }

        public short? est_ekbelkod1 { get; set; }

        [StringLength(12)]
        public string est_ekbelreferansno1 { get; set; }

        [StringLength(30)]
        public string est_ekbelaciklama1 { get; set; }

        public short? est_ekbelkod2 { get; set; }

        [StringLength(12)]
        public string est_ekbelreferansno2 { get; set; }

        [StringLength(30)]
        public string est_ekbelaciklama2 { get; set; }

        public short? est_ekbelkod3 { get; set; }

        [StringLength(12)]
        public string est_ekbelreferansno3 { get; set; }

        [StringLength(30)]
        public string est_ekbelaciklama3 { get; set; }

        public short? est_ekbelkod4 { get; set; }

        [StringLength(12)]
        public string est_ekbelreferansno4 { get; set; }

        [StringLength(30)]
        public string est_ekbelaciklama4 { get; set; }

        public short? est_ekbelkod5 { get; set; }

        [StringLength(12)]
        public string est_ekbelreferansno5 { get; set; }

        [StringLength(30)]
        public string est_ekbelaciklama5 { get; set; }

        public bool? est_dogrulama1 { get; set; }

        public bool? est_dogrulama2 { get; set; }

        public bool? est_dogrulama3 { get; set; }

        public bool? est_dogrulama4 { get; set; }

        public bool? est_dogrulama5 { get; set; }

        public bool? est_dogrulama6 { get; set; }

        public bool? est_dogrulama7 { get; set; }

        public bool? est_dogrulama8 { get; set; }

        [StringLength(10)]
        public string est_kotakodu { get; set; }

        [StringLength(4)]
        public string est_ekkod { get; set; }

        public double? est_istatislikkiymet { get; set; }

        public short? est_ebirlikambalajkod { get; set; }

        [StringLength(5)]
        public string est_ebirlik_iplikkodu { get; set; }

        public bool? est_bedelsiz { get; set; }

        [StringLength(30)]
        public string est_beyannameno { get; set; }

        public DateTime? est_beyannametarihi { get; set; }

        [StringLength(15)]
        public string est_beyannameSirano { get; set; }
    }
}
