namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_BEDEN_TANIMLARI
    {
        [Key]
        public int bdn_RECno { get; set; }

        public short bdn_RECid_DBCno { get; set; }

        public int bdn_RECid_RECno { get; set; }

        public int? bdn_SpecRECno { get; set; }

        public bool? bdn_iptal { get; set; }

        public short? bdn_fileid { get; set; }

        public bool? bdn_hidden { get; set; }

        public bool? bdn_kilitli { get; set; }

        public bool? bdn_degisti { get; set; }

        public int? bdn_checksum { get; set; }

        public short? bdn_create_user { get; set; }

        public DateTime? bdn_create_date { get; set; }

        public short? bdn_lastup_user { get; set; }

        public DateTime? bdn_lastup_date { get; set; }

        [StringLength(4)]
        public string bdn_special1 { get; set; }

        [StringLength(4)]
        public string bdn_special2 { get; set; }

        [StringLength(4)]
        public string bdn_special3 { get; set; }

        [StringLength(25)]
        public string bdn_kodu { get; set; }

        [StringLength(90)]
        public string bdn_ismi { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_1 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_2 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_3 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_4 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_5 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_6 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_7 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_8 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_9 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_10 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_11 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_12 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_13 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_14 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_15 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_16 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_17 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_18 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_19 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_20 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_21 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_22 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_23 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_24 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_25 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_26 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_27 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_28 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_29 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_30 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_31 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_32 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_33 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_34 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_35 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_36 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_37 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_38 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_39 { get; set; }

        [StringLength(10)]
        public string bdn_kirilim_40 { get; set; }
    }
}
