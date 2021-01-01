namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_OnlineUserDataScheme
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TableID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OnlineTableID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OnlineRecNo { get; set; }

        public int? FieldOrder { get; set; }

        [Key]
        [Column(Order = 3)]
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
    }
}
