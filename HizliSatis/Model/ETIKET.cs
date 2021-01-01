namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ETIKET")]
    public partial class ETIKET
    {
        [Key]
        public int te_RECno { get; set; }

        public short te_RECid_DBCno { get; set; }

        public int te_RECid_RECno { get; set; }

        public int? te_SpecRECno { get; set; }

        public bool? te_iptal { get; set; }

        public short? te_fileid { get; set; }

        public bool? te_hidden { get; set; }

        public bool? te_kilitli { get; set; }

        public bool? te_degisti { get; set; }

        public int? te_checksum { get; set; }

        public short? te_create_user { get; set; }

        public DateTime? te_create_date { get; set; }

        public short? te_lastup_user { get; set; }

        public DateTime? te_lastup_date { get; set; }

        [StringLength(4)]
        public string te_special1 { get; set; }

        [StringLength(4)]
        public string te_special2 { get; set; }

        [StringLength(4)]
        public string te_special3 { get; set; }

        [StringLength(25)]
        public string te_StokKodu { get; set; }

        public byte? te_RenkPntr { get; set; }

        public byte? te_BedenPntr { get; set; }

        public int? te_EtiketMiktari { get; set; }

        public byte? te_nedeni { get; set; }
    }
}
