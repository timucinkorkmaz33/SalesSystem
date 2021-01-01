namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IK_FORMU
    {
        [Key]
        public int ikf_RECno { get; set; }

        public short ikf_RECid_DBCno { get; set; }

        public int ikf_RECid_RECno { get; set; }

        public int? ikf_SpecRECno { get; set; }

        public bool? ikf_iptal { get; set; }

        public short? ikf_fileid { get; set; }

        public bool? ikf_hidden { get; set; }

        public bool? ikf_kilitli { get; set; }

        public bool? ikf_degisti { get; set; }

        public int? ikf_checksum { get; set; }

        public short? ikf_create_user { get; set; }

        public DateTime? ikf_create_date { get; set; }

        public short? ikf_lastup_user { get; set; }

        public DateTime? ikf_lastup_date { get; set; }

        [StringLength(4)]
        public string ikf_special1 { get; set; }

        [StringLength(4)]
        public string ikf_special2 { get; set; }

        [StringLength(4)]
        public string ikf_special3 { get; set; }

        public int? ikf_firmano { get; set; }

        public int? ikf_subeno { get; set; }

        public DateTime? ikf_tarih { get; set; }

        public byte? ikf_tipi { get; set; }

        [StringLength(20)]
        public string ikf_belgeno { get; set; }

        public DateTime? ikf_belge_tarih { get; set; }

        [StringLength(25)]
        public string ikf_kod { get; set; }

        [StringLength(40)]
        public string ikf_adi { get; set; }

        [StringLength(25)]
        public string ikf_dept { get; set; }

        [StringLength(25)]
        public string ikf_gorev { get; set; }

        [StringLength(25)]
        public string ikf_veren_pers { get; set; }

        [StringLength(25)]
        public string ikf_per_kodu { get; set; }

        public int? ikf_satirno { get; set; }

        [StringLength(25)]
        public string ikf_kriter { get; set; }

        public double? ikf_satirpuan { get; set; }

        public bool? ikf_degerlendir_fl { get; set; }

        [StringLength(25)]
        public string ikf_kadro { get; set; }

        [StringLength(120)]
        public string ikf_aciklama1 { get; set; }

        [StringLength(120)]
        public string ikf_aciklama2 { get; set; }

        [StringLength(120)]
        public string ikf_aciklama3 { get; set; }
    }
}
