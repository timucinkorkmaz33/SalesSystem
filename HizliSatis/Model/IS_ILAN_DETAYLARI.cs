namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IS_ILAN_DETAYLARI
    {
        [Key]
        public int ild_RECno { get; set; }

        public short ild_RECid_DBCno { get; set; }

        public int ild_RECid_RECno { get; set; }

        public int? ild_SpecRECno { get; set; }

        public bool? ild_iptal { get; set; }

        public short? ild_fileid { get; set; }

        public bool? ild_hidden { get; set; }

        public bool? ild_kilitli { get; set; }

        public bool? ild_degisti { get; set; }

        public int? ild_checksum { get; set; }

        public short? ild_create_user { get; set; }

        public DateTime? ild_create_date { get; set; }

        public short? ild_lastup_user { get; set; }

        public DateTime? ild_lastup_date { get; set; }

        [StringLength(4)]
        public string ild_special1 { get; set; }

        [StringLength(4)]
        public string ild_special2 { get; set; }

        [StringLength(4)]
        public string ild_special3 { get; set; }

        [StringLength(25)]
        public string ild_ilan_kodu { get; set; }

        public byte? ild_tipi { get; set; }

        [StringLength(25)]
        public string ild_kodu { get; set; }

        [StringLength(25)]
        public string ild_ilcekodu { get; set; }

        [StringLength(120)]
        public string ild_aciklama1 { get; set; }

        [StringLength(120)]
        public string ild_aciklama2 { get; set; }

        [StringLength(120)]
        public string ild_aciklama3 { get; set; }
    }
}
