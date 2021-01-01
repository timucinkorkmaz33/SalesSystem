namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SOSYALYARDIM_TANIMLARI
    {
        [Key]
        public int PSY_RECno { get; set; }

        public short? PSY_RECid_DBCno { get; set; }

        public int PSY_RECid_RECno { get; set; }

        public int? PSY_SpecRECno { get; set; }

        public bool? PSY_iptal { get; set; }

        public short? PSY_fileid { get; set; }

        public bool? PSY_hidden { get; set; }

        public bool? PSY_kilitli { get; set; }

        public bool? PSY_degisti { get; set; }

        public int? PSY_checksum { get; set; }

        public short? PSY_create_user { get; set; }

        public DateTime? PSY_create_date { get; set; }

        public short? PSY_lastup_user { get; set; }

        public DateTime? PSY_lastup_date { get; set; }

        [StringLength(4)]
        public string PSY_special1 { get; set; }

        [StringLength(4)]
        public string PSY_special2 { get; set; }

        [StringLength(4)]
        public string PSY_special3 { get; set; }

        [StringLength(25)]
        public string PSY_Kodu { get; set; }

        public short? PSY_SiraNo { get; set; }

        public double? PSY_Tutar1 { get; set; }

        public double? PSY_Tutar2 { get; set; }

        public double? PSY_Tutar3 { get; set; }

        public double? PSY_Tutar4 { get; set; }

        public double? PSY_Tutar5 { get; set; }

        public double? PSY_Tutar6 { get; set; }

        public double? PSY_Tutar7 { get; set; }

        public double? PSY_Tutar8 { get; set; }

        public byte? PSY_Tahno { get; set; }

        [StringLength(1)]
        public string PSY_GunAy { get; set; }

        public byte? PSY_BrutNet { get; set; }

        public byte? PSY_Ssk { get; set; }

        public byte? PSY_Gv { get; set; }

        public byte? PSY_Dv { get; set; }

        public double? PSY_Gv_Muaf { get; set; }

        public double? PSY_Ssk_Muaf { get; set; }

        public double? PSY_Dv_Muaf { get; set; }

        public byte? PSY_kazancgunhesaplansin1 { get; set; }

        public byte? PSY_kazancgunhesaplansin2 { get; set; }

        public byte? PSY_kazancgunhesaplansin3 { get; set; }

        public byte? PSY_kazancgunhesaplansin4 { get; set; }

        public byte? PSY_kazancgunhesaplansin5 { get; set; }

        public byte? PSY_kazancgunhesaplansin6 { get; set; }
    }
}
