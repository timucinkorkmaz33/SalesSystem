namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YUKLEME_KABUL
    {
        [Key]
        public int yk_RECno { get; set; }

        public short yk_RECid_DBCno { get; set; }

        public int yk_RECid_RECno { get; set; }

        public int? yk_SpecRECno { get; set; }

        public bool? yk_iptal { get; set; }

        public short? yk_fileid { get; set; }

        public bool? yk_hidden { get; set; }

        public bool? yk_kilitli { get; set; }

        public bool? yk_degisti { get; set; }

        public int? yk_checksum { get; set; }

        public short? yk_create_user { get; set; }

        public DateTime? yk_create_date { get; set; }

        public short? yk_lastup_user { get; set; }

        public DateTime? yk_lastup_date { get; set; }

        [StringLength(4)]
        public string yk_special1 { get; set; }

        [StringLength(4)]
        public string yk_special2 { get; set; }

        [StringLength(4)]
        public string yk_special3 { get; set; }

        public byte? yk_tipi { get; set; }

        [StringLength(25)]
        public string yk_kodu { get; set; }

        [StringLength(25)]
        public string yk_plaka { get; set; }

        [StringLength(127)]
        public string yk_aciklama { get; set; }

        public DateTime? yk_tarihi { get; set; }

        public DateTime? yk_sevktarihi { get; set; }
    }
}
