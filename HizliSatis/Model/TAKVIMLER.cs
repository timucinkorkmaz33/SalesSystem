namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAKVIMLER")]
    public partial class TAKVIMLER
    {
        [Key]
        public int takvim_RECno { get; set; }

        public short? takvim_RECid_DBCno { get; set; }

        public int takvim_RECid_RECno { get; set; }

        public int? takvim_SpecRECNo { get; set; }

        public bool? takvim_iptal { get; set; }

        public short? takvim_fileid { get; set; }

        public bool? takvim_hidden { get; set; }

        public bool? takvim_kilitli { get; set; }

        public bool? takvim_degisti { get; set; }

        public int? takvim_CheckSum { get; set; }

        public short? takvim_create_user { get; set; }

        public DateTime? takvim_create_date { get; set; }

        public short? takvim_lastup_user { get; set; }

        public DateTime? takvim_lastup_date { get; set; }

        [StringLength(4)]
        public string takvim_special1 { get; set; }

        [StringLength(4)]
        public string takvim_special2 { get; set; }

        [StringLength(4)]
        public string takvim_special3 { get; set; }

        [StringLength(4)]
        public string takvim_kodu { get; set; }

        [StringLength(40)]
        public string takvim_ismi { get; set; }
    }
}
