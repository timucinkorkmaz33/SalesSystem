namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_NACE_TANIMLARI
    {
        [Key]
        public int fnc_RECno { get; set; }

        public short fnc_RECid_DBCno { get; set; }

        public int fnc_RECid_RECno { get; set; }

        public int? fnc_SpecRecNo { get; set; }

        public bool? fnc_iptal { get; set; }

        public short? fnc_fileid { get; set; }

        public bool? fnc_hidden { get; set; }

        public bool? fnc_kilitli { get; set; }

        public bool? fnc_degisti { get; set; }

        public int? fnc_checksum { get; set; }

        public short? fnc_create_user { get; set; }

        public DateTime? fnc_create_date { get; set; }

        public short? fnc_lastup_user { get; set; }

        public DateTime? fnc_lastup_date { get; set; }

        [StringLength(4)]
        public string fnc_special1 { get; set; }

        [StringLength(4)]
        public string fnc_special2 { get; set; }

        [StringLength(4)]
        public string fnc_special3 { get; set; }

        public int? fnc_firmano { get; set; }

        public short? fnc_sirano { get; set; }

        [StringLength(25)]
        public string fnc_nace_kodu { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod1 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod2 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod3 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod4 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod5 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod6 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod7 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod8 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod9 { get; set; }

        [StringLength(25)]
        public string fnc_muh_hesap_kod10 { get; set; }
    }
}
