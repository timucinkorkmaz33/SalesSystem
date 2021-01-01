namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SORUMLULUK_TANIMLARI
    {
        [Key]
        public int sr_RECno { get; set; }

        public short sr_RECid_DBCno { get; set; }

        public int sr_RECid_RECno { get; set; }

        public int? sr_SpecRECno { get; set; }

        public bool? sr_iptal { get; set; }

        public short? sr_fileid { get; set; }

        public bool? sr_hidden { get; set; }

        public bool? sr_kilitli { get; set; }

        public bool? sr_degisti { get; set; }

        public int? sr_checksum { get; set; }

        public short? sr_create_user { get; set; }

        public DateTime? sr_create_date { get; set; }

        public short? sr_lastup_user { get; set; }

        public DateTime? sr_lastup_date { get; set; }

        [StringLength(4)]
        public string sr_special1 { get; set; }

        [StringLength(4)]
        public string sr_special2 { get; set; }

        [StringLength(4)]
        public string sr_special3 { get; set; }

        [StringLength(25)]
        public string sr_kod { get; set; }

        [StringLength(40)]
        public string sr_aciklama { get; set; }
    }
}
