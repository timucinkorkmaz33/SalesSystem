namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_ANA_GRUPLARI
    {
        [Key]
        public int san_RECno { get; set; }

        public short san_RECid_DBCno { get; set; }

        public int san_RECid_RECno { get; set; }

        public int? san_SpecRECno { get; set; }

        public bool? san_iptal { get; set; }

        public short? san_fileid { get; set; }

        public bool? san_hidden { get; set; }

        public bool? san_kilitli { get; set; }

        public bool? san_degisti { get; set; }

        public int? san_checksum { get; set; }

        public short? san_create_user { get; set; }

        public DateTime? san_create_date { get; set; }

        public short? san_lastup_user { get; set; }

        public DateTime? san_lastup_date { get; set; }

        [StringLength(4)]
        public string san_special1 { get; set; }

        [StringLength(4)]
        public string san_special2 { get; set; }

        [StringLength(4)]
        public string san_special3 { get; set; }

        [StringLength(25)]
        public string san_kod { get; set; }

        [StringLength(90)]
        public string san_isim { get; set; }
    }
}
