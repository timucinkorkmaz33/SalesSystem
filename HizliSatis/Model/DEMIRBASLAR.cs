namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEMIRBASLAR")]
    public partial class DEMIRBASLAR
    {
        [Key]
        public int dem_RECno { get; set; }

        public short dem_RECid_DBCno { get; set; }

        public int dem_RECid_RECno { get; set; }

        public int? dem_SpecRECno { get; set; }

        public bool? dem_iptal { get; set; }

        public short? dem_fileid { get; set; }

        public bool? dem_hidden { get; set; }

        public bool? dem_kilitli { get; set; }

        public bool? dem_degisti { get; set; }

        public int? dem_checksum { get; set; }

        public short? dem_create_user { get; set; }

        public DateTime? dem_create_date { get; set; }

        public short? dem_lastup_user { get; set; }

        public DateTime? dem_lastup_date { get; set; }

        [StringLength(4)]
        public string dem_special1 { get; set; }

        [StringLength(4)]
        public string dem_special2 { get; set; }

        [StringLength(4)]
        public string dem_special3 { get; set; }

        [StringLength(25)]
        public string dem_kod { get; set; }

        public int? dem_firmano { get; set; }

        public int? dem_subeno { get; set; }

        [StringLength(50)]
        public string dem_isim { get; set; }

        [StringLength(50)]
        public string dem_aciklama { get; set; }

        public byte? dem_doviz_cinsi { get; set; }

        public byte? dem_vergi { get; set; }

        public double? dem_amortoran { get; set; }

        public byte? dem_amortip { get; set; }

        [StringLength(10)]
        public string dem_birim { get; set; }

        public DateTime? dem_fatura_tarihi { get; set; }

        [StringLength(6)]
        public string dem_fatura_seri { get; set; }

        public int? dem_fatura_sira { get; set; }

        public double? dem_tutar { get; set; }

        public double? dem_tutar_alternatif { get; set; }

        public double? dem_tutar_orjinal { get; set; }

        public double? dem_miktar { get; set; }

        [StringLength(25)]
        public string dem_dagankodu { get; set; }

        [StringLength(25)]
        public string dem_sozlesmekodu { get; set; }

        [StringLength(40)]
        public string dem_muh_kodu { get; set; }

        [StringLength(40)]
        public string dem_birik_amort_muh { get; set; }

        [StringLength(40)]
        public string dem_ydf_muh_kod { get; set; }

        [StringLength(40)]
        public string dem_amorgider_muhkod { get; set; }

        [StringLength(40)]
        public string dem_maliyet_artis_mu { get; set; }

        [StringLength(40)]
        public string dem_satis_kar_muhkod { get; set; }

        [StringLength(40)]
        public string dem_satis_zarar_muhk { get; set; }

        [StringLength(40)]
        public string dem_yeni_fon_muhkodu { get; set; }

        [StringLength(40)]
        public string dem_SermEkgmStsKaz_m { get; set; }

        [StringLength(40)]
        public string dem_amorgidkar_muhkod { get; set; }

        [StringLength(40)]
        public string dem_yatirimtes_muhkod { get; set; }

        [StringLength(25)]
        public string dem_amort_masraf_kodu { get; set; }

        [StringLength(25)]
        public string dem_isl_demirbas_kodu { get; set; }

        public bool? dem_makinatesis_fl { get; set; }

        public bool? dem_emlak_fl { get; set; }

        public bool? dem_izdusum_fl { get; set; }

        public bool? dem_yeni_degyo_fl { get; set; }

        public bool? dem_kistas_fl { get; set; }

        public bool? dem_tesfik_fl { get; set; }

        public double? dem_atikizdeger_dusu { get; set; }

        [StringLength(25)]
        public string dem_zimmetyeri { get; set; }

        [StringLength(25)]
        public string dem_zimmetcaripers { get; set; }

        [StringLength(25)]
        public string dem_grupkodu { get; set; }

        [StringLength(25)]
        public string dem_SrmmMrkKodu { get; set; }

        public byte? dem_enf_tabii { get; set; }

        [StringLength(25)]
        public string dem_muhgrup_kodu { get; set; }

        [StringLength(10)]
        public string dem_mkod_artik { get; set; }

        [StringLength(25)]
        public string dem_faydaliOmur_kodu { get; set; }

        [StringLength(25)]
        public string dem_ProjeKodu { get; set; }

        [StringLength(25)]
        public string dem_altfaydali_omur_kodu { get; set; }

        public double? dem_alternatif_amortoran { get; set; }

        public double? dem_ufrstutar { get; set; }

        public double? dem_ufrstutar_alternatif { get; set; }

        public double? dem_ufrstutar_orjinal { get; set; }

        public byte? dem_ufrsamortip { get; set; }

        [StringLength(25)]
        public string dem_ufrs_omur_kodu { get; set; }

        public double? dem_ufrsamortoran { get; set; }

        public bool? dem_ufrskistas_fl { get; set; }

        [StringLength(40)]
        public string dem_ufrsfark_muh_kodu { get; set; }

        [StringLength(40)]
        public string dem_birik_amort_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_ydf_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_amorgider_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_maliyet_artis_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_satis_kar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_satis_zarar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_yeni_fon_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_SermEkgmStsKaz_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_amorgidkar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string dem_yatirimtes_ufrsfark_kodu { get; set; }

        public double? dem_otv_tutar { get; set; }

        public bool? dem_otv_maliyete_eklensin_fl { get; set; }
    }
}
