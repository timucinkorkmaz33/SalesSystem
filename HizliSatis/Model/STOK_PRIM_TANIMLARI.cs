namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_PRIM_TANIMLARI
    {
        [Key]
        public int prim_RECno { get; set; }

        public short prim_RECid_DBCno { get; set; }

        public int prim_RECid_RECno { get; set; }

        public int? prim_SpecRECno { get; set; }

        public bool? prim_iptal { get; set; }

        public short? prim_fileid { get; set; }

        public bool? prim_hidden { get; set; }

        public bool? prim_kilitli { get; set; }

        public bool? prim_degisti { get; set; }

        public int? prim_checksum { get; set; }

        public short? prim_create_user { get; set; }

        public DateTime? prim_create_date { get; set; }

        public short? prim_lastup_user { get; set; }

        public DateTime? prim_lastup_date { get; set; }

        [StringLength(4)]
        public string prim_special1 { get; set; }

        [StringLength(4)]
        public string prim_special2 { get; set; }

        [StringLength(4)]
        public string prim_special3 { get; set; }

        [StringLength(25)]
        public string prim_kod { get; set; }

        [StringLength(40)]
        public string prim_adi { get; set; }

        public int? prim_satirno { get; set; }

        public double? prim_yuzdesi { get; set; }

        public double? prim_min_isk { get; set; }

        public double? prim_max_isk { get; set; }

        public int? prim_min_vade_sapma { get; set; }

        public int? prim_max_vade_sapma { get; set; }

        public byte? prim_hesap_sekli { get; set; }

        public bool? prim_odemeye_bagli { get; set; }
    }
}
