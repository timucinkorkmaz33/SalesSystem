namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FINANSAL_SOZLESME_TAKSITLERI
    {
        [Key]
        public int FST_RECno { get; set; }

        public short FST_RECid_DBCno { get; set; }

        public int FST_RECid_RECno { get; set; }

        public int? FST_Spec_Rec_no { get; set; }

        public bool? FST_iptal { get; set; }

        public short? FST_fileid { get; set; }

        public bool? FST_hidden { get; set; }

        public bool? FST_kilitli { get; set; }

        public bool? FST_degisti { get; set; }

        public int? FST_checksum { get; set; }

        public short? FST_create_user { get; set; }

        public DateTime? FST_create_date { get; set; }

        public short? FST_lastup_user { get; set; }

        public DateTime? FST_lastup_date { get; set; }

        [StringLength(4)]
        public string FST_special1 { get; set; }

        [StringLength(4)]
        public string FST_special2 { get; set; }

        [StringLength(4)]
        public string FST_special3 { get; set; }

        [StringLength(25)]
        public string FST_sozkodu { get; set; }

        public short? FST_taksitno { get; set; }

        public DateTime? FST_vade { get; set; }

        public double? FST_anapara { get; set; }

        public double? FST_faiz { get; set; }

        public bool? FST_uzunvade { get; set; }

        [StringLength(6)]
        public string FST_faturaseri { get; set; }

        public int? FST_faturasira { get; set; }
    }
}
