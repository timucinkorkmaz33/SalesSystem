namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_MALIYET_DEVIR
    {
        [Key]
        public int umd_RECno { get; set; }

        public short umd_RECid_DBCno { get; set; }

        public int umd_RECid_RECno { get; set; }

        public int? umd_SpecRECno { get; set; }

        public bool? umd_iptal { get; set; }

        public short? umd_fileid { get; set; }

        public bool? umd_hidden { get; set; }

        public bool? umd_kilitli { get; set; }

        public bool? umd_degisti { get; set; }

        public int? umd_checksum { get; set; }

        public short? umd_create_user { get; set; }

        public DateTime? umd_create_date { get; set; }

        public short? umd_lastup_user { get; set; }

        public DateTime? umd_lastup_date { get; set; }

        [StringLength(4)]
        public string umd_special1 { get; set; }

        [StringLength(4)]
        public string umd_special2 { get; set; }

        [StringLength(4)]
        public string umd_special3 { get; set; }

        [StringLength(25)]
        public string umd_isemrikodu { get; set; }

        public double? umd_sevkedilen_malzeme { get; set; }

        public double? umd_urune_yansiyan_malzeme { get; set; }

        public double? umd_urune_yansiyan_direkt_iscilik { get; set; }

        public double? umd_gerceklesen_genel_uretim { get; set; }

        public double? umd_urune_yansiyan_genel_uretim { get; set; }
    }
}
