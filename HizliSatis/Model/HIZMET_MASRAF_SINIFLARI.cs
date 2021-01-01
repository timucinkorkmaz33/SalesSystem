namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_MASRAF_SINIFLARI
    {
        [Key]
        public int hmsnf_RECno { get; set; }

        public short hmsnf_RECid_DBCno { get; set; }

        public int hmsnf_RECid_RECno { get; set; }

        public int? hmsnf_SpecRECno { get; set; }

        public bool? hmsnf_iptal { get; set; }

        public short? hmsnf_fileid { get; set; }

        public bool? hmsnf_hidden { get; set; }

        public bool? hmsnf_kilitli { get; set; }

        public bool? hmsnf_degisti { get; set; }

        public int? hmsnf_checksum { get; set; }

        public short? hmsnf_create_user { get; set; }

        public DateTime? hmsnf_create_date { get; set; }

        public short? hmsnf_lastup_user { get; set; }

        public DateTime? hmsnf_lastup_date { get; set; }

        [StringLength(4)]
        public string hmsnf_special1 { get; set; }

        [StringLength(4)]
        public string hmsnf_special2 { get; set; }

        [StringLength(4)]
        public string hmsnf_special3 { get; set; }

        [StringLength(25)]
        public string hmsnf_kod { get; set; }

        [StringLength(90)]
        public string hmsnf_ismi { get; set; }
    }
}
