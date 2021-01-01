namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODEME_EMRI_ACILISLARI
    {
        [Key]
        public int sca_RECno { get; set; }

        public short sca_RECid_DBCno { get; set; }

        public int sca_RECid_RECno { get; set; }

        public int? sca_SpecRecNo { get; set; }

        public bool? sca_iptal { get; set; }

        public short? sca_fileid { get; set; }

        public bool? sca_hidden { get; set; }

        public bool? sca_kilitli { get; set; }

        public bool? sca_degisti { get; set; }

        public int? sca_CheckSum { get; set; }

        public short? sca_create_user { get; set; }

        public DateTime? sca_create_date { get; set; }

        public short? sca_lastup_user { get; set; }

        public DateTime? sca_lastup_date { get; set; }

        [StringLength(4)]
        public string sca_special1 { get; set; }

        [StringLength(4)]
        public string sca_special2 { get; set; }

        [StringLength(4)]
        public string sca_special3 { get; set; }

        public int? sca_firmano { get; set; }

        public int? sca_subeno { get; set; }

        public byte? sca_evrak_tip { get; set; }

        [StringLength(6)]
        public string sca_evrakno_seri { get; set; }

        public int? sca_evrakno_sira { get; set; }

        public int? sca_satir_no { get; set; }

        public DateTime? sca_tarihi { get; set; }

        public byte? sca_tip { get; set; }

        public byte? sca_cinsi { get; set; }

        public byte? sca_normal_Iade { get; set; }

        public byte? sca_tpoz { get; set; }

        public byte? sca_disticaret_turu { get; set; }

        [StringLength(20)]
        public string sca_belge_no { get; set; }

        public DateTime? sca_belge_tarih { get; set; }

        [StringLength(40)]
        public string sca_aciklama { get; set; }

        [StringLength(25)]
        public string sca_satici_kodu { get; set; }

        [StringLength(25)]
        public string sca_EXIMkodu { get; set; }

        [StringLength(25)]
        public string sca_projekodu { get; set; }

        [StringLength(25)]
        public string sca_yat_tes_kodu { get; set; }

        public byte? sca_cari_cins { get; set; }

        [StringLength(25)]
        public string sca_kod { get; set; }

        [StringLength(25)]
        public string sca_ciro_cari_kodu { get; set; }

        public byte? sca_d_cins { get; set; }

        public double? sca_d_kur { get; set; }

        public double? sca_altd_kur { get; set; }

        public byte? sca_grupno { get; set; }

        [StringLength(25)]
        public string sca_srmrkkodu { get; set; }

        public byte? sca_kasa_hizmet { get; set; }

        [StringLength(25)]
        public string sca_kasa_hizkod { get; set; }

        public byte? sca_karsidcinsi { get; set; }

        public double? sca_karsid_kur { get; set; }

        public byte? sca_karsidgrupno { get; set; }

        [StringLength(25)]
        public string sca_karsisrmrkkodu { get; set; }

        public double? sca_miktari { get; set; }

        public double? sca_meblag { get; set; }

        public double? sca_aratoplam { get; set; }

        public int? sca_vade { get; set; }

        public double? sca_Vade_Farki_Yuz { get; set; }

        public double? sca_ft_iskonto1 { get; set; }

        public double? sca_ft_iskonto2 { get; set; }

        public double? sca_ft_iskonto3 { get; set; }

        public double? sca_ft_iskonto4 { get; set; }

        public double? sca_ft_iskonto5 { get; set; }

        public double? sca_ft_iskonto6 { get; set; }

        public double? sca_ft_masraf1 { get; set; }

        public double? sca_ft_masraf2 { get; set; }

        public double? sca_ft_masraf3 { get; set; }

        public double? sca_ft_masraf4 { get; set; }

        public byte? sca_isk_mas1 { get; set; }

        public byte? sca_isk_mas2 { get; set; }

        public byte? sca_isk_mas3 { get; set; }

        public byte? sca_isk_mas4 { get; set; }

        public byte? sca_isk_mas5 { get; set; }

        public byte? sca_isk_mas6 { get; set; }

        public byte? sca_isk_mas7 { get; set; }

        public byte? sca_isk_mas8 { get; set; }

        public byte? sca_isk_mas9 { get; set; }

        public byte? sca_isk_mas10 { get; set; }

        public bool? sca_sat_iskmas1 { get; set; }

        public bool? sca_sat_iskmas2 { get; set; }

        public bool? sca_sat_iskmas3 { get; set; }

        public bool? sca_sat_iskmas4 { get; set; }

        public bool? sca_sat_iskmas5 { get; set; }

        public bool? sca_sat_iskmas6 { get; set; }

        public bool? sca_sat_iskmas7 { get; set; }

        public bool? sca_sat_iskmas8 { get; set; }

        public bool? sca_sat_iskmas9 { get; set; }

        public bool? sca_sat_iskmas10 { get; set; }

        public double? sca_yuvarlama { get; set; }

        public byte? sca_StFonPntr { get; set; }

        public double? sca_stopaj { get; set; }

        public double? sca_savsandesfonu { get; set; }

        public double? sca_avansmak_damgapul { get; set; }

        public byte? sca_vergipntr { get; set; }

        public double? sca_vergi1 { get; set; }

        public double? sca_vergi2 { get; set; }

        public double? sca_vergi3 { get; set; }

        public double? sca_vergi4 { get; set; }

        public double? sca_vergi5 { get; set; }

        public double? sca_vergi6 { get; set; }

        public double? sca_vergi7 { get; set; }

        public double? sca_vergi8 { get; set; }

        public double? sca_vergi9 { get; set; }

        public double? sca_vergi10 { get; set; }

        public bool? sca_vergisiz_fl { get; set; }

        public double? sca_otvtutari { get; set; }

        public bool? sca_otvvergisiz_fl { get; set; }

        public byte? sca_oiv_pntr { get; set; }

        public double? sca_oivtutari { get; set; }

        public double? sca_oiv_vergi { get; set; }

        public bool? sca_oivergisiz_fl { get; set; }

        public DateTime? sca_fis_tarih { get; set; }

        public int? sca_fis_sirano { get; set; }

        [StringLength(25)]
        public string sca_trefno { get; set; }

        public byte? sca_sntck_poz { get; set; }

        public DateTime? sca_reftarihi { get; set; }

        public byte? sca_istisnakodu { get; set; }

        public bool? sca_pos_hareketi { get; set; }

        public byte? sca_meblag_ana_doviz_icin_gecersiz_fl { get; set; }

        public byte? sca_meblag_alt_doviz_icin_gecersiz_fl { get; set; }

        public byte? sca_meblag_orj_doviz_icin_gecersiz_fl { get; set; }

        public short? sca_sip_recid_dbcno { get; set; }

        public int? sca_sip_recid_recno { get; set; }

        public short? cha_kirahar_recid_dbcno { get; set; }

        public int? cha_kirahar_recid_recno { get; set; }

        public DateTime? sca_vardiya_tarihi { get; set; }

        public byte? sca_vardiya_no { get; set; }

        public byte? sca_vardiya_evrak_ti { get; set; }

        public byte? sca_ebelge_cinsi { get; set; }

        public double? sca_tevkifat_toplam { get; set; }

        public double? sca_ilave_edilecek_kdv1 { get; set; }

        public double? sca_ilave_edilecek_kdv2 { get; set; }

        public double? sca_ilave_edilecek_kdv3 { get; set; }

        public double? sca_ilave_edilecek_kdv4 { get; set; }

        public double? sca_ilave_edilecek_kdv5 { get; set; }

        public double? sca_ilave_edilecek_kdv6 { get; set; }

        public double? sca_ilave_edilecek_kdv7 { get; set; }

        public double? sca_ilave_edilecek_kdv8 { get; set; }

        public double? sca_ilave_edilecek_kdv9 { get; set; }

        public double? sca_ilave_edilecek_kdv10 { get; set; }

        public byte? sca_e_islem_turu { get; set; }

        public byte? sca_fatura_belge_turu { get; set; }

        [StringLength(50)]
        public string sca_diger_belge_adi { get; set; }

        [StringLength(40)]
        public string sca_uuid { get; set; }

        public int? sca_adres_no { get; set; }

        public double? sca_vergifon_toplam { get; set; }

        public DateTime? sca_ilk_belge_tarihi { get; set; }

        public double? sca_ilk_belge_doviz_kuru { get; set; }
    }
}
