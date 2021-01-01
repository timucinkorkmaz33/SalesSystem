namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPERASYON_RECETELERI
    {
        [Key]
        public int opr_RECno { get; set; }

        public short opr_RECid_DBCno { get; set; }

        public int opr_RECid_RECno { get; set; }

        public int? opr_SpecRECno { get; set; }

        public bool? opr_iptal { get; set; }

        public short? opr_fileid { get; set; }

        public bool? opr_hidden { get; set; }

        public bool? opr_kilitli { get; set; }

        public bool? opr_degisti { get; set; }

        public int? opr_checksum { get; set; }

        public short? opr_create_user { get; set; }

        public DateTime? opr_create_date { get; set; }

        public short? opr_lastup_user { get; set; }

        public DateTime? opr_lastup_date { get; set; }

        [StringLength(4)]
        public string opr_special1 { get; set; }

        [StringLength(4)]
        public string opr_special2 { get; set; }

        [StringLength(4)]
        public string opr_special3 { get; set; }

        [StringLength(25)]
        public string opr_operasyon_kodu { get; set; }

        public DateTime? opr_duzenleme_tarihi { get; set; }

        [StringLength(50)]
        public string opr_aciklama { get; set; }

        [StringLength(25)]
        public string opr_tuketim_kodu { get; set; }

        public double? opr_tuketim_miktari { get; set; }

        public byte? opr_tuketim_birim { get; set; }

        public byte? opr_hesap_tipi { get; set; }

        public double? opr_ana_miktar_sure { get; set; }

        public byte? opr_uretim_tuketim { get; set; }

        public int? opr_satirno { get; set; }

        [StringLength(50)]
        public string opr_satir_aciklamasi { get; set; }

        public int? opr_depono { get; set; }

        [StringLength(25)]
        public string opr_alt_tukkod1 { get; set; }

        public double? opr_alt_1_katsayi { get; set; }

        [StringLength(25)]
        public string opr_alt_tukkod2 { get; set; }

        public double? opr_alt_2_katsayi { get; set; }

        [StringLength(25)]
        public string opr_alt_tukkod3 { get; set; }

        public double? opr_alt_3_katsayi { get; set; }

        [StringLength(25)]
        public string opr_alt_tukkod4 { get; set; }

        public double? opr_alt_4_katsayi { get; set; }

        [StringLength(25)]
        public string opr_alt_tukkod5 { get; set; }

        public double? opr_alt_5_katsayi { get; set; }

        public byte? opr_sarf_turu { get; set; }
    }
}
