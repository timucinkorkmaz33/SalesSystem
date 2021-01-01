namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEMIRBAS_GRUPLARI
    {
        [Key]
        public int grp_RECno { get; set; }

        public short grp_RECid_DBCno { get; set; }

        public int grp_RECid_RECno { get; set; }

        public int? grp_SpecRECno { get; set; }

        public bool? grp_iptal { get; set; }

        public short? grp_fileid { get; set; }

        public bool? grp_hidden { get; set; }

        public bool? grp_kilitli { get; set; }

        public bool? grp_degisti { get; set; }

        public int? grp_checksum { get; set; }

        public short? grp_create_user { get; set; }

        public DateTime? grp_create_date { get; set; }

        public short? grp_lastup_user { get; set; }

        public DateTime? grp_lastup_date { get; set; }

        [StringLength(4)]
        public string grp_special1 { get; set; }

        [StringLength(4)]
        public string grp_special2 { get; set; }

        [StringLength(4)]
        public string grp_special3 { get; set; }

        [StringLength(25)]
        public string grp_kod { get; set; }

        [StringLength(90)]
        public string grp_ismi { get; set; }
    }
}
