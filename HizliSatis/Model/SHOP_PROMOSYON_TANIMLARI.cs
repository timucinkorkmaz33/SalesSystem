namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOP_PROMOSYON_TANIMLARI
    {
        [Key]
        public int sp_RECno { get; set; }

        public short sp_RECid_DBCno { get; set; }

        public int sp_RECid_RECno { get; set; }

        public int? sp_SpecRECNo { get; set; }

        public bool? sp_iptal { get; set; }

        public short? sp_fileid { get; set; }

        public bool? sp_hidden { get; set; }

        public bool? sp_kilitli { get; set; }

        public bool? sp_degisti { get; set; }

        public int? sp_CheckSum { get; set; }

        public short? sp_create_user { get; set; }

        public DateTime? sp_create_date { get; set; }

        public short? sp_lastup_user { get; set; }

        public DateTime? sp_lastup_date { get; set; }

        [StringLength(4)]
        public string sp_special1 { get; set; }

        [StringLength(4)]
        public string sp_special2 { get; set; }

        [StringLength(4)]
        public string sp_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string sp_kodu { get; set; }

        [StringLength(50)]
        public string sp_ismi { get; set; }

        public byte? sp_promosyon_evraktipi { get; set; }

        public byte? sp_pos_tipleri { get; set; }

        public bool? sp_aktif { get; set; }

        public short? sp_matrah_grubu { get; set; }

        public short? sp_matrah_grubu_SiraNo { get; set; }

        public DateTime? sp_baslangic_zamani { get; set; }

        public DateTime? sp_bitis_zamani { get; set; }

        public DateTime? sp_gun_ici_baslangic_saati { get; set; }

        public DateTime? sp_gun_ici_bitis_saati { get; set; }

        public byte? sp_uygulama_gunleri { get; set; }

        public byte? sp_depo_kisit_tipi { get; set; }

        [StringLength(127)]
        public string sp_depo_listesi { get; set; }

        public bool? sp_uygulama_zorunlu { get; set; }

        public int? sp_maksimum_iterasyon { get; set; }

        public int? sp_Musteri_kisitlari_PromoTip { get; set; }

        [StringLength(25)]
        public string sp_Musteri_kisitlari_Sorgu { get; set; }

        [StringLength(127)]
        public string sp_Musteri_kisitlari_StrData { get; set; }

        public double? sp_Musteri_kisitlari_DblData { get; set; }

        public int? sp_Musteri_kisitlari_IntData { get; set; }

        public int? sp_Urun_kisitlari_PromoTip { get; set; }

        public int? sp_Urun_Kosullar1_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar1_Sorgu { get; set; }

        public double? sp_Urun_Kosullar1_Min { get; set; }

        public double? sp_Urun_Kosullar1_Max { get; set; }

        public double? sp_Urun_Kosullar1_Haric { get; set; }

        public double? sp_Urun_Kosullar1_Group { get; set; }

        public double? sp_Urun_Kosullar1_Deger { get; set; }

        public int? sp_Urun_Kosullar1_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar1_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar2_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar2_Sorgu { get; set; }

        public double? sp_Urun_Kosullar2_Min { get; set; }

        public double? sp_Urun_Kosullar2_Max { get; set; }

        public double? sp_Urun_Kosullar2_Haric { get; set; }

        public double? sp_Urun_Kosullar2_Group { get; set; }

        public double? sp_Urun_Kosullar2_Deger { get; set; }

        public int? sp_Urun_Kosullar2_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar2_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar3_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar3_Sorgu { get; set; }

        public double? sp_Urun_Kosullar3_Min { get; set; }

        public double? sp_Urun_Kosullar3_Max { get; set; }

        public double? sp_Urun_Kosullar3_Haric { get; set; }

        public double? sp_Urun_Kosullar3_Group { get; set; }

        public double? sp_Urun_Kosullar3_Deger { get; set; }

        public int? sp_Urun_Kosullar3_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar3_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar4_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar4_Sorgu { get; set; }

        public double? sp_Urun_Kosullar4_Min { get; set; }

        public double? sp_Urun_Kosullar4_Max { get; set; }

        public double? sp_Urun_Kosullar4_Haric { get; set; }

        public double? sp_Urun_Kosullar4_Group { get; set; }

        public double? sp_Urun_Kosullar4_Deger { get; set; }

        public int? sp_Urun_Kosullar4_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar4_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar5_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar5_Sorgu { get; set; }

        public double? sp_Urun_Kosullar5_Min { get; set; }

        public double? sp_Urun_Kosullar5_Max { get; set; }

        public double? sp_Urun_Kosullar5_Haric { get; set; }

        public double? sp_Urun_Kosullar5_Group { get; set; }

        public double? sp_Urun_Kosullar5_Deger { get; set; }

        public int? sp_Urun_Kosullar5_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar5_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar6_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar6_Sorgu { get; set; }

        public double? sp_Urun_Kosullar6_Min { get; set; }

        public double? sp_Urun_Kosullar6_Max { get; set; }

        public double? sp_Urun_Kosullar6_Haric { get; set; }

        public double? sp_Urun_Kosullar6_Group { get; set; }

        public double? sp_Urun_Kosullar6_Deger { get; set; }

        public int? sp_Urun_Kosullar6_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar6_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar7_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar7_Sorgu { get; set; }

        public double? sp_Urun_Kosullar7_Min { get; set; }

        public double? sp_Urun_Kosullar7_Max { get; set; }

        public double? sp_Urun_Kosullar7_Haric { get; set; }

        public double? sp_Urun_Kosullar7_Group { get; set; }

        public double? sp_Urun_Kosullar7_Deger { get; set; }

        public int? sp_Urun_Kosullar7_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar7_Yakin_Deger { get; set; }

        public int? sp_Urun_Kosullar8_Tip { get; set; }

        [StringLength(127)]
        public string sp_Urun_Kosullar8_Sorgu { get; set; }

        public double? sp_Urun_Kosullar8_Min { get; set; }

        public double? sp_Urun_Kosullar8_Max { get; set; }

        public double? sp_Urun_Kosullar8_Haric { get; set; }

        public double? sp_Urun_Kosullar8_Group { get; set; }

        public double? sp_Urun_Kosullar8_Deger { get; set; }

        public int? sp_Urun_Kosullar8_Yakin_Tip { get; set; }

        public double? sp_Urun_Kosullar8_Yakin_Deger { get; set; }

        public int? sp_StdUygulama_Kodu { get; set; }

        [StringLength(25)]
        public string sp_StdUygulama_Urunler { get; set; }

        public double? sp_StdUygulama_MiktarDbl { get; set; }

        public double? sp_StdUygulama_DegerDbl { get; set; }

        public byte? sp_StdUygulama_OzelDurum { get; set; }

        public byte? sp_StdUygulama_iskonto_dagitim_sekli { get; set; }

        public byte? sp_StdUygulama_iskonto_index { get; set; }

        public byte? sp_StdUygulama_yuvarlama_tipi { get; set; }

        public double? sp_StdUygulama_yuvarlama_miktar { get; set; }

        [StringLength(127)]
        public string sp_StdUygulama_eksikse_mesaj { get; set; }

        [StringLength(127)]
        public string sp_StdUygulama_kasa_mesaji { get; set; }

        [StringLength(127)]
        public string sp_StdUygulama_ekbilgi { get; set; }

        [StringLength(127)]
        public string sp_Kazanma_Kriteri { get; set; }

        [StringLength(127)]
        public string sp_Uygulama_Sekli { get; set; }

        [StringLength(127)]
        public string sp_KazanmayaYakin_Kriteri { get; set; }
    }
}
