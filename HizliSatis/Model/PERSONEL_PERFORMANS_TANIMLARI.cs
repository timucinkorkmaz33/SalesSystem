namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_PERFORMANS_TANIMLARI
    {
        [Key]
        public int prf_RECno { get; set; }

        public short prf_RECid_DBCno { get; set; }

        public int prf_RECid_RECno { get; set; }

        public int? prf_SpecRECno { get; set; }

        public bool? prf_iptal { get; set; }

        public short? prf_fileid { get; set; }

        public bool? prf_hidden { get; set; }

        public bool? prf_kilitli { get; set; }

        public bool? prf_degisti { get; set; }

        public int? prf_checksum { get; set; }

        public short? prf_create_user { get; set; }

        public DateTime? prf_create_date { get; set; }

        public short? prf_lastup_user { get; set; }

        public DateTime? prf_lastup_date { get; set; }

        [StringLength(4)]
        public string prf_special1 { get; set; }

        [StringLength(4)]
        public string prf_special2 { get; set; }

        [StringLength(4)]
        public string prf_special3 { get; set; }

        [StringLength(25)]
        public string prf_kodu { get; set; }

        [StringLength(40)]
        public string prf_adi { get; set; }

        public byte? prf_tip { get; set; }

        public byte? prf_sekil { get; set; }

        public byte? prf_birim { get; set; }

        public byte? prf_sosyrdmksntmo { get; set; }

        public double? prf_maxmiktar { get; set; }

        public bool? prf_degerlendir_fl { get; set; }
    }
}
