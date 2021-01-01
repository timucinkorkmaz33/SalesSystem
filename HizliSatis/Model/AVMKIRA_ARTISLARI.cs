namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMKIRA_ARTISLARI
    {
        [Key]
        public int AvmKA_RECno { get; set; }

        public short AvmKA_RECid_DBCno { get; set; }

        public int AvmKA_RECid_RECno { get; set; }

        public int? AvmKA_SpecRECno { get; set; }

        public bool? AvmKA_iptal { get; set; }

        public short? AvmKA_fileid { get; set; }

        public bool? AvmKA_hidden { get; set; }

        public bool? AvmKA_kilitli { get; set; }

        public bool? AvmKA_degisti { get; set; }

        public int? AvmKA_checksum { get; set; }

        public short? AvmKA_create_user { get; set; }

        public DateTime? AvmKA_create_date { get; set; }

        public short? AvmKA_lastup_user { get; set; }

        public DateTime? AvmKA_lastup_date { get; set; }

        [StringLength(4)]
        public string AvmKA_special1 { get; set; }

        [StringLength(4)]
        public string AvmKA_special2 { get; set; }

        [StringLength(4)]
        public string AvmKA_special3 { get; set; }

        [StringLength(25)]
        public string AvmKA_kodu { get; set; }

        [StringLength(90)]
        public string AvmKA_ismi { get; set; }

        [StringLength(40)]
        public string AvmKA_aciklama { get; set; }

        public double? AvmKA_orani { get; set; }
    }
}
