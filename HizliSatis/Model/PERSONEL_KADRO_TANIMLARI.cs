namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_TANIMLARI
    {
        [Key]
        public int kdr_RECno { get; set; }

        public short kdr_RECid_DBCno { get; set; }

        public int kdr_RECid_RECno { get; set; }

        public int? kdr_SpecRECno { get; set; }

        public bool? kdr_iptal { get; set; }

        public short? kdr_fileid { get; set; }

        public bool? kdr_hidden { get; set; }

        public bool? kdr_kilitli { get; set; }

        public bool? kdr_degisti { get; set; }

        public int? kdr_checksum { get; set; }

        public short? kdr_create_user { get; set; }

        public DateTime? kdr_create_date { get; set; }

        public short? kdr_lastup_user { get; set; }

        public DateTime? kdr_lastup_date { get; set; }

        [StringLength(4)]
        public string kdr_special1 { get; set; }

        [StringLength(4)]
        public string kdr_special2 { get; set; }

        [StringLength(4)]
        public string kdr_special3 { get; set; }

        [StringLength(25)]
        public string kdr_kod { get; set; }

        [StringLength(50)]
        public string kdr_aciklama { get; set; }

        [StringLength(50)]
        public string kdr_rutbe { get; set; }

        public int? kdr_kadrosayisi { get; set; }

        [StringLength(25)]
        public string kdr_bagli_idari_amir { get; set; }

        [StringLength(25)]
        public string kdr_bagli_teknik_amir { get; set; }

        public byte? kdr_minimum_egitim { get; set; }

        [StringLength(25)]
        public string kdr_hedef_kadro1 { get; set; }

        [StringLength(25)]
        public string kdr_hedef_kadro2 { get; set; }

        [StringLength(25)]
        public string kdr_hedef_kadro3 { get; set; }

        [StringLength(80)]
        public string kdr_gorev_tanimi { get; set; }

        [StringLength(120)]
        public string kdr_sorumluluk_tanimi { get; set; }

        public bool? kdr_semada_gosterme { get; set; }

        public double? kdr_min_ucret { get; set; }

        public double? kdr_max_ucret { get; set; }

        public byte? kdr_ucret_dcinsi { get; set; }

        [StringLength(25)]
        public string kdr_unvan_kodu { get; set; }

        [StringLength(25)]
        public string kdr_gorev_kodu { get; set; }

        [StringLength(25)]
        public string kdr_raporlama_yap_kadro_kodu { get; set; }

        [StringLength(25)]
        public string kdr_vekalet_kadro_kodu { get; set; }
    }
}
