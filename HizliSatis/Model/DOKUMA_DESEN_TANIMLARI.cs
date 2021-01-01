namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOKUMA_DESEN_TANIMLARI
    {
        [Key]
        public int dd_RECno { get; set; }

        public short dd_RECid_DBCno { get; set; }

        public int dd_RECid_RECno { get; set; }

        public int? dd_SpecRECno { get; set; }

        public bool? dd_iptal { get; set; }

        public short? dd_fileid { get; set; }

        public bool? dd_hidden { get; set; }

        public bool? dd_kilitli { get; set; }

        public bool? dd_degisti { get; set; }

        public int? dd_checksum { get; set; }

        public short? dd_create_user { get; set; }

        public DateTime? dd_create_date { get; set; }

        public short? dd_lastup_user { get; set; }

        public DateTime? dd_lastup_date { get; set; }

        [StringLength(4)]
        public string dd_special1 { get; set; }

        [StringLength(4)]
        public string dd_special2 { get; set; }

        [StringLength(4)]
        public string dd_special3 { get; set; }

        [StringLength(25)]
        public string dd_stok_kodu { get; set; }

        [StringLength(50)]
        public string dd_aciklama { get; set; }

        public DateTime? dd_tanim_tarihi { get; set; }

        [StringLength(25)]
        public string dd_tanimlayan_kisi { get; set; }

        public double? dd_enden_cekme_yuzdesi { get; set; }

        public double? dd_boydan_cekme_yuzdesi { get; set; }

        [StringLength(25)]
        public string dd_musteri_1 { get; set; }

        [StringLength(25)]
        public string dd_musteri_2 { get; set; }

        [StringLength(25)]
        public string dd_musteri_3 { get; set; }

        [StringLength(25)]
        public string dd_zemin_cozgu_stok_kodu { get; set; }

        public double? dd_zemin_cozgu_sikligi { get; set; }

        [StringLength(25)]
        public string dd_hav_cozgu_stok_kodu { get; set; }

        public double? dd_hav_cozgu_sikligi { get; set; }

        public double? dd_hav_orani_hesaplanan { get; set; }

        public double? dd_hav_orani_olculen { get; set; }

        public double? dd_boyhavorani_hesaplanandan { get; set; }

        public double? dd_boyhavorani_olculenden { get; set; }

        public double? dd_uretim_gramaji { get; set; }

        public double? dd_mamul_gramaji { get; set; }

        public double? dd_mamul_eni_cm { get; set; }

        public double? dd_uretim_eni_cm { get; set; }

        public short? dd_dokuma_en_sayisi { get; set; }

        public double? dd_uretim_boyu { get; set; }

        public double? dd_mamul_boyu { get; set; }

        public double? dd_faydali_tarak_eni { get; set; }

        public short? dd_ilmek_atki_sayisi { get; set; }

        public double? dd_havdan_hava_boy { get; set; }

        public double? dd_havdan_hava_en { get; set; }
    }
}
