namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_ALT_GRUPLARI
    {
        [Key]
        public int sta_RECno { get; set; }

        public short sta_RECid_DBCno { get; set; }

        public int sta_RECid_RECno { get; set; }

        public int? sta_SpecRECno { get; set; }

        public bool? sta_iptal { get; set; }

        public short? sta_fileid { get; set; }

        public bool? sta_hidden { get; set; }

        public bool? sta_kilitli { get; set; }

        public bool? sta_degisti { get; set; }

        public int? sta_checksum { get; set; }

        public short? sta_create_user { get; set; }

        public DateTime? sta_create_date { get; set; }

        public short? sta_lastup_user { get; set; }

        public DateTime? sta_lastup_date { get; set; }

        [StringLength(4)]
        public string sta_special1 { get; set; }

        [StringLength(4)]
        public string sta_special2 { get; set; }

        [StringLength(4)]
        public string sta_special3 { get; set; }

        [StringLength(25)]
        public string sta_kod { get; set; }

        [StringLength(90)]
        public string sta_isim { get; set; }

        [StringLength(25)]
        public string sta_ana_grup_kod { get; set; }
    }
}
