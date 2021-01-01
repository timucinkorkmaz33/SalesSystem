namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MULTIKOD_TANIMLARI
    {
        [Key]
        public int mcod_RECno { get; set; }

        public short mcod_RECid_DBCno { get; set; }

        public int mcod_RECid_RECno { get; set; }

        public int? mcod_SpecRecNo { get; set; }

        public bool? mcod_Iptal { get; set; }

        public short? mcod_fileid { get; set; }

        public bool? mcod_hidden { get; set; }

        public bool? mcod_kilitli { get; set; }

        public bool? mcod_degisti { get; set; }

        public int? mcod_CheckSum { get; set; }

        public short? mcod_create_user { get; set; }

        public DateTime? mcod_create_date { get; set; }

        public short? mcod_lastup_user { get; set; }

        public DateTime? mcod_lastup_date { get; set; }

        [StringLength(4)]
        public string mcod_special1 { get; set; }

        [StringLength(4)]
        public string mcod_special2 { get; set; }

        [StringLength(4)]
        public string mcod_special3 { get; set; }

        [StringLength(25)]
        public string mcod_carikod { get; set; }

        [StringLength(25)]
        public string mcod_stokkod { get; set; }

        [StringLength(25)]
        public string mcod_caristok_kod { get; set; }

        [StringLength(50)]
        public string mcod_caristok_ismi { get; set; }

        public byte? mcod_tipi { get; set; }

        public bool? mcod_herseferindeeslestir_fl { get; set; }
    }
}
