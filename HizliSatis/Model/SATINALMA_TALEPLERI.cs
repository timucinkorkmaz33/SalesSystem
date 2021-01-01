namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATINALMA_TALEPLERI
    {
        [Key]
        public int stl_RECno { get; set; }

        public short stl_RECid_DBCno { get; set; }

        public int stl_RECid_RECno { get; set; }

        public int? stl_SpecRECno { get; set; }

        public bool? stl_iptal { get; set; }

        public short? stl_fileid { get; set; }

        public bool? stl_hidden { get; set; }

        public bool? stl_kilitli { get; set; }

        public bool? stl_degisti { get; set; }

        public int? stl_checksum { get; set; }

        public short? stl_create_user { get; set; }

        public DateTime? stl_create_date { get; set; }

        public short? stl_lastup_user { get; set; }

        public DateTime? stl_lastup_date { get; set; }

        [StringLength(4)]
        public string stl_special1 { get; set; }

        [StringLength(4)]
        public string stl_special2 { get; set; }

        [StringLength(4)]
        public string stl_special3 { get; set; }

        public int? stl_firmano { get; set; }

        public int? stl_subeno { get; set; }

        public DateTime? stl_tarihi { get; set; }

        public DateTime? stl_teslim_tarihi { get; set; }

        [StringLength(6)]
        public string stl_evrak_seri { get; set; }

        public int? stl_evrak_sira { get; set; }

        public int? stl_satir_no { get; set; }

        [StringLength(20)]
        public string stl_belge_no { get; set; }

        public DateTime? stl_belge_tarihi { get; set; }

        [StringLength(25)]
        public string stl_Sor_Merk { get; set; }

        [StringLength(25)]
        public string stl_Stok_kodu { get; set; }

        [StringLength(25)]
        public string stl_Satici_Kodu { get; set; }

        public double? stl_miktari { get; set; }

        public double? stl_teslim_miktari { get; set; }

        [StringLength(50)]
        public string stl_aciklama { get; set; }

        [StringLength(50)]
        public string stl_aciklama2 { get; set; }

        public int? stl_depo_no { get; set; }

        public bool? stl_kapat_fl { get; set; }

        [StringLength(25)]
        public string stl_projekodu { get; set; }

        [StringLength(25)]
        public string stl_parti_kodu { get; set; }

        public int? stl_lot_no { get; set; }

        public short? stl_OnaylayanKulNo { get; set; }

        public bool? stl_cagrilabilir_fl { get; set; }

        public byte? stl_harekettipi { get; set; }

        [StringLength(25)]
        public string stl_talep_eden { get; set; }

        [StringLength(25)]
        public string stl_kapatmanedenkod { get; set; }

        public short? stl_KaynakSip_RECid_DBCno { get; set; }

        public int? stl_KaynakSip_RECid_RECno { get; set; }
    }
}
