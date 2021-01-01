namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_TASIT_PLAKALARI
    {
        [Key]
        public int plk_RECno { get; set; }

        public short plk_RECid_DBCno { get; set; }

        public int plk_RECid_RECno { get; set; }

        public int? plk_SpecRECno { get; set; }

        public bool? plk_iptal { get; set; }

        public short? plk_fileid { get; set; }

        public bool? plk_hidden { get; set; }

        public bool? plk_kilitli { get; set; }

        public bool? plk_degisti { get; set; }

        public int? plk_checksum { get; set; }

        public short? plk_create_user { get; set; }

        public DateTime? plk_create_date { get; set; }

        public short? plk_lastup_user { get; set; }

        public DateTime? plk_lastup_date { get; set; }

        [StringLength(4)]
        public string plk_special1 { get; set; }

        [StringLength(4)]
        public string plk_special2 { get; set; }

        [StringLength(4)]
        public string plk_special3 { get; set; }

        [StringLength(25)]
        public string plk_kod { get; set; }

        [StringLength(30)]
        public string plk_arac { get; set; }

        [StringLength(25)]
        public string plk_musterikodu { get; set; }
    }
}
