namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VERGI_FON_TANIMLARI
    {
        [Key]
        public int vf_RECno { get; set; }

        public short vf_RECid_DBCno { get; set; }

        public int vf_RECid_RECno { get; set; }

        public int? vf_SpecRECno { get; set; }

        public bool? vf_iptal { get; set; }

        public short? vf_fileid { get; set; }

        public bool? vf_hidden { get; set; }

        public bool? vf_kilitli { get; set; }

        public bool? vf_degisti { get; set; }

        public int? vf_checksum { get; set; }

        public short? vf_create_user { get; set; }

        public DateTime? vf_create_date { get; set; }

        public short? vf_lastup_user { get; set; }

        public DateTime? vf_lastup_date { get; set; }

        [StringLength(4)]
        public string vf_special1 { get; set; }

        [StringLength(4)]
        public string vf_special2 { get; set; }

        [StringLength(4)]
        public string vf_special3 { get; set; }

        public int? vf_firma_no { get; set; }

        public short? vf_sira_no { get; set; }

        [StringLength(5)]
        public string vf_kodu { get; set; }

        [StringLength(127)]
        public string vf_uzun_adi { get; set; }

        [StringLength(50)]
        public string vf_kisa_adi { get; set; }

        public double? vf_orani { get; set; }

        public double? vf_sabit_tutar { get; set; }

        [StringLength(25)]
        public string vf_giris_masraf_kodu { get; set; }

        [StringLength(40)]
        public string vf_giris_muh_kodu { get; set; }

        [StringLength(40)]
        public string vf_cikis_muh_kodu { get; set; }

        public bool? vf_kdvli { get; set; }

        public byte? vf_bsbayadahil { get; set; }
    }
}
