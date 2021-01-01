namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_SEKTORLERI
    {
        [Key]
        public int sktr_RECno { get; set; }

        public short sktr_RECid_DBCno { get; set; }

        public int sktr_RECid_RECno { get; set; }

        public int? sktr_SpecRECno { get; set; }

        public bool? sktr_iptal { get; set; }

        public short? sktr_fileid { get; set; }

        public bool? sktr_hidden { get; set; }

        public bool? sktr_kilitli { get; set; }

        public bool? sktr_degisti { get; set; }

        public int? sktr_checksum { get; set; }

        public short? sktr_create_user { get; set; }

        public DateTime? sktr_create_date { get; set; }

        public short? sktr_lastup_user { get; set; }

        public DateTime? sktr_lastup_date { get; set; }

        [StringLength(4)]
        public string sktr_special1 { get; set; }

        [StringLength(4)]
        public string sktr_special2 { get; set; }

        [StringLength(4)]
        public string sktr_special3 { get; set; }

        [StringLength(25)]
        public string sktr_kod { get; set; }

        [StringLength(90)]
        public string sktr_ismi { get; set; }

        [StringLength(4)]
        public string sktr_muhkodu { get; set; }
    }
}
