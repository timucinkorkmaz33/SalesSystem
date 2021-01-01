namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SINAV_GRUPLARI
    {
        [Key]
        public int sng_RECno { get; set; }

        public short sng_RECid_DBCno { get; set; }

        public int sng_RECid_RECno { get; set; }

        public int? sng_SpecRECno { get; set; }

        public bool? sng_iptal { get; set; }

        public short? sng_fileid { get; set; }

        public bool? sng_hidden { get; set; }

        public bool? sng_kilitli { get; set; }

        public bool? sng_degisti { get; set; }

        public int? sng_checksum { get; set; }

        public short? sng_create_user { get; set; }

        public DateTime? sng_create_date { get; set; }

        public short? sng_lastup_user { get; set; }

        public DateTime? sng_lastup_date { get; set; }

        [StringLength(4)]
        public string sng_special1 { get; set; }

        [StringLength(4)]
        public string sng_special2 { get; set; }

        [StringLength(4)]
        public string sng_special3 { get; set; }

        [StringLength(25)]
        public string sng_kodu { get; set; }

        [StringLength(40)]
        public string sng_adi { get; set; }

        [StringLength(25)]
        public string sng_anagrupkodu { get; set; }
    }
}
