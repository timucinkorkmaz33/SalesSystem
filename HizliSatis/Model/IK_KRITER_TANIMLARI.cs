namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IK_KRITER_TANIMLARI
    {
        [Key]
        public int ikk_RECno { get; set; }

        public short ikk_RECid_DBCno { get; set; }

        public int ikk_RECid_RECno { get; set; }

        public int? ikk_SpecRECno { get; set; }

        public bool? ikk_iptal { get; set; }

        public short? ikk_fileid { get; set; }

        public bool? ikk_hidden { get; set; }

        public bool? ikk_kilitli { get; set; }

        public bool? ikk_degisti { get; set; }

        public int? ikk_checksum { get; set; }

        public short? ikk_create_user { get; set; }

        public DateTime? ikk_create_date { get; set; }

        public short? ikk_lastup_user { get; set; }

        public DateTime? ikk_lastup_date { get; set; }

        [StringLength(4)]
        public string ikk_special1 { get; set; }

        [StringLength(4)]
        public string ikk_special2 { get; set; }

        [StringLength(4)]
        public string ikk_special3 { get; set; }

        public int? ikk_firmano { get; set; }

        public int? ikk_subeno { get; set; }

        public byte? ikk_tipi { get; set; }

        [StringLength(25)]
        public string ikk_kodu { get; set; }

        [StringLength(70)]
        public string ikk_adi { get; set; }

        [StringLength(120)]
        public string ikk_uzunadi { get; set; }

        [StringLength(120)]
        public string ikk_aciklama1 { get; set; }

        [StringLength(120)]
        public string ikk_aciklama2 { get; set; }

        [StringLength(120)]
        public string ikk_aciklama3 { get; set; }

        public double? ikk_maxpuan { get; set; }

        public double? ikk_agirlikOrt { get; set; }
    }
}
