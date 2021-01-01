namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_PlanPins
    {
        [Key]
        [Column(Order = 0)]
        public byte pp_plantype { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short pp_RECid_DBCno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pp_RECid_RECno { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pp_order { get; set; }

        public int? pp_pointx { get; set; }

        public int? pp_pointy { get; set; }

        public int? pp_color { get; set; }

        public short? pp_Conn_RECid_DBCno { get; set; }

        public int? pp_Conn_RECid_RECno { get; set; }
    }
}
