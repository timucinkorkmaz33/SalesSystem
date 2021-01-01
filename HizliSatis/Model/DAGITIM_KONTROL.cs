namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAGITIM_KONTROL
    {
        [Key]
        public int dkn_RECno { get; set; }

        public short dkn_RECid_DBCno { get; set; }

        public int dkn_RECid_RECno { get; set; }

        public int? dkn_SpecRECno { get; set; }

        public bool? dkn_iptal { get; set; }

        public short? dkn_fileid { get; set; }

        public bool? dkn_hidden { get; set; }

        public bool? dkn_kilitli { get; set; }

        public bool? dkn_degisti { get; set; }

        public int? dkn_checksum { get; set; }

        public short? dkn_create_user { get; set; }

        public DateTime? dkn_create_date { get; set; }

        public short? dkn_lastup_user { get; set; }

        public DateTime? dkn_lastup_date { get; set; }

        [StringLength(4)]
        public string dkn_special1 { get; set; }

        [StringLength(4)]
        public string dkn_special2 { get; set; }

        [StringLength(4)]
        public string dkn_special3 { get; set; }

        [StringLength(25)]
        public string dkn_borclu_hesap_kodu { get; set; }

        [StringLength(25)]
        public string dkn_borclu_srm_merkezi { get; set; }

        [StringLength(25)]
        public string dkn_borclu_proje { get; set; }

        [StringLength(25)]
        public string dkn_alacakli_hesap_kodu { get; set; }

        [StringLength(25)]
        public string dkn_alacakli_srm_merkezi { get; set; }

        [StringLength(25)]
        public string dkn_alacakli_proje { get; set; }

        [StringLength(25)]
        public string dkn_dagitim_anahtar_kodu { get; set; }

        public double? dkn_toplam_anahtar { get; set; }

        public double? dkn_anahtar { get; set; }

        public double? dkn_dagitilan_tutar_ana { get; set; }

        public double? dkn_dagitilan_tutar_alt { get; set; }

        public double? dkn_dagitilan_tutar_orj { get; set; }
    }
}
