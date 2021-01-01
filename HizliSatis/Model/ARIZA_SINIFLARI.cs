namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ARIZA_SINIFLARI
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

        [StringLength(25)]
        public string asn_kodu { get; set; }

        [StringLength(50)]
        public string asn_adi { get; set; }
    }
}
