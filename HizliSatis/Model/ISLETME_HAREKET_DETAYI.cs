namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISLETME_HAREKET_DETAYI
    {
        [Key]
        public int dtfis_RECno { get; set; }

        public short dtfis_RECid_DBCno { get; set; }

        public int dtfis_RECid_RECno { get; set; }

        public int? dtfis_SpecRECno { get; set; }

        public bool? dtfis_iptal { get; set; }

        public short? dtfis_fileid { get; set; }

        public bool? dtfis_hidden { get; set; }

        public bool? dtfis_kilitli { get; set; }

        public bool? dtfis_degisti { get; set; }

        public int? dtfis_checksum { get; set; }

        public short? dtfis_create_user { get; set; }

        public DateTime? dtfis_create_date { get; set; }

        public short? dtfis_lastup_user { get; set; }

        public DateTime? dtfis_lastup_date { get; set; }

        [StringLength(4)]
        public string dtfis_special1 { get; set; }

        [StringLength(4)]
        public string dtfis_special2 { get; set; }

        [StringLength(4)]
        public string dtfis_special3 { get; set; }

        public short? dtfis_har_DBCno { get; set; }

        public int? dtfis_har_RECno { get; set; }

        public int? dtfis_satirno { get; set; }

        [StringLength(50)]
        public string dtfis_stok_ismi { get; set; }

        [StringLength(50)]
        public string dtfis_aciklama { get; set; }

        public double? dtfis_miktar { get; set; }

        public double? dtfis_tutar { get; set; }
    }
}
