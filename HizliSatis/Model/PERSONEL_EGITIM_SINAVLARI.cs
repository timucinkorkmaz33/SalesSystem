namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITIM_SINAVLARI
    {
        [Key]
        public int pes_RECno { get; set; }

        public short pes_RECid_DBCno { get; set; }

        public int pes_RECid_RECno { get; set; }

        public int? pes_SpecRECno { get; set; }

        public bool? pes_iptal { get; set; }

        public short? pes_fileid { get; set; }

        public bool? pes_hidden { get; set; }

        public bool? pes_kilitli { get; set; }

        public bool? pes_degisti { get; set; }

        public int? pes_checksum { get; set; }

        public short? pes_create_user { get; set; }

        public DateTime? pes_create_date { get; set; }

        public short? pes_lastup_user { get; set; }

        public DateTime? pes_lastup_date { get; set; }

        [StringLength(4)]
        public string pes_special1 { get; set; }

        [StringLength(4)]
        public string pes_special2 { get; set; }

        [StringLength(4)]
        public string pes_special3 { get; set; }

        public byte? pes_tipi { get; set; }

        [StringLength(25)]
        public string pes_kodu { get; set; }

        [StringLength(25)]
        public string pes_sinavkodu { get; set; }

        public int? pes_sirano { get; set; }

        public double? pes_puan { get; set; }
    }
}
