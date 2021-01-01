namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGITIM_ALT_GRUP_TANIMLARI
    {
        [Key]
        public int eag_RECno { get; set; }

        public short eag_RECid_DBCno { get; set; }

        public int eag_RECid_RECno { get; set; }

        public int? eag_SpecRECno { get; set; }

        public bool? eag_iptal { get; set; }

        public short? eag_fileid { get; set; }

        public bool? eag_hidden { get; set; }

        public bool? eag_kilitli { get; set; }

        public bool? eag_degisti { get; set; }

        public int? eag_checksum { get; set; }

        public short? eag_create_user { get; set; }

        public DateTime? eag_create_date { get; set; }

        public short? eag_lastup_user { get; set; }

        public DateTime? eag_lastup_date { get; set; }

        [StringLength(4)]
        public string eag_special1 { get; set; }

        [StringLength(4)]
        public string eag_special2 { get; set; }

        [StringLength(4)]
        public string eag_special3 { get; set; }

        public int? eag_firmano { get; set; }

        public int? eag_subeno { get; set; }

        [StringLength(25)]
        public string eag_kod { get; set; }

        [StringLength(40)]
        public string eag_adi { get; set; }

        [StringLength(25)]
        public string eag_egitim_kodu { get; set; }
    }
}
