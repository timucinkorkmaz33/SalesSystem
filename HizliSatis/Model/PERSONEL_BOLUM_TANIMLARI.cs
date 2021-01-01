namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BOLUM_TANIMLARI
    {
        [Key]
        public int bl_RECno { get; set; }

        public short bl_RECid_DBCno { get; set; }

        public int bl_RECid_RECno { get; set; }

        public int? bl_SpecRECno { get; set; }

        public bool? bl_iptal { get; set; }

        public short? bl_fileid { get; set; }

        public bool? bl_hidden { get; set; }

        public bool? bl_kilitli { get; set; }

        public bool? bl_degisti { get; set; }

        public int? bl_checksum { get; set; }

        public short? bl_create_user { get; set; }

        public DateTime? bl_create_date { get; set; }

        public short? bl_lastup_user { get; set; }

        public DateTime? bl_lastup_date { get; set; }

        [StringLength(4)]
        public string bl_special1 { get; set; }

        [StringLength(4)]
        public string bl_special2 { get; set; }

        [StringLength(4)]
        public string bl_special3 { get; set; }

        [StringLength(25)]
        public string bl_kod { get; set; }

        [StringLength(60)]
        public string bl_adi { get; set; }
    }
}
