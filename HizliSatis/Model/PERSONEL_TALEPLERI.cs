namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_TALEPLERI
    {
        [Key]
        public int tlp_RECno { get; set; }

        public short tlp_RECid_DBCno { get; set; }

        public int tlp_RECid_RECno { get; set; }

        public int? tlp_SpecRECno { get; set; }

        public bool? tlp_iptal { get; set; }

        public short? tlp_fileid { get; set; }

        public bool? tlp_hidden { get; set; }

        public bool? tlp_kilitli { get; set; }

        public bool? tlp_degisti { get; set; }

        public int? tlp_checksum { get; set; }

        public short? tlp_create_user { get; set; }

        public DateTime? tlp_create_date { get; set; }

        public short? tlp_lastup_user { get; set; }

        public DateTime? tlp_lastup_date { get; set; }

        [StringLength(4)]
        public string tlp_special1 { get; set; }

        [StringLength(4)]
        public string tlp_special2 { get; set; }

        [StringLength(4)]
        public string tlp_special3 { get; set; }

        [StringLength(25)]
        public string tlp_kodu { get; set; }

        [StringLength(40)]
        public string tlp_adi { get; set; }

        public DateTime? tlp_tarih { get; set; }

        public DateTime? tlp_bitistarih { get; set; }

        [StringLength(25)]
        public string tlp_grv_kodu { get; set; }

        [StringLength(25)]
        public string tlp_dpt_kodu { get; set; }

        [StringLength(25)]
        public string tlp_eden_per_kodu { get; set; }

        public short? tlp_adet { get; set; }

        public byte? tlp_durum { get; set; }

        [StringLength(80)]
        public string tlp_aciklama1 { get; set; }

        [StringLength(80)]
        public string tlp_aciklama2 { get; set; }

        [StringLength(80)]
        public string tlp_aciklama3 { get; set; }

        [StringLength(80)]
        public string tlp_aciklama4 { get; set; }

        [StringLength(80)]
        public string tlp_aciklama5 { get; set; }

        [StringLength(25)]
        public string tlp_kadro_kodu { get; set; }

        public byte? tlp_nedeni { get; set; }

        public byte? tlp_cinsiyet { get; set; }

        public byte? tlp_medeni_hal { get; set; }

        public int? tlp_minyas { get; set; }

        public int? tlp_maxyas { get; set; }

        public byte? tlp_askerlik { get; set; }

        public byte? tlp_ehliyet { get; set; }

        public int? tlp_tecrube { get; set; }

        public byte? tlp_dil_tipi { get; set; }

        public byte? tlp_dil_seviye { get; set; }

        public byte? tlp_dil_konusma { get; set; }

        public byte? tlp_ozurderecesi { get; set; }

        public byte? tlp_ozurgrubu { get; set; }
    }
}
