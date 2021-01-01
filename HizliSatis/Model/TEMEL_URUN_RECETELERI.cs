namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMEL_URUN_RECETELERI
    {
        [Key]
        public int mre_RECno { get; set; }

        public short mre_RECid_DBCno { get; set; }

        public int mre_RECid_RECno { get; set; }

        public int? mre_SpecRECno { get; set; }

        public bool? mre_iptal { get; set; }

        public short? mre_fileid { get; set; }

        public bool? mre_hidden { get; set; }

        public bool? mre_kilitli { get; set; }

        public bool? mre_degisti { get; set; }

        public int? mre_checksum { get; set; }

        public short? mre_create_user { get; set; }

        public DateTime? mre_create_date { get; set; }

        public short? mre_lastup_user { get; set; }

        public DateTime? mre_lastup_date { get; set; }

        [StringLength(4)]
        public string mre_special1 { get; set; }

        [StringLength(4)]
        public string mre_special2 { get; set; }

        [StringLength(4)]
        public string mre_special3 { get; set; }

        [StringLength(25)]
        public string mre_ana_kodu { get; set; }

        public DateTime? mre_tarih { get; set; }

        [StringLength(50)]
        public string mre_aciklama { get; set; }

        public byte? mre_ana_birim { get; set; }

        public double? mre_ana_miktar { get; set; }

        public byte? mre_tuketim_turu { get; set; }

        [StringLength(25)]
        public string mre_tuketim_kodu { get; set; }

        public double? mre_tuketim_miktari { get; set; }

        public byte? mre_tuketim_birim { get; set; }

        public byte? mre_uretimtuketim { get; set; }

        public int? mre_satirno { get; set; }

        [StringLength(50)]
        public string mre_strdetay_acik { get; set; }

        public int? mre_depono { get; set; }

        public double? mre_fire_yuzdesi { get; set; }

        public byte? mre_PlanlamaTipi { get; set; }
    }
}
