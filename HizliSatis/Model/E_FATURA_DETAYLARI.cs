namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_FATURA_DETAYLARI
    {
        [Key]
        public int efd_RECno { get; set; }

        public short efd_RECid_DBCno { get; set; }

        public int efd_RECid_RECno { get; set; }

        public int? efd_SpecRECno { get; set; }

        public bool? efd_iptal { get; set; }

        public short? efd_fileid { get; set; }

        public bool? efd_hidden { get; set; }

        public bool? efd_kilitli { get; set; }

        public bool? efd_degisti { get; set; }

        public int? efd_checksum { get; set; }

        public short? efd_create_user { get; set; }

        public DateTime? efd_create_date { get; set; }

        public short? efd_lastup_user { get; set; }

        public DateTime? efd_lastup_date { get; set; }

        [StringLength(4)]
        public string efd_special1 { get; set; }

        [StringLength(4)]
        public string efd_special2 { get; set; }

        [StringLength(4)]
        public string efd_special3 { get; set; }

        public int? efd_firmano { get; set; }

        public byte? efd_tipi { get; set; }

        [StringLength(10)]
        public string efd_gib_seri { get; set; }

        public int? efd_gib_sira { get; set; }

        [StringLength(40)]
        public string efd_uuid { get; set; }

        public short? efd_fat_recid_dbcno { get; set; }

        public int? efd_fat_recid_recno { get; set; }

        public byte? efd_pozisyon { get; set; }

        [StringLength(15)]
        public string efd_mVkn { get; set; }
    }
}
