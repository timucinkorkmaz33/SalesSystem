namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEPARTMANLAR")]
    public partial class DEPARTMANLAR
    {
        [Key]
        public int pdp_RECno { get; set; }

        public short pdp_RECid_DBCno { get; set; }

        public int pdp_RECid_RECno { get; set; }

        public int? pdp_SpecRECno { get; set; }

        public bool? pdp_iptal { get; set; }

        public short? pdp_fileid { get; set; }

        public bool? pdp_hidden { get; set; }

        public bool? pdp_kilitli { get; set; }

        public bool? pdp_degisti { get; set; }

        public int? pdp_checksum { get; set; }

        public short? pdp_create_user { get; set; }

        public DateTime? pdp_create_date { get; set; }

        public short? pdp_lastup_user { get; set; }

        public DateTime? pdp_lastup_date { get; set; }

        [StringLength(4)]
        public string pdp_special1 { get; set; }

        [StringLength(4)]
        public string pdp_special2 { get; set; }

        [StringLength(4)]
        public string pdp_special3 { get; set; }

        [StringLength(25)]
        public string pdp_kodu { get; set; }

        [StringLength(40)]
        public string pdp_adi { get; set; }

        [StringLength(10)]
        public string pdp_muhkodu { get; set; }

        [StringLength(25)]
        public string pdp_sormer { get; set; }

        public double? pdp_KTprimyuzde { get; set; }

        public double? pdp_TTprimyuzde { get; set; }

        [StringLength(25)]
        public string pdp_projekodu { get; set; }

        [StringLength(25)]
        public string pdp_calismakodu { get; set; }
    }
}
