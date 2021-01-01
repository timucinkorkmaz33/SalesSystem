namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_PERFORMANSLAR
    {
        [Key]
        public int aprf_RECno { get; set; }

        public short aprf_RECid_DBCno { get; set; }

        public int aprf_RECid_RECno { get; set; }

        public int? aprf_SpecRECno { get; set; }

        public bool? aprf_iptal { get; set; }

        public short? aprf_fileid { get; set; }

        public bool? aprf_hidden { get; set; }

        public bool? aprf_kilitli { get; set; }

        public bool? aprf_degisti { get; set; }

        public int? aprf_checksum { get; set; }

        public short? aprf_create_user { get; set; }

        public DateTime? aprf_create_date { get; set; }

        public short? aprf_lastup_user { get; set; }

        public DateTime? aprf_lastup_date { get; set; }

        [StringLength(4)]
        public string aprf_special1 { get; set; }

        [StringLength(4)]
        public string aprf_special2 { get; set; }

        [StringLength(4)]
        public string aprf_special3 { get; set; }

        public int? aprf_firmano { get; set; }

        public int? aprf_subeno { get; set; }

        public DateTime? aprf_tarih { get; set; }

        public byte? aprf_tip { get; set; }

        [StringLength(6)]
        public string aprf_evrakno_seri { get; set; }

        public int? aprf_evrakno_sira { get; set; }

        public int? aprf_satirno { get; set; }

        [StringLength(20)]
        public string aprf_belgeno { get; set; }

        public DateTime? aprf_belge_tarih { get; set; }

        [StringLength(25)]
        public string aprf_veren_pers { get; set; }

        [StringLength(25)]
        public string aprf_per_kodu { get; set; }

        [StringLength(25)]
        public string aprf_perform_kodu { get; set; }

        [StringLength(80)]
        public string aprf_aciklama { get; set; }

        public double? aprf_miktar { get; set; }
    }
}
