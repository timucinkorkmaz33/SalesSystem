namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ATIK_MUHASEBE_GRUPLARI
    {
        [Key]
        public int atkmuh_RECno { get; set; }

        public short atkmuh_RECid_DBCno { get; set; }

        public int atkmuh_RECid_RECno { get; set; }

        public int? atkmuh_SpecRECno { get; set; }

        public bool? atkmuh_iptal { get; set; }

        public short? atkmuh_fileid { get; set; }

        public bool? atkmuh_hidden { get; set; }

        public bool? atkmuh_kilitli { get; set; }

        public bool? atkmuh_degisti { get; set; }

        public int? atkmuh_checksum { get; set; }

        public short? atkmuh_create_user { get; set; }

        public DateTime? atkmuh_create_date { get; set; }

        public short? atkmuh_lastup_user { get; set; }

        public DateTime? atkmuh_lastup_date { get; set; }

        [StringLength(4)]
        public string atkmuh_special1 { get; set; }

        [StringLength(4)]
        public string atkmuh_special2 { get; set; }

        [StringLength(4)]
        public string atkmuh_special3 { get; set; }

        [StringLength(25)]
        public string atkmuh_kod { get; set; }

        [StringLength(90)]
        public string atkmuh_ismi { get; set; }

        [StringLength(40)]
        public string atkmuh_muh_kod { get; set; }

        [StringLength(40)]
        public string atkmuh_birik_amort_muh { get; set; }

        [StringLength(40)]
        public string atkmuh_ydf_muh_kod { get; set; }

        [StringLength(40)]
        public string atkmuh_amorgider_muhkod { get; set; }

        [StringLength(40)]
        public string atkmuh_maliyet_artis_mu { get; set; }

        [StringLength(40)]
        public string atkmuh_satis_kar_muhkod { get; set; }

        [StringLength(40)]
        public string atkmuh_satis_zarar_muhk { get; set; }

        [StringLength(40)]
        public string atkmuh_yeni_fon_muhkodu { get; set; }

        [StringLength(40)]
        public string atkmuh_SermEkgmStsKaz_m { get; set; }

        [StringLength(40)]
        public string atkmuh_amorgidkar_muhkod { get; set; }

        [StringLength(40)]
        public string atkmuh_yatirimtes_muhkod { get; set; }

        [StringLength(25)]
        public string atkmuh_amort_masraf_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_ufrsfark_muh_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_birik_amort_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_ydf_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_amorgider_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_maliyet_artis_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_satis_kar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_satis_zarar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_yeni_fon_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_SermEkgmStsKaz_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_amorgidkar_ufrsfark_kodu { get; set; }

        [StringLength(40)]
        public string atkmuh_yatirimtes_ufrsfark_kodu { get; set; }
    }
}
