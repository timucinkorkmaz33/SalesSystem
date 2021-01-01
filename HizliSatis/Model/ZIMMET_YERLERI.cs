namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZIMMET_YERLERI
    {
        [Key]
        public int zim_RECno { get; set; }

        public short zim_RECid_DBCno { get; set; }

        public int zim_RECid_RECno { get; set; }

        public int? zim_SpecRECno { get; set; }

        public bool? zim_iptal { get; set; }

        public short? zim_fileid { get; set; }

        public bool? zim_hidden { get; set; }

        public bool? zim_kilitli { get; set; }

        public bool? zim_degisti { get; set; }

        public int? zim_checksum { get; set; }

        public short? zim_create_user { get; set; }

        public DateTime? zim_create_date { get; set; }

        public short? zim_lastup_user { get; set; }

        public DateTime? zim_lastup_date { get; set; }

        [StringLength(4)]
        public string zim_special1 { get; set; }

        [StringLength(4)]
        public string zim_special2 { get; set; }

        [StringLength(4)]
        public string zim_special3 { get; set; }

        [StringLength(25)]
        public string zim_kod { get; set; }

        [StringLength(90)]
        public string zim_ismi { get; set; }
    }
}
