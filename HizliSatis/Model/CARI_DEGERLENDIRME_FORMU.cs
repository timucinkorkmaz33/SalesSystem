namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_DEGERLENDIRME_FORMU
    {
        [Key]
        public int cdf_RECno { get; set; }

        public short cdf_RECid_DBCno { get; set; }

        public int cdf_RECid_RECno { get; set; }

        public int? cdf_SpecRECno { get; set; }

        public bool? cdf_iptal { get; set; }

        public short? cdf_fileid { get; set; }

        public bool? cdf_hidden { get; set; }

        public bool? cdf_kilitli { get; set; }

        public bool? cdf_degisti { get; set; }

        public int? cdf_checksum { get; set; }

        public short? cdf_create_user { get; set; }

        public DateTime? cdf_create_date { get; set; }

        public short? cdf_lastup_user { get; set; }

        public DateTime? cdf_lastup_date { get; set; }

        [StringLength(4)]
        public string cdf_special1 { get; set; }

        [StringLength(4)]
        public string cdf_special2 { get; set; }

        [StringLength(4)]
        public string cdf_special3 { get; set; }

        [StringLength(25)]
        public string cdf_form_kodu { get; set; }

        [StringLength(25)]
        public string cdf_cari_kodu { get; set; }

        public int? cdf_satirno { get; set; }

        public DateTime? cdf_tarih { get; set; }

        [StringLength(25)]
        public string cdf_kriter_kodu { get; set; }

        public double? cdf_puan { get; set; }

        public byte? cdf_sozelpuan { get; set; }
    }
}
