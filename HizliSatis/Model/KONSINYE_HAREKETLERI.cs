namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KONSINYE_HAREKETLERI
    {
        [Key]
        public int kon_RECno { get; set; }

        public short kon_RECid_DBCno { get; set; }

        public int kon_RECid_RECno { get; set; }

        public int? kon_SpecRecno { get; set; }

        public bool? kon_iptal { get; set; }

        public short? kon_fileid { get; set; }

        public bool? kon_hidden { get; set; }

        public bool? kon_kilitli { get; set; }

        public bool? kon_degisti { get; set; }

        public int? kon_checksum { get; set; }

        public short? kon_create_user { get; set; }

        public DateTime? kon_create_date { get; set; }

        public short? kon_lastup_user { get; set; }

        public DateTime? kon_lastup_date { get; set; }

        [StringLength(4)]
        public string kon_special1 { get; set; }

        [StringLength(4)]
        public string kon_special2 { get; set; }

        [StringLength(4)]
        public string kon_special3 { get; set; }

        public int? kon_firmano { get; set; }

        public int? kon_subeno { get; set; }

        public DateTime? kon_tarih { get; set; }

        public byte? kon_tip { get; set; }

        public byte? kon_normal_iade { get; set; }

        [StringLength(6)]
        public string kon_evrakno_seri { get; set; }

        public int? kon_evrakno_sira { get; set; }

        public int? kon_satirno { get; set; }

        [StringLength(20)]
        public string kon_belge_no { get; set; }

        public DateTime? kon_belge_tarih { get; set; }

        [StringLength(25)]
        public string kon_stok_kod { get; set; }

        [StringLength(25)]
        public string kon_cari_kod { get; set; }

        [StringLength(25)]
        public string kon_satici_kod { get; set; }

        public double? kon_miktar { get; set; }

        public double? kon_faturalanan { get; set; }

        [StringLength(50)]
        public string kon_aciklama { get; set; }

        public int? kon_giris_depo_no { get; set; }

        public int? kon_cikis_depo_no { get; set; }

        public DateTime? kon_malkabul_tarih { get; set; }

        public short? kon_sip_RECid_DBCno { get; set; }

        public int? kon_sip_RECid_RECno { get; set; }

        public double? kon_islemgoren { get; set; }

        public short? kon_karkonRecId_DBCn { get; set; }

        public int? kon_karkonRecId_RECn { get; set; }

        public double? kon_netagirlik { get; set; }

        public double? kon_brutagirlik { get; set; }

        public double? kon_rehinmiktari { get; set; }

        public double? kon_rehinfiyati { get; set; }

        public double? kon_miktar2 { get; set; }

        public double? kon_islemgoren2 { get; set; }

        public double? kon_sandikmiktari { get; set; }

        public double? kon_sandikfiyati { get; set; }

        public short? kon_sevk_adresno { get; set; }

        [StringLength(25)]
        public string kon_cari_srm_merkez { get; set; }

        [StringLength(25)]
        public string kon_stok_srm_merkez { get; set; }

        [StringLength(25)]
        public string kons_parti_kodu { get; set; }

        public int? kons_lot_no { get; set; }

        [StringLength(25)]
        public string kons_projekodu { get; set; }

        public byte? kons_har_doviz_cinsi { get; set; }

        public double? kons_har_doviz_kuru { get; set; }

        public double? kons_alt_doviz_kuru { get; set; }

        public byte? kons_stok_doviz_cinsi { get; set; }

        public double? kons_stok_doviz_kuru { get; set; }

        public int? kons_odeme_op { get; set; }

        public byte? kons_birim_pntr { get; set; }

        public double? kons_tutar { get; set; }

        public byte? kons_isk_mas1 { get; set; }

        public byte? kons_isk_mas2 { get; set; }

        public byte? kons_isk_mas3 { get; set; }

        public byte? kons_isk_mas4 { get; set; }

        public byte? kons_isk_mas5 { get; set; }

        public byte? kons_isk_mas6 { get; set; }

        public byte? kons_isk_mas7 { get; set; }

        public byte? kons_isk_mas8 { get; set; }

        public byte? kons_isk_mas9 { get; set; }

        public byte? kons_isk_mas10 { get; set; }

        public bool? kons_sat_iskmas1 { get; set; }

        public bool? kons_sat_iskmas2 { get; set; }

        public bool? kons_sat_iskmas3 { get; set; }

        public bool? kons_sat_iskmas4 { get; set; }

        public bool? kons_sat_iskmas5 { get; set; }

        public bool? kons_sat_iskmas6 { get; set; }

        public bool? kons_sat_iskmas7 { get; set; }

        public bool? kons_sat_iskmas8 { get; set; }

        public bool? kons_sat_iskmas9 { get; set; }

        public bool? kons_sat_iskmas10 { get; set; }

        public double? kons_iskonto1 { get; set; }

        public double? kons_iskonto2 { get; set; }

        public double? kons_iskonto3 { get; set; }

        public double? kons_iskonto4 { get; set; }

        public double? kons_iskonto5 { get; set; }

        public double? kons_iskonto6 { get; set; }

        public double? kons_masraf1 { get; set; }

        public double? kons_masraf2 { get; set; }

        public double? kons_masraf3 { get; set; }

        public double? kons_masraf4 { get; set; }

        public byte? kons_vergi_pntr { get; set; }

        public double? kons_vergi { get; set; }

        public byte? kons_masraf_vergi_pntr { get; set; }

        public double? kons_masraf_vergi { get; set; }

        public bool? kons_vergisiz_fl { get; set; }

        public byte? kons_otv_pntr { get; set; }

        public double? kons_otv_vergi { get; set; }

        public double? kons_otvtutari { get; set; }

        public bool? kons_otvvergisiz_fl { get; set; }

        public byte? kons_oiv_pntr { get; set; }

        public double? kons_oiv_vergi { get; set; }

        public bool? kons_oivvergisiz_fl { get; set; }

        public int? kons_fiyat_liste_no { get; set; }

        public byte? kon_cins { get; set; }

        public byte? kon_evraktip { get; set; }

        [StringLength(25)]
        public string kon_gider_kodu { get; set; }

        public double? kons_oivtutari { get; set; }

        public short? kon_irs_RECid_DBCno { get; set; }

        public int? kon_irs_RECid_RECno { get; set; }

        public short? kon_yetkili_recid_dbcno { get; set; }

        public int? kon_yetkili_recid_recno { get; set; }

        public int? kon_nakliyedeposu { get; set; }

        public byte? kon_nakliyedurumu { get; set; }
    }
}
