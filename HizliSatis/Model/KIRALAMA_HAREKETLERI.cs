namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_HAREKETLERI
    {
        [Key]
        public int khar_RECno { get; set; }

        public short khar_RECid_DBCno { get; set; }

        public int khar_RECid_RECno { get; set; }

        public int? khar_Spec_Rec_no { get; set; }

        public bool? khar_iptal { get; set; }

        public short? khar_fileid { get; set; }

        public bool? khar_hidden { get; set; }

        public bool? khar_kilitli { get; set; }

        public bool? khar_degisti { get; set; }

        public int? khar_checksum { get; set; }

        public short? khar_create_user { get; set; }

        public DateTime? khar_create_date { get; set; }

        public short? khar_lastup_user { get; set; }

        public DateTime? khar_lastup_date { get; set; }

        [StringLength(4)]
        public string khar_special1 { get; set; }

        [StringLength(4)]
        public string khar_special2 { get; set; }

        [StringLength(4)]
        public string khar_special3 { get; set; }

        public int? khar_firmano { get; set; }

        public int? khar_subeno { get; set; }

        [StringLength(25)]
        public string khar_kodu { get; set; }

        public DateTime? khar_tarihi { get; set; }

        [StringLength(25)]
        public string khar_cari_kodu { get; set; }

        public byte? khar_doviz_cinsi { get; set; }

        public byte? khar_fat_doviz_cinsi { get; set; }

        [StringLength(60)]
        public string khar_aciklama { get; set; }

        [StringLength(60)]
        public string khar_aciklama2 { get; set; }

        public int? khar_fat_adres_no { get; set; }

        public int? khar_sevk_adres_no { get; set; }

        public int? khar_depono { get; set; }

        [StringLength(25)]
        public string khar_temsilci_kodu { get; set; }

        public short? khar_yetkili_recid_dbcno { get; set; }

        public int? khar_yetkili_recid_recno { get; set; }

        [StringLength(25)]
        public string khar_srm_merkezi_kodu { get; set; }

        [StringLength(25)]
        public string khar_proje_kodu { get; set; }

        [StringLength(25)]
        public string khar_kullanim_alani_kodu { get; set; }

        [StringLength(25)]
        public string khar_yapilan_is_kodu { get; set; }

        public int? khar_opno { get; set; }

        public DateTime? khar_baslangic_tarihi { get; set; }

        public byte? khar_fatura_peryodu { get; set; }

        public short? khar_fatura_gunu { get; set; }

        public byte? khar_kiralama_cinsi { get; set; }

        [StringLength(6)]
        public string khar_son_faturano_seri { get; set; }

        public int? khar_son_faturano_sira { get; set; }

        public int? khar_satirno { get; set; }

        public byte? khar_hareket_tipi { get; set; }

        [StringLength(25)]
        public string khar_hareket_kodu { get; set; }

        [StringLength(25)]
        public string khar_seri_no { get; set; }

        public int? khar_kiralama_suresi { get; set; }

        public double? khar_isk_tutari { get; set; }

        public double? khar_tutar { get; set; }

        [StringLength(60)]
        public string khar_satir_aciklama { get; set; }

        public byte? khar_durumu { get; set; }

        public int? khar_revize_sure { get; set; }

        public double? khar_revize_tutar { get; set; }

        public DateTime? khar_bitis_tarihi { get; set; }

        public DateTime? khar_tahmini_donus_tarihi { get; set; }

        public DateTime? khar_faturalanan_son_tarih { get; set; }

        [StringLength(6)]
        public string khar_hizmet_faturano_seri { get; set; }

        public int? khar_hizmet_faturano_sira { get; set; }

        public short? khar_ktkf_recid_dbcno { get; set; }

        public int? khar_ktkf_recid_recno { get; set; }
    }
}
