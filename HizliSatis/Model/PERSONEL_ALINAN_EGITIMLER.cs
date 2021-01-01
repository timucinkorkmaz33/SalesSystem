namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_ALINAN_EGITIMLER
    {
        [Key]
        public int aeg_RECno { get; set; }

        public short aeg_RECid_DBCno { get; set; }

        public int aeg_RECid_RECno { get; set; }

        public int? aeg_SpecRECno { get; set; }

        public bool? aeg_iptal { get; set; }

        public short? aeg_fileid { get; set; }

        public bool? aeg_hidden { get; set; }

        public bool? aeg_kilitli { get; set; }

        public bool? aeg_degisti { get; set; }

        public int? aeg_checksum { get; set; }

        public short? aeg_create_user { get; set; }

        public DateTime? aeg_create_date { get; set; }

        public short? aeg_lastup_user { get; set; }

        public DateTime? aeg_lastup_date { get; set; }

        [StringLength(4)]
        public string aeg_special1 { get; set; }

        [StringLength(4)]
        public string aeg_special2 { get; set; }

        [StringLength(4)]
        public string aeg_special3 { get; set; }

        public int? aeg_firmano { get; set; }

        public int? aeg_subeno { get; set; }

        public DateTime? aeg_tarih { get; set; }

        [StringLength(6)]
        public string aeg_evrakno_seri { get; set; }

        public int? aeg_evrakno_sira { get; set; }

        [StringLength(25)]
        public string aeg_egitim_kodu { get; set; }

        public int? aeg_satirno { get; set; }

        public byte? aeg_durumu { get; set; }

        public DateTime? aeg_bastar { get; set; }

        public DateTime? aeg_bitistar { get; set; }

        public double? aeg_butce { get; set; }

        [StringLength(25)]
        public string aeg_per_kodu { get; set; }

        public double? aeg_sinav_puan { get; set; }

        public double? aeg_Onay_puan1 { get; set; }

        public double? aeg_Onay_puan2 { get; set; }

        public double? aeg_Onay_puan3 { get; set; }

        [StringLength(80)]
        public string aeg_aciklama1 { get; set; }

        [StringLength(80)]
        public string aeg_aciklama2 { get; set; }

        [StringLength(80)]
        public string aeg_aciklama3 { get; set; }

        public short? aeg_bagli_talep_DBCno { get; set; }

        public int? aeg_bagli_talep_RECno { get; set; }

        [StringLength(25)]
        public string aeg_egitim_grup_kodu { get; set; }

        [StringLength(25)]
        public string aeg_egitim_alt_grup_kodu { get; set; }
    }
}
