namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_MODEL_TANIMLARI
    {
        [Key]
        public int mdl_RECno { get; set; }

        public short mdl_RECid_DBCno { get; set; }

        public int mdl_RECid_RECno { get; set; }

        public int? mdl_SpecRECNo { get; set; }

        public bool? mdl_iptal { get; set; }

        public short? mdl_fileid { get; set; }

        public bool? mdl_hidden { get; set; }

        public bool? mdl_kilitli { get; set; }

        public bool? mdl_degisti { get; set; }

        public int? mdl_CheckSum { get; set; }

        public short? mdl_create_user { get; set; }

        public DateTime? mdl_create_date { get; set; }

        public short? mdl_lastup_user { get; set; }

        public DateTime? mdl_lastup_date { get; set; }

        [StringLength(4)]
        public string mdl_special1 { get; set; }

        [StringLength(4)]
        public string mdl_special2 { get; set; }

        [StringLength(4)]
        public string mdl_special3 { get; set; }

        [StringLength(25)]
        public string mdl_kodu { get; set; }

        [StringLength(90)]
        public string mdl_ismi { get; set; }
    }
}
