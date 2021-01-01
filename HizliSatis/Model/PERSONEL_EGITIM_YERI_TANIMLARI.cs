namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITIM_YERI_TANIMLARI
    {
        [Key]
        public int pey_RECno { get; set; }

        public short pey_RECid_DBCno { get; set; }

        public int pey_RECid_RECno { get; set; }

        public int? pey_SpecRECno { get; set; }

        public bool? pey_iptal { get; set; }

        public short? pey_fileid { get; set; }

        public bool? pey_hidden { get; set; }

        public bool? pey_kilitli { get; set; }

        public bool? pey_degisti { get; set; }

        public int? pey_checksum { get; set; }

        public short? pey_create_user { get; set; }

        public DateTime? pey_create_date { get; set; }

        public short? pey_lastup_user { get; set; }

        public DateTime? pey_lastup_date { get; set; }

        [StringLength(4)]
        public string pey_special1 { get; set; }

        [StringLength(4)]
        public string pey_special2 { get; set; }

        [StringLength(4)]
        public string pey_special3 { get; set; }

        [StringLength(25)]
        public string pey_kod { get; set; }

        [StringLength(40)]
        public string pey_adi { get; set; }

        public double? pey_ucret { get; set; }

        public byte? pey_doviz_cinsi { get; set; }

        public byte? pey_ucret_birimi { get; set; }

        [StringLength(25)]
        public string pey_bagli_cari_kodu { get; set; }
    }
}
