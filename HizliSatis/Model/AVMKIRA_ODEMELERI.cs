namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMKIRA_ODEMELERI
    {
        [Key]
        public int Avmko_RECNo { get; set; }

        public short Avmko_RECid_DBCno { get; set; }

        public int Avmko_RECid_RECno { get; set; }

        public int? Avmko_SpecRECno { get; set; }

        public bool? Avmko_iptal { get; set; }

        public short? Avmko_fileid { get; set; }

        public bool? Avmko_hidden { get; set; }

        public bool? Avmko_kilitli { get; set; }

        public bool? Avmko_degisti { get; set; }

        public int? Avmko_checksum { get; set; }

        public short? Avmko_create_user { get; set; }

        public DateTime? Avmko_create_date { get; set; }

        public short? Avmko_lastup_user { get; set; }

        public DateTime? Avmko_lastup_date { get; set; }

        [StringLength(4)]
        public string Avmko_special1 { get; set; }

        [StringLength(4)]
        public string Avmko_special2 { get; set; }

        [StringLength(4)]
        public string Avmko_special3 { get; set; }

        public int? Avmko_firma_no { get; set; }

        public int? Avmko_sube_no { get; set; }

        public DateTime? Avmko_tarihi { get; set; }

        [StringLength(6)]
        public string Avmko_evrakno_seri { get; set; }

        public int? Avmko_evrakno_sira { get; set; }

        public int? Avmko_satirno { get; set; }

        [StringLength(20)]
        public string Avmko_belge_no { get; set; }

        public DateTime? Avmko_belge_tarih { get; set; }

        [StringLength(25)]
        public string Avmko_kirakodu { get; set; }

        public double? Avmko_tutar { get; set; }
    }
}
