namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVM_SAYACLARI
    {
        [Key]
        public int Avmsyc_RECno { get; set; }

        public short Avmsyc_RECid_DBCno { get; set; }

        public int Avmsyc_RECid_RECno { get; set; }

        public int? Avmsyc_SpecRECno { get; set; }

        public bool? Avmsyc_iptal { get; set; }

        public short? Avmsyc_fileid { get; set; }

        public bool? Avmsyc_hidden { get; set; }

        public bool? Avmsyc_kilitli { get; set; }

        public bool? Avmsyc_degisti { get; set; }

        public int? Avmsyc_checksum { get; set; }

        public short? Avmsyc_create_user { get; set; }

        public DateTime? Avmsyc_create_date { get; set; }

        public short? Avmsyc_lastup_user { get; set; }

        public DateTime? Avmsyc_lastup_date { get; set; }

        [StringLength(4)]
        public string Avmsyc_special1 { get; set; }

        [StringLength(4)]
        public string Avmsyc_special2 { get; set; }

        [StringLength(4)]
        public string Avmsyc_special3 { get; set; }

        public byte? Avmsyc_turu { get; set; }

        public byte? Avmsyc_cinsi { get; set; }

        public byte? Avmsyc_tipi { get; set; }

        [StringLength(25)]
        public string Avmsyc_kod { get; set; }

        [StringLength(90)]
        public string Avmsyc_ismi { get; set; }

        [StringLength(25)]
        public string Avmsyc_sayacno { get; set; }

        [StringLength(20)]
        public string Avmsyc_sozlesmeno { get; set; }

        [StringLength(25)]
        public string Avmsyc_blmkodu { get; set; }

        [StringLength(25)]
        public string Avmsyc_masrafhizmetkodu { get; set; }

        [StringLength(25)]
        public string Avmsyc_merkezisayackodu { get; set; }
    }
}
