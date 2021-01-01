namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANSFER_IRSALIYELERI
    {
        [Key]
        public int transirs_RECno { get; set; }

        public short transirs_RECid_DBCno { get; set; }

        public int transirs_RECid_RECno { get; set; }

        public int? transirs_SpecRECno { get; set; }

        public bool? transirs_iptal { get; set; }

        public short? transirs_fileid { get; set; }

        public bool? transirs_hidden { get; set; }

        public bool? transirs_kilitli { get; set; }

        public bool? transirs_degisti { get; set; }

        public int? transirs_checksum { get; set; }

        public short? transirs_create_user { get; set; }

        public DateTime? transirs_create_date { get; set; }

        public short? transirs_lastup_user { get; set; }

        public DateTime? transirs_lastup_date { get; set; }

        [StringLength(4)]
        public string transirs_special1 { get; set; }

        [StringLength(4)]
        public string transirs_special2 { get; set; }

        [StringLength(4)]
        public string transirs_special3 { get; set; }

        public int? transirs_firmano { get; set; }

        public int? transirs_subeno { get; set; }

        public DateTime? transirs_tarih { get; set; }

        [StringLength(6)]
        public string transirs_evrakno_seri { get; set; }

        public int? transirs_evrakno_sira { get; set; }

        public int? transirs_satirno { get; set; }

        [StringLength(20)]
        public string transirs_belge_no { get; set; }

        public DateTime? transirs_belge_tarih { get; set; }

        [StringLength(25)]
        public string transirs_talepcarikodu { get; set; }

        public byte? transirs_talepcarigrupno { get; set; }

        public int? transirs_talepcariadresno { get; set; }

        [StringLength(25)]
        public string transirs_temincarikodu { get; set; }

        public byte? transirs_temincarigrupno { get; set; }

        public int? transirs_temincariadresno { get; set; }

        [StringLength(25)]
        public string transirs_plasiyer_kodu { get; set; }

        [StringLength(25)]
        public string transirs_stok_kod { get; set; }

        public byte? transirs_isk_mas1 { get; set; }

        public byte? transirs_isk_mas2 { get; set; }

        public byte? transirs_isk_mas3 { get; set; }

        public byte? transirs_isk_mas4 { get; set; }

        public byte? transirs_isk_mas5 { get; set; }

        public byte? transirs_isk_mas6 { get; set; }

        public byte? transirs_isk_mas7 { get; set; }

        public byte? transirs_isk_mas8 { get; set; }

        public byte? transirs_isk_mas9 { get; set; }

        public byte? transirs_isk_mas10 { get; set; }

        public bool? transirs_sat_iskmas1 { get; set; }

        public bool? transirs_sat_iskmas2 { get; set; }

        public bool? transirs_sat_iskmas3 { get; set; }

        public bool? transirs_sat_iskmas4 { get; set; }

        public bool? transirs_sat_iskmas5 { get; set; }

        public bool? transirs_sat_iskmas6 { get; set; }

        public bool? transirs_sat_iskmas7 { get; set; }

        public bool? transirs_sat_iskmas8 { get; set; }

        public bool? transirs_sat_iskmas9 { get; set; }

        public bool? transirs_sat_iskmas10 { get; set; }

        [StringLength(25)]
        public string transirs_paket_kodu { get; set; }

        public byte? transirs_har_doviz_cinsi { get; set; }

        public double? transirs_har_doviz_kuru { get; set; }

        public double? transirs_alt_doviz_kuru { get; set; }

        public byte? transirs_stok_doviz_cinsi { get; set; }

        public double? transirs_stok_doviz_kuru { get; set; }

        public double? transirs_miktar { get; set; }

        public double? transirs_miktar2 { get; set; }

        public byte? transirs_birim_pntr { get; set; }

        public double? transirs_birimfiyati { get; set; }

        public double? transirs_tutar { get; set; }

        public double? transirs_iskonto1 { get; set; }

        public double? transirs_iskonto2 { get; set; }

        public double? transirs_iskonto3 { get; set; }

        public double? transirs_iskonto4 { get; set; }

        public double? transirs_iskonto5 { get; set; }

        public double? transirs_iskonto6 { get; set; }

        public double? transirs_masraf1 { get; set; }

        public double? transirs_masraf2 { get; set; }

        public double? transirs_masraf3 { get; set; }

        public double? transirs_masraf4 { get; set; }

        public byte? transirs_vergi_pntr { get; set; }

        public double? transirs_vergi { get; set; }

        public byte? transirs_masraf_vergi_pntr { get; set; }

        public double? transirs_masraf_vergi { get; set; }

        public double? transirs_netagirlik { get; set; }

        public int? transirs_odeme_op { get; set; }

        [StringLength(50)]
        public string transirs_aciklama { get; set; }

        public short? transirs_sip_recid_dbcno { get; set; }

        public int? transirs_sip_recid_recno { get; set; }

        public DateTime? transirs_malkbl_sevk_tarihi { get; set; }

        [StringLength(25)]
        public string transirs_cari_srm_merkezi { get; set; }

        [StringLength(25)]
        public string transirs_stok_srm_merkezi { get; set; }

        public bool? transirs_vergisiz_fl { get; set; }

        public double? transirs_maliyet_ana { get; set; }

        public double? transirs_maliyet_alternatif { get; set; }

        public double? transirs_maliyet_orjinal { get; set; }

        [StringLength(25)]
        public string transirs_parti_kodu { get; set; }

        public int? transirs_lot_no { get; set; }

        [StringLength(25)]
        public string transirs_proje_kodu { get; set; }

        public byte? transirs_otv_pntr { get; set; }

        public double? transirs_otv_vergi { get; set; }

        public double? transirs_brutagirlik { get; set; }

        public double? transirs_otvtutari { get; set; }

        public bool? transirs_otvvergisiz_fl { get; set; }

        public byte? transirs_oiv_pntr { get; set; }

        public double? transirs_oiv_tutar { get; set; }

        public double? transirs_oiv_vergi { get; set; }

        public bool? transirs_oivvergisiz_fl { get; set; }

        public int? transirs_fiyatlisteno { get; set; }

        public short? transirs_talepkomfat_recid_dbcno { get; set; }

        public int? transirs_talepkomfat_recid_recno { get; set; }

        public short? transirs_teminkomfat_recid_dbcno { get; set; }

        public int? transirs_teminkomfat_recid_recno { get; set; }
    }
}
