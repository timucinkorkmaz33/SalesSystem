namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_ANAHAMMADDELERI
    {
        [Key]
        public int ahm_RECno { get; set; }

        public short ahm_RECid_DBCno { get; set; }

        public int ahm_RECid_RECno { get; set; }

        public int? ahm_SpecRECNo { get; set; }

        public bool? ahm_iptal { get; set; }

        public short? ahm_fileid { get; set; }

        public bool? ahm_hidden { get; set; }

        public bool? ahm_kilitli { get; set; }

        public bool? ahm_degisti { get; set; }

        public int? ahm_CheckSum { get; set; }

        public short? ahm_create_user { get; set; }

        public DateTime? ahm_create_date { get; set; }

        public short? ahm_lastup_user { get; set; }

        public DateTime? ahm_lastup_date { get; set; }

        [StringLength(4)]
        public string ahm_special1 { get; set; }

        [StringLength(4)]
        public string ahm_special2 { get; set; }

        [StringLength(4)]
        public string ahm_special3 { get; set; }

        [StringLength(25)]
        public string ahm_kodu { get; set; }

        [StringLength(90)]
        public string ahm_ismi { get; set; }
    }
}
