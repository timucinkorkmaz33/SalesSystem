namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_MALIYIL_URETIM_PARAMETRELERI
    {
        [Key]
        public int fmu_RECno { get; set; }

        public short fmu_RECid_DBCno { get; set; }

        public int fmu_RECid_RECno { get; set; }

        public int? fmu_SpecRECno { get; set; }

        public bool? fmu_iptal { get; set; }

        public short? fmu_fileid { get; set; }

        public bool? fmu_hidden { get; set; }

        public bool? fmu_kilitli { get; set; }

        public bool? fmu_degisti { get; set; }

        public int? fmu_checksum { get; set; }

        public short? fmu_create_user { get; set; }

        public DateTime? fmu_create_date { get; set; }

        public short? fmu_lastup_user { get; set; }

        public DateTime? fmu_lastup_date { get; set; }

        [StringLength(4)]
        public string fmu_special1 { get; set; }

        [StringLength(4)]
        public string fmu_special2 { get; set; }

        [StringLength(4)]
        public string fmu_special3 { get; set; }

        public int? fmu_sirano { get; set; }

        public int? fmu_maliyil { get; set; }

        [StringLength(20)]
        public string fmu_dig_isim_1 { get; set; }

        public double? fmu_dig_tutar_1_0 { get; set; }

        public double? fmu_dig_tutar_1_1 { get; set; }

        public double? fmu_dig_tutar_1_2 { get; set; }

        public double? fmu_dig_tutar_1_3 { get; set; }

        public double? fmu_dig_tutar_1_4 { get; set; }

        public double? fmu_dig_tutar_1_5 { get; set; }

        public double? fmu_dig_tutar_1_6 { get; set; }

        public double? fmu_dig_tutar_1_7 { get; set; }

        public double? fmu_dig_tutar_1_8 { get; set; }

        public double? fmu_dig_tutar_1_9 { get; set; }

        public double? fmu_dig_tutar_1_10 { get; set; }

        public double? fmu_dig_tutar_1_11 { get; set; }

        public double? fmu_dig_tutar_1_12 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_1 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_2 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_3 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_4 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_5 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_6 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_7 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_8 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_9 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_10 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_11 { get; set; }

        public double? fmu_dig_ds_bekleyen_1_12 { get; set; }

        [StringLength(25)]
        public string fmu_dig_birikim_muhkodu_1 { get; set; }

        [StringLength(20)]
        public string fmu_dig_isim_2 { get; set; }

        public double? fmu_dig_tutar_2_0 { get; set; }

        public double? fmu_dig_tutar_2_1 { get; set; }

        public double? fmu_dig_tutar_2_2 { get; set; }

        public double? fmu_dig_tutar_2_3 { get; set; }

        public double? fmu_dig_tutar_2_4 { get; set; }

        public double? fmu_dig_tutar_2_5 { get; set; }

        public double? fmu_dig_tutar_2_6 { get; set; }

        public double? fmu_dig_tutar_2_7 { get; set; }

        public double? fmu_dig_tutar_2_8 { get; set; }

        public double? fmu_dig_tutar_2_9 { get; set; }

        public double? fmu_dig_tutar_2_10 { get; set; }

        public double? fmu_dig_tutar_2_11 { get; set; }

        public double? fmu_dig_tutar_2_12 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_1 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_2 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_3 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_4 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_5 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_6 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_7 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_8 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_9 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_10 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_11 { get; set; }

        public double? fmu_dig_ds_bekleyen_2_12 { get; set; }

        [StringLength(25)]
        public string fmu_dig_birikim_muhkodu_2 { get; set; }

        [StringLength(20)]
        public string fmu_dig_isim_3 { get; set; }

        public double? fmu_dig_tutar_3_0 { get; set; }

        public double? fmu_dig_tutar_3_1 { get; set; }

        public double? fmu_dig_tutar_3_2 { get; set; }

        public double? fmu_dig_tutar_3_3 { get; set; }

        public double? fmu_dig_tutar_3_4 { get; set; }

        public double? fmu_dig_tutar_3_5 { get; set; }

        public double? fmu_dig_tutar_3_6 { get; set; }

        public double? fmu_dig_tutar_3_7 { get; set; }

        public double? fmu_dig_tutar_3_8 { get; set; }

        public double? fmu_dig_tutar_3_9 { get; set; }

        public double? fmu_dig_tutar_3_10 { get; set; }

        public double? fmu_dig_tutar_3_11 { get; set; }

        public double? fmu_dig_tutar_3_12 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_1 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_2 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_3 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_4 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_5 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_6 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_7 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_8 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_9 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_10 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_11 { get; set; }

        public double? fmu_dig_ds_bekleyen_3_12 { get; set; }

        [StringLength(25)]
        public string fmu_dig_birikim_muhkodu_3 { get; set; }

        [StringLength(20)]
        public string fmu_dig_isim_4 { get; set; }

        public double? fmu_dig_tutar_4_0 { get; set; }

        public double? fmu_dig_tutar_4_1 { get; set; }

        public double? fmu_dig_tutar_4_2 { get; set; }

        public double? fmu_dig_tutar_4_3 { get; set; }

        public double? fmu_dig_tutar_4_4 { get; set; }

        public double? fmu_dig_tutar_4_5 { get; set; }

        public double? fmu_dig_tutar_4_6 { get; set; }

        public double? fmu_dig_tutar_4_7 { get; set; }

        public double? fmu_dig_tutar_4_8 { get; set; }

        public double? fmu_dig_tutar_4_9 { get; set; }

        public double? fmu_dig_tutar_4_10 { get; set; }

        public double? fmu_dig_tutar_4_11 { get; set; }

        public double? fmu_dig_tutar_4_12 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_1 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_2 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_3 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_4 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_5 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_6 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_7 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_8 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_9 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_10 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_11 { get; set; }

        public double? fmu_dig_ds_bekleyen_4_12 { get; set; }

        [StringLength(25)]
        public string fmu_dig_birikim_muhkodu_4 { get; set; }

        [StringLength(20)]
        public string fmu_dig_isim_5 { get; set; }

        public double? fmu_dig_tutar_5_0 { get; set; }

        public double? fmu_dig_tutar_5_1 { get; set; }

        public double? fmu_dig_tutar_5_2 { get; set; }

        public double? fmu_dig_tutar_5_3 { get; set; }

        public double? fmu_dig_tutar_5_4 { get; set; }

        public double? fmu_dig_tutar_5_5 { get; set; }

        public double? fmu_dig_tutar_5_6 { get; set; }

        public double? fmu_dig_tutar_5_7 { get; set; }

        public double? fmu_dig_tutar_5_8 { get; set; }

        public double? fmu_dig_tutar_5_9 { get; set; }

        public double? fmu_dig_tutar_5_10 { get; set; }

        public double? fmu_dig_tutar_5_11 { get; set; }

        public double? fmu_dig_tutar_5_12 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_1 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_2 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_3 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_4 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_5 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_6 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_7 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_8 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_9 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_10 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_11 { get; set; }

        public double? fmu_dig_ds_bekleyen_5_12 { get; set; }

        [StringLength(25)]
        public string fmu_dig_birikim_muhkodu_5 { get; set; }

        [StringLength(20)]
        public string fmu_gug_isim_1 { get; set; }

        public double? fmu_gug_tutar_1_0 { get; set; }

        public double? fmu_gug_tutar_1_1 { get; set; }

        public double? fmu_gug_tutar_1_2 { get; set; }

        public double? fmu_gug_tutar_1_3 { get; set; }

        public double? fmu_gug_tutar_1_4 { get; set; }

        public double? fmu_gug_tutar_1_5 { get; set; }

        public double? fmu_gug_tutar_1_6 { get; set; }

        public double? fmu_gug_tutar_1_7 { get; set; }

        public double? fmu_gug_tutar_1_8 { get; set; }

        public double? fmu_gug_tutar_1_9 { get; set; }

        public double? fmu_gug_tutar_1_10 { get; set; }

        public double? fmu_gug_tutar_1_11 { get; set; }

        public double? fmu_gug_tutar_1_12 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_1 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_2 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_3 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_4 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_5 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_6 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_7 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_8 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_9 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_10 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_11 { get; set; }

        public double? fmu_gug_ds_bekleyen_1_12 { get; set; }

        [StringLength(25)]
        public string fmu_gug_birikim_muhkodu_1 { get; set; }

        [StringLength(20)]
        public string fmu_gug_isim_2 { get; set; }

        public double? fmu_gug_tutar_2_0 { get; set; }

        public double? fmu_gug_tutar_2_1 { get; set; }

        public double? fmu_gug_tutar_2_2 { get; set; }

        public double? fmu_gug_tutar_2_3 { get; set; }

        public double? fmu_gug_tutar_2_4 { get; set; }

        public double? fmu_gug_tutar_2_5 { get; set; }

        public double? fmu_gug_tutar_2_6 { get; set; }

        public double? fmu_gug_tutar_2_7 { get; set; }

        public double? fmu_gug_tutar_2_8 { get; set; }

        public double? fmu_gug_tutar_2_9 { get; set; }

        public double? fmu_gug_tutar_2_10 { get; set; }

        public double? fmu_gug_tutar_2_11 { get; set; }

        public double? fmu_gug_tutar_2_12 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_1 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_2 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_3 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_4 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_5 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_6 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_7 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_8 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_9 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_10 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_11 { get; set; }

        public double? fmu_gug_ds_bekleyen_2_12 { get; set; }

        [StringLength(25)]
        public string fmu_gug_birikim_muhkodu_2 { get; set; }

        [StringLength(20)]
        public string fmu_gug_isim_3 { get; set; }

        public double? fmu_gug_tutar_3_0 { get; set; }

        public double? fmu_gug_tutar_3_1 { get; set; }

        public double? fmu_gug_tutar_3_2 { get; set; }

        public double? fmu_gug_tutar_3_3 { get; set; }

        public double? fmu_gug_tutar_3_4 { get; set; }

        public double? fmu_gug_tutar_3_5 { get; set; }

        public double? fmu_gug_tutar_3_6 { get; set; }

        public double? fmu_gug_tutar_3_7 { get; set; }

        public double? fmu_gug_tutar_3_8 { get; set; }

        public double? fmu_gug_tutar_3_9 { get; set; }

        public double? fmu_gug_tutar_3_10 { get; set; }

        public double? fmu_gug_tutar_3_11 { get; set; }

        public double? fmu_gug_tutar_3_12 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_1 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_2 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_3 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_4 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_5 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_6 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_7 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_8 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_9 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_10 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_11 { get; set; }

        public double? fmu_gug_ds_bekleyen_3_12 { get; set; }

        [StringLength(25)]
        public string fmu_gug_birikim_muhkodu_3 { get; set; }

        [StringLength(20)]
        public string fmu_gug_isim_4 { get; set; }

        public double? fmu_gug_tutar_4_0 { get; set; }

        public double? fmu_gug_tutar_4_1 { get; set; }

        public double? fmu_gug_tutar_4_2 { get; set; }

        public double? fmu_gug_tutar_4_3 { get; set; }

        public double? fmu_gug_tutar_4_4 { get; set; }

        public double? fmu_gug_tutar_4_5 { get; set; }

        public double? fmu_gug_tutar_4_6 { get; set; }

        public double? fmu_gug_tutar_4_7 { get; set; }

        public double? fmu_gug_tutar_4_8 { get; set; }

        public double? fmu_gug_tutar_4_9 { get; set; }

        public double? fmu_gug_tutar_4_10 { get; set; }

        public double? fmu_gug_tutar_4_11 { get; set; }

        public double? fmu_gug_tutar_4_12 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_1 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_2 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_3 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_4 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_5 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_6 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_7 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_8 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_9 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_10 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_11 { get; set; }

        public double? fmu_gug_ds_bekleyen_4_12 { get; set; }

        [StringLength(25)]
        public string fmu_gug_birikim_muhkodu_4 { get; set; }

        [StringLength(20)]
        public string fmu_gug_isim_5 { get; set; }

        public double? fmu_gug_tutar_5_0 { get; set; }

        public double? fmu_gug_tutar_5_1 { get; set; }

        public double? fmu_gug_tutar_5_2 { get; set; }

        public double? fmu_gug_tutar_5_3 { get; set; }

        public double? fmu_gug_tutar_5_4 { get; set; }

        public double? fmu_gug_tutar_5_5 { get; set; }

        public double? fmu_gug_tutar_5_6 { get; set; }

        public double? fmu_gug_tutar_5_7 { get; set; }

        public double? fmu_gug_tutar_5_8 { get; set; }

        public double? fmu_gug_tutar_5_9 { get; set; }

        public double? fmu_gug_tutar_5_10 { get; set; }

        public double? fmu_gug_tutar_5_11 { get; set; }

        public double? fmu_gug_tutar_5_12 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_1 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_2 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_3 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_4 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_5 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_6 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_7 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_8 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_9 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_10 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_11 { get; set; }

        public double? fmu_gug_ds_bekleyen_5_12 { get; set; }

        [StringLength(25)]
        public string fmu_gug_birikim_muhkodu_5 { get; set; }

        [StringLength(25)]
        public string fmu_dfgeneluretimyansitmamuhkodu1 { get; set; }

        [StringLength(25)]
        public string fmu_dfgeneluretimyansitmamuhkodu2 { get; set; }

        [StringLength(25)]
        public string fmu_dfgeneluretimyansitmamuhkodu3 { get; set; }

        [StringLength(25)]
        public string fmu_dfgeneluretimyansitmamuhkodu4 { get; set; }

        [StringLength(25)]
        public string fmu_dfgeneluretimyansitmamuhkodu5 { get; set; }

        [StringLength(25)]
        public string fmu_dfstokbirikimmuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfhizmetbirikimmuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfstokyansitmamuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfhizmetyansitmamuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfyarimamulbirikimmuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfyarimamulyansitmamuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfdirektiscilikyansitmamuhkodu1 { get; set; }

        [StringLength(25)]
        public string fmu_dfdirektiscilikyansitmamuhkodu2 { get; set; }

        [StringLength(25)]
        public string fmu_dfdirektiscilikyansitmamuhkodu3 { get; set; }

        [StringLength(25)]
        public string fmu_dfdirektiscilikyansitmamuhkodu4 { get; set; }

        [StringLength(25)]
        public string fmu_dfdirektiscilikyansitmamuhkodu5 { get; set; }

        [StringLength(25)]
        public string fmu_dfmakinemaliyetyansitmamuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfelemanmaliyetyansitmamuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_dfyarimamulmuhkodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_uretimmaliyetifarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_stokyansitmafarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_yarimamulyansitmafarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_hizmetyansitmafarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_elemanmaliyetyansitmafarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ufrs_makinemaliyetyansitmafarkikodu { get; set; }

        [StringLength(25)]
        public string fmu_ilkmadde_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmu_iscilik_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmu_geneluretim_gider_hesapkodu { get; set; }

        [StringLength(25)]
        public string fmu_hizmeturetim_gider_hesapkodu { get; set; }
    }
}
