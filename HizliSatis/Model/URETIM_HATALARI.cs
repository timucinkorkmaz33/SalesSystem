namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_HATALARI
    {
        [Key]
        public int uh_RECno { get; set; }

        public short uh_RECid_DBCno { get; set; }

        public int uh_RECid_RECno { get; set; }

        public int? uh_SpecRECNo { get; set; }

        public bool? uh_iptal { get; set; }

        public short? uh_fileid { get; set; }

        public bool? uh_hidden { get; set; }

        public bool? uh_kilitli { get; set; }

        public bool? uh_degisti { get; set; }

        public int? uh_CheckSum { get; set; }

        public short? uh_create_user { get; set; }

        public DateTime? uh_create_date { get; set; }

        public short? uh_lastup_user { get; set; }

        public DateTime? uh_lastup_date { get; set; }

        [StringLength(4)]
        public string uh_special1 { get; set; }

        [StringLength(4)]
        public string uh_special2 { get; set; }

        [StringLength(4)]
        public string uh_special3 { get; set; }

        [StringLength(25)]
        public string uh_kod { get; set; }

        [StringLength(90)]
        public string uh_aciklama { get; set; }
    }
}
