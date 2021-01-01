namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_LIMITLERI
    {
        [Key]
        public int pkl_RECno { get; set; }

        public short pkl_RECid_DBCno { get; set; }

        public int pkl_RECid_RECno { get; set; }

        public int? pkl_SpecRECno { get; set; }

        public bool? pkl_iptal { get; set; }

        public short? pkl_fileid { get; set; }

        public bool? pkl_hidden { get; set; }

        public bool? pkl_kilitli { get; set; }

        public bool? pkl_degisti { get; set; }

        public int? pkl_checksum { get; set; }

        public short? pkl_create_user { get; set; }

        public DateTime? pkl_create_date { get; set; }

        public short? pkl_lastup_user { get; set; }

        public DateTime? pkl_lastup_date { get; set; }

        [StringLength(4)]
        public string pkl_special1 { get; set; }

        [StringLength(4)]
        public string pkl_special2 { get; set; }

        [StringLength(4)]
        public string pkl_special3 { get; set; }

        public byte? pkl_tipi { get; set; }

        [StringLength(25)]
        public string pkl_kadro_kodu { get; set; }

        public int? pkl_kadro_no { get; set; }

        public byte? pkl_cinsi { get; set; }

        [StringLength(25)]
        public string pkl_kodu { get; set; }

        public byte? pkl_periyod { get; set; }

        public double? pkl_limit { get; set; }
    }
}
