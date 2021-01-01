namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IHRACAAT_KREDILERI
    {
        [Key]
        public int ihk_RECno { get; set; }

        public short ihk_RECid_DBCno { get; set; }

        public int ihk_RECid_RECno { get; set; }

        public int? ihk_SpecRECNo { get; set; }

        public bool? ihk_iptal { get; set; }

        public short? ihk_fileid { get; set; }

        public bool? ihk_hidden { get; set; }

        public bool? ihk_kilitli { get; set; }

        public bool? ihk_degisti { get; set; }

        public int? ihk_CheckSum { get; set; }

        public short? ihk_create_user { get; set; }

        public DateTime? ihk_create_date { get; set; }

        public short? ihk_lastup_user { get; set; }

        public DateTime? ihk_lastup_date { get; set; }

        [StringLength(4)]
        public string ihk_special1 { get; set; }

        [StringLength(4)]
        public string ihk_special2 { get; set; }

        [StringLength(4)]
        public string ihk_special3 { get; set; }

        [StringLength(4)]
        public string ihk_kodu { get; set; }

        [StringLength(40)]
        public string ihk_adi { get; set; }

        [StringLength(25)]
        public string ihk_bankakodu { get; set; }

        public double? ihk_tutar { get; set; }

        public byte? ihk_dovizcinsi { get; set; }

        public double? ihk_doviztutar { get; set; }

        public double? ihk_usdtutar { get; set; }

        public double? ihk_faizorani { get; set; }

        public double? ihk_faiztutari { get; set; }

        public DateTime? ihk_alindigitarih { get; set; }

        public DateTime? ihk_odemetarih { get; set; }

        public double? ihk_kapananusdtutar { get; set; }
    }
}
