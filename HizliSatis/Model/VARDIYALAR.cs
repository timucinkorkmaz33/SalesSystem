namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VARDIYALAR")]
    public partial class VARDIYALAR
    {
        [Key]
        public int vardiya_RECno { get; set; }

        public short? vardiya_RECid_DBCno { get; set; }

        public int vardiya_RECid_RECno { get; set; }

        public int? vardiya_SpecRECNo { get; set; }

        public bool? vardiya_iptal { get; set; }

        public short? vardiya_fileid { get; set; }

        public bool? vardiya_hidden { get; set; }

        public bool? vardiya_kilitli { get; set; }

        public bool? vardiya_degisti { get; set; }

        public int? vardiya_CheckSum { get; set; }

        public short? vardiya_create_user { get; set; }

        public DateTime? vardiya_create_date { get; set; }

        public short? vardiya_lastup_user { get; set; }

        public DateTime? vardiya_lastup_date { get; set; }

        [StringLength(4)]
        public string vardiya_special1 { get; set; }

        [StringLength(4)]
        public string vardiya_special2 { get; set; }

        [StringLength(4)]
        public string vardiya_special3 { get; set; }

        [StringLength(25)]
        public string vardiya_kodu { get; set; }

        [StringLength(40)]
        public string vardiya_ismi { get; set; }

        public byte? vardiya_adedi { get; set; }

        public int? vardiya_renk { get; set; }

        public byte? vardiya_ekkazancno { get; set; }

        public int? vardiya_tolerans { get; set; }

        public DateTime? vardiya_vbassaat1 { get; set; }

        public DateTime? vardiya_vbitsaat1 { get; set; }

        public DateTime? vardiya_vmobassaat1_1 { get; set; }

        public DateTime? vardiya_vmobitsaat1_1 { get; set; }

        public DateTime? vardiya_vmobassaat1_2 { get; set; }

        public DateTime? vardiya_vmobitsaat1_2 { get; set; }

        public DateTime? vardiya_vmobassaat1_3 { get; set; }

        public DateTime? vardiya_vmobitsaat1_3 { get; set; }

        public DateTime? vardiya_vmobassaat1_4 { get; set; }

        public DateTime? vardiya_vmobitsaat1_4 { get; set; }

        public DateTime? vardiya_vbassaat2 { get; set; }

        public DateTime? vardiya_vbitsaat2 { get; set; }

        public DateTime? vardiya_vmobassaat2_1 { get; set; }

        public DateTime? vardiya_vmobitsaat2_1 { get; set; }

        public DateTime? vardiya_vmobassaat2_2 { get; set; }

        public DateTime? vardiya_vmobitsaat2_2 { get; set; }

        public DateTime? vardiya_vmobassaat2_3 { get; set; }

        public DateTime? vardiya_vmobitsaat2_3 { get; set; }

        public DateTime? vardiya_vmobassaat2_4 { get; set; }

        public DateTime? vardiya_vmobitsaat2_4 { get; set; }

        public DateTime? vardiya_vbassaat3 { get; set; }

        public DateTime? vardiya_vbitsaat3 { get; set; }

        public DateTime? vardiya_vmobassaat3_1 { get; set; }

        public DateTime? vardiya_vmobitsaat3_1 { get; set; }

        public DateTime? vardiya_vmobassaat3_2 { get; set; }

        public DateTime? vardiya_vmobitsaat3_2 { get; set; }

        public DateTime? vardiya_vmobassaat3_3 { get; set; }

        public DateTime? vardiya_vmobitsaat3_3 { get; set; }

        public DateTime? vardiya_vmobassaat3_4 { get; set; }

        public DateTime? vardiya_vmobitsaat3_4 { get; set; }

        public DateTime? vardiya_vbassaat4 { get; set; }

        public DateTime? vardiya_vbitsaat4 { get; set; }

        public DateTime? vardiya_vmobassaat4_1 { get; set; }

        public DateTime? vardiya_vmobitsaat4_1 { get; set; }

        public DateTime? vardiya_vmobassaat4_2 { get; set; }

        public DateTime? vardiya_vmobitsaat4_2 { get; set; }

        public DateTime? vardiya_vmobassaat4_3 { get; set; }

        public DateTime? vardiya_vmobitsaat4_3 { get; set; }

        public DateTime? vardiya_vmobassaat4_4 { get; set; }

        public DateTime? vardiya_vmobitsaat4_4 { get; set; }
    }
}
