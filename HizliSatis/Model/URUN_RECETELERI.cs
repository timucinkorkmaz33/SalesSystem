namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_RECETELERI
    {
        [Key]
        public int rec_RECno { get; set; }

        public short rec_RECid_DBCno { get; set; }

        public int rec_RECid_RECno { get; set; }

        public int? rec_SpecRECno { get; set; }

        public bool? rec_iptal { get; set; }

        public short? rec_fileid { get; set; }

        public bool? rec_hidden { get; set; }

        public bool? rec_kilitli { get; set; }

        public bool? rec_degisti { get; set; }

        public int? rec_checksum { get; set; }

        public short? rec_create_user { get; set; }

        public DateTime? rec_create_date { get; set; }

        public short? rec_lastup_user { get; set; }

        public DateTime? rec_lastup_date { get; set; }

        [StringLength(4)]
        public string rec_special1 { get; set; }

        [StringLength(4)]
        public string rec_special2 { get; set; }

        [StringLength(4)]
        public string rec_special3 { get; set; }

        public byte? rec_anatipi { get; set; }

        [StringLength(25)]
        public string rec_anakod { get; set; }

        [StringLength(25)]
        public string rec_tanimkod { get; set; }

        public byte? rec_cinsi { get; set; }

        public DateTime? rec_tarih { get; set; }

        [StringLength(127)]
        public string rec_aciklama { get; set; }

        public byte? rec_anabirim { get; set; }

        public double? rec_anamiktar { get; set; }

        public byte? rec_tuketim_tur { get; set; }

        [StringLength(25)]
        public string rec_tuketim_kod { get; set; }

        [StringLength(25)]
        public string rec_tuketim_tanim_kodu { get; set; }

        public byte? rec_tuketim_recete_cinsi { get; set; }

        public double? rec_tuketim_miktar { get; set; }

        public byte? rec_tuketim_birim { get; set; }

        public byte? rec_uretim_tuketim { get; set; }

        public int? rec_satirno { get; set; }

        [StringLength(127)]
        public string rec_satir_acik { get; set; }

        public int? rec_depono { get; set; }

        public double? rec_fireyuzde { get; set; }

        public DateTime? rec_baslama_tarihi { get; set; }

        public DateTime? rec_bitis_tarihi { get; set; }

        [StringLength(25)]
        public string rec_alt_tukkod1 { get; set; }

        public double? rec_alt_1_katsayi { get; set; }

        [StringLength(25)]
        public string rec_alt_tukkod2 { get; set; }

        public double? rec_alt_2_katsayi { get; set; }

        [StringLength(25)]
        public string rec_alt_tukkod3 { get; set; }

        public double? rec_alt_3_katsayi { get; set; }

        [StringLength(25)]
        public string rec_alt_tukkod4 { get; set; }

        public double? rec_alt_4_katsayi { get; set; }

        [StringLength(25)]
        public string rec_alt_tukkod5 { get; set; }

        public double? rec_alt_5_katsayi { get; set; }

        public short? rec_safha_no { get; set; }

        public byte? rec_safha_turu { get; set; }

        public byte? rec_ana_renk_no { get; set; }

        public byte? rec_ana_beden_no { get; set; }

        public byte? rec_tuketim_renk_no { get; set; }

        public byte? rec_tuketim_beden_no { get; set; }

        public byte? rec_PlanlamaTipi { get; set; }

        public byte? rec_eklenme_sarti { get; set; }

        [StringLength(70)]
        public string rec_miktar_fonksiyon_adi { get; set; }
    }
}
