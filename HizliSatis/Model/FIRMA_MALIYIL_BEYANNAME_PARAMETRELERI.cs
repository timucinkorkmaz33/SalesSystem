namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_MALIYIL_BEYANNAME_PARAMETRELERI
    {
        [Key]
        public int fmyb_RECno { get; set; }

        public short fmyb_RECid_DBCno { get; set; }

        public int fmyb_RECid_RECno { get; set; }

        public int? fmyb_SpecRECno { get; set; }

        public bool? fmyb_iptal { get; set; }

        public short? fmyb_fileid { get; set; }

        public bool? fmyb_hidden { get; set; }

        public bool? fmyb_kilitli { get; set; }

        public bool? fmyb_degisti { get; set; }

        public int? fmyb_checksum { get; set; }

        public short? fmyb_create_user { get; set; }

        public DateTime? fmyb_create_date { get; set; }

        public short? fmyb_lastup_user { get; set; }

        public DateTime? fmyb_lastup_date { get; set; }

        [StringLength(4)]
        public string fmyb_special1 { get; set; }

        [StringLength(4)]
        public string fmyb_special2 { get; set; }

        [StringLength(4)]
        public string fmyb_special3 { get; set; }

        public int? fmyb_sirano { get; set; }

        public int? fmyb_maliyil { get; set; }

        public byte? fmyb_kdv_hesap_sekli { get; set; }

        public byte? fmyb_kdv_normal_matrah_vergi1 { get; set; }

        public byte? fmyb_kdv_normal_matrah_vergi2 { get; set; }

        public byte? fmyb_kdv_normal_matrah_vergi3 { get; set; }

        public byte? fmyb_kdv_normal_matrah_vergi4 { get; set; }

        public byte? fmyb_kdv_tevk_matrah_vergi1 { get; set; }

        public byte? fmyb_kdv_tevk_matrah_vergi2 { get; set; }

        public byte? fmyb_kdv_tevk_matrah_vergi3 { get; set; }

        public byte? fmyb_kdv_tevk_matrah_vergi4 { get; set; }

        public byte? fmyb_kdv_tevkifat_tipi1 { get; set; }

        public byte? fmyb_kdv_tevkifat_tipi2 { get; set; }

        public byte? fmyb_kdv_tevkifat_tipi3 { get; set; }

        public byte? fmyb_kdv_tevkifat_tipi4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_isl_tev_hesap_kodu1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_isl_tev_hesap_kodu2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_isl_tev_hesap_kodu3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_isl_tev_hesap_kodu4 { get; set; }

        public byte? fmyb_kdv_ihracat_vergi1 { get; set; }

        public byte? fmyb_kdv_ihracat_vergi2 { get; set; }

        public byte? fmyb_kdv_ihracat_vergi3 { get; set; }

        public byte? fmyb_kdv_kismi_ist_index1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_matheskod1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_yukkdvkod1 { get; set; }

        public byte? fmyb_kdv_kismi_ist_index2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_matheskod2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_yukkdvkod2 { get; set; }

        public byte? fmyb_kdv_kismi_ist_index3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_matheskod3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_yukkdvkod3 { get; set; }

        public byte? fmyb_kdv_kismi_ist_index4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_matheskod4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_yukkdvkod4 { get; set; }

        public byte? fmyb_kdv_kismi_ist_index5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_matheskod5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kismi_ist_yukkdvkod5 { get; set; }

        public byte? fmyb_kdv_tam_ist_index1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_matheskod1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_yukkdvkod1 { get; set; }

        public byte? fmyb_kdv_tam_ist_index2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_matheskod2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_yukkdvkod2 { get; set; }

        public byte? fmyb_kdv_tam_ist_index3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_matheskod3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_yukkdvkod3 { get; set; }

        public byte? fmyb_kdv_tam_ist_index4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_matheskod4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_yukkdvkod4 { get; set; }

        public byte? fmyb_kdv_tam_ist_index5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_matheskod5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_tam_ist_yukkdvkod5 { get; set; }

        public byte? fmyb_kdv_diger_ist_index1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_matheskod1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_yukkdvkod1 { get; set; }

        public byte? fmyb_kdv_diger_ist_index2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_matheskod2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_yukkdvkod2 { get; set; }

        public byte? fmyb_kdv_diger_ist_index3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_matheskod3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_yukkdvkod3 { get; set; }

        public byte? fmyb_kdv_diger_ist_index4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_matheskod4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_yukkdvkod4 { get; set; }

        public byte? fmyb_kdv_diger_ist_index5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_matheskod5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_ist_yukkdvkod5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_matheskod1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_kdvkod1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_matheskod2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_kdvkod2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_matheskod3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_kdvkod3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_matheskod4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_diger_kdvkod4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_ozelmatrah_isk_kodu { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_devreden_kdv_kodu { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_ozmat_dholm_bedel_kodu { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu1 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu2 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu3 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu4 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu5 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu6 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu7 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu8 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu9 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu10 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu11 { get; set; }

        [StringLength(25)]
        public string fmyb_kdv_kredi_kart_kodu12 { get; set; }

        public bool? fmyb_kdv_isl_onceki_donemi_oku { get; set; }

        [StringLength(25)]
        public string fmyb_dig_ilave_kdv_kodu { get; set; }

        [StringLength(25)]
        public string fmyb_ihracat_donem_iade_Kdv_kodu { get; set; }

        public byte? fmyb_kdv2_tam_tevk_vergi1 { get; set; }

        public byte? fmyb_kdv2_tam_tevk_vergi2 { get; set; }

        public byte? fmyb_kdv2_tam_tevk_vergi3 { get; set; }

        public byte? fmyb_kdv2_tam_tevk_vergi4 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi1 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi2 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi3 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi4 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi5 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_vergi6 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi1 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi2 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi3 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi4 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi5 { get; set; }

        public byte? fmyb_kdv2_kismi_tevk_tipi6 { get; set; }

        public byte? fmyb_kdv_onceki_donem_hesabi { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip1 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap1 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip2 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap2 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip3 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap3 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip4 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap4 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip5 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap5 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip6 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap6 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip7 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap7 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip8 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap8 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip9 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap9 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip10 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap10 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip11 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap11 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip12 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap12 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip13 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap13 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip14 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap14 { get; set; }

        public byte? fmyb_kanunen_kabul_edilmeyen_tip15 { get; set; }

        [StringLength(127)]
        public string fmyb_kanunen_kabul_edilmeyen_hesap15 { get; set; }
    }
}
