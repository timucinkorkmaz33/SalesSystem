namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAKINA_SORUNLARI
    {
        [Key]
        public int mks_RECno { get; set; }

        public short mks_RECid_DBCno { get; set; }

        public int mks_RECid_RECno { get; set; }

        public int? mks_SpecRECno { get; set; }

        public bool? mks_iptal { get; set; }

        public short? mks_fileid { get; set; }

        public bool? mks_hidden { get; set; }

        public bool? mks_kilitli { get; set; }

        public bool? mks_degisti { get; set; }

        public int? mks_checksum { get; set; }

        public short? mks_create_user { get; set; }

        public DateTime? mks_create_date { get; set; }

        public short? mks_lastup_user { get; set; }

        public DateTime? mks_lastup_date { get; set; }

        [StringLength(4)]
        public string mks_special1 { get; set; }

        [StringLength(4)]
        public string mks_special2 { get; set; }

        [StringLength(4)]
        public string mks_special3 { get; set; }

        [StringLength(25)]
        public string mks_kod { get; set; }

        [StringLength(90)]
        public string mks_ismi { get; set; }
    }
}
