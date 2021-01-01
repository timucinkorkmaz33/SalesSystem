namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_FIS_GRUBU_TANIMLARI
    {
        [Key]
        public int mfg_RECno { get; set; }

        public short mfg_RECid_DBCno { get; set; }

        public int mfg_RECid_RECno { get; set; }

        public int? mfg_SpecRECno { get; set; }

        public bool? mfg_iptal { get; set; }

        public short? mfg_fileid { get; set; }

        public bool? mfg_hidden { get; set; }

        public bool? mfg_kilitli { get; set; }

        public bool? mfg_degisti { get; set; }

        public int? mfg_checksum { get; set; }

        public short? mfg_create_user { get; set; }

        public DateTime? mfg_create_date { get; set; }

        public short? mfg_lastup_user { get; set; }

        public DateTime? mfg_lastup_date { get; set; }

        [StringLength(4)]
        public string mfg_special1 { get; set; }

        [StringLength(4)]
        public string mfg_special2 { get; set; }

        [StringLength(4)]
        public string mfg_special3 { get; set; }

        [StringLength(4)]
        public string mfg_kodu { get; set; }

        [StringLength(30)]
        public string mfg_aciklama { get; set; }
    }
}
