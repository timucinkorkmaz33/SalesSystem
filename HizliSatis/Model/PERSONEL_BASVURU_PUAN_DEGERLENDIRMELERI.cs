namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BASVURU_PUAN_DEGERLENDIRMELERI
    {
        [Key]
        public int bsd_RECno { get; set; }

        public short bsd_RECid_DBCno { get; set; }

        public int bsd_RECid_RECno { get; set; }

        public int? bsd_SpecRECno { get; set; }

        public bool? bsd_iptal { get; set; }

        public short? bsd_fileid { get; set; }

        public bool? bsd_hidden { get; set; }

        public bool? bsd_kilitli { get; set; }

        public bool? bsd_degisti { get; set; }

        public int? bsd_checksum { get; set; }

        public short? bsd_create_user { get; set; }

        public DateTime? bsd_create_date { get; set; }

        public short? bsd_lastup_user { get; set; }

        public DateTime? bsd_lastup_date { get; set; }

        [StringLength(4)]
        public string bsd_special1 { get; set; }

        [StringLength(4)]
        public string bsd_special2 { get; set; }

        [StringLength(4)]
        public string bsd_special3 { get; set; }

        public DateTime? bsd_tarih { get; set; }

        [StringLength(25)]
        public string bsd_per_kodu { get; set; }

        public int? bsd_bas_RECno { get; set; }

        [StringLength(25)]
        public string bsd_puan_kodu { get; set; }

        public double? bsd_puan { get; set; }

        [StringLength(80)]
        public string bsd_aciklama { get; set; }
    }
}
