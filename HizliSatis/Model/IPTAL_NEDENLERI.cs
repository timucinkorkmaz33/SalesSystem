namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IPTAL_NEDENLERI
    {
        [Key]
        public int ipt_RECno { get; set; }

        public short ipt_RECid_DBCno { get; set; }

        public int ipt_RECid_RECno { get; set; }

        public int? ipt_SpecRECno { get; set; }

        public bool? ipt_iptal { get; set; }

        public short? ipt_fileid { get; set; }

        public bool? ipt_hidden { get; set; }

        public bool? ipt_kilitli { get; set; }

        public bool? ipt_degisti { get; set; }

        public int? ipt_checksum { get; set; }

        public short? ipt_create_user { get; set; }

        public DateTime? ipt_create_date { get; set; }

        public short? ipt_lastup_user { get; set; }

        public DateTime? ipt_lastup_date { get; set; }

        [StringLength(4)]
        public string ipt_special1 { get; set; }

        [StringLength(4)]
        public string ipt_special2 { get; set; }

        [StringLength(4)]
        public string ipt_special3 { get; set; }

        [StringLength(25)]
        public string ipt_kodu { get; set; }

        [StringLength(50)]
        public string ipt_adi { get; set; }
    }
}
