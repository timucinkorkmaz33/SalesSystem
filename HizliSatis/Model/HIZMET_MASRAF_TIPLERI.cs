namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_MASRAF_TIPLERI
    {
        [Key]
        public int hmtip_RECno { get; set; }

        public short hmtip_RECid_DBCno { get; set; }

        public int hmtip_RECid_RECno { get; set; }

        public int? hmtip_SpecRECno { get; set; }

        public bool? hmtip_iptal { get; set; }

        public short? hmtip_fileid { get; set; }

        public bool? hmtip_hidden { get; set; }

        public bool? hmtip_kilitli { get; set; }

        public bool? hmtip_degisti { get; set; }

        public int? hmtip_checksum { get; set; }

        public short? hmtip_create_user { get; set; }

        public DateTime? hmtip_create_date { get; set; }

        public short? hmtip_lastup_user { get; set; }

        public DateTime? hmtip_lastup_date { get; set; }

        [StringLength(4)]
        public string hmtip_special1 { get; set; }

        [StringLength(4)]
        public string hmtip_special2 { get; set; }

        [StringLength(4)]
        public string hmtip_special3 { get; set; }

        [StringLength(25)]
        public string hmtip_kod { get; set; }

        [StringLength(90)]
        public string hmtip_ismi { get; set; }
    }
}
