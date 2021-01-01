namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_CubeItems
    {
        [Key]
        public int ci_id { get; set; }

        public int? ci_cubeid { get; set; }

        public int? ci_fieldid { get; set; }

        [StringLength(255)]
        public string ci_fieldalias { get; set; }

        [StringLength(255)]
        public string ci_fielduseralias { get; set; }

        [StringLength(1000)]
        public string ci_description { get; set; }

        public bool? ci_ismeasure { get; set; }

        public bool? ci_isvisible { get; set; }

        [StringLength(255)]
        public string ci_displayformat { get; set; }
    }
}
