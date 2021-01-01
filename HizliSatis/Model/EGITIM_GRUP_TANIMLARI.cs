namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGITIM_GRUP_TANIMLARI
    {
        [Key]
        public int egr_RECno { get; set; }

        public short egr_RECid_DBCno { get; set; }

        public int egr_RECid_RECno { get; set; }

        public int? egr_SpecRECno { get; set; }

        public bool? egr_iptal { get; set; }

        public short? egr_fileid { get; set; }

        public bool? egr_hidden { get; set; }

        public bool? egr_kilitli { get; set; }

        public bool? egr_degisti { get; set; }

        public int? egr_checksum { get; set; }

        public short? egr_create_user { get; set; }

        public DateTime? egr_create_date { get; set; }

        public short? egr_lastup_user { get; set; }

        public DateTime? egr_lastup_date { get; set; }

        [StringLength(4)]
        public string egr_special1 { get; set; }

        [StringLength(4)]
        public string egr_special2 { get; set; }

        [StringLength(4)]
        public string egr_special3 { get; set; }

        public int? egr_firmano { get; set; }

        public int? egr_subeno { get; set; }

        [StringLength(25)]
        public string egr_kod { get; set; }

        [StringLength(40)]
        public string egr_adi { get; set; }

        [StringLength(25)]
        public string egr_tip_kodu { get; set; }

        [StringLength(25)]
        public string egr_alt_grup_kodu { get; set; }
    }
}
