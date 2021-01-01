namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_PRIM_DAGITIM_TANIMLARI
    {
        [Key]
        public int prprm_RECno { get; set; }

        public short prprm_RECid_DBCno { get; set; }

        public int prprm_RECid_RECno { get; set; }

        public int? prprm_SpecRECno { get; set; }

        public bool? prprm_iptal { get; set; }

        public short? prprm_fileid { get; set; }

        public bool? prprm_hidden { get; set; }

        public bool? prprm_kilitli { get; set; }

        public bool? prprm_degisti { get; set; }

        public int? prprm_checksum { get; set; }

        public short? prprm_create_user { get; set; }

        public DateTime? prprm_create_date { get; set; }

        public short? prprm_lastup_user { get; set; }

        public DateTime? prprm_lastup_date { get; set; }

        [StringLength(4)]
        public string prprm_special1 { get; set; }

        [StringLength(4)]
        public string prprm_special2 { get; set; }

        [StringLength(4)]
        public string prprm_special3 { get; set; }

        [StringLength(25)]
        public string prprm_per_kod { get; set; }

        public double? prprm_dgt_yuzde1 { get; set; }

        public byte? prprm_dgt_tip1 { get; set; }

        [StringLength(25)]
        public string prprm_dgt_per_kod1 { get; set; }

        public double? prprm_dgt_yuzde2 { get; set; }

        public byte? prprm_dgt_tip2 { get; set; }

        [StringLength(25)]
        public string prprm_dgt_per_kod2 { get; set; }

        public double? prprm_dgt_yuzde3 { get; set; }

        public byte? prprm_dgt_tip3 { get; set; }

        [StringLength(25)]
        public string prprm_dgt_per_kod3 { get; set; }

        public double? prprm_dgt_yuzde4 { get; set; }

        public byte? prprm_dgt_tip4 { get; set; }

        [StringLength(25)]
        public string prprm_dgt_per_kod4 { get; set; }

        public double? prprm_dgt_yuzde5 { get; set; }

        public byte? prprm_dgt_tip5 { get; set; }

        [StringLength(25)]
        public string prprm_dgt_per_kod5 { get; set; }
    }
}
