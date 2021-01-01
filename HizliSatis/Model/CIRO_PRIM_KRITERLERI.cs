namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIRO_PRIM_KRITERLERI
    {
        [Key]
        public int cprk_RECno { get; set; }

        [StringLength(25)]
        public string cprk_baglicarikod { get; set; }

        public int? cprk_numarasi { get; set; }

        public string cprk_stok_sorgu { get; set; }

        public string cprk_depo_sorgu { get; set; }
    }
}
