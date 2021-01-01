namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BUTCE_MASTER
    {
        [Key]
        public int bm_RECno { get; set; }

        public short bm_RECid_DBCno { get; set; }

        public int bm_RECid_RECno { get; set; }

        public int? bm_SpecRECno { get; set; }

        public bool? bm_iptal { get; set; }

        public short? bm_fileid { get; set; }

        public bool? bm_hidden { get; set; }

        public bool? bm_kilitli { get; set; }

        public bool? bm_degisti { get; set; }

        public int? bm_checksum { get; set; }

        public short? bm_create_user { get; set; }

        public DateTime? bm_create_date { get; set; }

        public short? bm_lastup_user { get; set; }

        public DateTime? bm_lastup_date { get; set; }

        [StringLength(4)]
        public string bm_special1 { get; set; }

        [StringLength(4)]
        public string bm_special2 { get; set; }

        [StringLength(4)]
        public string bm_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string bm_butcekodu { get; set; }

        [StringLength(40)]
        public string bm_butceadi { get; set; }

        public int? bm_firmano { get; set; }

        public byte? bm_butcetipi { get; set; }

        public byte? bm_stok_detayi { get; set; }

        public byte? bm_hizmet_detayi { get; set; }

        public byte? bm_masraf_detayi { get; set; }

        public byte? bm_cari_detayi { get; set; }

        public byte? bm_sorumlu_detayi { get; set; }

        public byte? bm_depo_detayi { get; set; }

        public byte? bm_sormrk_detayi { get; set; }

        public byte? bm_proje_detayi { get; set; }

        public byte? bm_donem_tipi { get; set; }

        public byte? bm_deger_detayi1 { get; set; }

        public byte? bm_deger_detayi2 { get; set; }

        public byte? bm_deger_detayi3 { get; set; }

        public byte? bm_deger_detayi4 { get; set; }

        public byte? bm_deger_detayi5 { get; set; }

        public byte? bm_MaxTanimliDonem { get; set; }

        [StringLength(25)]
        public string bm_Donem1_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem2_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem3_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem4_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem5_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem6_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem7_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem8_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem9_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem10_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem11_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem12_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem13_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem14_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem15_adi { get; set; }

        [StringLength(25)]
        public string bm_Donem16_adi { get; set; }

        public DateTime? bm_Donem1_bas { get; set; }

        public DateTime? bm_Donem1_bit { get; set; }

        public DateTime? bm_Donem2_bas { get; set; }

        public DateTime? bm_Donem2_bit { get; set; }

        public DateTime? bm_Donem3_bas { get; set; }

        public DateTime? bm_Donem3_bit { get; set; }

        public DateTime? bm_Donem4_bas { get; set; }

        public DateTime? bm_Donem4_bit { get; set; }

        public DateTime? bm_Donem5_bas { get; set; }

        public DateTime? bm_Donem5_bit { get; set; }

        public DateTime? bm_Donem6_bas { get; set; }

        public DateTime? bm_Donem6_bit { get; set; }

        public DateTime? bm_Donem7_bas { get; set; }

        public DateTime? bm_Donem7_bit { get; set; }

        public DateTime? bm_Donem8_bas { get; set; }

        public DateTime? bm_Donem8_bit { get; set; }

        public DateTime? bm_Donem9_bas { get; set; }

        public DateTime? bm_Donem9_bit { get; set; }

        public DateTime? bm_Donem10_bas { get; set; }

        public DateTime? bm_Donem10_bit { get; set; }

        public DateTime? bm_Donem11_bas { get; set; }

        public DateTime? bm_Donem11_bit { get; set; }

        public DateTime? bm_Donem12_bas { get; set; }

        public DateTime? bm_Donem12_bit { get; set; }

        public DateTime? bm_Donem13_bas { get; set; }

        public DateTime? bm_Donem13_bit { get; set; }

        public DateTime? bm_Donem14_bas { get; set; }

        public DateTime? bm_Donem14_bit { get; set; }

        public DateTime? bm_Donem15_bas { get; set; }

        public DateTime? bm_Donem15_bit { get; set; }

        public DateTime? bm_Donem16_bas { get; set; }

        public DateTime? bm_Donem16_bit { get; set; }

        public string bm_stok_detay_str { get; set; }

        public string bm_hizmet_detay_str { get; set; }

        public string bm_masraf_detay_str { get; set; }

        public string bm_cari_detay_str { get; set; }

        public string bm_sorumlu_detay_str { get; set; }

        public string bm_depo_detay_str { get; set; }

        public string bm_sormrk_detay_str { get; set; }

        public string bm_proje_detay_str { get; set; }

        public string bm_donem_detay_str { get; set; }
    }
}
