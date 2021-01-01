namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_VARDIYA_CALISANLARI
    {
        [Key]
        public int vc_RECno { get; set; }

        public short vc_RECid_DBCno { get; set; }

        public int vc_RECid_RECno { get; set; }

        public int? vc_SpecRECno { get; set; }

        public bool? vc_iptal { get; set; }

        public short? vc_fileid { get; set; }

        public bool? vc_hidden { get; set; }

        public bool? vc_kilitli { get; set; }

        public bool? vc_degisti { get; set; }

        public int? vc_checksum { get; set; }

        public short? vc_create_user { get; set; }

        public DateTime? vc_create_date { get; set; }

        public short? vc_lastup_user { get; set; }

        public DateTime? vc_lastup_date { get; set; }

        [StringLength(4)]
        public string vc_special1 { get; set; }

        [StringLength(4)]
        public string vc_special2 { get; set; }

        [StringLength(4)]
        public string vc_special3 { get; set; }

        public int? vc_firmano { get; set; }

        public int? vc_subeno { get; set; }

        public byte? vc_vardiyahesaptip { get; set; }

        public DateTime? vc_Tarihi { get; set; }

        public byte? vc_Numarasi { get; set; }

        [StringLength(25)]
        public string vc_pers_kodu { get; set; }

        public byte? vc_Acik_Kapali { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_1 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_2 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_3 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_4 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_5 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_6 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_7 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_8 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_9 { get; set; }

        [StringLength(25)]
        public string vc_ortak_pers_10 { get; set; }
    }
}
