namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RAF_ADRESLERI
    {
        [Key]
        public int ra_RECno { get; set; }

        public short ra_RECid_DBCno { get; set; }

        public int ra_RECid_RECno { get; set; }

        public int? ra_SpecRECno { get; set; }

        public bool? ra_iptal { get; set; }

        public short? ra_fileid { get; set; }

        public bool? ra_hidden { get; set; }

        public bool? ra_kilitli { get; set; }

        public bool? ra_degisti { get; set; }

        public int? ra_checksum { get; set; }

        public short? ra_create_user { get; set; }

        public DateTime? ra_create_date { get; set; }

        public short? ra_lastup_user { get; set; }

        public DateTime? ra_lastup_date { get; set; }

        [StringLength(4)]
        public string ra_special1 { get; set; }

        [StringLength(4)]
        public string ra_special2 { get; set; }

        [StringLength(4)]
        public string ra_special3 { get; set; }

        [StringLength(25)]
        public string ra_kod { get; set; }

        public byte? ra_cins { get; set; }

        public int? ra_depo { get; set; }

        [StringLength(4)]
        public string ra_koridor { get; set; }

        public byte? ra_yon { get; set; }

        [StringLength(4)]
        public string ra_blok { get; set; }

        [StringLength(4)]
        public string ra_kat { get; set; }

        public short? ra_en { get; set; }

        public short? ra_boy { get; set; }

        public short? ra_yukseklik { get; set; }

        public int? ra_hacim { get; set; }

        public int? ra_kapasite { get; set; }

        public byte? ra_bolumsayisi { get; set; }
    }
}
