namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITHALAT_MUHASEBE_GRUPLARI
    {
        [Key]
        public int IthMuh_RECno { get; set; }

        public short IthMuh_RECid_DBCno { get; set; }

        public int IthMuh_RECid_RECno { get; set; }

        public int? IthMuh_SpecRECno { get; set; }

        public bool? IthMuh_iptal { get; set; }

        public short? IthMuh_fileid { get; set; }

        public bool? IthMuh_hidden { get; set; }

        public bool? IthMuh_kilitli { get; set; }

        public bool? IthMuh_degisti { get; set; }

        public int? IthMuh_checksum { get; set; }

        public short? IthMuh_create_user { get; set; }

        public DateTime? IthMuh_create_date { get; set; }

        public short? IthMuh_lastup_user { get; set; }

        public DateTime? IthMuh_lastup_date { get; set; }

        [StringLength(4)]
        public string IthMuh_special1 { get; set; }

        [StringLength(4)]
        public string IthMuh_special2 { get; set; }

        [StringLength(4)]
        public string IthMuh_special3 { get; set; }

        [StringLength(25)]
        public string IthMuh_kod { get; set; }

        [StringLength(90)]
        public string IthMuh_ismi { get; set; }

        [StringLength(40)]
        public string IthMuh_navlun_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_sigorta_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_gumruk_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_banka_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger1_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger2_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger3_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger4_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger5_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_diger6_muh_kod { get; set; }

        [StringLength(40)]
        public string IthMuh_MalBedeliMuhKodu { get; set; }
    }
}
