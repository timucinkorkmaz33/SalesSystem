namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_SERINO_TANIMLARI
    {
        [Key]
        public int chz_RECno { get; set; }

        public short chz_RECid_DBCno { get; set; }

        public int chz_RECid_RECno { get; set; }

        public int? chz_Spec_Rec_no { get; set; }

        public bool? chz_iptal { get; set; }

        public short? chz_fileid { get; set; }

        public bool? chz_hidden { get; set; }

        public bool? chz_kilitli { get; set; }

        public bool? chz_degisti { get; set; }

        public int? chz_checksum { get; set; }

        public short? chz_create_user { get; set; }

        public DateTime? chz_create_date { get; set; }

        public short? chz_lastup_user { get; set; }

        public DateTime? chz_lastup_date { get; set; }

        [StringLength(4)]
        public string chz_special1 { get; set; }

        [StringLength(4)]
        public string chz_special2 { get; set; }

        [StringLength(4)]
        public string chz_special3 { get; set; }

        [StringLength(25)]
        public string chz_serino { get; set; }

        [StringLength(25)]
        public string chz_stok_kodu { get; set; }

        [StringLength(25)]
        public string chz_grup_kodu { get; set; }

        [StringLength(25)]
        public string chz_Tuktckodu { get; set; }

        public DateTime? chz_GrnBasTarihi { get; set; }

        public DateTime? chz_GrnBitTarihi { get; set; }

        [StringLength(80)]
        public string chz_aciklama1 { get; set; }

        [StringLength(80)]
        public string chz_aciklama2 { get; set; }

        [StringLength(80)]
        public string chz_aciklama3 { get; set; }

        public DateTime? chz_al_tarih { get; set; }

        [StringLength(6)]
        public string chz_al_evr_seri { get; set; }

        public int? chz_al_evr_sira { get; set; }

        [StringLength(25)]
        public string chz_al_cari_kodu { get; set; }

        public DateTime? chz_al_wd_tarih { get; set; }

        [StringLength(6)]
        public string chz_al_wd_evr_seri { get; set; }

        public int? chz_al_wd_evr_sira { get; set; }

        public DateTime? chz_st_tarih { get; set; }

        [StringLength(6)]
        public string chz_st_evr_seri { get; set; }

        public int? chz_st_evr_sira { get; set; }

        [StringLength(25)]
        public string chz_st_cari_kodu { get; set; }

        public DateTime? chz_st_wd_tarih { get; set; }

        [StringLength(6)]
        public string chz_st_wd_evr_seri { get; set; }

        public int? chz_st_wd_evr_sira { get; set; }

        public double? chz_brut_fiati { get; set; }

        public double? chz_al_fiati_ana { get; set; }

        public double? chz_al_fiati_alt { get; set; }

        public double? chz_al_fiati_orj { get; set; }

        public double? chz_st_fiati_ana { get; set; }

        public double? chz_st_fiati_alt { get; set; }

        public double? chz_st_fiati_orj { get; set; }

        public bool? chz_parca_garantisi { get; set; }

        [StringLength(25)]
        public string chz_parca_serino { get; set; }

        public DateTime? chz_parca_garanti_baslangic { get; set; }

        public DateTime? chz_parca_garanti_bitis { get; set; }

        public byte? chz_makina_tipi { get; set; }

        [StringLength(4)]
        public string chz_model_yili { get; set; }

        public DateTime? chz_kiraya_acilma_tarihi { get; set; }

        public DateTime? chz_musteri_garanti_baslangic { get; set; }

        public DateTime? chz_musteri_garanti_bitis { get; set; }

        [StringLength(25)]
        public string chz_demirbas_kodu { get; set; }

        public DateTime? chz_tescil_tarihi { get; set; }

        public byte? chz_bakim_tipi { get; set; }

        public DateTime? chz_bakim_tarihi { get; set; }

        public int? chz_ara_bakim_sayisi { get; set; }

        public byte? chz_bakim_peryodu { get; set; }
    }
}
