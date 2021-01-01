namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rb_folder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int folder_id { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(60)]
        public string folder_name { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parent_id { get; set; }
    }
}
