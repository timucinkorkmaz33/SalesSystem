namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_GOREV_TANIMLARI
    {
        [Key]
        public int pgk_RECno { get; set; }

        public short pgk_RECid_DBCno { get; set; }

        public int pgk_RECid_RECno { get; set; }

        public int? pgk_SpecRECno { get; set; }

        public bool? pgk_iptal { get; set; }

        public short? pgk_fileid { get; set; }

        public bool? pgk_hidden { get; set; }

        public bool? pgk_kilitli { get; set; }

        public bool? pgk_degisti { get; set; }

        public int? pgk_checksum { get; set; }

        public short? pgk_create_user { get; set; }

        public DateTime? pgk_create_date { get; set; }

        public short? pgk_lastup_user { get; set; }

        public DateTime? pgk_lastup_date { get; set; }

        [StringLength(4)]
        public string pgk_special1 { get; set; }

        [StringLength(4)]
        public string pgk_special2 { get; set; }

        [StringLength(4)]
        public string pgk_special3 { get; set; }

        [StringLength(25)]
        public string pgk_gorev_kodu { get; set; }

        [StringLength(50)]
        public string pgk_gorev_adi { get; set; }
    }
}
