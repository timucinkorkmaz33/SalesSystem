namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGITIM_GRUP_TIPLERI
    {
        [Key]
        public int egt_RECno { get; set; }

        public short egt_RECid_DBCno { get; set; }

        public int egt_RECid_RECno { get; set; }

        public int? egt_SpecRECno { get; set; }

        public bool? egt_iptal { get; set; }

        public short? egt_fileid { get; set; }

        public bool? egt_hidden { get; set; }

        public bool? egt_kilitli { get; set; }

        public bool? egt_degisti { get; set; }

        public int? egt_checksum { get; set; }

        public short? egt_create_user { get; set; }

        public DateTime? egt_create_date { get; set; }

        public short? egt_lastup_user { get; set; }

        public DateTime? egt_lastup_date { get; set; }

        [StringLength(4)]
        public string egt_special1 { get; set; }

        [StringLength(4)]
        public string egt_special2 { get; set; }

        [StringLength(4)]
        public string egt_special3 { get; set; }

        [StringLength(25)]
        public string egt_kodu { get; set; }

        [StringLength(40)]
        public string egt_adi { get; set; }
    }
}
