namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_HAREKETLERI
    {
        [Key]
        public int sth_RECno { get; set; }

        public short sth_RECid_DBCno { get; set; }

        public int sth_RECid_RECno { get; set; }

        public int? sth_SpecRECno { get; set; }

        public bool? sth_iptal { get; set; }

        public short? sth_fileid { get; set; }

        public bool? sth_hidden { get; set; }

        public bool? sth_kilitli { get; set; }

        public bool? sth_degisti { get; set; }

        public int? sth_checksum { get; set; }

        public short? sth_create_user { get; set; }

        public DateTime? sth_create_date { get; set; }

        public short? sth_lastup_user { get; set; }

        public DateTime? sth_lastup_date { get; set; }

        [StringLength(4)]
        public string sth_special1 { get; set; }

        [StringLength(4)]
        public string sth_special2 { get; set; }

        [StringLength(4)]
        public string sth_special3 { get; set; }

        public int? sth_firmano { get; set; }

        public int? sth_subeno { get; set; }

        public DateTime? sth_tarih { get; set; }

        public byte? sth_tip { get; set; }

        public byte? sth_cins { get; set; }

        public byte? sth_normal_iade { get; set; }

        public byte? sth_evraktip { get; set; }

        [StringLength(6)]
        public string sth_evrakno_seri { get; set; }

        public int? sth_evrakno_sira { get; set; }

        public int? sth_satirno { get; set; }

        [StringLength(20)]
        public string sth_belge_no { get; set; }

        public DateTime? sth_belge_tarih { get; set; }

        [StringLength(25)]
        public string sth_stok_kod { get; set; }

        public byte? sth_isk_mas1 { get; set; }

        public byte? sth_isk_mas2 { get; set; }

        public byte? sth_isk_mas3 { get; set; }

        public byte? sth_isk_mas4 { get; set; }

        public byte? sth_isk_mas5 { get; set; }

        public byte? sth_isk_mas6 { get; set; }

        public byte? sth_isk_mas7 { get; set; }

        public byte? sth_isk_mas8 { get; set; }

        public byte? sth_isk_mas9 { get; set; }

        public byte? sth_isk_mas10 { get; set; }

        public bool? sth_sat_iskmas1 { get; set; }

        public bool? sth_sat_iskmas2 { get; set; }

        public bool? sth_sat_iskmas3 { get; set; }

        public bool? sth_sat_iskmas4 { get; set; }

        public bool? sth_sat_iskmas5 { get; set; }

        public bool? sth_sat_iskmas6 { get; set; }

        public bool? sth_sat_iskmas7 { get; set; }

        public bool? sth_sat_iskmas8 { get; set; }

        public bool? sth_sat_iskmas9 { get; set; }

        public bool? sth_sat_iskmas10 { get; set; }

        public bool? sth_pos_satis { get; set; }

        public bool? sth_promosyon_fl { get; set; }

        public byte? sth_cari_cinsi { get; set; }

        [StringLength(25)]
        public string sth_cari_kodu { get; set; }

        public byte? sth_cari_grup_no { get; set; }

        [StringLength(25)]
        public string sth_isemri_gider_kodu { get; set; }

        [StringLength(25)]
        public string sth_plasiyer_kodu { get; set; }

        public byte? sth_har_doviz_cinsi { get; set; }

        public double? sth_har_doviz_kuru { get; set; }

        public double? sth_alt_doviz_kuru { get; set; }

        public byte? sth_stok_doviz_cinsi { get; set; }

        public double? sth_stok_doviz_kuru { get; set; }

        public double? sth_miktar { get; set; }

        public double? sth_miktar2 { get; set; }

        public byte? sth_birim_pntr { get; set; }

        public double? sth_tutar { get; set; }

        public double? sth_iskonto1 { get; set; }

        public double? sth_iskonto2 { get; set; }

        public double? sth_iskonto3 { get; set; }

        public double? sth_iskonto4 { get; set; }

        public double? sth_iskonto5 { get; set; }

        public double? sth_iskonto6 { get; set; }

        public double? sth_masraf1 { get; set; }

        public double? sth_masraf2 { get; set; }

        public double? sth_masraf3 { get; set; }

        public double? sth_masraf4 { get; set; }

        public byte? sth_vergi_pntr { get; set; }

        public double? sth_vergi { get; set; }

        public byte? sth_masraf_vergi_pntr { get; set; }

        public double? sth_masraf_vergi { get; set; }

        public double? sth_netagirlik { get; set; }

        public int? sth_odeme_op { get; set; }

        [StringLength(50)]
        public string sth_aciklama { get; set; }

        public short? sth_sip_recid_dbcno { get; set; }

        public int? sth_sip_recid_recno { get; set; }

        public short? sth_fat_recid_dbcno { get; set; }

        public int? sth_fat_recid_recno { get; set; }

        public int? sth_giris_depo_no { get; set; }

        public int? sth_cikis_depo_no { get; set; }

        public DateTime? sth_malkbl_sevk_tarihi { get; set; }

        [StringLength(25)]
        public string sth_cari_srm_merkezi { get; set; }

        [StringLength(25)]
        public string sth_stok_srm_merkezi { get; set; }

        public DateTime? sth_fis_tarihi { get; set; }

        public int? sth_fis_sirano { get; set; }

        public bool? sth_vergisiz_fl { get; set; }

        public double? sth_maliyet_ana { get; set; }

        public double? sth_maliyet_alternatif { get; set; }

        public double? sth_maliyet_orjinal { get; set; }

        public int? sth_adres_no { get; set; }

        [StringLength(25)]
        public string sth_parti_kodu { get; set; }

        public int? sth_lot_no { get; set; }

        public short? sth_kons_recid_dbcno { get; set; }

        public int? sth_kons_recid_recno { get; set; }

        [StringLength(25)]
        public string sth_proje_kodu { get; set; }

        [StringLength(25)]
        public string sth_exim_kodu { get; set; }

        public byte? sth_otv_pntr { get; set; }

        public double? sth_otv_vergi { get; set; }

        public double? sth_brutagirlik { get; set; }

        public byte? sth_disticaret_turu { get; set; }

        public double? sth_otvtutari { get; set; }

        public bool? sth_otvvergisiz_fl { get; set; }

        public byte? sth_oiv_pntr { get; set; }

        public double? sth_oiv_vergi { get; set; }

        public bool? sth_oivvergisiz_fl { get; set; }

        public int? sth_fiyat_liste_no { get; set; }

        public double? sth_oivtutari { get; set; }

        public byte? sth_Tevkifat_turu { get; set; }

        public int? sth_nakliyedeposu { get; set; }

        public byte? sth_nakliyedurumu { get; set; }

        public short? sth_yetkili_recid_dbcno { get; set; }

        public int? sth_yetkili_recid_recno { get; set; }

        public bool? sth_taxfree_fl { get; set; }

        public double? sth_ilave_edilecek_kdv { get; set; }

        [StringLength(25)]
        public string sth_ismerkezi_kodu { get; set; }
    }
}
