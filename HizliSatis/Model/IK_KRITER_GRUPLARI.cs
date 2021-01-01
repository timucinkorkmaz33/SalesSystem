namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IK_KRITER_GRUPLARI
    {
        [Key]
        public int ikg_RECno { get; set; }

        public short ikg_RECid_DBCno { get; set; }

        public int ikg_RECid_RECno { get; set; }

        public int? ikg_SpecRECno { get; set; }

        public bool? ikg_iptal { get; set; }

        public short? ikg_fileid { get; set; }

        public bool? ikg_hidden { get; set; }

        public bool? ikg_kilitli { get; set; }

        public bool? ikg_degisti { get; set; }

        public int? ikg_checksum { get; set; }

        public short? ikg_create_user { get; set; }

        public DateTime? ikg_create_date { get; set; }

        public short? ikg_lastup_user { get; set; }

        public DateTime? ikg_lastup_date { get; set; }

        [StringLength(4)]
        public string ikg_special1 { get; set; }

        [StringLength(4)]
        public string ikg_special2 { get; set; }

        [StringLength(4)]
        public string ikg_special3 { get; set; }

        public int? ikg_firmano { get; set; }

        public int? ikg_subeno { get; set; }

        public byte? ikg_tipi { get; set; }

        [StringLength(25)]
        public string ikg_kod { get; set; }

        [StringLength(40)]
        public string ikg_adi { get; set; }

        [StringLength(25)]
        public string ikg_kriter_kodu { get; set; }
    }
}
