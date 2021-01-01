namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_REYONLARI
    {
        [Key]
        public int ryn_RECno { get; set; }

        public short ryn_RECid_DBCno { get; set; }

        public int ryn_RECid_RECno { get; set; }

        public int? ryn_SpecRECno { get; set; }

        public bool? ryn_iptal { get; set; }

        public short? ryn_fileid { get; set; }

        public bool? ryn_hidden { get; set; }

        public bool? ryn_kilitli { get; set; }

        public bool? ryn_degisti { get; set; }

        public int? ryn_checksum { get; set; }

        public short? ryn_create_user { get; set; }

        public DateTime? ryn_create_date { get; set; }

        public short? ryn_lastup_user { get; set; }

        public DateTime? ryn_lastup_date { get; set; }

        [StringLength(4)]
        public string ryn_special1 { get; set; }

        [StringLength(4)]
        public string ryn_special2 { get; set; }

        [StringLength(4)]
        public string ryn_special3 { get; set; }

        [StringLength(25)]
        public string ryn_kod { get; set; }

        [StringLength(90)]
        public string ryn_ismi { get; set; }
    }
}
