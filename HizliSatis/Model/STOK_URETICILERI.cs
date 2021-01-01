namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_URETICILERI
    {
        [Key]
        public int urt_RECno { get; set; }

        public short urt_RECid_DBCno { get; set; }

        public int urt_RECid_RECno { get; set; }

        public int? urt_SpecRECno { get; set; }

        public bool? urt_iptal { get; set; }

        public short? urt_fileid { get; set; }

        public bool? urt_hidden { get; set; }

        public bool? urt_kilitli { get; set; }

        public bool? urt_degisti { get; set; }

        public int? urt_checksum { get; set; }

        public short? urt_create_user { get; set; }

        public DateTime? urt_create_date { get; set; }

        public short? urt_lastup_user { get; set; }

        public DateTime? urt_lastup_date { get; set; }

        [StringLength(4)]
        public string urt_special1 { get; set; }

        [StringLength(4)]
        public string urt_special2 { get; set; }

        [StringLength(4)]
        public string urt_special3 { get; set; }

        [StringLength(25)]
        public string urt_kod { get; set; }

        [StringLength(90)]
        public string urt_ismi { get; set; }
    }
}
