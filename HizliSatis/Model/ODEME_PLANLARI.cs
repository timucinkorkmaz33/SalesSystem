namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODEME_PLANLARI
    {
        [Key]
        public int odp_RECno { get; set; }

        public short odp_RECid_DBCno { get; set; }

        public int odp_RECid_RECno { get; set; }

        public int? odp_SpecRECno { get; set; }

        public bool? odp_iptal { get; set; }

        public short? odp_fileid { get; set; }

        public bool? odp_hidden { get; set; }

        public bool? odp_kilitli { get; set; }

        public bool? odp_degisti { get; set; }

        public int? odp_checksum { get; set; }

        public short? odp_create_user { get; set; }

        public DateTime? odp_create_date { get; set; }

        public short? odp_lastup_user { get; set; }

        public DateTime? odp_lastup_date { get; set; }

        [StringLength(4)]
        public string odp_special1 { get; set; }

        [StringLength(4)]
        public string odp_special2 { get; set; }

        [StringLength(4)]
        public string odp_special3 { get; set; }

        public int? odp_no { get; set; }

        [StringLength(25)]
        public string odp_kodu { get; set; }

        [StringLength(50)]
        public string odp_adi { get; set; }

        [StringLength(127)]
        public string odp_aratop { get; set; }

        [StringLength(127)]
        public string odp_masraf { get; set; }

        [StringLength(127)]
        public string odp_vergi { get; set; }

        public int? odp_ortgun { get; set; }
    }
}
