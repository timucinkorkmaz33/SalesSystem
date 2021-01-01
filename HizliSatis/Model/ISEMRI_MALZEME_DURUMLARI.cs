namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISEMRI_MALZEME_DURUMLARI
    {
        [Key]
        public int ish_RECno { get; set; }

        public short ish_RECid_DBCno { get; set; }

        public int ish_RECid_RECno { get; set; }

        public int? ish_SpecRecNo { get; set; }

        public bool? ish_iptal { get; set; }

        public short? ish_fileid { get; set; }

        public bool? ish_hidden { get; set; }

        public bool? ish_kilitli { get; set; }

        public bool? ish_degisti { get; set; }

        public int? ish_checksum { get; set; }

        public short? ish_create_user { get; set; }

        public DateTime? ish_create_date { get; set; }

        public short? ish_lastup_user { get; set; }

        public DateTime? ish_lastup_date { get; set; }

        [StringLength(4)]
        public string ish_ozelkod1 { get; set; }

        [StringLength(4)]
        public string ish_ozelkod2 { get; set; }

        [StringLength(4)]
        public string ish_ozelkod3 { get; set; }

        public byte? ish_stok_hizm_gider { get; set; }

        [StringLength(25)]
        public string ish_stokhizm_gid_kod { get; set; }

        [StringLength(25)]
        public string ish_isemri { get; set; }

        [StringLength(25)]
        public string ish_fasoncu { get; set; }

        public double? ish_sevk_miktar { get; set; }

        public double? ish_sevk_deger0 { get; set; }

        public double? ish_sevk_deger1 { get; set; }

        public double? ish_sevk_deger2 { get; set; }

        public double? ish_iade_miktar { get; set; }

        public double? ish_iade_deger0 { get; set; }

        public double? ish_iade_deger1 { get; set; }

        public double? ish_iade_deger2 { get; set; }

        public double? ish_tuket_miktar { get; set; }

        public double? ish_tuket_deger0 { get; set; }

        public double? ish_tuket_deger1 { get; set; }

        public double? ish_tuket_deger2 { get; set; }

        public double? ish_uret_miktar { get; set; }

        public double? ish_uret_deger0 { get; set; }

        public double? ish_uret_deger1 { get; set; }

        public double? ish_uret_deger2 { get; set; }

        public double? ish_uretiade_miktar { get; set; }

        public double? ish_uretiade_deg0 { get; set; }

        public double? ish_uretiade_deg1 { get; set; }

        public double? ish_uretiade_deg2 { get; set; }

        public double? ish_plan_sevkmiktar { get; set; }

        public double? ish_planuretim { get; set; }

        public double? ish_GenelUretimMaliyeti_Ana { get; set; }

        public double? ish_GenelUretimMaliyeti_Alt { get; set; }

        public double? ish_GenelUretimMaliyeti_Orj { get; set; }

        public double? ish_DirektIscilikMaliyeti_Ana { get; set; }

        public double? ish_DirektIscilikMaliyeti_Alt { get; set; }

        public double? ish_DirektIscilikMaliyeti_Orj { get; set; }
    }
}
