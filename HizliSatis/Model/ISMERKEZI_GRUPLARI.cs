namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISMERKEZI_GRUPLARI
    {
        [Key]
        public int imgr_RECno { get; set; }

        public short imgr_RECid_DBCno { get; set; }

        public int imgr_RECid_RECno { get; set; }

        public int? imgr_SpecRECNo { get; set; }

        public bool? imgr_iptal { get; set; }

        public short? imgr_fileid { get; set; }

        public bool? imgr_hidden { get; set; }

        public bool? imgr_kilitli { get; set; }

        public bool? imgr_degisti { get; set; }

        public int? imgr_CheckSum { get; set; }

        public short? imgr_create_user { get; set; }

        public DateTime? imgr_create_date { get; set; }

        public short? imgr_lastup_user { get; set; }

        public DateTime? imgr_lastup_date { get; set; }

        [StringLength(4)]
        public string imgr_special1 { get; set; }

        [StringLength(4)]
        public string imgr_special2 { get; set; }

        [StringLength(4)]
        public string imgr_special3 { get; set; }

        [StringLength(4)]
        public string imgr_kod { get; set; }

        [StringLength(90)]
        public string imgr_isim { get; set; }
    }
}
