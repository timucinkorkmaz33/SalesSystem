namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGITIM_KONU_TANIMLARI
    {
        [Key]
        public int ekonu_RECno { get; set; }

        public short ekonu_RECid_DBCno { get; set; }

        public int ekonu_RECid_RECno { get; set; }

        public int? ekonu_SpecRECno { get; set; }

        public bool? ekonu_iptal { get; set; }

        public short? ekonu_fileid { get; set; }

        public bool? ekonu_hidden { get; set; }

        public bool? ekonu_kilitli { get; set; }

        public bool? ekonu_degisti { get; set; }

        public int? ekonu_checksum { get; set; }

        public short? ekonu_create_user { get; set; }

        public DateTime? ekonu_create_date { get; set; }

        public short? ekonu_lastup_user { get; set; }

        public DateTime? ekonu_lastup_date { get; set; }

        [StringLength(4)]
        public string ekonu_special1 { get; set; }

        [StringLength(4)]
        public string ekonu_special2 { get; set; }

        [StringLength(4)]
        public string ekonu_special3 { get; set; }

        [StringLength(25)]
        public string ekonu_kodu { get; set; }

        [StringLength(40)]
        public string ekonu_adi { get; set; }

        public byte? ekonu_tip { get; set; }

        [StringLength(120)]
        public string eaciklama1 { get; set; }

        [StringLength(120)]
        public string eaciklama2 { get; set; }

        [StringLength(120)]
        public string eaciklama3 { get; set; }
    }
}
