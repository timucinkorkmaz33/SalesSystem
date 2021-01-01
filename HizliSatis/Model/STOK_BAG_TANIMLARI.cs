namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_BAG_TANIMLARI
    {
        [Key]
        public int bag_RECno { get; set; }

        public short bag_RECid_DBCno { get; set; }

        public int bag_RECid_RECno { get; set; }

        public int? bag_Spec_Rec_no { get; set; }

        public bool? bag_iptal { get; set; }

        public short? bag_fileid { get; set; }

        public bool? bag_hidden { get; set; }

        public bool? bag_kilitli { get; set; }

        public bool? bag_degisti { get; set; }

        public int? bag_checksum { get; set; }

        public short? bag_create_user { get; set; }

        public DateTime? bag_create_date { get; set; }

        public short? bag_lastup_user { get; set; }

        public DateTime? bag_lastup_date { get; set; }

        [StringLength(4)]
        public string bag_special1 { get; set; }

        [StringLength(4)]
        public string bag_special2 { get; set; }

        [StringLength(4)]
        public string bag_special3 { get; set; }

        [StringLength(25)]
        public string bag_kodu { get; set; }

        [StringLength(25)]
        public string bag_stokkodu { get; set; }

        [StringLength(25)]
        public string bag_partikodu { get; set; }

        public int? bag_lotno { get; set; }

        [StringLength(80)]
        public string bag_aciklama1 { get; set; }

        [StringLength(80)]
        public string bag_aciklama2 { get; set; }

        public double? bag_miktar { get; set; }

        public double? bag_miktar2 { get; set; }

        public short? bag_HarRecID_DBCno { get; set; }

        public int? bag_HarRecID_RECno { get; set; }
    }
}
