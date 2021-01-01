namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITIM_TANIMLARI
    {
        [Key]
        public int egt_RECno { get; set; }

        public short egt_RECid_DBCno { get; set; }

        public int egt_RECid_RECno { get; set; }

        public int? egt_SpecRECno { get; set; }

        public bool? egt_iptal { get; set; }

        public short? egt_fileid { get; set; }

        public bool? egt_hidden { get; set; }

        public bool? egt_kilitli { get; set; }

        public bool? egt_degisti { get; set; }

        public int? egt_checksum { get; set; }

        public short? egt_create_user { get; set; }

        public DateTime? egt_create_date { get; set; }

        public short? egt_lastup_user { get; set; }

        public DateTime? egt_lastup_date { get; set; }

        [StringLength(4)]
        public string egt_special1 { get; set; }

        [StringLength(4)]
        public string egt_special2 { get; set; }

        [StringLength(4)]
        public string egt_special3 { get; set; }

        [StringLength(25)]
        public string egt_kodu { get; set; }

        [StringLength(40)]
        public string egt_adi { get; set; }

        public byte? egt_tipi { get; set; }

        public double? egt_puan { get; set; }

        public int? egt_suresi { get; set; }

        public byte? egt_peryodu { get; set; }

        public double? egt_peryotgunu { get; set; }

        public byte? egt_perhaftasi { get; set; }

        public bool? egt_pergunu2_1 { get; set; }

        public bool? egt_pergunu2_2 { get; set; }

        public bool? egt_pergunu2_3 { get; set; }

        public bool? egt_pergunu2_4 { get; set; }

        public bool? egt_pergunu2_5 { get; set; }

        public bool? egt_pergunu2_6 { get; set; }

        public bool? egt_pergunu2_7 { get; set; }

        public DateTime? egt_bastar { get; set; }

        public DateTime? egt_bitistar { get; set; }

        public double? egt_plan_butce { get; set; }

        public byte? egt_doviz_cinsi { get; set; }

        public double? egt_doviz_kuru { get; set; }

        [StringLength(25)]
        public string egt_egitim_yer_kodu { get; set; }

        [StringLength(25)]
        public string egt_konu_kodu { get; set; }

        [StringLength(25)]
        public string egt_amac_kodu { get; set; }

        [StringLength(120)]
        public string egt_aciklama1 { get; set; }

        [StringLength(120)]
        public string egt_aciklama2 { get; set; }

        [StringLength(120)]
        public string egt_aciklama3 { get; set; }

        public int? egt_maxKatilimci { get; set; }

        public bool? egt_sertifika_fl { get; set; }
    }
}
