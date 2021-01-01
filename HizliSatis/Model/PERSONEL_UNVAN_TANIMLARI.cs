namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_UNVAN_TANIMLARI
    {
        [Key]
        public int un_RECno { get; set; }

        public short un_RECid_DBCno { get; set; }

        public int un_RECid_RECno { get; set; }

        public int? un_SpecRECno { get; set; }

        public bool? un_iptal { get; set; }

        public short? un_fileid { get; set; }

        public bool? un_hidden { get; set; }

        public bool? un_kilitli { get; set; }

        public bool? un_degisti { get; set; }

        public int? un_checksum { get; set; }

        public short? un_create_user { get; set; }

        public DateTime? un_create_date { get; set; }

        public short? un_lastup_user { get; set; }

        public DateTime? un_lastup_date { get; set; }

        [StringLength(4)]
        public string un_special1 { get; set; }

        [StringLength(4)]
        public string un_special2 { get; set; }

        [StringLength(4)]
        public string un_special3 { get; set; }

        [StringLength(25)]
        public string un_kod { get; set; }

        [StringLength(40)]
        public string un_aciklama { get; set; }
    }
}
