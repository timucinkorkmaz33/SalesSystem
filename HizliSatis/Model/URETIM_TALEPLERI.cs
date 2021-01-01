namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_TALEPLERI
    {
        [Key]
        public int utl_RECno { get; set; }

        public short utl_RECid_DBCno { get; set; }

        public int utl_RECid_RECno { get; set; }

        public int? utl_SpecRECno { get; set; }

        public bool? utl_iptal { get; set; }

        public short? utl_fileid { get; set; }

        public bool? utl_hidden { get; set; }

        public bool? utl_kilitli { get; set; }

        public bool? utl_degisti { get; set; }

        public int? utl_checksum { get; set; }

        public short? utl_create_user { get; set; }

        public DateTime? utl_create_date { get; set; }

        public short? utl_lastup_user { get; set; }

        public DateTime? utl_lastup_date { get; set; }

        [StringLength(4)]
        public string utl_special1 { get; set; }

        [StringLength(4)]
        public string utl_special2 { get; set; }

        [StringLength(4)]
        public string utl_special3 { get; set; }

        public int? utl_firmano { get; set; }

        public int? utl_subeno { get; set; }

        public DateTime? utl_tarihi { get; set; }

        public DateTime? utl_teslim_tarihi { get; set; }

        [StringLength(6)]
        public string utl_evrak_seri { get; set; }

        public int? utl_evrak_sira { get; set; }

        public int? utl_satir_no { get; set; }

        [StringLength(20)]
        public string utl_belge_no { get; set; }

        public DateTime? utl_belge_tarihi { get; set; }

        [StringLength(25)]
        public string utl_Sor_Merk { get; set; }

        [StringLength(25)]
        public string utl_Stok_kodu { get; set; }

        [StringLength(25)]
        public string utl_Satici_Kodu { get; set; }

        public double? utl_miktari { get; set; }

        public double? utl_planlanan_miktar { get; set; }

        [StringLength(40)]
        public string utl_aciklama { get; set; }

        public int? utl_depo_no { get; set; }

        public bool? utl_kapat_fl { get; set; }

        [StringLength(25)]
        public string utl_projekodu { get; set; }

        [StringLength(25)]
        public string utl_parti_kodu { get; set; }

        public int? utl_lot_no { get; set; }

        public short? utl_sip_RECid_DBCno { get; set; }

        public int? utl_sip_RECid_RECno { get; set; }

        [StringLength(25)]
        public string utl_kapatmanedenkod { get; set; }
    }
}
