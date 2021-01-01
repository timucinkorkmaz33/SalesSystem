namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_FATURA_TANIMLARI
    {
        [Key]
        public int efp_RECno { get; set; }

        public short efp_RECid_DBCno { get; set; }

        public int efp_RECid_RECno { get; set; }

        public int? efp_SpecRECno { get; set; }

        public bool? efp_iptal { get; set; }

        public short? efp_fileid { get; set; }

        public bool? efp_hidden { get; set; }

        public bool? efp_kilitli { get; set; }

        public bool? efp_degisti { get; set; }

        public int? efp_checksum { get; set; }

        public short? efp_create_user { get; set; }

        public DateTime? efp_create_date { get; set; }

        public short? efp_lastup_user { get; set; }

        public DateTime? efp_lastup_date { get; set; }

        [StringLength(4)]
        public string efp_special1 { get; set; }

        [StringLength(4)]
        public string efp_special2 { get; set; }

        [StringLength(4)]
        public string efp_special3 { get; set; }

        public int? efp_firmano { get; set; }

        public int? efp_subeno { get; set; }

        [StringLength(25)]
        public string efp_kullanici { get; set; }

        [StringLength(127)]
        public string efp_sifre { get; set; }

        public byte? efp_entegrator_id { get; set; }

        public byte? efp_ucnokta_url_set { get; set; }

        [StringLength(40)]
        public string efp_fp_alias { get; set; }

        [StringLength(127)]
        public string efp_fp_sifre { get; set; }

        [StringLength(127)]
        public string efp_portal_izin { get; set; }

        [StringLength(127)]
        public string efp_portal_fatura_dosya { get; set; }

        [StringLength(3)]
        public string efp_portal_birim_kodu { get; set; }

        public int? efp_baslangic_degeri { get; set; }

        public bool? efp_aciklama_aktarilsin_fl { get; set; }

        public bool? efp_kabul_irs_karsila_fl { get; set; }

        public bool? efp_kabul_sip_karsila_fl { get; set; }

        public bool? efp_carievrak_kilitle_fl { get; set; }

        public bool? efp_belgetarihini_evraktarihi_kaydet_fl { get; set; }

        public bool? efp_irsaliye_belgeno_gonder_fl { get; set; }

        public bool? efp_siparis_belgeno_gonder_fl { get; set; }

        public bool? efp_satis_fat_stokbirlestir_fl { get; set; }

        public bool? efp_ana_dovizle_gonder_fl { get; set; }

        public bool? efp_detayli_goster_fl { get; set; }

        public bool? efp_satis_fat_hizmetbirlestir_fl { get; set; }

        public bool? efp_srmllk_prje_ayirdtmdn_hizm_brlstr { get; set; }

        public bool? efp_sevk_adresi_kullan_fl { get; set; }

        public bool? efp_yetkili_eposta_kullan_fl { get; set; }

        public bool? efp_alis_fat_efatura_kullanicisi_fl { get; set; }

        public bool? efp_srmllk_prje_ayirdtmdn_stok_brlstr { get; set; }

        [StringLength(127)]
        public string efp_VarsayilanIstisna_aciklama { get; set; }

        public int? efp_custom_irsaliye_field_count { get; set; }

        public double? efp_KDVFarkitutari { get; set; }

        [StringLength(25)]
        public string efp_EkMasraflarinKodu { get; set; }

        public bool? efp_FatBaglama_BelgeNoGuncelle_fl { get; set; }

        public bool? efp_YenidenEntegreFisAciklamaBelgeno_fl { get; set; }

        public byte? efp_NotHareketAciklamayaAktarilMAsin_fl { get; set; }

        public bool? efp_EvrakSiraGirilsin_fl { get; set; }

        public bool? efp_VKNSorguGlbVeritabanindan_fl { get; set; }

        public bool? efp_detay_takipsiz_stok_birlestir_fl { get; set; }

        public bool? efp_gonderimde_log_olustur_fl { get; set; }

        public byte? efp_irsaliye_siparis_eklentileri { get; set; }

        [StringLength(25)]
        public string efp_varsayilan_araci_kodu { get; set; }

        [StringLength(25)]
        public string efp_SGK_cari_kodu { get; set; }

        public bool? efp_subeye_gore_filtrele { get; set; }

        public byte? efp_navlun_masraf_tip { get; set; }

        public byte? efp_sigorta_masraf_tip { get; set; }

        public byte? efp_komisyon_masraf_tip { get; set; }

        public byte? efp_diger_masraf_tip { get; set; }

        [StringLength(50)]
        public string efp_diger_aciklama { get; set; }

        public byte? efp_KullaniciYetkiKontroluNereden { get; set; }
    }
}
