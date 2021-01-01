namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAPLAR
    {
        [Key]
        public int cari_RECno { get; set; }

        public short cari_RECid_DBCno { get; set; }

        public int cari_RECid_RECno { get; set; }

        public int? cari_SpecRECno { get; set; }

        public bool? cari_iptal { get; set; }

        public short? cari_fileid { get; set; }

        public bool? cari_hidden { get; set; }

        public bool? cari_kilitli { get; set; }

        public bool? cari_degisti { get; set; }

        public int? cari_checksum { get; set; }

        public short? cari_create_user { get; set; }

        public DateTime? cari_create_date { get; set; }

        public short? cari_lastup_user { get; set; }

        public DateTime? cari_lastup_date { get; set; }

        [StringLength(4)]
        public string cari_special1 { get; set; }

        [StringLength(4)]
        public string cari_special2 { get; set; }

        [StringLength(4)]
        public string cari_special3 { get; set; }

        [StringLength(25)]
        public string cari_kod { get; set; }

        [StringLength(50)]
        public string cari_unvan1 { get; set; }

        [StringLength(50)]
        public string cari_unvan2 { get; set; }

        public byte? cari_hareket_tipi { get; set; }

        public byte? cari_baglanti_tipi { get; set; }

        public byte? cari_stok_alim_cinsi { get; set; }

        public byte? cari_stok_satim_cinsi { get; set; }

        [StringLength(40)]
        public string cari_muh_kod { get; set; }

        [StringLength(40)]
        public string cari_muh_kod1 { get; set; }

        [StringLength(40)]
        public string cari_muh_kod2 { get; set; }

        public byte? cari_doviz_cinsi { get; set; }

        public byte? cari_doviz_cinsi1 { get; set; }

        public byte? cari_doviz_cinsi2 { get; set; }

        public double? cari_vade_fark_yuz { get; set; }

        public double? cari_vade_fark_yuz1 { get; set; }

        public double? cari_vade_fark_yuz2 { get; set; }

        public byte? cari_KurHesapSekli { get; set; }

        [StringLength(50)]
        public string cari_vdaire_adi { get; set; }

        [StringLength(15)]
        public string cari_vdaire_no { get; set; }

        [StringLength(15)]
        public string cari_sicil_no { get; set; }

        [StringLength(10)]
        public string cari_VergiKimlikNo { get; set; }

        public int? cari_satis_fk { get; set; }

        public byte? cari_odeme_cinsi { get; set; }

        public byte? cari_odeme_gunu { get; set; }

        public int? cari_odemeplan_no { get; set; }

        public int? cari_opsiyon_gun { get; set; }

        public byte? cari_cariodemetercihi { get; set; }

        public int? cari_fatura_adres_no { get; set; }

        public int? cari_sevk_adres_no { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod1 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod1 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod1 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno1 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu1 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod2 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod2 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod2 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno2 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu2 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod3 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod3 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod3 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno3 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu3 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod4 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod4 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod4 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno4 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu4 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod5 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod5 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod5 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno5 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu5 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod6 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod6 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod6 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno6 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu6 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod7 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod7 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod7 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno7 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu7 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod8 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod8 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod8 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno8 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu8 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod9 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod9 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod9 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno9 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu9 { get; set; }

        [StringLength(4)]
        public string cari_banka_tcmb_kod10 { get; set; }

        [StringLength(8)]
        public string cari_banka_tcmb_subekod10 { get; set; }

        [StringLength(3)]
        public string cari_banka_tcmb_ilkod10 { get; set; }

        [StringLength(30)]
        public string cari_banka_hesapno10 { get; set; }

        [StringLength(25)]
        public string cari_banka_swiftkodu10 { get; set; }

        public byte? cari_EftHesapNum { get; set; }

        [StringLength(25)]
        public string cari_Ana_cari_kodu { get; set; }

        [StringLength(4)]
        public string cari_satis_isk_kod { get; set; }

        [StringLength(25)]
        public string cari_sektor_kodu { get; set; }

        [StringLength(25)]
        public string cari_bolge_kodu { get; set; }

        [StringLength(25)]
        public string cari_grup_kodu { get; set; }

        [StringLength(25)]
        public string cari_temsilci_kodu { get; set; }

        [StringLength(10)]
        public string cari_muhartikeli { get; set; }

        public bool? cari_firma_acik_kapal { get; set; }

        public bool? cari_BUV_tabi_fl { get; set; }

        public bool? cari_cari_kilitli_flg { get; set; }

        public bool? cari_etiket_bas_fl { get; set; }

        public bool? cari_Detay_incele_flg { get; set; }

        public bool? cari_efatura_fl { get; set; }

        public double? cari_POS_ongpesyuzde { get; set; }

        public double? cari_POS_ongtaksayi { get; set; }

        public double? cari_POS_ongIskOran { get; set; }

        public DateTime? cari_kaydagiristarihi { get; set; }

        public double? cari_KabEdFCekTutar { get; set; }

        public byte? cari_hal_caritip { get; set; }

        public double? cari_HalKomYuzdesi { get; set; }

        public short? cari_TeslimSuresi { get; set; }

        [StringLength(30)]
        public string cari_wwwadresi { get; set; }

        [StringLength(80)]
        public string cari_EMail { get; set; }

        [StringLength(20)]
        public string cari_CepTel { get; set; }

        public int? cari_VarsayilanGirisDepo { get; set; }

        public int? cari_VarsayilanCikisDepo { get; set; }

        public bool? cari_Portal_Enabled { get; set; }

        [StringLength(127)]
        public string cari_Portal_PW { get; set; }

        public int? cari_BagliOrtaklisa_Firma { get; set; }

        [StringLength(4)]
        public string cari_kampanyakodu { get; set; }

        public bool? cari_b_bakiye_degerlendirilmesin_fl { get; set; }

        public bool? cari_a_bakiye_degerlendirilmesin_fl { get; set; }

        public bool? cari_b_irsbakiye_degerlendirilmesin_fl { get; set; }

        public bool? cari_a_irsbakiye_degerlendirilmesin_fl { get; set; }

        public bool? cari_b_sipbakiye_degerlendirilmesin_fl { get; set; }

        public bool? cari_a_sipbakiye_degerlendirilmesin_fl { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri1KiraKodu { get; set; }

        public byte? cari_AvmBilgileri1TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri2KiraKodu { get; set; }

        public byte? cari_AvmBilgileri2TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri3KiraKodu { get; set; }

        public byte? cari_AvmBilgileri3TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri4KiraKodu { get; set; }

        public byte? cari_AvmBilgileri4TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri5KiraKodu { get; set; }

        public byte? cari_AvmBilgileri5TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri6KiraKodu { get; set; }

        public byte? cari_AvmBilgileri6TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri7KiraKodu { get; set; }

        public byte? cari_AvmBilgileri7TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri8KiraKodu { get; set; }

        public byte? cari_AvmBilgileri8TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri9KiraKodu { get; set; }

        public byte? cari_AvmBilgileri9TebligatSekli { get; set; }

        [StringLength(25)]
        public string cari_AvmBilgileri10KiraKodu { get; set; }

        public byte? cari_AvmBilgileri10TebligatSekli { get; set; }

        public bool? cari_KrediRiskTakibiVar_flg { get; set; }

        [StringLength(40)]
        public string cari_ufrs_fark_muh_kod { get; set; }

        [StringLength(40)]
        public string cari_ufrs_fark_muh_kod1 { get; set; }

        [StringLength(40)]
        public string cari_ufrs_fark_muh_kod2 { get; set; }

        public byte? cari_odeme_sekli { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekAlacakMuhKodu { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekAlacakMuhKodu1 { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekAlacakMuhKodu2 { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekBorcMuhKodu { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekBorcMuhKodu1 { get; set; }

        [StringLength(40)]
        public string cari_TeminatMekBorcMuhKodu2 { get; set; }

        [StringLength(40)]
        public string cari_VerilenDepozitoTeminatMuhKodu { get; set; }

        [StringLength(40)]
        public string cari_VerilenDepozitoTeminatMuhKodu1 { get; set; }

        [StringLength(40)]
        public string cari_VerilenDepozitoTeminatMuhKodu2 { get; set; }

        [StringLength(40)]
        public string cari_AlinanDepozitoTeminatMuhKodu { get; set; }

        [StringLength(40)]
        public string cari_AlinanDepozitoTeminatMuhKodu1 { get; set; }

        [StringLength(40)]
        public string cari_AlinanDepozitoTeminatMuhKodu2 { get; set; }

        public byte? cari_def_efatura_cinsi { get; set; }

        public bool? cari_otv_tevkifatina_tabii_fl { get; set; }

        [StringLength(80)]
        public string cari_KEP_adresi { get; set; }

        public DateTime? cari_efatura_baslangic_tarihi { get; set; }

        [StringLength(80)]
        public string cari_mutabakat_mail_adresi { get; set; }

        [StringLength(25)]
        public string cari_mersis_no { get; set; }

        [StringLength(25)]
        public string cari_istasyon_cari_kodu { get; set; }

        public bool? cari_gonderionayi_sms { get; set; }

        public bool? cari_gonderionayi_email { get; set; }
    }
}
