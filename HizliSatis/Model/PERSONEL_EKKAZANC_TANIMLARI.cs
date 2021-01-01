namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EKKAZANC_TANIMLARI
    {
        [Key]
        public int PEK_RECno { get; set; }

        public short? PEK_RECid_DBCno { get; set; }

        public int PEK_RECid_RECno { get; set; }

        public int? PEK_SpecRECno { get; set; }

        public bool? PEK_iptal { get; set; }

        public short? PEK_fileid { get; set; }

        public bool? PEK_hidden { get; set; }

        public bool? PEK_kilitli { get; set; }

        public bool? PEK_degisti { get; set; }

        public int? PEK_checksum { get; set; }

        public short? PEK_create_user { get; set; }

        public DateTime? PEK_create_date { get; set; }

        public short? PEK_lastup_user { get; set; }

        public DateTime? PEK_lastup_date { get; set; }

        [StringLength(4)]
        public string PEK_special1 { get; set; }

        [StringLength(4)]
        public string PEK_special2 { get; set; }

        [StringLength(4)]
        public string PEK_special3 { get; set; }

        [StringLength(25)]
        public string PEK_Kodu { get; set; }

        public short? PEK_SiraNo { get; set; }

        public double? PEK_Carpan { get; set; }

        public double? PEK_Sabit { get; set; }

        public byte? PEK_Ssk { get; set; }

        public byte? PEK_Gv { get; set; }

        public double? PEK_Gv_Muaf { get; set; }

        public double? PEK_Ssk_Muaf { get; set; }

        public double? PEK_SabitUcret { get; set; }

        public byte? PEK_SabitUcretIsleyisi { get; set; }

        public byte? PEK_CarpanBolenIliskisi { get; set; }

        public bool? PEK_yardimekle_1 { get; set; }

        public bool? PEK_yardimekle_2 { get; set; }

        public bool? PEK_yardimekle_3 { get; set; }

        public bool? PEK_yardimekle_4 { get; set; }

        public bool? PEK_yardimekle_5 { get; set; }

        public bool? PEK_yardimekle_6 { get; set; }

        public bool? PEK_yardimekle_7 { get; set; }

        public bool? PEK_yardimekle_8 { get; set; }

        public bool? PEK_yardimekle_9 { get; set; }

        public bool? PEK_yardimekle_10 { get; set; }

        public bool? PEK_yardimekle_11 { get; set; }

        public bool? PEK_yardimekle_12 { get; set; }

        public bool? PEK_yardimekle_13 { get; set; }

        public bool? PEK_yardimekle_14 { get; set; }

        public bool? PEK_yardimekle_15 { get; set; }

        public bool? PEK_yardimekle_16 { get; set; }

        public bool? PEK_yardimekle_17 { get; set; }

        public bool? PEK_yardimekle_18 { get; set; }

        public bool? PEK_yardimekle_19 { get; set; }

        public bool? PEK_yardimekle_20 { get; set; }

        public bool? PEK_yardimekle_21 { get; set; }

        public bool? PEK_yardimekle_22 { get; set; }

        public bool? PEK_yardimekle_23 { get; set; }

        public bool? PEK_yardimekle_24 { get; set; }

        public bool? PEK_yardimekle_25 { get; set; }

        public bool? PEK_yardimekle_26 { get; set; }

        public bool? PEK_yardimekle_27 { get; set; }

        public bool? PEK_yardimekle_28 { get; set; }

        public bool? PEK_yardimekle_29 { get; set; }

        public bool? PEK_yardimekle_30 { get; set; }

        public bool? PEK_yardimekle_31 { get; set; }

        public bool? PEK_yardimekle_32 { get; set; }

        public byte? PEK_Dv { get; set; }

        public double? PEK_Dv_Muaf { get; set; }
    }
}
