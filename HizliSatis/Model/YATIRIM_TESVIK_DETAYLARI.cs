namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YATIRIM_TESVIK_DETAYLARI
    {
        [Key]
        public int YTD_RECno { get; set; }

        public short YTD_RECid_DBCno { get; set; }

        public int YTD_RECid_RECno { get; set; }

        public int? YTD_SpecRECno { get; set; }

        public bool? YTD_iptal { get; set; }

        public short? YTD_fileid { get; set; }

        public bool? YTD_hidden { get; set; }

        public bool? YTD_kilitli { get; set; }

        public bool? YTD_degisti { get; set; }

        public int? YTD_checksum { get; set; }

        public short? YTD_create_user { get; set; }

        public DateTime? YTD_create_date { get; set; }

        public short? YTD_lastup_user { get; set; }

        public DateTime? YTD_lastup_date { get; set; }

        [StringLength(4)]
        public string YTD_special1 { get; set; }

        [StringLength(4)]
        public string YTD_special2 { get; set; }

        [StringLength(4)]
        public string YTD_special3 { get; set; }

        [StringLength(25)]
        public string YTD_YTKodu { get; set; }

        public int? YTD_SatirNo { get; set; }

        public byte? YTD_Cinsi { get; set; }

        [StringLength(25)]
        public string YTD_CinsKodu { get; set; }

        public byte? YTD_TeminCinsi { get; set; }

        public double? YTD_Miktar { get; set; }

        public double? YTD_Tutari { get; set; }

        public double? YTD_KDVTutari { get; set; }

        public bool? YTD_KDVIstKap_fl { get; set; }

        public byte? YTD_MenseDoviz { get; set; }

        public double? YTD_MenseKuru { get; set; }

        public double? YTD_FobKuru { get; set; }

        [StringLength(10)]
        public string YTD_muhkodartikeli { get; set; }

        public double? YTD_faturalasmismiktar { get; set; }
    }
}
