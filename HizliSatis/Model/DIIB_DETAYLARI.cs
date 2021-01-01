namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIIB_DETAYLARI
    {
        [Key]
        public int dd_RECno { get; set; }

        public short dd_RECid_DBCno { get; set; }

        public int dd_RECid_RECno { get; set; }

        public int? dd_SpecRecNo { get; set; }

        public bool? dd_iptal { get; set; }

        public short? dd_fileid { get; set; }

        public bool? dd_hidden { get; set; }

        public bool? dd_kilitli { get; set; }

        public bool? dd_degisti { get; set; }

        public int? dd_checksum { get; set; }

        public short? dd_create_user { get; set; }

        public DateTime? dd_create_date { get; set; }

        public short? dd_lastup_user { get; set; }

        public DateTime? dd_lastup_date { get; set; }

        [StringLength(4)]
        public string dd_special1 { get; set; }

        [StringLength(4)]
        public string dd_special2 { get; set; }

        [StringLength(4)]
        public string dd_special3 { get; set; }

        [StringLength(25)]
        public string dd_nosu { get; set; }

        public byte? dd_tip { get; set; }

        public int? dd_sirano { get; set; }

        [StringLength(25)]
        public string dd_gtip { get; set; }

        public double? dd_miktar { get; set; }

        public double? dd_USD_tutar { get; set; }

        public double? dd_tam_USD_tutar { get; set; }

        public double? dd_tam_AB_miktar { get; set; }

        public double? dd_tam_AU_miktar { get; set; }

        public double? dd_tam_3ulke_miktar { get; set; }

        public double? dd_tam_dahili_miktar { get; set; }

        public double? dd_miktar2 { get; set; }

        public double? dd_tam_AB_miktar2 { get; set; }

        public double? dd_tam_AU_miktar2 { get; set; }

        public double? dd_tam_3ulke_miktar2 { get; set; }

        public double? dd_tam_dahili_miktar2 { get; set; }

        [StringLength(127)]
        public string dd_KapEsya { get; set; }
    }
}
