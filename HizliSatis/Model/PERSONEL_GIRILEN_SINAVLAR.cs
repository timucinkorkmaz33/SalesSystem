namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_GIRILEN_SINAVLAR
    {
        [Key]
        public int asn_RECno { get; set; }

        public short asn_RECid_DBCno { get; set; }

        public int asn_RECid_RECno { get; set; }

        public int? asn_SpecRECno { get; set; }

        public bool? asn_iptal { get; set; }

        public short? asn_fileid { get; set; }

        public bool? asn_hidden { get; set; }

        public bool? asn_kilitli { get; set; }

        public bool? asn_degisti { get; set; }

        public int? asn_checksum { get; set; }

        public short? asn_create_user { get; set; }

        public DateTime? asn_create_date { get; set; }

        public short? asn_lastup_user { get; set; }

        public DateTime? asn_lastup_date { get; set; }

        [StringLength(4)]
        public string asn_special1 { get; set; }

        [StringLength(4)]
        public string asn_special2 { get; set; }

        [StringLength(4)]
        public string asn_special3 { get; set; }

        public DateTime? asn_tarih { get; set; }

        public byte? asn_kapsam { get; set; }

        [StringLength(25)]
        public string asn_per_kodu { get; set; }

        [StringLength(25)]
        public string asn_sinav_kodu { get; set; }

        public double? asn_puan { get; set; }

        [StringLength(80)]
        public string asn_aciklama { get; set; }

        [StringLength(25)]
        public string asn_sinav_yeri { get; set; }

        public byte? asn_sinavi_yapan_tipi { get; set; }

        [StringLength(25)]
        public string asn_sinavi_yapan { get; set; }
    }
}
