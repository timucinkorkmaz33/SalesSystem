namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITIM_DETAYLARI
    {
        [Key]
        public int edet_RECno { get; set; }

        public short edet_RECid_DBCno { get; set; }

        public int edet_RECid_RECno { get; set; }

        public int? edet_SpecRECno { get; set; }

        public bool? edet_iptal { get; set; }

        public short? edet_fileid { get; set; }

        public bool? edet_hidden { get; set; }

        public bool? edet_kilitli { get; set; }

        public bool? edet_degisti { get; set; }

        public int? edet_checksum { get; set; }

        public short? edet_create_user { get; set; }

        public DateTime? edet_create_date { get; set; }

        public short? edet_lastup_user { get; set; }

        public DateTime? edet_lastup_date { get; set; }

        [StringLength(4)]
        public string edet_special1 { get; set; }

        [StringLength(4)]
        public string edet_special2 { get; set; }

        [StringLength(4)]
        public string edet_special3 { get; set; }

        [StringLength(25)]
        public string edet_kodu { get; set; }

        public byte? edet_detaytipi { get; set; }

        public int? edet_satirno { get; set; }

        public byte? edet_hartipi { get; set; }

        [StringLength(25)]
        public string edet_harkodu { get; set; }

        [StringLength(40)]
        public string edet_aciklama { get; set; }

        public double? edet_miktar { get; set; }

        public byte? edet_birim { get; set; }

        public double? edet_tutar { get; set; }

        public byte? edet_doviz_cinsi { get; set; }

        public double? edet_doviz_kuru { get; set; }

        [StringLength(6)]
        public string edet_aeg_evrakno_seri { get; set; }

        public int? edet_aeg_evrakno_sira { get; set; }
    }
}
