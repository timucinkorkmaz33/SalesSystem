namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TAKVIM_VARDIYA_DETAYLARI
    {
        [Key]
        public int takvimhr_RECno { get; set; }

        public short? takvimhr_RECid_DBCno { get; set; }

        public int takvimhr_RECid_RECno { get; set; }

        public int? takvimhr_SpecRECNo { get; set; }

        public bool? takvimhr_iptal { get; set; }

        public short? takvimhr_fileid { get; set; }

        public bool? takvimhr_hidden { get; set; }

        public bool? takvimhr_kilitli { get; set; }

        public bool? takvimhr_degisti { get; set; }

        public int? takvimhr_CheckSum { get; set; }

        public short? takvimhr_create_user { get; set; }

        public DateTime? takvimhr_create_date { get; set; }

        public short? takvimhr_lastup_user { get; set; }

        public DateTime? takvimhr_lastup_date { get; set; }

        [StringLength(4)]
        public string takvimhr_special1 { get; set; }

        [StringLength(4)]
        public string takvimhr_special2 { get; set; }

        [StringLength(4)]
        public string takvimhr_special3 { get; set; }

        [StringLength(4)]
        public string takvimhr_takkodu { get; set; }

        public DateTime? takvimhr_tarih { get; set; }

        [StringLength(25)]
        public string takvimhr_vardkodu { get; set; }
    }
}
