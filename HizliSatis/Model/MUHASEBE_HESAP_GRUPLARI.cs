namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_HESAP_GRUPLARI
    {
        [Key]
        public int mhg_RECno { get; set; }

        public short mhg_RECid_DBCno { get; set; }

        public int mhg_RECid_RECno { get; set; }

        public int? mhg_SpecRECno { get; set; }

        public bool? mhg_iptal { get; set; }

        public short? mhg_fileid { get; set; }

        public bool? mhg_hidden { get; set; }

        public bool? mhg_kilitli { get; set; }

        public bool? mhg_degisti { get; set; }

        public int? mhg_checksum { get; set; }

        public short? mhg_create_user { get; set; }

        public DateTime? mhg_create_date { get; set; }

        public short? mhg_lastup_user { get; set; }

        public DateTime? mhg_lastup_date { get; set; }

        [StringLength(4)]
        public string mhg_special1 { get; set; }

        [StringLength(4)]
        public string mhg_special2 { get; set; }

        [StringLength(4)]
        public string mhg_special3 { get; set; }

        [StringLength(4)]
        public string mhg_kodu { get; set; }

        [StringLength(40)]
        public string mhg_aciklama { get; set; }
    }
}
