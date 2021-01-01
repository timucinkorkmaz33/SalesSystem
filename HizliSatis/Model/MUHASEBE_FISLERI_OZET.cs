namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_FISLERI_OZET
    {
        [Key]
        public int mfo_RECno { get; set; }

        public int? mfo_firmano { get; set; }

        public int? mfo_subeno { get; set; }

        [StringLength(25)]
        public string mfo_HesapKodu { get; set; }

        public byte? mfo_FisTuru { get; set; }

        [StringLength(25)]
        public string mfo_ProjeKodu { get; set; }

        [StringLength(25)]
        public string mfo_SrmMerkezi { get; set; }

        public int? mfo_MaliYil { get; set; }

        public byte? mfo_Donem { get; set; }

        public double? mfo_Grp0_B_Meblag { get; set; }

        public double? mfo_Grp1_B_Meblag { get; set; }

        public double? mfo_Grp2_B_Meblag { get; set; }

        public double? mfo_Grp3_B_Meblag { get; set; }

        public double? mfo_Grp4_B_Meblag { get; set; }

        public double? mfo_Grp5_B_Meblag { get; set; }

        public double? mfo_Grp6_B_Meblag { get; set; }

        public double? mfo_Grp0_A_Meblag { get; set; }

        public double? mfo_Grp1_A_Meblag { get; set; }

        public double? mfo_Grp2_A_Meblag { get; set; }

        public double? mfo_Grp3_A_Meblag { get; set; }

        public double? mfo_Grp4_A_Meblag { get; set; }

        public double? mfo_Grp5_A_Meblag { get; set; }

        public double? mfo_Grp6_A_Meblag { get; set; }

        public double? mfo_Grp0_B_PasifMeblag { get; set; }

        public double? mfo_Grp1_B_PasifMeblag { get; set; }

        public double? mfo_Grp2_B_PasifMeblag { get; set; }

        public double? mfo_Grp3_B_PasifMeblag { get; set; }

        public double? mfo_Grp4_B_PasifMeblag { get; set; }

        public double? mfo_Grp5_B_PasifMeblag { get; set; }

        public double? mfo_Grp6_B_PasifMeblag { get; set; }

        public double? mfo_Grp0_A_PasifMeblag { get; set; }

        public double? mfo_Grp1_A_PasifMeblag { get; set; }

        public double? mfo_Grp2_A_PasifMeblag { get; set; }

        public double? mfo_Grp3_A_PasifMeblag { get; set; }

        public double? mfo_Grp4_A_PasifMeblag { get; set; }

        public double? mfo_Grp5_A_PasifMeblag { get; set; }

        public double? mfo_Grp6_A_PasifMeblag { get; set; }
    }
}
