namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_SAYACLARI
    {
        [Key]
        public int s_RECno { get; set; }

        public short s_RECid_DBCno { get; set; }

        public int s_RECid_RECno { get; set; }

        public int? s_SpecRECno { get; set; }

        public bool? s_iptal { get; set; }

        public short? s_fileid { get; set; }

        public bool? s_hidden { get; set; }

        public bool? s_kilitli { get; set; }

        public bool? s_degisti { get; set; }

        public int? s_checksum { get; set; }

        public short? s_create_user { get; set; }

        public DateTime? s_create_date { get; set; }

        public short? s_lastup_user { get; set; }

        public DateTime? s_lastup_date { get; set; }

        [StringLength(4)]
        public string s_special1 { get; set; }

        [StringLength(4)]
        public string s_special2 { get; set; }

        [StringLength(4)]
        public string s_special3 { get; set; }

        [StringLength(25)]
        public string s_kod { get; set; }

        [StringLength(30)]
        public string s_ismi { get; set; }

        public int? s_firma_no { get; set; }

        public int? s_sube_no { get; set; }

        public byte? s_hareket_tipi { get; set; }

        [StringLength(25)]
        public string s_stokkodu { get; set; }

        [StringLength(25)]
        public string s_adakodu { get; set; }

        [StringLength(50)]
        public string s_aciklama { get; set; }

        public int? s_depono { get; set; }

        public double? s_acilis { get; set; }

        [StringLength(25)]
        public string s_sube_sayackodu { get; set; }
    }
}
