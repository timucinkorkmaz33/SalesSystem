namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KAT_TANIMLARI
    {
        [Key]
        public int kat_RECno { get; set; }

        public short kat_RECid_DBCno { get; set; }

        public int kat_RECid_RECno { get; set; }

        public int? kat_SpecRECno { get; set; }

        public bool? kat_iptal { get; set; }

        public short? kat_fileid { get; set; }

        public bool? kat_hidden { get; set; }

        public bool? kat_kilitli { get; set; }

        public bool? kat_degisti { get; set; }

        public int? kat_checksum { get; set; }

        public short? kat_create_user { get; set; }

        public DateTime? kat_create_date { get; set; }

        public short? kat_lastup_user { get; set; }

        public DateTime? kat_lastup_date { get; set; }

        [StringLength(4)]
        public string kat_special1 { get; set; }

        [StringLength(4)]
        public string kat_special2 { get; set; }

        [StringLength(4)]
        public string kat_special3 { get; set; }

        [StringLength(25)]
        public string kat_sitekod { get; set; }

        [StringLength(25)]
        public string kat_blokkod { get; set; }

        [StringLength(25)]
        public string kat_kod { get; set; }

        [StringLength(90)]
        public string kat_ismi { get; set; }
    }
}
