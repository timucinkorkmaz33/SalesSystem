namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_RENK_TANIMLARI
    {
        [Key]
        public int rnk_RECno { get; set; }

        public short rnk_RECid_DBCno { get; set; }

        public int rnk_RECid_RECno { get; set; }

        public int? rnk_SpecRECNo { get; set; }

        public bool? rnk_iptal { get; set; }

        public short? rnk_fileid { get; set; }

        public bool? rnk_hidden { get; set; }

        public bool? rnk_kilitli { get; set; }

        public bool? rnk_degisti { get; set; }

        public int? rnk_CheckSum { get; set; }

        public short? rnk_create_user { get; set; }

        public DateTime? rnk_create_date { get; set; }

        public short? rnk_lastup_user { get; set; }

        public DateTime? rnk_lastup_date { get; set; }

        [StringLength(4)]
        public string rnk_special1 { get; set; }

        [StringLength(4)]
        public string rnk_special2 { get; set; }

        [StringLength(4)]
        public string rnk_special3 { get; set; }

        [StringLength(25)]
        public string rnk_kodu { get; set; }

        [StringLength(90)]
        public string rnk_ismi { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_1 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_2 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_3 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_4 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_5 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_6 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_7 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_8 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_9 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_10 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_11 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_12 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_13 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_14 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_15 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_16 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_17 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_18 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_19 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_20 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_21 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_22 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_23 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_24 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_25 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_26 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_27 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_28 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_29 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_30 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_31 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_32 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_33 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_34 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_35 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_36 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_37 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_38 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_39 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_40 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_41 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_42 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_43 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_44 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_45 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_46 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_47 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_48 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_49 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_50 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_51 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_52 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_53 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_54 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_55 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_56 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_57 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_58 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_59 { get; set; }

        [StringLength(90)]
        public string rnk_kirilim_60 { get; set; }
    }
}
