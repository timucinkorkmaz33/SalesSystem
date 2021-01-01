namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_PLAN_MATRISI_DETAY
    {
        [Key]
        public int upmd_RECno { get; set; }

        public short upmd_RECid_DBCno { get; set; }

        public int upmd_RECid_RECno { get; set; }

        public int? upmd_SpecRECno { get; set; }

        public bool? upmd_iptal { get; set; }

        public short? upmd_fileid { get; set; }

        public bool? upmd_hidden { get; set; }

        public bool? upmd_kilitli { get; set; }

        public bool? upmd_degisti { get; set; }

        public int? upmd_checksum { get; set; }

        public short? upmd_create_user { get; set; }

        public DateTime? upmd_create_date { get; set; }

        public short? upmd_lastup_user { get; set; }

        public DateTime? upmd_lastup_date { get; set; }

        [StringLength(4)]
        public string upmd_special1 { get; set; }

        [StringLength(4)]
        public string upmd_special2 { get; set; }

        [StringLength(4)]
        public string upmd_special3 { get; set; }

        [StringLength(25)]
        public string upmd_matriskodu { get; set; }

        [StringLength(25)]
        public string upmd_stokkodu { get; set; }

        public byte? upmd_donemno { get; set; }

        public double? upmd_miktar { get; set; }
    }
}
