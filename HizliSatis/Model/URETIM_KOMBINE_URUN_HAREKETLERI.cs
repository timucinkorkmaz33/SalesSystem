namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_KOMBINE_URUN_HAREKETLERI
    {
        [Key]
        public int kmu_RECno { get; set; }

        public short kmu_RECid_DBCno { get; set; }

        public int kmu_RECid_RECno { get; set; }

        public int? kmu_SpecRecno { get; set; }

        public bool? kmu_iptal { get; set; }

        public short? kmu_fileid { get; set; }

        public bool? kmu_hidden { get; set; }

        public bool? kmu_kilitli { get; set; }

        public bool? kmu_degisti { get; set; }

        public int? kmu_checksum { get; set; }

        public short? kmu_create_user { get; set; }

        public DateTime? kmu_create_date { get; set; }

        public short? kmu_lastup_user { get; set; }

        public DateTime? kmu_lastup_date { get; set; }

        [StringLength(4)]
        public string kmu_special1 { get; set; }

        [StringLength(4)]
        public string kmu_special2 { get; set; }

        [StringLength(4)]
        public string kmu_special3 { get; set; }

        [StringLength(6)]
        public string kmu_ust_seri { get; set; }

        [StringLength(15)]
        public string kmu_ust_grup { get; set; }

        public int? kmu_ust_KombineSira { get; set; }

        [StringLength(25)]
        public string kmu_ust_isemri { get; set; }

        public int? kmu_satir_no { get; set; }

        [StringLength(25)]
        public string kmu_urun_kodu { get; set; }

        public double? kmu_miktar { get; set; }

        public int? kmu_evraksirano { get; set; }

        public DateTime? kmu_urunGirdiTarihi { get; set; }

        [StringLength(25)]
        public string kmu_parti { get; set; }

        public int? kmu_Lotno { get; set; }

        [StringLength(6)]
        public string kmu_SiparisSeri { get; set; }

        public int? kmu_SiparisSira { get; set; }

        public int? kmu_depono { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_1 { get; set; }

        public double? kmu_rec_HamMMik_1 { get; set; }

        public byte? kmu_rec_HamMCno_1 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_2 { get; set; }

        public double? kmu_rec_HamMMik_2 { get; set; }

        public byte? kmu_rec_HamMCno_2 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_3 { get; set; }

        public double? kmu_rec_HamMMik_3 { get; set; }

        public byte? kmu_rec_HamMCno_3 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_4 { get; set; }

        public double? kmu_rec_HamMMik_4 { get; set; }

        public byte? kmu_rec_HamMCno_4 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_5 { get; set; }

        public double? kmu_rec_HamMMik_5 { get; set; }

        public byte? kmu_rec_HamMCno_5 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_6 { get; set; }

        public double? kmu_rec_HamMMik_6 { get; set; }

        public byte? kmu_rec_HamMCno_6 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_7 { get; set; }

        public double? kmu_rec_HamMMik_7 { get; set; }

        public byte? kmu_rec_HamMCno_7 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_8 { get; set; }

        public double? kmu_rec_HamMMik_8 { get; set; }

        public byte? kmu_rec_HamMCno_8 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_9 { get; set; }

        public double? kmu_rec_HamMMik_9 { get; set; }

        public byte? kmu_rec_HamMCno_9 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_10 { get; set; }

        public double? kmu_rec_HamMMk_10 { get; set; }

        public byte? kmu_rec_HamMCno_10 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_11 { get; set; }

        public double? kmu_rec_HamMMik_11 { get; set; }

        public byte? kmu_rec_HamMCno_11 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_12 { get; set; }

        public double? kmu_rec_HamMMik_12 { get; set; }

        public byte? kmu_rec_HamMCno_12 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_13 { get; set; }

        public double? kmu_rec_HamMMik_13 { get; set; }

        public byte? kmu_rec_HamMCno_13 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_14 { get; set; }

        public double? kmu_rec_HamMMik_14 { get; set; }

        public byte? kmu_rec_HamMCno_14 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_15 { get; set; }

        public double? kmu_rec_HamMMik_15 { get; set; }

        public byte? kmu_rec_HamMCno_15 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_16 { get; set; }

        public double? kmu_rec_HamMMik_16 { get; set; }

        public byte? kmu_rec_HamMCno_16 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_17 { get; set; }

        public double? kmu_rec_HamMMik_17 { get; set; }

        public byte? kmu_rec_HamMCno_17 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_18 { get; set; }

        public double? kmu_rec_HamMMik_18 { get; set; }

        public byte? kmu_rec_HamMCno_18 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_19 { get; set; }

        public double? kmu_rec_HamMMik_19 { get; set; }

        public byte? kmu_rec_HamMCno_19 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_20 { get; set; }

        public double? kmu_rec_HamMMik_20 { get; set; }

        public byte? kmu_rec_HamMCno_20 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_21 { get; set; }

        public double? kmu_rec_HamMMik_21 { get; set; }

        public byte? kmu_rec_HamMCno_21 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_22 { get; set; }

        public double? kmu_rec_HamMMik_22 { get; set; }

        public byte? kmu_rec_HamMCno_22 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_23 { get; set; }

        public double? kmu_rec_HamMMik_23 { get; set; }

        public byte? kmu_rec_HamMCno_23 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_24 { get; set; }

        public double? kmu_rec_HamMMik_24 { get; set; }

        public byte? kmu_rec_HamMCno_24 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_25 { get; set; }

        public double? kmu_rec_HamMMik_25 { get; set; }

        public byte? kmu_rec_HamMCno_25 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_26 { get; set; }

        public double? kmu_rec_HamMMik_26 { get; set; }

        public byte? kmu_rec_HamMCno_26 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_27 { get; set; }

        public double? kmu_rec_HamMMik_27 { get; set; }

        public byte? kmu_rec_HamMCno_27 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_28 { get; set; }

        public double? kmu_rec_HamMMik_28 { get; set; }

        public byte? kmu_rec_HamMCno_28 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_29 { get; set; }

        public double? kmu_rec_HamMMik_29 { get; set; }

        public byte? kmu_rec_HamMCno_29 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_30 { get; set; }

        public double? kmu_rec_HamMMik_30 { get; set; }

        public byte? kmu_rec_HamMCno_30 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_31 { get; set; }

        public double? kmu_rec_HamMMik_31 { get; set; }

        public byte? kmu_rec_HamMCno_31 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_32 { get; set; }

        public double? kmu_rec_HamMMik_32 { get; set; }

        public byte? kmu_rec_HamMCno_32 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_33 { get; set; }

        public double? kmu_rec_HamMMik_33 { get; set; }

        public byte? kmu_rec_HamMCno_33 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_34 { get; set; }

        public double? kmu_rec_HamMMik_34 { get; set; }

        public byte? kmu_rec_HamMCno_34 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_35 { get; set; }

        public double? kmu_rec_HamMMik_35 { get; set; }

        public byte? kmu_rec_HamMCno_35 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_36 { get; set; }

        public double? kmu_rec_HamMMik_36 { get; set; }

        public byte? kmu_rec_HamMCno_36 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_37 { get; set; }

        public double? kmu_rec_HamMMik_37 { get; set; }

        public byte? kmu_rec_HamMCno_37 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_38 { get; set; }

        public double? kmu_rec_HamMMik_38 { get; set; }

        public byte? kmu_rec_HamMCno_38 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_39 { get; set; }

        public double? kmu_rec_HamMMik_39 { get; set; }

        public byte? kmu_rec_HamMCno_39 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_40 { get; set; }

        public double? kmu_rec_HamMMik_40 { get; set; }

        public byte? kmu_rec_HamMCno_40 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_41 { get; set; }

        public double? kmu_rec_HamMMik_41 { get; set; }

        public byte? kmu_rec_HamMCno_41 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_42 { get; set; }

        public double? kmu_rec_HamMMik_42 { get; set; }

        public byte? kmu_rec_HamMCno_42 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_43 { get; set; }

        public double? kmu_rec_HamMMik_43 { get; set; }

        public byte? kmu_rec_HamMCno_43 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_44 { get; set; }

        public double? kmu_rec_HamMMik_44 { get; set; }

        public byte? kmu_rec_HamMCno_44 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_45 { get; set; }

        public double? kmu_rec_HamMMik_45 { get; set; }

        public byte? kmu_rec_HamMCno_45 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_46 { get; set; }

        public double? kmu_rec_HamMMik_46 { get; set; }

        public byte? kmu_rec_HamMCno_46 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_47 { get; set; }

        public double? kmu_rec_HamMMik_47 { get; set; }

        public byte? kmu_rec_HamMCno_47 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_48 { get; set; }

        public double? kmu_rec_HamMMik_48 { get; set; }

        public byte? kmu_rec_HamMCno_48 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_49 { get; set; }

        public double? kmu_rec_HamMMik_49 { get; set; }

        public byte? kmu_rec_HamMCno_49 { get; set; }

        [StringLength(25)]
        public string kmu_rec_HamMKod_50 { get; set; }

        public double? kmu_rec_HamMMik_50 { get; set; }

        public byte? kmu_rec_HamMCno_50 { get; set; }

        public int? kmu_evraksatir_no { get; set; }

        public double? kmu_miktar2 { get; set; }

        public byte? kmu_hartip { get; set; }

        [StringLength(25)]
        public string kmu_fasoncukodu { get; set; }
    }
}
