namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GELIR_GIDER_TANIMLARI
    {
        [Key]
        public int ggt_RECno { get; set; }

        public short ggt_RECid_DBCno { get; set; }

        public int ggt_RECid_RECno { get; set; }

        public int? ggt_Spec_Rec_no { get; set; }

        public bool? ggt_iptal { get; set; }

        public short? ggt_fileid { get; set; }

        public bool? ggt_hidden { get; set; }

        public bool? ggt_kilitli { get; set; }

        public bool? ggt_degisti { get; set; }

        public int? ggt_checksum { get; set; }

        public short? ggt_create_user { get; set; }

        public DateTime? ggt_create_date { get; set; }

        public short? ggt_lastup_user { get; set; }

        public DateTime? ggt_lastup_date { get; set; }

        [StringLength(4)]
        public string ggt_special1 { get; set; }

        [StringLength(4)]
        public string ggt_special2 { get; set; }

        [StringLength(4)]
        public string ggt_special3 { get; set; }

        [StringLength(25)]
        public string ggt_hesap_kod { get; set; }

        [StringLength(25)]
        public string ggt_srm_kod { get; set; }

        public double? ggt_borc { get; set; }

        public double? ggt_alacak { get; set; }
    }
}
