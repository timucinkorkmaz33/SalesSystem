namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSFER_SIPARISLERI
    {
        [Key]
        public int transsip_RECno { get; set; }

        public short transsip_RECid_DBCno { get; set; }

        public int transsip_RECid_RECno { get; set; }

        public int? transsip_SpecRECno { get; set; }

        public bool? transsip_iptal { get; set; }

        public short? transsip_fileid { get; set; }

        public bool? transsip_hidden { get; set; }

        public bool? transsip_kilitli { get; set; }

        public bool? transsip_degisti { get; set; }

        public int? transsip_checksum { get; set; }

        public short? transsip_create_user { get; set; }

        public DateTime? transsip_create_date { get; set; }

        public short? transsip_lastup_user { get; set; }

        public DateTime? transsip_lastup_date { get; set; }

        [StringLength(4)]
        public string transsip_special1 { get; set; }

        [StringLength(4)]
        public string transsip_special2 { get; set; }

        [StringLength(4)]
        public string transsip_special3 { get; set; }

        public int? transsip_firmano { get; set; }

        public int? transsip_subeno { get; set; }

        public DateTime? transsip_tarih { get; set; }

        public DateTime? transsip_teslim_tarih { get; set; }

        [StringLength(6)]
        public string transsip_evrakno_seri { get; set; }

        public int? transsip_evrakno_sira { get; set; }

        public int? transsip_satirno { get; set; }

        [StringLength(20)]
        public string transsip_belgeno { get; set; }

        public DateTime? transsip_belge_tarih { get; set; }

        [StringLength(25)]
        public string transsip_talepcarikodu { get; set; }

        public int? transsip_talepcariadresno { get; set; }

        [StringLength(25)]
        public string transsip_temincarikodu { get; set; }

        public int? transsip_temincariadresno { get; set; }

        [StringLength(25)]
        public string transsip_plasiyer_kodu { get; set; }

        [StringLength(25)]
        public string transsip_stok_kod { get; set; }

        public double? transsip_b_fiyat { get; set; }

        public double? transsip_miktar { get; set; }

        public byte? transsip_birim_pntr { get; set; }

        public double? transsip_teslim_miktar { get; set; }

        public double? transsip_tutar { get; set; }

        public double? transsip_iskonto_1 { get; set; }

        public double? transsip_iskonto_2 { get; set; }

        public double? transsip_iskonto_3 { get; set; }

        public double? transsip_iskonto_4 { get; set; }

        public double? transsip_iskonto_5 { get; set; }

        public double? transsip_iskonto_6 { get; set; }

        public double? transsip_masraf_1 { get; set; }

        public double? transsip_masraf_2 { get; set; }

        public double? transsip_masraf_3 { get; set; }

        public double? transsip_masraf_4 { get; set; }

        public byte? transsip_vergi_pntr { get; set; }

        public double? transsip_vergi { get; set; }

        public byte? transsip_masvergi_pntr { get; set; }

        public double? transsip_masvergi { get; set; }

        public int? transsip_opno { get; set; }

        [StringLength(40)]
        public string transsip_aciklama { get; set; }

        public short? transsip_OnaylayanKulNo { get; set; }

        public bool? transsip_vergisiz_fl { get; set; }

        public bool? transsip_kapat_fl { get; set; }

        [StringLength(25)]
        public string transsip_cari_sormerk { get; set; }

        [StringLength(25)]
        public string transsip_stok_sormerk { get; set; }

        public byte? transsip_doviz_cinsi { get; set; }

        public double? transsip_doviz_kuru { get; set; }

        public double? transsip_alt_doviz_kuru { get; set; }

        [StringLength(4)]
        public string transsip_teslimturu { get; set; }

        public bool? transsip_cagrilabilir_fl { get; set; }

        public byte? transsip_iskonto1 { get; set; }

        public byte? transsip_iskonto2 { get; set; }

        public byte? transsip_iskonto3 { get; set; }

        public byte? transsip_iskonto4 { get; set; }

        public byte? transsip_iskonto5 { get; set; }

        public byte? transsip_iskonto6 { get; set; }

        public byte? transsip_masraf1 { get; set; }

        public byte? transsip_masraf2 { get; set; }

        public byte? transsip_masraf3 { get; set; }

        public byte? transsip_masraf4 { get; set; }

        public bool? transsip_isk1 { get; set; }

        public bool? transsip_isk2 { get; set; }

        public bool? transsip_isk3 { get; set; }

        public bool? transsip_isk4 { get; set; }

        public bool? transsip_isk5 { get; set; }

        public bool? transsip_isk6 { get; set; }

        public bool? transsip_mas1 { get; set; }

        public bool? transsip_mas2 { get; set; }

        public bool? transsip_mas3 { get; set; }

        public bool? transsip_mas4 { get; set; }

        [StringLength(40)]
        public string transsip_aciklama2 { get; set; }

        public double? transsip_kar_orani { get; set; }

        public byte? transsip_durumu { get; set; }

        [StringLength(25)]
        public string transsip_parti_kodu { get; set; }

        public int? transsip_lot_no { get; set; }

        [StringLength(25)]
        public string transsip_projekodu { get; set; }

        public int? transsip_fiyatlisteno { get; set; }

        public byte? transsip_otvpntr { get; set; }

        public double? transsip_otvvergi { get; set; }

        public double? transsip_otvtutari { get; set; }

        public byte? transsip_otvvergisiz_fl { get; set; }

        [StringLength(25)]
        public string transsip_paket_kodu { get; set; }

        [StringLength(25)]
        public string transsip_kapatmanedenkod { get; set; }
    }
}
