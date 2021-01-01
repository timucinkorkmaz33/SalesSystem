namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SATIS_SARTLARI
    {
        [Key]
        public int sat_RECno { get; set; }

        public short sat_RECid_DBCno { get; set; }

        public int sat_RECid_RECno { get; set; }

        public int? sat_SpecRECno { get; set; }

        public bool? sat_iptal { get; set; }

        public short? sat_fileid { get; set; }

        public bool? sat_hidden { get; set; }

        public bool? sat_kilitli { get; set; }

        public bool? sat_degisti { get; set; }

        public int? sat_checksum { get; set; }

        public short? sat_create_user { get; set; }

        public DateTime? sat_create_date { get; set; }

        public short? sat_lastup_user { get; set; }

        public DateTime? sat_lastup_date { get; set; }

        [StringLength(4)]
        public string sat_special1 { get; set; }

        [StringLength(4)]
        public string sat_special2 { get; set; }

        [StringLength(4)]
        public string sat_special3 { get; set; }

        [StringLength(25)]
        public string sat_stok_kod { get; set; }

        [StringLength(25)]
        public string sat_cari_kod { get; set; }

        [StringLength(6)]
        public string sat_evrakno_seri { get; set; }

        public int? sat_evrakno_sira { get; set; }

        public DateTime? sat_evrak_tarih { get; set; }

        public int? sat_satirno { get; set; }

        [StringLength(20)]
        public string sat_belgeno { get; set; }

        public DateTime? sat_belge_tarih { get; set; }

        public double? sat_asgari_miktar { get; set; }

        public short? sat_teslimat_sure { get; set; }

        public DateTime? sat_basla_tarih { get; set; }

        public DateTime? sat_bitis_tarih { get; set; }

        public double? sat_brut_fiyat { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik1 { get; set; }

        public byte? sat_det_isk_uyg1 { get; set; }

        public byte? sat_det_isk_durum1 { get; set; }

        public byte? sat_det_isk_vergi1 { get; set; }

        public double? sat_det_isk_kriter1 { get; set; }

        public double? sat_det_isk_yuzde1 { get; set; }

        public double? sat_det_isk_miktar1 { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik2 { get; set; }

        public byte? sat_det_isk_uyg2 { get; set; }

        public byte? sat_det_isk_durum2 { get; set; }

        public byte? sat_det_isk_vergi2 { get; set; }

        public double? sat_det_isk_kriter2 { get; set; }

        public double? sat_det_isk_yuzde2 { get; set; }

        public double? sat_det_isk_miktar2 { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik3 { get; set; }

        public byte? sat_det_isk_uyg3 { get; set; }

        public byte? sat_det_isk_durum3 { get; set; }

        public byte? sat_det_isk_vergi3 { get; set; }

        public double? sat_det_isk_kriter3 { get; set; }

        public double? sat_det_isk_yuzde3 { get; set; }

        public double? sat_det_isk_miktar3 { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik4 { get; set; }

        public byte? sat_det_isk_uyg4 { get; set; }

        public byte? sat_det_isk_durum4 { get; set; }

        public byte? sat_det_isk_vergi4 { get; set; }

        public double? sat_det_isk_kriter4 { get; set; }

        public double? sat_det_isk_yuzde4 { get; set; }

        public double? sat_det_isk_miktar4 { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik5 { get; set; }

        public byte? sat_det_isk_uyg5 { get; set; }

        public byte? sat_det_isk_durum5 { get; set; }

        public byte? sat_det_isk_vergi5 { get; set; }

        public double? sat_det_isk_kriter5 { get; set; }

        public double? sat_det_isk_yuzde5 { get; set; }

        public double? sat_det_isk_miktar5 { get; set; }

        [StringLength(20)]
        public string sat_det_isk_acik6 { get; set; }

        public byte? sat_det_isk_uyg6 { get; set; }

        public byte? sat_det_isk_durum6 { get; set; }

        public byte? sat_det_isk_vergi6 { get; set; }

        public double? sat_det_isk_kriter6 { get; set; }

        public double? sat_det_isk_yuzde6 { get; set; }

        public double? sat_det_isk_miktar6 { get; set; }

        [StringLength(20)]
        public string sat_det_mas_acik1 { get; set; }

        public byte? sat_det_mas_uyg1 { get; set; }

        public byte? sat_det_mas_durum1 { get; set; }

        public byte? sas_det_mas_vergi1 { get; set; }

        public double? sat_det_mas_kriter1 { get; set; }

        public double? sat_det_mas_yuzde1 { get; set; }

        public double? sat_det_mas_miktar1 { get; set; }

        [StringLength(20)]
        public string sat_det_mas_acik2 { get; set; }

        public byte? sat_det_mas_uyg2 { get; set; }

        public byte? sat_det_mas_durum2 { get; set; }

        public byte? sas_det_mas_vergi2 { get; set; }

        public double? sat_det_mas_kriter2 { get; set; }

        public double? sat_det_mas_yuzde2 { get; set; }

        public double? sat_det_mas_miktar2 { get; set; }

        [StringLength(20)]
        public string sat_det_mas_acik3 { get; set; }

        public byte? sat_det_mas_uyg3 { get; set; }

        public byte? sat_det_mas_durum3 { get; set; }

        public byte? sas_det_mas_vergi3 { get; set; }

        public double? sat_det_mas_kriter3 { get; set; }

        public double? sat_det_mas_yuzde3 { get; set; }

        public double? sat_det_mas_miktar3 { get; set; }

        [StringLength(20)]
        public string sat_det_mas_acik4 { get; set; }

        public byte? sat_det_mas_uyg4 { get; set; }

        public byte? sat_det_mas_durum4 { get; set; }

        public byte? sas_det_mas_vergi4 { get; set; }

        public double? sat_det_mas_kriter4 { get; set; }

        public double? sat_det_mas_yuzde4 { get; set; }

        public double? sat_det_mas_miktar4 { get; set; }

        public int? sat_odeme_plan { get; set; }

        public byte? sat_doviz_cinsi { get; set; }

        public int? sat_depo_no { get; set; }

        public int? sat_fiyat_liste_no { get; set; }
    }
}
