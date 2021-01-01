namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rb_item
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int item_id { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folder_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(60)]
        public string item_name { get; set; }

        public int? item_size { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int item_type { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime modified { get; set; }

        public DateTime? deleted { get; set; }

        [Column(TypeName = "image")]
        public byte[] template { get; set; }
    }
}
