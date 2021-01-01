namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_UserDataScheme
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }

        public int? FieldOrder { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(40)]
        public string FieldName { get; set; }

        [StringLength(80)]
        public string DisplayName { get; set; }

        public byte? FieldType { get; set; }

        public int? FieldLength { get; set; }

        public int? DecimalLength { get; set; }

        public byte? LookUpKind { get; set; }

        public int? LookUpTable { get; set; }

        [StringLength(80)]
        public string LookUpField { get; set; }

        [StringLength(80)]
        public string LookUpChoose { get; set; }

        public bool? LookUpMultiSelect { get; set; }

        [StringLength(4000)]
        public string LookUpString { get; set; }

        public bool? LookUpF10Mandatory { get; set; }

        [StringLength(80)]
        public string GroupName { get; set; }

        public bool? ApplyCriteria { get; set; }

        public byte? Cr1Field { get; set; }

        public byte? Cr1Operation { get; set; }

        [StringLength(80)]
        public string Cr1Value { get; set; }

        public byte? Cr1Link { get; set; }

        public byte? Cr2Field { get; set; }

        public byte? Cr2Operation { get; set; }

        [StringLength(80)]
        public string Cr2Value { get; set; }

        public byte? Cr2Link { get; set; }

        public byte? Cr3Field { get; set; }

        public byte? Cr3Operation { get; set; }

        [StringLength(80)]
        public string Cr3Value { get; set; }

        public byte? Cr3Link { get; set; }
    }
}
