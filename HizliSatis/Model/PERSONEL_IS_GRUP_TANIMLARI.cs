namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_IS_GRUP_TANIMLARI
    {
        [Key]
        public int ig_RECno { get; set; }

        public short ig_RECid_DBCno { get; set; }

        public int ig_RECid_RECno { get; set; }

        public int? ig_SpecRECno { get; set; }

        public bool? ig_iptal { get; set; }

        public short? ig_fileid { get; set; }

        public bool? ig_hidden { get; set; }

        public bool? ig_kilitli { get; set; }

        public bool? ig_degisti { get; set; }

        public int? ig_checksum { get; set; }

        public short? ig_create_user { get; set; }

        public DateTime? ig_create_date { get; set; }

        public short? ig_lastup_user { get; set; }

        public DateTime? ig_lastup_date { get; set; }

        [StringLength(4)]
        public string ig_special1 { get; set; }

        [StringLength(4)]
        public string ig_special2 { get; set; }

        [StringLength(4)]
        public string ig_special3 { get; set; }

        [StringLength(25)]
        public string ig_kod { get; set; }

        [StringLength(40)]
        public string ig_adi { get; set; }
    }
}
