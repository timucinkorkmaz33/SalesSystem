namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BASVURU_PUAN_TANIMLARI
    {
        [Key]
        public int bsp_RECno { get; set; }

        public short bsp_RECid_DBCno { get; set; }

        public int bsp_RECid_RECno { get; set; }

        public int? bsp_SpecRECno { get; set; }

        public bool? bsp_iptal { get; set; }

        public short? bsp_fileid { get; set; }

        public bool? bsp_hidden { get; set; }

        public bool? bsp_kilitli { get; set; }

        public bool? bsp_degisti { get; set; }

        public int? bsp_checksum { get; set; }

        public short? bsp_create_user { get; set; }

        public DateTime? bsp_create_date { get; set; }

        public short? bsp_lastup_user { get; set; }

        public DateTime? bsp_lastup_date { get; set; }

        [StringLength(4)]
        public string bsp_special1 { get; set; }

        [StringLength(4)]
        public string bsp_special2 { get; set; }

        [StringLength(4)]
        public string bsp_special3 { get; set; }

        [StringLength(25)]
        public string bsp_kodu { get; set; }

        [StringLength(40)]
        public string bsp_adi { get; set; }

        public double? bsp_maxpuan { get; set; }

        public double? bsp_agirlik { get; set; }
    }
}
