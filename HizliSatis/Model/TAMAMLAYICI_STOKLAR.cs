namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAMAMLAYICI_STOKLAR
    {
        [Key]
        public int ts_RECno { get; set; }

        public short ts_RECid_DBCno { get; set; }

        public int ts_RECid_RECno { get; set; }

        public int? ts_SpecRECno { get; set; }

        public bool? ts_iptal { get; set; }

        public short? ts_fileid { get; set; }

        public bool? ts_hidden { get; set; }

        public bool? ts_kilitli { get; set; }

        public bool? ts_degisti { get; set; }

        public int? ts_checksum { get; set; }

        public short? ts_create_user { get; set; }

        public DateTime? ts_create_date { get; set; }

        public short? ts_lastup_user { get; set; }

        public DateTime? ts_lastup_date { get; set; }

        [StringLength(4)]
        public string ts_special1 { get; set; }

        [StringLength(4)]
        public string ts_special2 { get; set; }

        [StringLength(4)]
        public string ts_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string ts_kodu { get; set; }

        [Required]
        [StringLength(25)]
        public string ts_stokkodu { get; set; }

        public double? ts_miktar { get; set; }

        public int? ts_satirno { get; set; }
    }
}
