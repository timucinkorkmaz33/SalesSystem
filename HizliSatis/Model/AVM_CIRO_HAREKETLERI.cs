namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVM_CIRO_HAREKETLERI
    {
        [Key]
        public int ach_RECno { get; set; }

        public short ach_RECid_DBCno { get; set; }

        public int ach_RECid_RECno { get; set; }

        public int? ach_Spec_Rec_no { get; set; }

        public bool? ach_iptal { get; set; }

        public short? ach_fileid { get; set; }

        public bool? ach_hidden { get; set; }

        public bool? ach_kilitli { get; set; }

        public bool? ach_degisti { get; set; }

        public int? ach_checksum { get; set; }

        public short? ach_create_user { get; set; }

        public DateTime? ach_create_date { get; set; }

        public short? ach_lastup_user { get; set; }

        public DateTime? ach_lastup_date { get; set; }

        [StringLength(4)]
        public string ach_special1 { get; set; }

        [StringLength(4)]
        public string ach_special2 { get; set; }

        [StringLength(4)]
        public string ach_special3 { get; set; }

        public int? ach_firmano { get; set; }

        public int? ach_subeno { get; set; }

        [StringLength(25)]
        public string ach_cari_kodu { get; set; }

        [StringLength(25)]
        public string ach_kira_kodu { get; set; }

        public DateTime? ach_tarih { get; set; }

        public int? ach_fis_sayisi { get; set; }

        public double? ach_tutar { get; set; }

        public short? ach_CH_recid_dbcno { get; set; }

        public int? ach_CH_recid_recno { get; set; }

        public short? ach_CH_recid2_dbcno { get; set; }

        public int? ach_CH_recid2_recno { get; set; }

        public short? ach_CH_recid3_dbcno { get; set; }

        public int? ach_CH_recid3_recno { get; set; }

        public int? ach_fis_sayisi2 { get; set; }

        public double? ach_tutar2 { get; set; }

        public int? ach_fis_sayisi3 { get; set; }

        public double? ach_tutar3 { get; set; }
    }
}
