namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TESLIM_TURLERI
    {
        [Key]
        public int tslt_RECno { get; set; }

        public short tslt_RECid_DBCno { get; set; }

        public int tslt_RECid_RECno { get; set; }

        public int? tslt_SpecRECno { get; set; }

        public bool? tslt_iptal { get; set; }

        public short? tslt_fileid { get; set; }

        public bool? tslt_hidden { get; set; }

        public bool? tslt_kilitli { get; set; }

        public bool? tslt_degisti { get; set; }

        public int? tslt_checksum { get; set; }

        public short? tslt_create_user { get; set; }

        public DateTime? tslt_create_date { get; set; }

        public short? tslt_lastup_user { get; set; }

        public DateTime? tslt_lastup_date { get; set; }

        [StringLength(4)]
        public string tslt_special1 { get; set; }

        [StringLength(4)]
        public string tslt_special2 { get; set; }

        [StringLength(4)]
        public string tslt_special3 { get; set; }

        [StringLength(4)]
        public string tslt_kod { get; set; }

        [StringLength(90)]
        public string tslt_ismi { get; set; }
    }
}
