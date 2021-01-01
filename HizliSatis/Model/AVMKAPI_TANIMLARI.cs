namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMKAPI_TANIMLARI
    {
        [Key]
        public int kapi_RECno { get; set; }

        public short kapi_RECid_DBCno { get; set; }

        public int kapi_RECid_RECno { get; set; }

        public int? kapi_SpecRECno { get; set; }

        public bool? kapi_iptal { get; set; }

        public short? kapi_fileid { get; set; }

        public bool? kapi_hidden { get; set; }

        public bool? kapi_kilitli { get; set; }

        public bool? kapi_degisti { get; set; }

        public int? kapi_checksum { get; set; }

        public short? kapi_create_user { get; set; }

        public DateTime? kapi_create_date { get; set; }

        public short? kapi_lastup_user { get; set; }

        public DateTime? kapi_lastup_date { get; set; }

        [StringLength(4)]
        public string kapi_special1 { get; set; }

        [StringLength(4)]
        public string kapi_special2 { get; set; }

        [StringLength(4)]
        public string kapi_special3 { get; set; }

        [StringLength(25)]
        public string kapi_sitekod { get; set; }

        [StringLength(25)]
        public string kapi_blokkod { get; set; }

        [StringLength(25)]
        public string kapi_katkod { get; set; }

        [StringLength(25)]
        public string kapi_kod { get; set; }

        [StringLength(90)]
        public string kapi_ismi { get; set; }

        public byte? kapi_turu { get; set; }
    }
}
