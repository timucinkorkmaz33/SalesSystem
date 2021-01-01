namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RAKIP_STOK_DEPO_DETAYLARI
    {
        [Key]
        public int rsdp_RECno { get; set; }

        public short rsdp_RECid_DBCno { get; set; }

        public int rsdp_RECid_RECno { get; set; }

        public int? rsdp_SpecRECno { get; set; }

        public bool? rsdp_iptal { get; set; }

        public short? rsdp_fileid { get; set; }

        public bool? rsdp_hidden { get; set; }

        public bool? rsdp_kilitli { get; set; }

        public bool? rsdp_degisti { get; set; }

        public int? rsdp_checksum { get; set; }

        public short? rsdp_create_user { get; set; }

        public DateTime? rsdp_create_date { get; set; }

        public short? rsdp_lastup_user { get; set; }

        public DateTime? rsdp_lastup_date { get; set; }

        [StringLength(4)]
        public string rsdp_special1 { get; set; }

        [StringLength(4)]
        public string rsdp_special2 { get; set; }

        [StringLength(4)]
        public string rsdp_special3 { get; set; }

        [StringLength(25)]
        public string rsdp_depo_kod { get; set; }

        public int? rsdp_depo_no { get; set; }

        public double? rsdp_kar_orani { get; set; }

        public double? rsdp_satisfiat { get; set; }

        public byte? rsdp_fiat_doviz { get; set; }

        public int? rsdp_fiat_opno { get; set; }

        [StringLength(4)]
        public string rsdp_fiat_isk_kod { get; set; }

        public bool? rsdp_kdvdahil { get; set; }
    }
}
