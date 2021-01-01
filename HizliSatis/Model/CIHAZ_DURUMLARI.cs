namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIHAZ_DURUMLARI
    {
        [Key]
        public int cdr_RECno { get; set; }

        public short cdr_RECid_DBCno { get; set; }

        public int cdr_RECid_RECno { get; set; }

        public int? cdr_SpecRECno { get; set; }

        public bool? cdr_iptal { get; set; }

        public short? cdr_fileid { get; set; }

        public bool? cdr_hidden { get; set; }

        public bool? cdr_kilitli { get; set; }

        public bool? cdr_degisti { get; set; }

        public int? cdr_checksum { get; set; }

        public short? cdr_create_user { get; set; }

        public DateTime? cdr_create_date { get; set; }

        public short? cdr_lastup_user { get; set; }

        public DateTime? cdr_lastup_date { get; set; }

        [StringLength(4)]
        public string cdr_special1 { get; set; }

        [StringLength(4)]
        public string cdr_special2 { get; set; }

        [StringLength(4)]
        public string cdr_special3 { get; set; }

        [StringLength(25)]
        public string cdr_kod { get; set; }

        [StringLength(50)]
        public string cdr_isim { get; set; }
    }
}
