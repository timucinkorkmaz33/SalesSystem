namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_KALITE_KONTROL_TANIMLARI
    {
        [Key]
        public int KKon_RECno { get; set; }

        public short KKon_RECid_DBCno { get; set; }

        public int KKon_RECid_RECno { get; set; }

        public int? KKon_SpecRecno { get; set; }

        public bool? KKon_iptal { get; set; }

        public short? KKon_fileid { get; set; }

        public bool? KKon_hidden { get; set; }

        public bool? KKon_kilitli { get; set; }

        public bool? KKon_degisti { get; set; }

        public int? KKon_checksum { get; set; }

        public short? KKon_create_user { get; set; }

        public DateTime? KKon_create_date { get; set; }

        public short? KKon_lastup_user { get; set; }

        public DateTime? KKon_lastup_date { get; set; }

        [StringLength(4)]
        public string KKon_special1 { get; set; }

        [StringLength(4)]
        public string KKon_special2 { get; set; }

        [StringLength(4)]
        public string KKon_special3 { get; set; }

        [StringLength(25)]
        public string KKon_kod { get; set; }

        [StringLength(90)]
        public string KKon_ismi { get; set; }
    }
}
