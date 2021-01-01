namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BELGE_TANIMLARI
    {
        [Key]
        public int bel_RECno { get; set; }

        public short bel_RECid_DBCno { get; set; }

        public int bel_RECid_RECno { get; set; }

        public int? bel_SpecRECno { get; set; }

        public bool? bel_iptal { get; set; }

        public short? bel_fileid { get; set; }

        public bool? bel_hidden { get; set; }

        public bool? bel_kilitli { get; set; }

        public bool? bel_degisti { get; set; }

        public int? bel_checksum { get; set; }

        public short? bel_create_user { get; set; }

        public DateTime? bel_create_date { get; set; }

        public short? bel_lastup_user { get; set; }

        public DateTime? bel_lastup_date { get; set; }

        [StringLength(4)]
        public string bel_special1 { get; set; }

        [StringLength(4)]
        public string bel_special2 { get; set; }

        [StringLength(4)]
        public string bel_special3 { get; set; }

        [StringLength(25)]
        public string bel_kod { get; set; }

        [StringLength(40)]
        public string bel_isim { get; set; }
    }
}
