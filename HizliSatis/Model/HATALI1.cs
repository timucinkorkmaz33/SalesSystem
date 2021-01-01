namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HATALI1
    {
        [Key]
        public int Online_RECno { get; set; }

        public short Online_RECid_DBCno { get; set; }

        public int Online_RECid_RECno { get; set; }

        public int? Online_SpecRECNo { get; set; }

        public bool? Online_iptal { get; set; }

        public short? Online_fileid { get; set; }

        public bool? Online_hidden { get; set; }

        public bool? Online_kilitli { get; set; }

        public bool? Online_degisti { get; set; }

        public int? Online_CheckSum { get; set; }

        public short? Online_create_user { get; set; }

        public DateTime? Online_create_date { get; set; }

        public short? Online_lastup_user { get; set; }

        public DateTime? Online_lastup_date { get; set; }

        [StringLength(4)]
        public string Online_special1 { get; set; }

        [StringLength(4)]
        public string Online_special2 { get; set; }

        [StringLength(4)]
        public string Online_special3 { get; set; }

        public byte[] Online_Buffer { get; set; }
    }
}
