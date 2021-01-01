namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PARTILOT")]
    public partial class PARTILOT
    {
        [Key]
        public int pl_RECno { get; set; }

        public short pl_RECid_DBCno { get; set; }

        public int pl_RECid_RECno { get; set; }

        public int? pl_SpecRECno { get; set; }

        public bool? pl_iptal { get; set; }

        public short? pl_fileid { get; set; }

        public bool? pl_hidden { get; set; }

        public bool? pl_kilitli { get; set; }

        public bool? pl_degisti { get; set; }

        public int? pl_checksum { get; set; }

        public short? pl_create_user { get; set; }

        public DateTime? pl_create_date { get; set; }

        public short? pl_lastup_user { get; set; }

        public DateTime? pl_lastup_date { get; set; }

        [StringLength(4)]
        public string pl_ozelkod1 { get; set; }

        [StringLength(4)]
        public string pl_ozelkod2 { get; set; }

        [StringLength(4)]
        public string pl_ozelkod3 { get; set; }

        [StringLength(25)]
        public string pl_partikodu { get; set; }

        public int? pl_lotno { get; set; }

        [StringLength(25)]
        public string pl_stokkodu { get; set; }

        [StringLength(50)]
        public string pl_aciklama { get; set; }

        public double? pl_olckalkdeg_deg1 { get; set; }

        public double? pl_olckalkdeg_deg2 { get; set; }

        public double? pl_olckalkdeg_deg3 { get; set; }

        public double? pl_olckalkdeg_deg4 { get; set; }

        public double? pl_olckalkdeg_deg5 { get; set; }

        public double? pl_olckalkdeg_deg6 { get; set; }

        public double? pl_olckalkdeg_deg7 { get; set; }

        public double? pl_olckalkdeg_deg8 { get; set; }

        public double? pl_olckalkdeg_deg9 { get; set; }

        public double? pl_olckalkdeg_deg10 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama1 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama2 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama3 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama4 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama5 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama6 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama7 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama8 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama9 { get; set; }

        [StringLength(25)]
        public string pl_olckalkdeg_aciklama10 { get; set; }

        public DateTime? pl_son_kullanim_tar { get; set; }

        public double? pl_DaraliKilo { get; set; }

        public double? pl_SafiKilo { get; set; }

        public double? pl_En { get; set; }

        public double? pl_Boy { get; set; }

        public double? pl_Yukseklik { get; set; }

        public double? pl_OzgulAgirlik { get; set; }

        [StringLength(25)]
        public string pl_kod1 { get; set; }

        [StringLength(25)]
        public string pl_kod2 { get; set; }

        [StringLength(25)]
        public string pl_kod3 { get; set; }

        [StringLength(25)]
        public string pl_kod4 { get; set; }

        [StringLength(25)]
        public string pl_kod5 { get; set; }

        [StringLength(25)]
        public string pl_kod6 { get; set; }

        [StringLength(25)]
        public string pl_kod7 { get; set; }

        [StringLength(25)]
        public string pl_kod8 { get; set; }

        [StringLength(25)]
        public string pl_kod9 { get; set; }

        [StringLength(25)]
        public string pl_kod10 { get; set; }
    }
}
