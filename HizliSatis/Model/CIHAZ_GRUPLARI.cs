namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIHAZ_GRUPLARI
    {
        [Key]
        public int cg_RECno { get; set; }

        public short cg_RECid_DBCno { get; set; }

        public int cg_RECid_RECno { get; set; }

        public int? cg_SpecRECno { get; set; }

        public bool? cg_iptal { get; set; }

        public short? cg_fileid { get; set; }

        public bool? cg_hidden { get; set; }

        public bool? cg_kilitli { get; set; }

        public bool? cg_degisti { get; set; }

        public int? cg_checksum { get; set; }

        public short? cg_create_user { get; set; }

        public DateTime? cg_create_date { get; set; }

        public short? cg_lastup_user { get; set; }

        public DateTime? cg_lastup_date { get; set; }

        [StringLength(4)]
        public string cg_special1 { get; set; }

        [StringLength(4)]
        public string cg_special2 { get; set; }

        [StringLength(4)]
        public string cg_special3 { get; set; }

        [StringLength(25)]
        public string cg_kodu { get; set; }

        [StringLength(80)]
        public string cg_aciklama { get; set; }
    }
}
