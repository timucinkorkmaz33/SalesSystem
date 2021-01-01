namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BELGE_GRUPLARI
    {
        [Key]
        public int bgr_RECno { get; set; }

        public short bgr_RECid_DBCno { get; set; }

        public int bgr_RECid_RECno { get; set; }

        public int? bgr_SpecRECno { get; set; }

        public bool? bgr_iptal { get; set; }

        public short? bgr_fileid { get; set; }

        public bool? bgr_hidden { get; set; }

        public bool? bgr_kilitli { get; set; }

        public bool? bgr_degisti { get; set; }

        public int? bgr_checksum { get; set; }

        public short? bgr_create_user { get; set; }

        public DateTime? bgr_create_date { get; set; }

        public short? bgr_lastup_user { get; set; }

        public DateTime? bgr_lastup_date { get; set; }

        [StringLength(4)]
        public string bgr_special1 { get; set; }

        [StringLength(4)]
        public string bgr_special2 { get; set; }

        [StringLength(4)]
        public string bgr_special3 { get; set; }

        public int? bgr_firmano { get; set; }

        public int? bgr_subeno { get; set; }

        [StringLength(25)]
        public string bgr_kod { get; set; }

        [StringLength(40)]
        public string bgr_isim { get; set; }

        [StringLength(25)]
        public string bgr_belge_kod { get; set; }

        public bool? bgr_zorunlu_fl { get; set; }
    }
}
