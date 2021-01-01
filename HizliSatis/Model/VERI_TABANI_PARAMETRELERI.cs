namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VERI_TABANI_PARAMETRELERI
    {
        [Key]
        public int Param_recno { get; set; }

        public short Param_id { get; set; }

        public short Param_item { get; set; }

        public int? Param_size { get; set; }

        [MaxLength(8000)]
        public byte[] Param_buf { get; set; }
    }
}
