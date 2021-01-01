namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_MARKALARI
    {
        [Key]
        public int mrk_RECno { get; set; }

        public short mrk_RECid_DBCno { get; set; }

        public int mrk_RECid_RECno { get; set; }

        public int? mrk_SpecRECno { get; set; }

        public bool? mrk_iptal { get; set; }

        public short? mrk_fileid { get; set; }

        public bool? mrk_hidden { get; set; }

        public bool? mrk_kilitli { get; set; }

        public bool? mrk_degisti { get; set; }

        public int? mrk_checksum { get; set; }

        public short? mrk_create_user { get; set; }

        public DateTime? mrk_create_date { get; set; }

        public short? mrk_lastup_user { get; set; }

        public DateTime? mrk_lastup_date { get; set; }

        [StringLength(4)]
        public string mrk_special1 { get; set; }

        [StringLength(4)]
        public string mrk_special2 { get; set; }

        [StringLength(4)]
        public string mrk_special3 { get; set; }

        [StringLength(25)]
        public string mrk_kod { get; set; }

        [StringLength(90)]
        public string mrk_ismi { get; set; }
    }
}
