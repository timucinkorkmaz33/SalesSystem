namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_AMBALAJLARI
    {
        [Key]
        public int amb_RECno { get; set; }

        public short amb_RECid_DBCno { get; set; }

        public int amb_RECid_RECno { get; set; }

        public int? amb_SpecRECno { get; set; }

        public bool? amb_iptal { get; set; }

        public short? amb_fileid { get; set; }

        public bool? amb_hidden { get; set; }

        public bool? amb_kilitli { get; set; }

        public bool? amb_degisti { get; set; }

        public int? amb_checksum { get; set; }

        public short? amb_create_user { get; set; }

        public DateTime? amb_create_date { get; set; }

        public short? amb_lastup_user { get; set; }

        public DateTime? amb_lastup_date { get; set; }

        [StringLength(4)]
        public string amb_special1 { get; set; }

        [StringLength(4)]
        public string amb_special2 { get; set; }

        [StringLength(4)]
        public string amb_special3 { get; set; }

        [StringLength(25)]
        public string amb_kod { get; set; }

        [StringLength(90)]
        public string amb_ismi { get; set; }

        public double? amb_miktar { get; set; }

        public double? amb_dara { get; set; }
    }
}
