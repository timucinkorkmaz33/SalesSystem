namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEPOLAR_ARASI_SIPARISLER
    {
        [Key]
        public int ssip_RECno { get; set; }

        public short ssip_RECid_DBCno { get; set; }

        public int ssip_RECid_RECno { get; set; }

        public int? ssip_SpecRECno { get; set; }

        public bool? ssip_iptal { get; set; }

        public short? ssip_fileid { get; set; }

        public bool? ssip_hidden { get; set; }

        public bool? ssip_kilitli { get; set; }

        public bool? ssip_degisti { get; set; }

        public int? ssip_checksum { get; set; }

        public short? ssip_create_user { get; set; }

        public DateTime? ssip_create_date { get; set; }

        public short? ssip_lastup_user { get; set; }

        public DateTime? ssip_lastup_date { get; set; }

        [StringLength(4)]
        public string ssip_special1 { get; set; }

        [StringLength(4)]
        public string ssip_special2 { get; set; }

        [StringLength(4)]
        public string ssip_special3 { get; set; }

        public int? ssip_firmano { get; set; }

        public int? ssip_subeno { get; set; }

        public DateTime? ssip_tarih { get; set; }

        public DateTime? ssip_teslim_tarih { get; set; }

        [StringLength(6)]
        public string ssip_evrakno_seri { get; set; }

        public int? ssip_evrakno_sira { get; set; }

        public int? ssip_satirno { get; set; }

        [StringLength(20)]
        public string ssip_belgeno { get; set; }

        public DateTime? ssip_belge_tarih { get; set; }

        [StringLength(25)]
        public string ssip_stok_kod { get; set; }

        public double? ssip_miktar { get; set; }

        public double? ssip_b_fiyat { get; set; }

        public double? ssip_tutar { get; set; }

        public double? ssip_teslim_miktar { get; set; }

        [StringLength(50)]
        public string ssip_aciklama { get; set; }

        public int? ssip_girdepo { get; set; }

        public int? ssip_cikdepo { get; set; }

        public bool? ssip_kapat_fl { get; set; }

        public byte? ssip_birim_pntr { get; set; }

        public int? ssip_fiyat_liste_no { get; set; }

        public short? ssip_stalRecId_DBCno { get; set; }

        public int? ssip_stalRecId_RECno { get; set; }

        [StringLength(25)]
        public string ssip_paket_kod { get; set; }

        [StringLength(25)]
        public string ssip_kapatmanedenkod { get; set; }

        [StringLength(25)]
        public string ssip_projekodu { get; set; }

        [StringLength(25)]
        public string ssip_sormerkezi { get; set; }

        public DateTime? ssip_gecerlilik_tarihi { get; set; }

        public double? ssip_rezervasyon_miktari { get; set; }

        public double? ssip_rezerveden_teslim_edilen { get; set; }
    }
}
