namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROGRAM_LOGLARI
    {
        [Key]
        public int log_RECno { get; set; }

        public short log_RECid_DBCno { get; set; }

        public int log_RECid_RECno { get; set; }

        public int? log_SpecRECno { get; set; }

        public bool? log_iptal { get; set; }

        public short? log_fileid { get; set; }

        public bool? log_hidden { get; set; }

        public bool? log_kilitli { get; set; }

        public bool? log_degisti { get; set; }

        public int? log_checksum { get; set; }

        public short? log_create_user { get; set; }

        public DateTime? log_create_date { get; set; }

        public short? log_lastup_user { get; set; }

        public DateTime? log_lastup_date { get; set; }

        [StringLength(4)]
        public string log_special1 { get; set; }

        [StringLength(4)]
        public string log_special2 { get; set; }

        [StringLength(4)]
        public string log_special3 { get; set; }

        public byte? log_type { get; set; }

        public int? log_firmano { get; set; }

        public int? log_subeno { get; set; }

        public DateTime? log_tarihi { get; set; }

        public int? log_user { get; set; }

        public short? log_prgno { get; set; }

        public int? log_menuno { get; set; }

        [StringLength(127)]
        public string log_aciklama { get; set; }
    }
}
