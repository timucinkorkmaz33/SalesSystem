namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEPO_GRUPLARI
    {
        [Key]
        public int dgr_RECno { get; set; }

        public short dgr_RECid_DBCno { get; set; }

        public int dgr_RECid_RECno { get; set; }

        public int? dgr_SpecRECno { get; set; }

        public bool? dgr_iptal { get; set; }

        public short? dgr_fileid { get; set; }

        public bool? dgr_hidden { get; set; }

        public bool? dgr_kilitli { get; set; }

        public bool? dgr_degisti { get; set; }

        public int? dgr_checksum { get; set; }

        public short? dgr_create_user { get; set; }

        public DateTime? dgr_create_date { get; set; }

        public short? dgr_lastup_user { get; set; }

        public DateTime? dgr_lastup_date { get; set; }

        [StringLength(4)]
        public string dgr_special1 { get; set; }

        [StringLength(4)]
        public string dgr_special2 { get; set; }

        [StringLength(4)]
        public string dgr_special3 { get; set; }

        [StringLength(25)]
        public string dgr_kod { get; set; }

        [StringLength(90)]
        public string dgr_ismi { get; set; }
    }
}
