namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOP_PROMOSYON_SORGULARI
    {
        [Key]
        public int prq_RECno { get; set; }

        public short prq_RECid_DBCno { get; set; }

        public int prq_RECid_RECno { get; set; }

        public int? prq_SpecRECNo { get; set; }

        public bool? prq_iptal { get; set; }

        public short? prq_fileid { get; set; }

        public bool? prq_hidden { get; set; }

        public bool? prq_kilitli { get; set; }

        public bool? prq_degisti { get; set; }

        public int? prq_CheckSum { get; set; }

        public short? prq_create_user { get; set; }

        public DateTime? prq_create_date { get; set; }

        public short? prq_lastup_user { get; set; }

        public DateTime? prq_lastup_date { get; set; }

        [StringLength(4)]
        public string prq_special1 { get; set; }

        [StringLength(4)]
        public string prq_special2 { get; set; }

        [StringLength(4)]
        public string prq_special3 { get; set; }

        [StringLength(50)]
        public string prq_kodu { get; set; }

        [StringLength(100)]
        public string prq_ismi { get; set; }

        public byte? prq_tipi { get; set; }

        public byte? prq_pos_tipleri { get; set; }

        public byte? prq_ozellikler { get; set; }
    }
}
