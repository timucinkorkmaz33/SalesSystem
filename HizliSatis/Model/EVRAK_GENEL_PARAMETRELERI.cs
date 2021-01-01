namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVRAK_GENEL_PARAMETRELERI
    {
        [Key]
        public int egp_RECno { get; set; }

        public short egp_RECid_DBCno { get; set; }

        public int egp_RECid_RECno { get; set; }

        public int? egp_SpecRECno { get; set; }

        public bool? egp_iptal { get; set; }

        public short? egp_fileid { get; set; }

        public bool? egp_hidden { get; set; }

        public bool? egp_kilitli { get; set; }

        public bool? egp_degisti { get; set; }

        public int? egp_checksum { get; set; }

        public short? egp_create_user { get; set; }

        public DateTime? egp_create_date { get; set; }

        public short? egp_lastup_user { get; set; }

        public DateTime? egp_lastup_date { get; set; }

        [StringLength(4)]
        public string egp_special1 { get; set; }

        [StringLength(4)]
        public string egp_special2 { get; set; }

        [StringLength(4)]
        public string egp_special3 { get; set; }

        public int? egp_program_no { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_1 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_2 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_3 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_4 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_5 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_6 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_7 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_8 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_9 { get; set; }

        [StringLength(40)]
        public string egp_aciklama_baslik_10 { get; set; }

        [StringLength(127)]
        public string egp_form_adi { get; set; }

        public bool? egp_tarih_kontrolu_pasif_fl { get; set; }

        public bool? egp_kilit_kaydedince_fl { get; set; }

        public bool? egp_kilit_dokunce_fl { get; set; }

        public bool? egp_kilit_mail_fl { get; set; }

        public bool? egp_kilit_onzileme_fl { get; set; }

        public bool? egp_kilitli_dok_fl { get; set; }

        public bool? egp_kilitli_mail_fl { get; set; }

        public bool? egp_kilitli_ozizle_fl { get; set; }
    }
}
