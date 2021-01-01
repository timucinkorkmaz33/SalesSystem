namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_ALTERNATIFLERI
    {
        [Key]
        public int sa_RECno { get; set; }

        public short sa_RECid_DBCno { get; set; }

        public int sa_RECid_RECno { get; set; }

        public int? sa_SpecRECno { get; set; }

        public bool? sa_iptal { get; set; }

        public short? sa_fileid { get; set; }

        public bool? sa_hidden { get; set; }

        public bool? sa_kilitli { get; set; }

        public bool? sa_degisti { get; set; }

        public int? sa_checksum { get; set; }

        public short? sa_create_user { get; set; }

        public DateTime? sa_create_date { get; set; }

        public short? sa_lastup_user { get; set; }

        public DateTime? sa_lastup_date { get; set; }

        [StringLength(4)]
        public string sa_special1 { get; set; }

        [StringLength(4)]
        public string sa_special2 { get; set; }

        [StringLength(4)]
        public string sa_special3 { get; set; }

        [StringLength(25)]
        public string sa_kod { get; set; }

        [StringLength(25)]
        public string sa_alternatifkod { get; set; }
    }
}
