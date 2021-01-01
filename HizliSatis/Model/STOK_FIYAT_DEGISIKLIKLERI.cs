namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_FIYAT_DEGISIKLIKLERI
    {
        [Key]
        public int fid_RECno { get; set; }

        public short fid_RECid_DBCno { get; set; }

        public int fid_RECid_RECno { get; set; }

        public int? fid_SpecRecNo { get; set; }

        public bool? fid_iptal { get; set; }

        public short? fid_fileid { get; set; }

        public bool? fid_hidden { get; set; }

        public bool? fid_kilitli { get; set; }

        public bool? fid_degisti { get; set; }

        public int? fid_checksum { get; set; }

        public short? fid_create_user { get; set; }

        public DateTime? fid_create_date { get; set; }

        public short? fid_lastup_user { get; set; }

        public DateTime? fid_lastup_date { get; set; }

        [StringLength(4)]
        public string fid_special1 { get; set; }

        [StringLength(4)]
        public string fid_special2 { get; set; }

        [StringLength(4)]
        public string fid_special3 { get; set; }

        public int? fid_evrak_satir_no { get; set; }

        [StringLength(6)]
        public string fid_evrak_seri_no { get; set; }

        public int? fid_evrak_sira_no { get; set; }

        public DateTime? fid_evrak_tarih { get; set; }

        [StringLength(20)]
        public string fid_belge_no { get; set; }

        public DateTime? fid_belge_tarih { get; set; }

        [StringLength(25)]
        public string fid_stok_kod { get; set; }

        public DateTime? fid_tarih { get; set; }

        public byte? fid_saat { get; set; }

        public byte? fid_fiyat_deg_neden { get; set; }

        public int? fid_fiyat_no { get; set; }

        public double? fid_eskifiy_tutar { get; set; }

        public byte? fid_eskifiy_doviz { get; set; }

        [StringLength(4)]
        public string fid_eskifiy_iskonto { get; set; }

        public int? fid_eskifiy_opno { get; set; }

        public double? fid_yenifiy_tutar { get; set; }

        public byte? fid_yenifiy_doviz { get; set; }

        [StringLength(4)]
        public string fid_yenifiy_iskonto { get; set; }

        public int? fid_yenifiy_opno { get; set; }

        public byte? fid_yapildi_fl { get; set; }

        public double? fid_eski_karorani { get; set; }

        public double? fid_yeni_karorani { get; set; }

        public int? fid_depo_no { get; set; }

        public short? fid_prof_RECid_DBCno { get; set; }

        public int? fid_prof_RECid_RECno { get; set; }
    }
}
