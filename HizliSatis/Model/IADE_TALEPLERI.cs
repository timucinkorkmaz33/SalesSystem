namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IADE_TALEPLERI
    {
        [Key]
        public int itlp_RECno { get; set; }

        public short itlp_RECid_DBCno { get; set; }

        public int itlp_RECid_RECno { get; set; }

        public int? itlp_SpecRECno { get; set; }

        public bool? itlp_iptal { get; set; }

        public short? itlp_fileid { get; set; }

        public bool? itlp_hidden { get; set; }

        public bool? itlp_kilitli { get; set; }

        public bool? itlp_degisti { get; set; }

        public int? itlp_checksum { get; set; }

        public short? itlp_create_user { get; set; }

        public DateTime? itlp_create_date { get; set; }

        public short? itlp_lastup_user { get; set; }

        public DateTime? itlp_lastup_date { get; set; }

        [StringLength(4)]
        public string itlp_special1 { get; set; }

        [StringLength(4)]
        public string itlp_special2 { get; set; }

        [StringLength(4)]
        public string itlp_special3 { get; set; }

        public int? itlp_firmano { get; set; }

        public int? itlp_subeno { get; set; }

        public DateTime? itlp_tarihi { get; set; }

        public DateTime? itlp_teslim_tarihi { get; set; }

        public byte? itlp_tip { get; set; }

        [StringLength(6)]
        public string itlp_evrak_seri { get; set; }

        public int? itlp_evrak_sira { get; set; }

        public int? itlp_satir_no { get; set; }

        [StringLength(20)]
        public string itlp_belge_no { get; set; }

        public DateTime? itlp_belge_tarihi { get; set; }

        [StringLength(25)]
        public string itlp_musteri_kodu { get; set; }

        [StringLength(25)]
        public string itlp_sor_merk_kodu { get; set; }

        public int? itlp_opno { get; set; }

        [StringLength(25)]
        public string itlp_stok_kodu { get; set; }

        [StringLength(25)]
        public string itlp_satici_Kodu { get; set; }

        public double? itlp_miktari { get; set; }

        public double? itlp_teslim_miktari { get; set; }

        [StringLength(40)]
        public string itlp_aciklama { get; set; }

        public int? itlp_depo_no { get; set; }

        public byte? itlp_cari_grupno { get; set; }

        public byte? itlp_doviz_cinsi { get; set; }

        public byte? itlp_doviz_kuru { get; set; }

        public double? itlp_birim_fiyat { get; set; }

        public int? itlp_fiyat_listeno { get; set; }

        public double? itlp_tutar { get; set; }

        public bool? itlp_kapat_fl { get; set; }

        [StringLength(25)]
        public string itlp_projekodu { get; set; }

        [StringLength(25)]
        public string itlp_parti_kodu { get; set; }

        public int? itlp_lot_no { get; set; }

        public short? itlp_onaylayan_kulno { get; set; }

        public bool? itlp_cagrilabilir_fl { get; set; }

        [StringLength(25)]
        public string itlp_kapatmanedenkod { get; set; }
    }
}
