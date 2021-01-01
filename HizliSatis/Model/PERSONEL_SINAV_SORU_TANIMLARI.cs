namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SINAV_SORU_TANIMLARI
    {
        [Key]
        public int pst_RECno { get; set; }

        public short pst_RECid_DBCno { get; set; }

        public int pst_RECid_RECno { get; set; }

        public int? pst_SpecRECno { get; set; }

        public bool? pst_iptal { get; set; }

        public short? pst_fileid { get; set; }

        public bool? pst_hidden { get; set; }

        public bool? pst_kilitli { get; set; }

        public bool? pst_degisti { get; set; }

        public int? pst_checksum { get; set; }

        public short? pst_create_user { get; set; }

        public DateTime? pst_create_date { get; set; }

        public short? pst_lastup_user { get; set; }

        public DateTime? pst_lastup_date { get; set; }

        [StringLength(4)]
        public string pst_special1 { get; set; }

        [StringLength(4)]
        public string pst_special2 { get; set; }

        [StringLength(4)]
        public string pst_special3 { get; set; }

        [StringLength(25)]
        public string pst_kodu { get; set; }

        [StringLength(120)]
        public string pst_soru { get; set; }

        public byte? pst_sorutipi { get; set; }
    }
}
