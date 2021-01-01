namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_VARDIYA_SATISLARI
    {
        [Key]
        public int vp_RECno { get; set; }

        public short vp_RECid_DBCno { get; set; }

        public int vp_RECid_RECno { get; set; }

        public int? vp_SpecRECno { get; set; }

        public bool? vp_iptal { get; set; }

        public short? vp_fileid { get; set; }

        public bool? vp_hidden { get; set; }

        public bool? vp_kilitli { get; set; }

        public bool? vp_degisti { get; set; }

        public int? vp_checksum { get; set; }

        public short? vp_create_user { get; set; }

        public DateTime? vp_create_date { get; set; }

        public short? vp_lastup_user { get; set; }

        public DateTime? vp_lastup_date { get; set; }

        [StringLength(4)]
        public string vp_special1 { get; set; }

        [StringLength(4)]
        public string vp_special2 { get; set; }

        [StringLength(4)]
        public string vp_special3 { get; set; }

        public int? vp_firmano { get; set; }

        public int? vp_subeno { get; set; }

        public DateTime? vp_tarihi { get; set; }

        public byte? vp_Numarasi { get; set; }

        [StringLength(25)]
        public string vp_pers_kodu { get; set; }

        [StringLength(25)]
        public string vp_stok_kodu { get; set; }

        public double? vp_satis_miktari { get; set; }

        public double? vp_satis_tutari { get; set; }
    }
}
