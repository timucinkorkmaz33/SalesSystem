namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_RECETE_REVIZYONLARI
    {
        [Key]
        public int urr_RECno { get; set; }

        public short urr_RECid_DBCno { get; set; }

        public int urr_RECid_RECno { get; set; }

        public int? urr_SpecRECno { get; set; }

        public bool? urr_iptal { get; set; }

        public short? urr_fileid { get; set; }

        public bool? urr_hidden { get; set; }

        public bool? urr_kilitli { get; set; }

        public bool? urr_degisti { get; set; }

        public int? urr_checksum { get; set; }

        public short? urr_create_user { get; set; }

        public DateTime? urr_create_date { get; set; }

        public short? urr_lastup_user { get; set; }

        public DateTime? urr_lastup_date { get; set; }

        [StringLength(4)]
        public string urr_special1 { get; set; }

        [StringLength(4)]
        public string urr_special2 { get; set; }

        [StringLength(4)]
        public string urr_special3 { get; set; }

        public byte? urr_anatipi { get; set; }

        [StringLength(25)]
        public string urr_anakod { get; set; }

        [StringLength(25)]
        public string urr_tanimkod { get; set; }

        public byte? urr_cinsi { get; set; }

        public bool? urr_recete_degisti { get; set; }

        public bool? urr_rota_degisti { get; set; }

        public int? urr_recete_revizyon_no { get; set; }

        public int? urr_rota_revizyon_no { get; set; }

        public DateTime? urr_revizyon_tarihi { get; set; }

        [StringLength(127)]
        public string urr_revizyon_aciklama { get; set; }

        public int? urr_rec_RECno { get; set; }

        public short? urr_rec_RECid_DBCno { get; set; }

        public int? urr_rec_RECid_RECno { get; set; }

        public int? urr_rec_SpecRECno { get; set; }

        public bool? urr_rec_iptal { get; set; }

        public short? urr_rec_fileid { get; set; }

        public bool? urr_rec_hidden { get; set; }

        public bool? urr_rec_kilitli { get; set; }

        public bool? urr_rec_degisti { get; set; }

        public int? urr_rec_checksum { get; set; }

        public short? urr_rec_create_user { get; set; }

        public DateTime? urr_rec_create_date { get; set; }

        public short? urr_rec_lastup_user { get; set; }

        public DateTime? urr_rec_lastup_date { get; set; }

        [StringLength(4)]
        public string urr_rec_special1 { get; set; }

        [StringLength(4)]
        public string urr_rec_special2 { get; set; }

        [StringLength(4)]
        public string urr_rec_special3 { get; set; }

        public byte? urr_rec_anatipi { get; set; }

        [StringLength(25)]
        public string urr_rec_anakod { get; set; }

        [StringLength(25)]
        public string urr_rec_tanimkod { get; set; }

        public byte? urr_rec_cinsi { get; set; }

        public DateTime? urr_rec_tarih { get; set; }

        [StringLength(127)]
        public string urr_rec_aciklama { get; set; }

        public byte? urr_rec_anabirim { get; set; }

        public double? urr_rec_anamiktar { get; set; }

        public byte? urr_rec_tuketim_tur { get; set; }

        [StringLength(25)]
        public string urr_rec_tuketim_kod { get; set; }

        [StringLength(25)]
        public string urr_rec_tuketim_tanim_kodu { get; set; }

        public byte? urr_rec_tuketim_recete_cinsi { get; set; }

        public double? urr_rec_tuketim_miktar { get; set; }

        public byte? urr_rec_tuketim_birim { get; set; }

        public byte? urr_rec_uretim_tuketim { get; set; }

        public int? urr_rec_satirno { get; set; }

        [StringLength(127)]
        public string urr_rec_satir_acik { get; set; }

        public int? urr_rec_depono { get; set; }

        public double? urr_rec_fireyuzde { get; set; }

        public DateTime? urr_rec_baslama_tarihi { get; set; }

        public DateTime? urr_rec_bitis_tarihi { get; set; }

        [StringLength(25)]
        public string urr_rec_alt_tukkod1 { get; set; }

        public double? urr_rec_alt_1_katsayi { get; set; }

        [StringLength(25)]
        public string urr_rec_alt_tukkod2 { get; set; }

        public double? urr_rec_alt_2_katsayi { get; set; }

        [StringLength(25)]
        public string urr_rec_alt_tukkod3 { get; set; }

        public double? urr_rec_alt_3_katsayi { get; set; }

        [StringLength(25)]
        public string urr_rec_alt_tukkod4 { get; set; }

        public double? urr_rec_alt_4_katsayi { get; set; }

        [StringLength(25)]
        public string urr_rec_alt_tukkod5 { get; set; }

        public double? urr_rec_alt_5_katsayi { get; set; }

        public short? urr_rec_safha_no { get; set; }

        public byte? urr_rec_safha_turu { get; set; }

        public byte? urr_rec_ana_renk_no { get; set; }

        public byte? urr_rec_ana_beden_no { get; set; }

        public byte? urr_rec_tuketim_renk_no { get; set; }

        public byte? urr_rec_tuketim_beden_no { get; set; }

        public byte? urr_rec_PlanlamaTipi { get; set; }

        public byte? urr_rec_eklenme_sarti { get; set; }

        [StringLength(70)]
        public string urr_rec_miktar_fonksiyon_adi { get; set; }

        public int? urr_rec_tuketim_recete_revizyon_no { get; set; }

        public int? urr_rec_tuketim_rota_revizyon_no { get; set; }

        public int? urr_URt_RECno { get; set; }

        public short? urr_URt_RECid_DBCno { get; set; }

        public int? urr_URt_RECid_RECno { get; set; }

        public int? urr_URt_SpecRECNo { get; set; }

        public bool? urr_URt_iptal { get; set; }

        public short? urr_URt_fileid { get; set; }

        public bool? urr_URt_hidden { get; set; }

        public bool? urr_URt_kilitli { get; set; }

        public bool? urr_URt_degisti { get; set; }

        public int? urr_URt_CheckSum { get; set; }

        public short? urr_URt_create_user { get; set; }

        public DateTime? urr_URt_create_date { get; set; }

        public short? urr_URt_lastup_user { get; set; }

        public DateTime? urr_URt_lastup_date { get; set; }

        [StringLength(4)]
        public string urr_URt_special1 { get; set; }

        [StringLength(4)]
        public string urr_URt_special2 { get; set; }

        [StringLength(4)]
        public string urr_URt_special3 { get; set; }

        [StringLength(25)]
        public string urr_URt_RotaUrunKodu { get; set; }

        public byte? urr_URt_cinsi { get; set; }

        public int? urr_URt_SatirNo { get; set; }

        public short? urr_URt_ID { get; set; }

        public short? urr_URt_BagliRotaID { get; set; }

        [StringLength(25)]
        public string urr_URt_OpKod { get; set; }

        public byte? urr_URt_RotaIsMerkeziveSureTespitTipi { get; set; }

        public byte? urr_URt_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string urr_URt_IsmerkeziveyaGrupKod { get; set; }

        public int? urr_URt_SabitHazirlikSuresi { get; set; }

        public int? urr_URt_DegiskenOperasyonSuresi { get; set; }

        public double? urr_URt_UretimMiktari { get; set; }

        public int? urr_URt_SabitOperasyonSuresi { get; set; }

        public double? urr_URt_CikisPartiMiktari { get; set; }

        public double? urr_URt_OperasyonSureCarpani { get; set; }

        public byte? urr_URt_OperasyonTekrarSayisi { get; set; }

        public double? urr_URt_Enerji1_miktari { get; set; }

        public double? urr_URt_Enerji2_miktari { get; set; }

        [StringLength(80)]
        public string urr_URt_Aciklama { get; set; }

        public short? urr_URt_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string urr_URt_KalipKodu { get; set; }

        public double? urr_URt_HazirlikElemanIhtiyaci { get; set; }

        public double? urr_URt_OperasyonElemanIhtiyaci { get; set; }

        public int? urr_rk_RECno { get; set; }

        public short? urr_rk_RECid_DBCno { get; set; }

        public int? urr_rk_RECid_RECno { get; set; }

        public int? urr_rk_SpecRECno { get; set; }

        public bool? urr_rk_iptal { get; set; }

        public short? urr_rk_fileid { get; set; }

        public bool? urr_rk_hidden { get; set; }

        public bool? urr_rk_kilitli { get; set; }

        public bool? urr_rk_degisti { get; set; }

        public int? urr_rk_checksum { get; set; }

        public short? urr_rk_create_user { get; set; }

        public DateTime? urr_rk_create_date { get; set; }

        public short? urr_rk_lastup_user { get; set; }

        public DateTime? urr_rk_lastup_date { get; set; }

        [StringLength(4)]
        public string urr_rk_special1 { get; set; }

        [StringLength(4)]
        public string urr_rk_special2 { get; set; }

        [StringLength(4)]
        public string urr_rk_special3 { get; set; }

        public short? urr_rk_recete_recid_dbcno { get; set; }

        public int? urr_rk_recete_recid_recno { get; set; }

        public int? urr_rk_satirno { get; set; }

        public byte? urr_rk_tablo { get; set; }

        [StringLength(80)]
        public string urr_rk_alan_adi { get; set; }

        public byte? urr_rk_islem { get; set; }

        [StringLength(80)]
        public string urr_rk_stringdata { get; set; }

        public byte? urr_rk_baglanti_tipi { get; set; }

        public int? urr_urd_RECno { get; set; }

        public short? urr_urd_RECid_DBCno { get; set; }

        public int? urr_urd_RECid_RECno { get; set; }

        public int? urr_urd_SpecRECNo { get; set; }

        public bool? urr_urd_iptal { get; set; }

        public short? urr_urd_fileid { get; set; }

        public bool? urr_urd_hidden { get; set; }

        public bool? urr_urd_kilitli { get; set; }

        public bool? urr_urd_degisti { get; set; }

        public int? urr_urd_CheckSum { get; set; }

        public short? urr_urd_create_user { get; set; }

        public DateTime? urr_urd_create_date { get; set; }

        public short? urr_urd_lastup_user { get; set; }

        public DateTime? urr_urd_lastup_date { get; set; }

        [StringLength(4)]
        public string urr_urd_special1 { get; set; }

        [StringLength(4)]
        public string urr_urd_special2 { get; set; }

        [StringLength(4)]
        public string urr_urd_special3 { get; set; }

        public short? urr_urd_BagliRota_RECid_DBCno { get; set; }

        public int? urr_urd_BagliRota_RECid_RECno { get; set; }

        public int? urr_urd_DetaySatirNo { get; set; }

        public byte? urr_urd_KriterDegeri1 { get; set; }

        public double? urr_urd_MaxDeger1 { get; set; }

        public double? urr_urd_MinDeger1 { get; set; }

        public byte? urr_urd_KriterDegeri2 { get; set; }

        public double? urr_urd_MaxDeger2 { get; set; }

        public double? urr_urd_MinDeger2 { get; set; }

        public byte? urr_urd_KriterDegeri3 { get; set; }

        public double? urr_urd_MaxDeger3 { get; set; }

        public double? urr_urd_MinDeger3 { get; set; }

        public byte? urr_urd_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string urr_urd_IsmerkeziveyaGrupKod { get; set; }

        public int? urr_urd_SabitHazirlikSuresi { get; set; }

        public int? urr_urd_DegiskenOperasyonSuresi { get; set; }

        public int? urr_urd_SabitOperasyonSuresi { get; set; }

        public double? urr_urd_UretimMiktari { get; set; }

        public double? urr_urd_CikisPartiMiktari { get; set; }

        public double? urr_urd_Enerji1_miktari { get; set; }

        public double? urr_urd_Enerji2_miktari { get; set; }

        [StringLength(80)]
        public string urr_urd_Aciklama { get; set; }

        public short? urr_urd_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string urr_urd_KalipKodu { get; set; }

        public double? urr_urd_HazirlikElemanIhtiyaci { get; set; }

        public double? urr_urd_OperasyonElemanIhtiyaci { get; set; }
    }
}
