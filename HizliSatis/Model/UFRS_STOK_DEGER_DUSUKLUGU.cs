namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UFRS_STOK_DEGER_DUSUKLUGU
    {
        [Key]
        public int usdd_RECno { get; set; }

        public short usdd_RECid_DBCno { get; set; }

        public int usdd_RECid_RECno { get; set; }

        public int? usdd_SpecRECno { get; set; }

        public bool? usdd_iptal { get; set; }

        public short? usdd_fileid { get; set; }

        public bool? usdd_hidden { get; set; }

        public bool? usdd_kilitli { get; set; }

        public bool? usdd_degisti { get; set; }

        public int? usdd_checksum { get; set; }

        public short? usdd_create_user { get; set; }

        public DateTime? usdd_create_date { get; set; }

        public short? usdd_lastup_user { get; set; }

        public DateTime? usdd_lastup_date { get; set; }

        [StringLength(4)]
        public string usdd_special1 { get; set; }

        [StringLength(4)]
        public string usdd_special2 { get; set; }

        [StringLength(4)]
        public string usdd_special3 { get; set; }

        public DateTime? usdd_tarih { get; set; }

        public int? usdd_satirno { get; set; }

        [StringLength(25)]
        public string usdd_stokkodu { get; set; }

        public int? usdd_depono { get; set; }

        public double? usdd_envantermiktar { get; set; }

        public double? usdd_envanterdeger { get; set; }

        public double? usdd_piyasadegeri { get; set; }

        public double? usdd_degerfarki { get; set; }

        public byte? usdd_stokdcinsi { get; set; }

        public double? usdd_stokdkur { get; set; }

        public byte? usdd_hardcinsi { get; set; }

        public double? usdd_hardkur { get; set; }

        public double? usdd_altdkur { get; set; }
    }
}
