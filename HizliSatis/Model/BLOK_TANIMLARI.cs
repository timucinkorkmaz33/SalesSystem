namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BLOK_TANIMLARI
    {
        [Key]
        public int blok_RECno { get; set; }

        public short blok_RECid_DBCno { get; set; }

        public int blok_RECid_RECno { get; set; }

        public int? blok_SpecRECno { get; set; }

        public bool? blok_iptal { get; set; }

        public short? blok_fileid { get; set; }

        public bool? blok_hidden { get; set; }

        public bool? blok_kilitli { get; set; }

        public bool? blok_degisti { get; set; }

        public int? blok_checksum { get; set; }

        public short? blok_create_user { get; set; }

        public DateTime? blok_create_date { get; set; }

        public short? blok_lastup_user { get; set; }

        public DateTime? blok_lastup_date { get; set; }

        [StringLength(4)]
        public string blok_special1 { get; set; }

        [StringLength(4)]
        public string blok_special2 { get; set; }

        [StringLength(4)]
        public string blok_special3 { get; set; }

        [StringLength(25)]
        public string blok_sitekod { get; set; }

        [StringLength(25)]
        public string blok_kod { get; set; }

        [StringLength(90)]
        public string blok_ismi { get; set; }
    }
}
