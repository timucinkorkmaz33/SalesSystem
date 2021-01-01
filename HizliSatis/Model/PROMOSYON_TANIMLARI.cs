namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROMOSYON_TANIMLARI
    {
        [Key]
        public int Promo_RECno { get; set; }

        public short Promo_RECid_DBCno { get; set; }

        public int Promo_RECid_RECno { get; set; }

        public int? Promo_SpecRECNo { get; set; }

        public bool? Promo_iptal { get; set; }

        public short? Promo_fileid { get; set; }

        public bool? Promo_hidden { get; set; }

        public bool? Promo_kilitli { get; set; }

        public bool? Promo_degisti { get; set; }

        public int? Promo_CheckSum { get; set; }

        public short? Promo_create_user { get; set; }

        public DateTime? Promo_create_date { get; set; }

        public short? Promo_lastup_user { get; set; }

        public DateTime? Promo_lastup_date { get; set; }

        [StringLength(4)]
        public string Promo_special1 { get; set; }

        [StringLength(4)]
        public string Promo_special2 { get; set; }

        [StringLength(4)]
        public string Promo_special3 { get; set; }

        [StringLength(25)]
        public string Promo_kodu { get; set; }

        [StringLength(50)]
        public string Promo_ismi { get; set; }

        public int Promo_SiraNo { get; set; }

        public byte? Promo_stok_kriter_tipi { get; set; }

        [StringLength(25)]
        public string Promo_stok_kriter_yapisi { get; set; }

        [StringLength(125)]
        public string Promo_stok_sorgu_cumlesi { get; set; }

        [StringLength(25)]
        public string Promo_matris_stok_kriteri1 { get; set; }

        public double? Promo_matris_stok_miktari1 { get; set; }

        [StringLength(25)]
        public string Promo_matris_stok_kriteri2 { get; set; }

        public double? Promo_matris_stok_miktari2 { get; set; }

        [StringLength(25)]
        public string Promo_matris_stok_kriteri3 { get; set; }

        public double? Promo_matris_stok_miktari3 { get; set; }

        [StringLength(25)]
        public string Promo_matris_stok_kriteri4 { get; set; }

        public double? Promo_matris_stok_miktari4 { get; set; }

        [StringLength(25)]
        public string Promo_matris_stok_kriteri5 { get; set; }

        public double? Promo_matris_stok_miktari5 { get; set; }

        [StringLength(25)]
        public string Promo_musteri_kod_yapisi { get; set; }

        public byte? Promo_stok_promosyon_tipi { get; set; }

        public byte? Promo_belge_Promosyon_tipi { get; set; }

        public byte? Promo_zaman_promosyon_tipi { get; set; }

        public byte? Promo_carpraz_promosyon_tipi { get; set; }

        public double? Promo_D1 { get; set; }

        public double? Promo_D2 { get; set; }

        public double? Promo_D3 { get; set; }

        public double? Promo_D4 { get; set; }

        [StringLength(25)]
        public string Promo_hediye_kodu { get; set; }

        public double? Promo_hediye_D1 { get; set; }

        public double? Promo_hediye_D2 { get; set; }

        public DateTime? Promo_baslangic_gunu { get; set; }

        public DateTime? Promo_bitis_gunu { get; set; }

        public bool? Promo_uygulama_gunleri1 { get; set; }

        public bool? Promo_uygulama_gunleri2 { get; set; }

        public bool? Promo_uygulama_gunleri3 { get; set; }

        public bool? Promo_uygulama_gunleri4 { get; set; }

        public bool? Promo_uygulama_gunleri5 { get; set; }

        public bool? Promo_uygulama_gunleri6 { get; set; }

        public bool? Promo_uygulama_gunleri7 { get; set; }

        public DateTime? Promo_gun_ici_baslangic_saati { get; set; }

        public DateTime? Promo_gun_ici_bitis_saati { get; set; }

        [StringLength(40)]
        public string Promo_kasaya_gidecek_mesaj { get; set; }
    }
}
