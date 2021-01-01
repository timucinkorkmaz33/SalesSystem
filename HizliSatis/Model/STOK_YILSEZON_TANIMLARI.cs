namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_YILSEZON_TANIMLARI
    {
        [Key]
        public int ysn_RECno { get; set; }

        public short ysn_RECid_DBCno { get; set; }

        public int ysn_RECid_RECno { get; set; }

        public int? ysn_SpecRECNo { get; set; }

        public bool? ysn_iptal { get; set; }

        public short? ysn_fileid { get; set; }

        public bool? ysn_hidden { get; set; }

        public bool? ysn_kilitli { get; set; }

        public bool? ysn_degisti { get; set; }

        public int? ysn_CheckSum { get; set; }

        public short? ysn_create_user { get; set; }

        public DateTime? ysn_create_date { get; set; }

        public short? ysn_lastup_user { get; set; }

        public DateTime? ysn_lastup_date { get; set; }

        [StringLength(4)]
        public string ysn_special1 { get; set; }

        [StringLength(4)]
        public string ysn_special2 { get; set; }

        [StringLength(4)]
        public string ysn_special3 { get; set; }

        [StringLength(25)]
        public string ysn_kodu { get; set; }

        [StringLength(90)]
        public string ysn_ismi { get; set; }
    }
}
