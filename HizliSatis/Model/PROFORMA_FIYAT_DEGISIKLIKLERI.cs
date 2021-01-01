namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROFORMA_FIYAT_DEGISIKLIKLERI
    {
        [Key]
        public int prfd_RECno { get; set; }

        public short prfd_RECid_DBCno { get; set; }

        public int prfd_RECid_RECno { get; set; }

        public int? prfd_SpecRecNo { get; set; }

        public bool? prfd_iptal { get; set; }

        public short? prfd_fileid { get; set; }

        public bool? prfd_hidden { get; set; }

        public bool? prfd_kilitli { get; set; }

        public bool? prfd_degisti { get; set; }

        public int? prfd_checksum { get; set; }

        public short? prfd_create_user { get; set; }

        public DateTime? prfd_create_date { get; set; }

        public short? prfd_lastup_user { get; set; }

        public DateTime? prfd_lastup_date { get; set; }

        [StringLength(4)]
        public string prfd_special1 { get; set; }

        [StringLength(4)]
        public string prfd_special2 { get; set; }

        [StringLength(4)]
        public string prfd_special3 { get; set; }

        public int? prfd_evrak_satir_no { get; set; }

        [StringLength(6)]
        public string prfd_evrak_seri_no { get; set; }

        public int? prfd_evrak_sira_no { get; set; }

        public DateTime? prfd_evrak_tarih { get; set; }

        [StringLength(20)]
        public string prfd_belge_no { get; set; }

        public DateTime? prfd_belge_tarih { get; set; }

        [StringLength(25)]
        public string prfd_stok_kod { get; set; }

        public DateTime? prfd_tarih { get; set; }

        public byte? prfd_saat { get; set; }

        public byte? prfd_fiyat_deg_neden { get; set; }

        public int? prfd_fiyat_no { get; set; }

        public double? prfd_eskifiy_tutar { get; set; }

        public byte? prfd_eskifiy_doviz { get; set; }

        [StringLength(4)]
        public string prfd_eskifiy_iskonto { get; set; }

        public int? prfd_eskifiy_opno { get; set; }

        public double? prfd_yenifiy_tutar { get; set; }

        public byte? prfd_yenifiy_doviz { get; set; }

        [StringLength(4)]
        public string prfd_yenifiy_iskonto { get; set; }

        public int? prfd_yenifiy_opno { get; set; }

        public double? prfd_eski_karorani { get; set; }

        public double? prfd_yeni_karorani { get; set; }

        public int? prfd_depo_no { get; set; }

        public byte? prfd_OnaylayanKulNo { get; set; }

        public bool? prfd_cagrilabilir_fl { get; set; }

        public bool? prfd_kapat_fl { get; set; }

        public double? prfd_oncekifiy_tutar { get; set; }

        public byte? prfd_oncekifiy_doviz { get; set; }

        [StringLength(4)]
        public string prfd_oncekifiy_iskonto { get; set; }

        public int? prfd_oncekifiy_opno { get; set; }

        [StringLength(25)]
        public string prfd_kapatmanedenkod { get; set; }
    }
}
