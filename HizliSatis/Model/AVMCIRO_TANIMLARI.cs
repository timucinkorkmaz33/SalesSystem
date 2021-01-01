namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMCIRO_TANIMLARI
    {
        [Key]
        public int Avmc_RECno { get; set; }

        public short Avmc_RECid_DBCno { get; set; }

        public int Avmc_RECid_RECno { get; set; }

        public int? Avmc_SpecRECno { get; set; }

        public bool? Avmc_iptal { get; set; }

        public short? Avmc_fileid { get; set; }

        public bool? Avmc_hidden { get; set; }

        public bool? Avmc_kilitli { get; set; }

        public bool? Avmc_degisti { get; set; }

        public int? Avmc_checksum { get; set; }

        public short? Avmc_create_user { get; set; }

        public DateTime? Avmc_create_date { get; set; }

        public short? Avmc_lastup_user { get; set; }

        public DateTime? Avmc_lastup_date { get; set; }

        [StringLength(4)]
        public string Avmc_special1 { get; set; }

        [StringLength(4)]
        public string Avmc_special2 { get; set; }

        [StringLength(4)]
        public string Avmc_special3 { get; set; }

        [StringLength(25)]
        public string Avmc_cirokira_kodu { get; set; }

        public byte? Avmc_cirobildirimperiyodu { get; set; }

        public byte? Avmc_cirodegperyodu { get; set; }

        public byte? Avmc_cirodegdvzkriteri { get; set; }

        public byte? Avmc_cirodvzdegerleme { get; set; }

        public short? Avmc_cirobildirimgecikmesuresi { get; set; }

        public short? Avmc_cirobildirimsuresi { get; set; }

        public short? Avmc_cirokiraodemevadesi { get; set; }

        public double? Avmc_cirokiraodemevadfyuz { get; set; }

        [StringLength(25)]
        public string Avmc_cirokirahizmetkodu { get; set; }

        public byte? Avmc_cirokiraodemecinsi { get; set; }

        public byte? Avmc_cirokiraodemegunu { get; set; }

        public byte? Avmc_cirokirasiperyodu { get; set; }

        public short? Avmc_cirokirasiperyodaraligi { get; set; }

        public byte? Avmc_CiroKirasiHesYontemi { get; set; }

        public double? Avmc_cirokirasiorani { get; set; }

        public double? Avmc_cirokirasiorani2 { get; set; }

        public double? Avmc_cirokirasiorani3 { get; set; }

        public DateTime? Avmc_cirokirasi1Bastar { get; set; }

        public DateTime? Avmc_cirokirasi1Bittar { get; set; }

        public double? Avmc_cirokirasi1Orani { get; set; }

        public double? Avmc_cirokirasi1Tavan11 { get; set; }

        public double? Avmc_cirokirasi1Tavan12 { get; set; }

        public double? Avmc_cirokirasi1Tavan13 { get; set; }

        public double? Avmc_cirokirasi1Carpani11 { get; set; }

        public double? Avmc_cirokirasi1Carpani12 { get; set; }

        public double? Avmc_cirokirasi1Carpani13 { get; set; }

        public bool? Avmc_cirokirasi1TavanAyriDeg_fl1 { get; set; }

        public double? Avmc_cirokirasi1Orani2 { get; set; }

        public double? Avmc_cirokirasi1Tavan21 { get; set; }

        public double? Avmc_cirokirasi1Tavan22 { get; set; }

        public double? Avmc_cirokirasi1Tavan213 { get; set; }

        public double? Avmc_cirokirasi1Carpani21 { get; set; }

        public double? Avmc_cirokirasi1Carpani22 { get; set; }

        public double? Avmc_cirokirasi1Carpani23 { get; set; }

        public bool? Avmc_cirokirasi1TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi1Orani3 { get; set; }

        public double? Avmc_cirokirasi1Tavan31 { get; set; }

        public double? Avmc_cirokirasi1Tavan32 { get; set; }

        public double? Avmc_cirokirasi1Tavan33 { get; set; }

        public double? Avmc_cirokirasi1Carpani31 { get; set; }

        public double? Avmc_cirokirasi1Carpani32 { get; set; }

        public double? Avmc_cirokirasi1Carpani33 { get; set; }

        public bool? Avmc_cirokirasi1TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi2Bastar { get; set; }

        public DateTime? Avmc_cirokirasi2Bittar { get; set; }

        public double? Avmc_cirokirasi2Orani { get; set; }

        public double? Avmc_cirokirasi2Tavan1 { get; set; }

        public double? Avmc_cirokirasi2Tavan2 { get; set; }

        public double? Avmc_cirokirasi2Tavan3 { get; set; }

        public double? Avmc_cirokirasi2Carpani1 { get; set; }

        public double? Avmc_cirokirasi2Carpani2 { get; set; }

        public double? Avmc_cirokirasi2Carpani3 { get; set; }

        public bool? Avmc_cirokirasi2TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi2Orani2 { get; set; }

        public double? Avmc_cirokirasi2Tavan21 { get; set; }

        public double? Avmc_cirokirasi2Tavan22 { get; set; }

        public double? Avmc_cirokirasi2Tavan213 { get; set; }

        public double? Avmc_cirokirasi2Carpani21 { get; set; }

        public double? Avmc_cirokirasi2Carpani22 { get; set; }

        public double? Avmc_cirokirasi2Carpani23 { get; set; }

        public bool? Avmc_cirokirasi2TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi2Orani3 { get; set; }

        public double? Avmc_cirokirasi2Tavan31 { get; set; }

        public double? Avmc_cirokirasi2Tavan32 { get; set; }

        public double? Avmc_cirokirasi2Tavan33 { get; set; }

        public double? Avmc_cirokirasi2Carpani31 { get; set; }

        public double? Avmc_cirokirasi2Carpani32 { get; set; }

        public double? Avmc_cirokirasi2Carpani33 { get; set; }

        public bool? Avmc_cirokirasi2TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi3Bastar { get; set; }

        public DateTime? Avmc_cirokirasi3Bittar { get; set; }

        public double? Avmc_cirokirasi3Orani { get; set; }

        public double? Avmc_cirokirasi3Tavan1 { get; set; }

        public double? Avmc_cirokirasi3Tavan2 { get; set; }

        public double? Avmc_cirokirasi3Tavan3 { get; set; }

        public double? Avmc_cirokirasi3Carpani1 { get; set; }

        public double? Avmc_cirokirasi3Carpani2 { get; set; }

        public double? Avmc_cirokirasi3Carpani3 { get; set; }

        public bool? Avmc_cirokirasi3TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi3Orani2 { get; set; }

        public double? Avmc_cirokirasi3Tavan21 { get; set; }

        public double? Avmc_cirokirasi3Tavan22 { get; set; }

        public double? Avmc_cirokirasi3Tavan23 { get; set; }

        public double? Avmc_cirokirasi3Carpani21 { get; set; }

        public double? Avmc_cirokirasi3Carpani22 { get; set; }

        public double? Avmc_cirokirasi3Carpani23 { get; set; }

        public bool? Avmc_cirokirasi3TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi3Orani3 { get; set; }

        public double? Avmc_cirokirasi3Tavan31 { get; set; }

        public double? Avmc_cirokirasi3Tavan32 { get; set; }

        public double? Avmc_cirokirasi3Tavan33 { get; set; }

        public double? Avmc_cirokirasi3Carpani31 { get; set; }

        public double? Avmc_cirokirasi3Carpani32 { get; set; }

        public double? Avmc_cirokirasi3Carpani33 { get; set; }

        public bool? Avmc_cirokirasi3TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi4Bastar { get; set; }

        public DateTime? Avmc_cirokirasi4Bittar { get; set; }

        public double? Avmc_cirokirasi4Orani { get; set; }

        public double? Avmc_cirokirasi4Tavan1 { get; set; }

        public double? Avmc_cirokirasi4Tavan2 { get; set; }

        public double? Avmc_cirokirasi4Tavan3 { get; set; }

        public double? Avmc_cirokirasi4Carpani1 { get; set; }

        public double? Avmc_cirokirasi4Carpani2 { get; set; }

        public double? Avmc_cirokirasi4Carpani3 { get; set; }

        public bool? Avmc_cirokirasi4TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi4Orani2 { get; set; }

        public double? Avmc_cirokirasi4Tavan21 { get; set; }

        public double? Avmc_cirokirasi4Tavan22 { get; set; }

        public double? Avmc_cirokirasi4Tavan213 { get; set; }

        public double? Avmc_cirokirasi4Carpani21 { get; set; }

        public double? Avmc_cirokirasi4Carpani22 { get; set; }

        public double? Avmc_cirokirasi4Carpani23 { get; set; }

        public bool? Avmc_cirokirasi4TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi4Orani3 { get; set; }

        public double? Avmc_cirokirasi4Tavan31 { get; set; }

        public double? Avmc_cirokirasi4Tavan32 { get; set; }

        public double? Avmc_cirokirasi4Tavan33 { get; set; }

        public double? Avmc_cirokirasi4Carpani31 { get; set; }

        public double? Avmc_cirokirasi4Carpani32 { get; set; }

        public double? Avmc_cirokirasi4Carpani33 { get; set; }

        public bool? Avmc_cirokirasi4TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi5Bastar { get; set; }

        public DateTime? Avmc_cirokirasi5Bittar { get; set; }

        public double? Avmc_cirokirasi5Orani { get; set; }

        public double? Avmc_cirokirasi5Tavan1 { get; set; }

        public double? Avmc_cirokirasi5Tavan2 { get; set; }

        public double? Avmc_cirokirasi5Tavan3 { get; set; }

        public double? Avmc_cirokirasi5Carpani1 { get; set; }

        public double? Avmc_cirokirasi5Carpani2 { get; set; }

        public double? Avmc_cirokirasi5Carpani3 { get; set; }

        public bool? Avmc_cirokirasi5TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi5Orani2 { get; set; }

        public double? Avmc_cirokirasi5Tavan21 { get; set; }

        public double? Avmc_cirokirasi5Tavan22 { get; set; }

        public double? Avmc_cirokirasi5Tavan213 { get; set; }

        public double? Avmc_cirokirasi5Carpani21 { get; set; }

        public double? Avmc_cirokirasi5Carpani22 { get; set; }

        public double? Avmc_cirokirasi5Carpani23 { get; set; }

        public bool? Avmc_cirokirasi5TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi5Orani3 { get; set; }

        public double? Avmc_cirokirasi5Tavan31 { get; set; }

        public double? Avmc_cirokirasi5Tavan32 { get; set; }

        public double? Avmc_cirokirasi5Tavan33 { get; set; }

        public double? Avmc_cirokirasi5Carpani31 { get; set; }

        public double? Avmc_cirokirasi5Carpani32 { get; set; }

        public double? Avmc_cirokirasi5Carpani33 { get; set; }

        public bool? Avmc_cirokirasi5TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi6Bastar { get; set; }

        public DateTime? Avmc_cirokirasi6Bittar { get; set; }

        public double? Avmc_cirokirasi6Orani { get; set; }

        public double? Avmc_cirokirasi6Tavan1 { get; set; }

        public double? Avmc_cirokirasi6Tavan2 { get; set; }

        public double? Avmc_cirokirasi6Tavan3 { get; set; }

        public double? Avmc_cirokirasi6Carpani1 { get; set; }

        public double? Avmc_cirokirasi6Carpani2 { get; set; }

        public double? Avmc_cirokirasi6Carpani3 { get; set; }

        public bool? Avmc_cirokirasi6TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi6Orani2 { get; set; }

        public double? Avmc_cirokirasi6Tavan21 { get; set; }

        public double? Avmc_cirokirasi6Tavan22 { get; set; }

        public double? Avmc_cirokirasi6Tavan213 { get; set; }

        public double? Avmc_cirokirasi6Carpani21 { get; set; }

        public double? Avmc_cirokirasi6Carpani22 { get; set; }

        public double? Avmc_cirokirasi6Carpani23 { get; set; }

        public bool? Avmc_cirokirasi6TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi6Orani3 { get; set; }

        public double? Avmc_cirokirasi6Tavan31 { get; set; }

        public double? Avmc_cirokirasi6Tavan32 { get; set; }

        public double? Avmc_cirokirasi6Tavan33 { get; set; }

        public double? Avmc_cirokirasi6Carpani31 { get; set; }

        public double? Avmc_cirokirasi6Carpani32 { get; set; }

        public double? Avmc_cirokirasi6Carpani33 { get; set; }

        public bool? Avmc_cirokirasi6TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi7Bastar { get; set; }

        public DateTime? Avmc_cirokirasi7Bittar { get; set; }

        public double? Avmc_cirokirasi7Orani { get; set; }

        public double? Avmc_cirokirasi7Tavan1 { get; set; }

        public double? Avmc_cirokirasi7Tavan2 { get; set; }

        public double? Avmc_cirokirasi7Tavan3 { get; set; }

        public double? Avmc_cirokirasi7Carpani1 { get; set; }

        public double? Avmc_cirokirasi7Carpani2 { get; set; }

        public double? Avmc_cirokirasi7Carpani3 { get; set; }

        public bool? Avmc_cirokirasi7TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi7Orani2 { get; set; }

        public double? Avmc_cirokirasi7Tavan21 { get; set; }

        public double? Avmc_cirokirasi7Tavan22 { get; set; }

        public double? Avmc_cirokirasi7Tavan213 { get; set; }

        public double? Avmc_cirokirasi7Carpani21 { get; set; }

        public double? Avmc_cirokirasi7Carpani22 { get; set; }

        public double? Avmc_cirokirasi7Carpani23 { get; set; }

        public bool? Avmc_cirokirasi7TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi7Orani3 { get; set; }

        public double? Avmc_cirokirasi7Tavan31 { get; set; }

        public double? Avmc_cirokirasi7Tavan32 { get; set; }

        public double? Avmc_cirokirasi7Tavan33 { get; set; }

        public double? Avmc_cirokirasi7Carpani31 { get; set; }

        public double? Avmc_cirokirasi7Carpani32 { get; set; }

        public double? Avmc_cirokirasi7Carpani33 { get; set; }

        public bool? Avmc_cirokirasi7TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi8Bastar { get; set; }

        public DateTime? Avmc_cirokirasi8Bittar { get; set; }

        public double? Avmc_cirokirasi8Orani { get; set; }

        public double? Avmc_cirokirasi8Tavan1 { get; set; }

        public double? Avmc_cirokirasi8Tavan2 { get; set; }

        public double? Avmc_cirokirasi8Tavan3 { get; set; }

        public double? Avmc_cirokirasi8Carpani1 { get; set; }

        public double? Avmc_cirokirasi8Carpani2 { get; set; }

        public double? Avmc_cirokirasi8Carpani3 { get; set; }

        public bool? Avmc_cirokirasi8TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi8Orani2 { get; set; }

        public double? Avmc_cirokirasi8Tavan21 { get; set; }

        public double? Avmc_cirokirasi8Tavan22 { get; set; }

        public double? Avmc_cirokirasi8Tavan213 { get; set; }

        public double? Avmc_cirokirasi8Carpani21 { get; set; }

        public double? Avmc_cirokirasi8Carpani22 { get; set; }

        public double? Avmc_cirokirasi8Carpani23 { get; set; }

        public bool? Avmc_cirokirasi8TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi8Orani3 { get; set; }

        public double? Avmc_cirokirasi8Tavan31 { get; set; }

        public double? Avmc_cirokirasi8Tavan32 { get; set; }

        public double? Avmc_cirokirasi8Tavan33 { get; set; }

        public double? Avmc_cirokirasi8Carpani31 { get; set; }

        public double? Avmc_cirokirasi8Carpani32 { get; set; }

        public double? Avmc_cirokirasi8Carpani33 { get; set; }

        public bool? Avmc_cirokirasi8TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi9Bastar { get; set; }

        public DateTime? Avmc_cirokirasi9Bittar { get; set; }

        public double? Avmc_cirokirasi9Orani { get; set; }

        public double? Avmc_cirokirasi9Tavan1 { get; set; }

        public double? Avmc_cirokirasi9Tavan2 { get; set; }

        public double? Avmc_cirokirasi9Tavan3 { get; set; }

        public double? Avmc_cirokirasi9Carpani1 { get; set; }

        public double? Avmc_cirokirasi9Carpani2 { get; set; }

        public double? Avmc_cirokirasi9Carpani3 { get; set; }

        public bool? Avmc_cirokirasi9TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi9Orani2 { get; set; }

        public double? Avmc_cirokirasi9Tavan21 { get; set; }

        public double? Avmc_cirokirasi9Tavan22 { get; set; }

        public double? Avmc_cirokirasi9Tavan213 { get; set; }

        public double? Avmc_cirokirasi9Carpani21 { get; set; }

        public double? Avmc_cirokirasi9Carpani22 { get; set; }

        public double? Avmc_cirokirasi9Carpani23 { get; set; }

        public bool? Avmc_cirokirasi9TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi9Orani3 { get; set; }

        public double? Avmc_cirokirasi9Tavan31 { get; set; }

        public double? Avmc_cirokirasi9Tavan32 { get; set; }

        public double? Avmc_cirokirasi9Tavan33 { get; set; }

        public double? Avmc_cirokirasi9Carpani31 { get; set; }

        public double? Avmc_cirokirasi9Carpani32 { get; set; }

        public double? Avmc_cirokirasi9Carpani33 { get; set; }

        public bool? Avmc_cirokirasi9TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi10Bastar { get; set; }

        public DateTime? Avmc_cirokirasi10Bittar { get; set; }

        public double? Avmc_cirokirasi10Orani { get; set; }

        public double? Avmc_cirokirasi10Tavan1 { get; set; }

        public double? Avmc_cirokirasi10Tavan2 { get; set; }

        public double? Avmc_cirokirasi10Tavan3 { get; set; }

        public double? Avmc_cirokirasi10Carpani1 { get; set; }

        public double? Avmc_cirokirasi10Carpani2 { get; set; }

        public double? Avmc_cirokirasi10Carpani3 { get; set; }

        public bool? Avmc_cirokirasi10TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi10Orani2 { get; set; }

        public double? Avmc_cirokirasi10Tavan21 { get; set; }

        public double? Avmc_cirokirasi10Tavan22 { get; set; }

        public double? Avmc_cirokirasi10Tavan213 { get; set; }

        public double? Avmc_cirokirasi10Carpani21 { get; set; }

        public double? Avmc_cirokirasi10Carpani22 { get; set; }

        public double? Avmc_cirokirasi10Carpani23 { get; set; }

        public bool? Avmc_cirokirasi10TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi10Orani3 { get; set; }

        public double? Avmc_cirokirasi10Tavan31 { get; set; }

        public double? Avmc_cirokirasi10Tavan32 { get; set; }

        public double? Avmc_cirokirasi10Tavan33 { get; set; }

        public double? Avmc_cirokirasi10Carpani31 { get; set; }

        public double? Avmc_cirokirasi10Carpani32 { get; set; }

        public double? Avmc_cirokirasi10Carpani33 { get; set; }

        public bool? Avmc_cirokirasi10TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi11Bastar { get; set; }

        public DateTime? Avmc_cirokirasi11Bittar { get; set; }

        public double? Avmc_cirokirasi11Orani { get; set; }

        public double? Avmc_cirokirasi11Tavan1 { get; set; }

        public double? Avmc_cirokirasi11Tavan2 { get; set; }

        public double? Avmc_cirokirasi11Tavan3 { get; set; }

        public double? Avmc_cirokirasi11Carpani1 { get; set; }

        public double? Avmc_cirokirasi11Carpani2 { get; set; }

        public double? Avmc_cirokirasi11Carpani3 { get; set; }

        public bool? Avmc_cirokirasi11TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi11Orani2 { get; set; }

        public double? Avmc_cirokirasi11Tavan21 { get; set; }

        public double? Avmc_cirokirasi11Tavan22 { get; set; }

        public double? Avmc_cirokirasi11Tavan213 { get; set; }

        public double? Avmc_cirokirasi11Carpani21 { get; set; }

        public double? Avmc_cirokirasi11Carpani22 { get; set; }

        public double? Avmc_cirokirasi11Carpani23 { get; set; }

        public bool? Avmc_cirokirasi11TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi11Orani3 { get; set; }

        public double? Avmc_cirokirasi11Tavan31 { get; set; }

        public double? Avmc_cirokirasi11Tavan32 { get; set; }

        public double? Avmc_cirokirasi11Tavan33 { get; set; }

        public double? Avmc_cirokirasi11Carpani31 { get; set; }

        public double? Avmc_cirokirasi11Carpani32 { get; set; }

        public double? Avmc_cirokirasi11Carpani33 { get; set; }

        public bool? Avmc_cirokirasi11TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi12Bastar { get; set; }

        public DateTime? Avmc_cirokirasi12Bittar { get; set; }

        public double? Avmc_cirokirasi12Orani { get; set; }

        public double? Avmc_cirokirasi12Tavan1 { get; set; }

        public double? Avmc_cirokirasi12Tavan2 { get; set; }

        public double? Avmc_cirokirasi12Tavan3 { get; set; }

        public double? Avmc_cirokirasi12Carpani1 { get; set; }

        public double? Avmc_cirokirasi12Carpani2 { get; set; }

        public double? Avmc_cirokirasi12Carpani3 { get; set; }

        public bool? Avmc_cirokirasi12TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi12Orani2 { get; set; }

        public double? Avmc_cirokirasi12Tavan21 { get; set; }

        public double? Avmc_cirokirasi12Tavan22 { get; set; }

        public double? Avmc_cirokirasi12Tavan213 { get; set; }

        public double? Avmc_cirokirasi12Carpani21 { get; set; }

        public double? Avmc_cirokirasi12Carpani22 { get; set; }

        public double? Avmc_cirokirasi12Carpani23 { get; set; }

        public bool? Avmc_cirokirasi12TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi12Orani3 { get; set; }

        public double? Avmc_cirokirasi12Tavan31 { get; set; }

        public double? Avmc_cirokirasi12Tavan32 { get; set; }

        public double? Avmc_cirokirasi12Tavan33 { get; set; }

        public double? Avmc_cirokirasi12Carpani31 { get; set; }

        public double? Avmc_cirokirasi12Carpani32 { get; set; }

        public double? Avmc_cirokirasi12Carpani33 { get; set; }

        public bool? Avmc_cirokirasi12TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi13Bastar { get; set; }

        public DateTime? Avmc_cirokirasi13Bittar { get; set; }

        public double? Avmc_cirokirasi13Orani { get; set; }

        public double? Avmc_cirokirasi13Tavan1 { get; set; }

        public double? Avmc_cirokirasi13Tavan2 { get; set; }

        public double? Avmc_cirokirasi13Tavan3 { get; set; }

        public double? Avmc_cirokirasi13Carpani1 { get; set; }

        public double? Avmc_cirokirasi13Carpani2 { get; set; }

        public double? Avmc_cirokirasi13Carpani3 { get; set; }

        public bool? Avmc_cirokirasi13TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi13Orani2 { get; set; }

        public double? Avmc_cirokirasi13Tavan21 { get; set; }

        public double? Avmc_cirokirasi13Tavan22 { get; set; }

        public double? Avmc_cirokirasi13Tavan213 { get; set; }

        public double? Avmc_cirokirasi13Carpani21 { get; set; }

        public double? Avmc_cirokirasi13Carpani22 { get; set; }

        public double? Avmc_cirokirasi13Carpani23 { get; set; }

        public bool? Avmc_cirokirasi13TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi13Orani3 { get; set; }

        public double? Avmc_cirokirasi13Tavan31 { get; set; }

        public double? Avmc_cirokirasi13Tavan32 { get; set; }

        public double? Avmc_cirokirasi13Tavan33 { get; set; }

        public double? Avmc_cirokirasi13Carpani31 { get; set; }

        public double? Avmc_cirokirasi13Carpani32 { get; set; }

        public double? Avmc_cirokirasi13Carpani33 { get; set; }

        public bool? Avmc_cirokirasi13TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi14Bastar { get; set; }

        public DateTime? Avmc_cirokirasi14Bittar { get; set; }

        public double? Avmc_cirokirasi14Orani { get; set; }

        public double? Avmc_cirokirasi14Tavan1 { get; set; }

        public double? Avmc_cirokirasi14Tavan2 { get; set; }

        public double? Avmc_cirokirasi14Tavan3 { get; set; }

        public double? Avmc_cirokirasi14Carpani1 { get; set; }

        public double? Avmc_cirokirasi14Carpani2 { get; set; }

        public double? Avmc_cirokirasi14Carpani3 { get; set; }

        public bool? Avmc_cirokirasi14TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi14Orani2 { get; set; }

        public double? Avmc_cirokirasi14Tavan21 { get; set; }

        public double? Avmc_cirokirasi14Tavan22 { get; set; }

        public double? Avmc_cirokirasi14Tavan213 { get; set; }

        public double? Avmc_cirokirasi14Carpani21 { get; set; }

        public double? Avmc_cirokirasi14Carpani22 { get; set; }

        public double? Avmc_cirokirasi14Carpani23 { get; set; }

        public bool? Avmc_cirokirasi14TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi14Orani3 { get; set; }

        public double? Avmc_cirokirasi14Tavan31 { get; set; }

        public double? Avmc_cirokirasi14Tavan32 { get; set; }

        public double? Avmc_cirokirasi14Tavan33 { get; set; }

        public double? Avmc_cirokirasi14Carpani31 { get; set; }

        public double? Avmc_cirokirasi14Carpani32 { get; set; }

        public double? Avmc_cirokirasi14Carpani33 { get; set; }

        public bool? Avmc_cirokirasi14TavanAyriDeg_fl3 { get; set; }

        public DateTime? Avmc_cirokirasi15Bastar { get; set; }

        public DateTime? Avmc_cirokirasi15Bittar { get; set; }

        public double? Avmc_cirokirasi15Orani { get; set; }

        public double? Avmc_cirokirasi15Tavan1 { get; set; }

        public double? Avmc_cirokirasi15Tavan2 { get; set; }

        public double? Avmc_cirokirasi15Tavan3 { get; set; }

        public double? Avmc_cirokirasi15Carpani1 { get; set; }

        public double? Avmc_cirokirasi15Carpani2 { get; set; }

        public double? Avmc_cirokirasi15Carpani3 { get; set; }

        public bool? Avmc_cirokirasi15TavanAyriDeg_fl { get; set; }

        public double? Avmc_cirokirasi15Orani2 { get; set; }

        public double? Avmc_cirokirasi15Tavan21 { get; set; }

        public double? Avmc_cirokirasi15Tavan22 { get; set; }

        public double? Avmc_cirokirasi15Tavan213 { get; set; }

        public double? Avmc_cirokirasi15Carpani21 { get; set; }

        public double? Avmc_cirokirasi15Carpani22 { get; set; }

        public double? Avmc_cirokirasi15Carpani23 { get; set; }

        public bool? Avmc_cirokirasi15TavanAyriDeg_fl2 { get; set; }

        public double? Avmc_cirokirasi15Orani3 { get; set; }

        public double? Avmc_cirokirasi15Tavan31 { get; set; }

        public double? Avmc_cirokirasi15Tavan32 { get; set; }

        public double? Avmc_cirokirasi15Tavan33 { get; set; }

        public double? Avmc_cirokirasi15Carpani31 { get; set; }

        public double? Avmc_cirokirasi15Carpani32 { get; set; }

        public double? Avmc_cirokirasi15Carpani33 { get; set; }

        public bool? Avmc_cirokirasi15TavanAyriDeg_fl3 { get; set; }
    }
}
