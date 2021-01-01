namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_PlanImages
    {
        [Key]
        [Column(Order = 0)]
        public byte pi_plantype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short pi_RECid_DBCno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pi_RECid_RECno { get; set; }

        [Column(TypeName = "image")]
        public byte[] pi_image { get; set; }

        public int? pi_leftmargin { get; set; }

        public int? pi_topmargin { get; set; }

        public int? pi_zoom { get; set; }
    }
}
