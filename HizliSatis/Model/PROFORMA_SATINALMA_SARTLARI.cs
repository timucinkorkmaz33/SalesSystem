namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROFORMA_SATINALMA_SARTLARI
    {
        [Key]
        public int prosas_RECno { get; set; }

        public short prosas_RECid_DBCno { get; set; }

        public int prosas_RECid_RECno { get; set; }

        public int? prosas_SpecRECno { get; set; }

        public bool? prosas_iptal { get; set; }

        public short? prosas_fileid { get; set; }

        public bool? prosas_hidden { get; set; }

        public bool? prosas_kilitli { get; set; }

        public bool? prosas_degisti { get; set; }

        public int? prosas_checksum { get; set; }

        public short? prosas_create_user { get; set; }

        public DateTime? prosas_create_date { get; set; }

        public short? prosas_lastup_user { get; set; }

        public DateTime? prosas_lastup_date { get; set; }

        [StringLength(4)]
        public string prosas_special1 { get; set; }

        [StringLength(4)]
        public string prosas_special2 { get; set; }

        [StringLength(4)]
        public string prosas_special3 { get; set; }

        [StringLength(25)]
        public string prosas_stok_kod { get; set; }

        [StringLength(25)]
        public string prosas_cari_kod { get; set; }

        [StringLength(6)]
        public string prosas_evrak_no_seri { get; set; }

        public int? prosas_evrak_no_sira { get; set; }

        public DateTime? prosas_evrak_tarih { get; set; }

        public int? prosas_satir_no { get; set; }

        [StringLength(20)]
        public string prosas_belge_no { get; set; }

        public DateTime? prosas_belge_tarih { get; set; }

        public double? prosas_asgari_miktar { get; set; }

        public short? prosas_teslim_sure { get; set; }

        public DateTime? prosas_basla_tarih { get; set; }

        public DateTime? prosas_bitis_tarih { get; set; }

        public double? prosas_brut_fiyat { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik1 { get; set; }

        public byte? prosas_isk_uyg1 { get; set; }

        public byte? prosas_isk_durum1 { get; set; }

        public byte? prosas_isk_vergi1 { get; set; }

        public double? prosas_isk_kriter1 { get; set; }

        public double? prosas_isk_yuzde1 { get; set; }

        public double? prosas_isk_miktar1 { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik2 { get; set; }

        public byte? prosas_isk_uyg2 { get; set; }

        public byte? prosas_isk_durum2 { get; set; }

        public byte? prosas_isk_vergi2 { get; set; }

        public double? prosas_isk_kriter2 { get; set; }

        public double? prosas_isk_yuzde2 { get; set; }

        public double? prosas_isk_miktar2 { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik3 { get; set; }

        public byte? prosas_isk_uyg3 { get; set; }

        public byte? prosas_isk_durum3 { get; set; }

        public byte? prosas_isk_vergi3 { get; set; }

        public double? prosas_isk_kriter3 { get; set; }

        public double? prosas_isk_yuzde3 { get; set; }

        public double? prosas_isk_miktar3 { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik4 { get; set; }

        public byte? prosas_isk_uyg4 { get; set; }

        public byte? prosas_isk_durum4 { get; set; }

        public byte? prosas_isk_vergi4 { get; set; }

        public double? prosas_isk_kriter4 { get; set; }

        public double? prosas_isk_yuzde4 { get; set; }

        public double? prosas_isk_miktar4 { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik5 { get; set; }

        public byte? prosas_isk_uyg5 { get; set; }

        public byte? prosas_isk_durum5 { get; set; }

        public byte? prosas_isk_vergi5 { get; set; }

        public double? prosas_isk_kriter5 { get; set; }

        public double? prosas_isk_yuzde5 { get; set; }

        public double? prosas_isk_miktar5 { get; set; }

        [StringLength(20)]
        public string prosas_isk_acik6 { get; set; }

        public byte? prosas_isk_uyg6 { get; set; }

        public byte? prosas_isk_durum6 { get; set; }

        public byte? prosas_isk_vergi6 { get; set; }

        public double? prosas_isk_kriter6 { get; set; }

        public double? prosas_isk_yuzde6 { get; set; }

        public double? prosas_isk_miktar6 { get; set; }

        [StringLength(20)]
        public string prosas_mas_acik1 { get; set; }

        public byte? prosas_mas_uyg1 { get; set; }

        public byte? prosas_mas_durum1 { get; set; }

        public byte? prosas_mas_vergi1 { get; set; }

        public double? prosas_mas_kriter1 { get; set; }

        public double? prosas_mas_yuzde1 { get; set; }

        public double? prosas_mas_miktar1 { get; set; }

        [StringLength(20)]
        public string prosas_mas_acik2 { get; set; }

        public byte? prosas_mas_uyg2 { get; set; }

        public byte? prosas_mas_durum2 { get; set; }

        public byte? prosas_mas_vergi2 { get; set; }

        public double? prosas_mas_kriter2 { get; set; }

        public double? prosas_mas_yuzde2 { get; set; }

        public double? prosas_mas_miktar2 { get; set; }

        [StringLength(20)]
        public string prosas_mas_acik3 { get; set; }

        public byte? prosas_mas_uyg3 { get; set; }

        public byte? prosas_mas_durum3 { get; set; }

        public byte? prosas_mas_vergi3 { get; set; }

        public double? prosas_mas_kriter3 { get; set; }

        public double? prosas_mas_yuzde3 { get; set; }

        public double? prosas_mas_miktar3 { get; set; }

        [StringLength(20)]
        public string prosas_mas_acik4 { get; set; }

        public byte? prosas_mas_uyg4 { get; set; }

        public byte? prosas_mas_durum4 { get; set; }

        public byte? prosas_mas_vergi4 { get; set; }

        public double? prosas_mas_kriter4 { get; set; }

        public double? prosas_mas_yuzde4 { get; set; }

        public double? prosas_mas_miktar4 { get; set; }

        public int? prosas_odeme_plan { get; set; }

        public double? prosas_net_alis_kdvli { get; set; }

        public double? prosas_kar_oran { get; set; }

        public double? prosas_net_satis_kdvli { get; set; }

        public double? prosas_satis_fiyat { get; set; }

        public byte? prosas_doviz_cinsi { get; set; }

        public byte? prosas_evrtipi { get; set; }

        [StringLength(40)]
        public string prosas_aciklama { get; set; }

        public int? prosas_depo_no { get; set; }

        public bool? prosas_maliyette_kullan_fl { get; set; }

        public double? prosas_ilave_maliyet_tutari { get; set; }

        public double? prosas_ilave_maliyet_yuzdesi { get; set; }

        public bool? prosas_Kesinlesti_fl { get; set; }

        public short? prosas_sas_RECid_DBCno { get; set; }

        public int? prosas_sas_RECid_RECno { get; set; }
    }
}
