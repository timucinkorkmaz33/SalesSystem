namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_EVRAKFORMLARI
    {
        [Key]
        public int cf_RECno { get; set; }

        public short cf_RECid_DBCno { get; set; }

        public int cf_RECid_RECno { get; set; }

        public int? cf_SpecRECno { get; set; }

        public bool? cf_iptal { get; set; }

        public short? cf_fileid { get; set; }

        public bool? cf_hidden { get; set; }

        public bool? cf_kilitli { get; set; }

        public bool? cf_degisti { get; set; }

        public int? cf_checksum { get; set; }

        public short? cf_create_user { get; set; }

        public DateTime? cf_create_date { get; set; }

        public short? cf_lastup_user { get; set; }

        public DateTime? cf_lastup_date { get; set; }

        [StringLength(4)]
        public string cf_special1 { get; set; }

        [StringLength(4)]
        public string cf_special2 { get; set; }

        [StringLength(4)]
        public string cf_special3 { get; set; }

        public byte? cf_formtipi { get; set; }

        [StringLength(25)]
        public string cf_carikodu { get; set; }

        [StringLength(80)]
        public string cf_yenitipformadi { get; set; }

        [StringLength(80)]
        public string cf_eskitipformadi { get; set; }
    }
}
