namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIKAYET_TANIMLARI
    {
        [Key]
        public int skyt_RECno { get; set; }

        public short skyt_RECid_DBCno { get; set; }

        public int skyt_RECid_RECno { get; set; }

        public int? skyt_SpecRECno { get; set; }

        public bool? skyt_iptal { get; set; }

        public short? skyt_fileid { get; set; }

        public bool? skyt_hidden { get; set; }

        public bool? skyt_kilitli { get; set; }

        public bool? skyt_degisti { get; set; }

        public int? skyt_checksum { get; set; }

        public short? skyt_create_user { get; set; }

        public DateTime? skyt_create_date { get; set; }

        public short? skyt_lastup_user { get; set; }

        public DateTime? skyt_lastup_date { get; set; }

        [StringLength(4)]
        public string skyt_special1 { get; set; }

        [StringLength(4)]
        public string skyt_special2 { get; set; }

        [StringLength(4)]
        public string skyt_special3 { get; set; }

        [StringLength(25)]
        public string skyt_kod { get; set; }

        [StringLength(90)]
        public string skyt_isim { get; set; }

        [StringLength(25)]
        public string skyt_personel_kod { get; set; }
    }
}
