namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_SERBEST_HAREKET
    {
        [Key]
        public int sm_RECno { get; set; }

        public short sm_RECid_DBCno { get; set; }

        public int sm_RECid_RECno { get; set; }

        public int? sm_SpecRECno { get; set; }

        public bool? sm_iptal { get; set; }

        public short? sm_fileid { get; set; }

        public bool? sm_hidden { get; set; }

        public bool? sm_kilitli { get; set; }

        public bool? sm_degisti { get; set; }

        public int? sm_checksum { get; set; }

        public short? sm_create_user { get; set; }

        public DateTime? sm_create_date { get; set; }

        public short? sm_lastup_user { get; set; }

        public DateTime? sm_lastup_date { get; set; }

        [StringLength(4)]
        public string sm_special1 { get; set; }

        [StringLength(4)]
        public string sm_special2 { get; set; }

        [StringLength(4)]
        public string sm_special3 { get; set; }

        public DateTime? sm_tarih { get; set; }

        public int? sm_firmano { get; set; }

        [StringLength(6)]
        public string sm_EvrNo_seri { get; set; }

        public int? sm_EvrNo_sira { get; set; }

        public byte? sm_IB { get; set; }

        public byte? sm_IM { get; set; }

        [StringLength(20)]
        public string sm_pveren { get; set; }

        [StringLength(127)]
        public string sm_adr1 { get; set; }

        [StringLength(127)]
        public string sm_adr2 { get; set; }

        [StringLength(127)]
        public string sm_adr3 { get; set; }

        [StringLength(30)]
        public string sm_HesapNo { get; set; }

        public double? sm_Brut { get; set; }

        public double? sm_KDV { get; set; }

        public double? sm_Stopaj { get; set; }

        public double? sm_SSDF { get; set; }

        public double? sm_Net { get; set; }

        [StringLength(10)]
        public string sm_VD { get; set; }

        public DateTime? sm_fistarih { get; set; }

        public int? sm_fissirano { get; set; }

        public bool? sm_Acik { get; set; }

        [StringLength(25)]
        public string sm_muhkodu { get; set; }

        [StringLength(25)]
        public string sm_dbkodu { get; set; }

        [StringLength(15)]
        public string sm_tckimlikno { get; set; }

        public double? sm_Tevkifat { get; set; }
    }
}
