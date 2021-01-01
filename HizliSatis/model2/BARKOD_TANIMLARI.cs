namespace HizliSatis.model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BARKOD_TANIMLARI
    {
        [Key]
        public int bar_RECno { get; set; }

        public short bar_RECid_DBCno { get; set; }

        public int bar_RECid_RECno { get; set; }

        public int? bar_SpecRECno { get; set; }

        public bool? bar_iptal { get; set; }

        public short? bar_fileid { get; set; }

        public bool? bar_hidden { get; set; }

        public bool? bar_kilitli { get; set; }

        public bool? bar_degisti { get; set; }

        public int? bar_checksum { get; set; }

        public short? bar_create_user { get; set; }

        public DateTime? bar_create_date { get; set; }

        public short? bar_lastup_user { get; set; }

        public DateTime? bar_lastup_date { get; set; }

        [StringLength(4)]
        public string bar_special1 { get; set; }

        [StringLength(4)]
        public string bar_special2 { get; set; }

        [StringLength(4)]
        public string bar_special3 { get; set; }

        [StringLength(25)]
        public string bar_kodu { get; set; }

        [StringLength(25)]
        public string bar_stokkodu { get; set; }

        [StringLength(25)]
        public string bar_partikodu { get; set; }

        public int? bar_lotno { get; set; }

        [StringLength(25)]
        public string bar_serino_veya_bagkodu { get; set; }

        public byte? bar_barkodtipi { get; set; }

        public byte? bar_icerigi { get; set; }

        public byte? bar_birimpntr { get; set; }

        public bool? bar_master { get; set; }

        public byte? bar_bedenpntr { get; set; }

        public byte? bar_renkpntr { get; set; }

        public byte? bar_baglantitipi { get; set; }

        public short? bar_harrecid_dbcno { get; set; }

        public int? bar_harrecid_recno { get; set; }

        [StringLength(25)]
        public string bar_asortitanimkodu { get; set; }
    }
}
