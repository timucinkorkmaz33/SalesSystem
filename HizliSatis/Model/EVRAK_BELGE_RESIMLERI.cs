namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EVRAK_BELGE_RESIMLERI
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ei_Key { get; set; }

        public short? ei_dosyano { get; set; }

        public byte? ei_hareket_tip { get; set; }

        public byte? ei_evr_tip { get; set; }

        [StringLength(6)]
        public string ei_evr_seri { get; set; }

        public int? ei_evr_sira { get; set; }

        [StringLength(25)]
        public string ei_evr_ustkod { get; set; }

        public byte? ei_classid { get; set; }

        [Column(TypeName = "image")]
        public byte[] ei_image { get; set; }

        [StringLength(127)]
        public string ei_aciklama { get; set; }
    }
}
