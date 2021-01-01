namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ARIZA_GRUPLARI
    {
        [Key]
        public int agr_RECno { get; set; }

        public short agr_RECid_DBCno { get; set; }

        public int agr_RECid_RECno { get; set; }

        public int? agr_SpecRECno { get; set; }

        public bool? agr_iptal { get; set; }

        public short? agr_fileid { get; set; }

        public bool? agr_hidden { get; set; }

        public bool? agr_kilitli { get; set; }

        public bool? agr_degisti { get; set; }

        public int? agr_checksum { get; set; }

        public short? agr_create_user { get; set; }

        public DateTime? agr_create_date { get; set; }

        public short? agr_lastup_user { get; set; }

        public DateTime? agr_lastup_date { get; set; }

        [StringLength(4)]
        public string agr_special1 { get; set; }

        [StringLength(4)]
        public string agr_special2 { get; set; }

        [StringLength(4)]
        public string agr_special3 { get; set; }

        [StringLength(25)]
        public string agr_kodu { get; set; }

        [StringLength(50)]
        public string agr_adi { get; set; }
    }
}
