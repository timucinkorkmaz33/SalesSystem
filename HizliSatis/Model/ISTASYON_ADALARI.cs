namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_ADALARI
    {
        [Key]
        public int ada_RECno { get; set; }

        public short ada_RECid_DBCno { get; set; }

        public int ada_RECid_RECno { get; set; }

        public int? ada_SpecRECno { get; set; }

        public bool? ada_iptal { get; set; }

        public short? ada_fileid { get; set; }

        public bool? ada_hidden { get; set; }

        public bool? ada_kilitli { get; set; }

        public bool? ada_degisti { get; set; }

        public int? ada_checksum { get; set; }

        public short? ada_create_user { get; set; }

        public DateTime? ada_create_date { get; set; }

        public short? ada_lastup_user { get; set; }

        public DateTime? ada_lastup_date { get; set; }

        [StringLength(4)]
        public string ada_special1 { get; set; }

        [StringLength(4)]
        public string ada_special2 { get; set; }

        [StringLength(4)]
        public string ada_special3 { get; set; }

        [StringLength(25)]
        public string ada_kod { get; set; }

        [StringLength(30)]
        public string ada_ismi { get; set; }

        [StringLength(50)]
        public string ada_aciklama { get; set; }
    }
}
