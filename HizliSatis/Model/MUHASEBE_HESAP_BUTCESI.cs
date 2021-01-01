namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_HESAP_BUTCESI
    {
        [Key]
        public int hesbut_RECno { get; set; }

        public short hesbut_RECid_DBCno { get; set; }

        public int hesbut_RECid_RECno { get; set; }

        public int? hesbut_SpecRECNo { get; set; }

        public bool? hesbut_iptal { get; set; }

        public short? hesbut_fileid { get; set; }

        public bool? hesbut_hidden { get; set; }

        public bool? hesbut_kilitli { get; set; }

        public bool? hesbut_degisti { get; set; }

        public int? hesbut_CheckSum { get; set; }

        public short? hesbut_create_user { get; set; }

        public DateTime? hesbut_create_date { get; set; }

        public short? hesbut_lastup_user { get; set; }

        public DateTime? hesbut_lastup_date { get; set; }

        [StringLength(4)]
        public string hesbut_special1 { get; set; }

        [StringLength(4)]
        public string hesbut_special2 { get; set; }

        [StringLength(4)]
        public string hesbut_special3 { get; set; }

        [StringLength(25)]
        public string hesbut_HesapKodu { get; set; }

        public int? hesbut_FirmaNo { get; set; }

        public int? hesbut_MaliYil { get; set; }

        public double? hesbut_Donemler1 { get; set; }

        public double? hesbut_Donemler1Grup1 { get; set; }

        public double? hesbut_Donemler1Grup2 { get; set; }

        public double? hesbut_Donemler1Grup3 { get; set; }

        public double? hesbut_Donemler1Grup4 { get; set; }

        public double? hesbut_Donemler1Grup5 { get; set; }

        public double? hesbut_Donemler1Grup6 { get; set; }

        public double? hesbut_Donemler2 { get; set; }

        public double? hesbut_Donemler2Grup1 { get; set; }

        public double? hesbut_Donemler2Grup2 { get; set; }

        public double? hesbut_Donemler2Grup3 { get; set; }

        public double? hesbut_Donemler2Grup4 { get; set; }

        public double? hesbut_Donemler2Grup5 { get; set; }

        public double? hesbut_Donemler2Grup6 { get; set; }

        public double? hesbut_Donemler3 { get; set; }

        public double? hesbut_Donemler3Grup1 { get; set; }

        public double? hesbut_Donemler3Grup2 { get; set; }

        public double? hesbut_Donemler3Grup3 { get; set; }

        public double? hesbut_Donemler3Grup4 { get; set; }

        public double? hesbut_Donemler3Grup5 { get; set; }

        public double? hesbut_Donemler3Grup6 { get; set; }

        public double? hesbut_Donemler4 { get; set; }

        public double? hesbut_Donemler4Grup1 { get; set; }

        public double? hesbut_Donemler4Grup2 { get; set; }

        public double? hesbut_Donemler4Grup3 { get; set; }

        public double? hesbut_Donemler4Grup4 { get; set; }

        public double? hesbut_Donemler4Grup5 { get; set; }

        public double? hesbut_Donemler4Grup6 { get; set; }

        public double? hesbut_Donemler5 { get; set; }

        public double? hesbut_Donemler5Grup1 { get; set; }

        public double? hesbut_Donemler5Grup2 { get; set; }

        public double? hesbut_Donemler5Grup3 { get; set; }

        public double? hesbut_Donemler5Grup4 { get; set; }

        public double? hesbut_Donemler5Grup5 { get; set; }

        public double? hesbut_Donemler5Grup6 { get; set; }

        public double? hesbut_Donemler6 { get; set; }

        public double? hesbut_Donemler6Grup1 { get; set; }

        public double? hesbut_Donemler6Grup2 { get; set; }

        public double? hesbut_Donemler6Grup3 { get; set; }

        public double? hesbut_Donemler6Grup4 { get; set; }

        public double? hesbut_Donemler6Grup5 { get; set; }

        public double? hesbut_Donemler6Grup6 { get; set; }

        public double? hesbut_Donemler7 { get; set; }

        public double? hesbut_Donemler7Grup1 { get; set; }

        public double? hesbut_Donemler7Grup2 { get; set; }

        public double? hesbut_Donemler7Grup3 { get; set; }

        public double? hesbut_Donemler7Grup4 { get; set; }

        public double? hesbut_Donemler7Grup5 { get; set; }

        public double? hesbut_Donemler7Grup6 { get; set; }

        public double? hesbut_Donemler8 { get; set; }

        public double? hesbut_Donemler8Grup1 { get; set; }

        public double? hesbut_Donemler8Grup2 { get; set; }

        public double? hesbut_Donemler8Grup3 { get; set; }

        public double? hesbut_Donemler8Grup4 { get; set; }

        public double? hesbut_Donemler8Grup5 { get; set; }

        public double? hesbut_Donemler8Grup6 { get; set; }

        public double? hesbut_Donemler9 { get; set; }

        public double? hesbut_Donemler9Grup1 { get; set; }

        public double? hesbut_Donemler9Grup2 { get; set; }

        public double? hesbut_Donemler9Grup3 { get; set; }

        public double? hesbut_Donemler9Grup4 { get; set; }

        public double? hesbut_Donemler9Grup5 { get; set; }

        public double? hesbut_Donemler9Grup6 { get; set; }

        public double? hesbut_Donemler10 { get; set; }

        public double? hesbut_Donemler10Grup1 { get; set; }

        public double? hesbut_Donemler10Grup2 { get; set; }

        public double? hesbut_Donemler10Grup3 { get; set; }

        public double? hesbut_Donemler10Grup4 { get; set; }

        public double? hesbut_Donemler10Grup5 { get; set; }

        public double? hesbut_Donemler10Grup6 { get; set; }

        public double? hesbut_Donemler11 { get; set; }

        public double? hesbut_Donemler11Grup1 { get; set; }

        public double? hesbut_Donemler11Grup2 { get; set; }

        public double? hesbut_Donemler11Grup3 { get; set; }

        public double? hesbut_Donemler11Grup4 { get; set; }

        public double? hesbut_Donemler11Grup5 { get; set; }

        public double? hesbut_Donemler11Grup6 { get; set; }

        public double? hesbut_Donemler12 { get; set; }

        public double? hesbut_Donemler12Grup1 { get; set; }

        public double? hesbut_Donemler12Grup2 { get; set; }

        public double? hesbut_Donemler12Grup3 { get; set; }

        public double? hesbut_Donemler12Grup4 { get; set; }

        public double? hesbut_Donemler12Grup5 { get; set; }

        public double? hesbut_Donemler12Grup6 { get; set; }

        [StringLength(25)]
        public string hesbut_Srmkodu { get; set; }

        [StringLength(25)]
        public string hesbut_projekodu { get; set; }
    }
}
