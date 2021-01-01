namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KAPAMA_NEDENLERI_TANIMLARI
    {
        [Key]
        public int Kpm_RECno { get; set; }

        public short Kpm_RECid_DBCno { get; set; }

        public int Kpm_RECid_RECno { get; set; }

        public int? Kpm_SpecRECno { get; set; }

        public bool? Kpm_iptal { get; set; }

        public short? Kpm_fileid { get; set; }

        public bool? Kpm_hidden { get; set; }

        public bool? Kpm_kilitli { get; set; }

        public bool? Kpm_degisti { get; set; }

        public int? Kpm_checksum { get; set; }

        public short? Kpm_create_user { get; set; }

        public DateTime? Kpm_create_date { get; set; }

        public short? Kpm_lastup_user { get; set; }

        public DateTime? Kpm_lastup_date { get; set; }

        [StringLength(4)]
        public string Kpm_special1 { get; set; }

        [StringLength(4)]
        public string Kpm_special2 { get; set; }

        [StringLength(4)]
        public string Kpm_special3 { get; set; }

        [StringLength(25)]
        public string Kpm_kod { get; set; }

        [StringLength(90)]
        public string Kpm_ismi { get; set; }

        [StringLength(40)]
        public string Kpm_aciklama { get; set; }
    }
}
