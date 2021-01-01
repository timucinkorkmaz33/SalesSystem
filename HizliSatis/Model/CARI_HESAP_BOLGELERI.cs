namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_BOLGELERI
    {
        [Key]
        public int bol_RECno { get; set; }

        public short bol_RECid_DBCno { get; set; }

        public int bol_RECid_RECno { get; set; }

        public int? bol_SpecRECno { get; set; }

        public bool? bol_iptal { get; set; }

        public short? bol_fileid { get; set; }

        public bool? bol_hidden { get; set; }

        public bool? bol_kilitli { get; set; }

        public bool? bol_degisti { get; set; }

        public int? bol_checksum { get; set; }

        public short? bol_create_user { get; set; }

        public DateTime? bol_create_date { get; set; }

        public short? bol_lastup_user { get; set; }

        public DateTime? bol_lastup_date { get; set; }

        [StringLength(4)]
        public string bol_special1 { get; set; }

        [StringLength(4)]
        public string bol_special2 { get; set; }

        [StringLength(4)]
        public string bol_special3 { get; set; }

        [StringLength(25)]
        public string bol_kod { get; set; }

        [StringLength(90)]
        public string bol_ismi { get; set; }
    }
}
