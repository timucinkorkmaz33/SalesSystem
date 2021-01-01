namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIPARISLER_OZET
    {
        [Key]
        public int so_RECno { get; set; }

        public int? so_firmano { get; set; }

        public int? so_subeno { get; set; }

        public byte? so_Tipi { get; set; }

        [StringLength(25)]
        public string so_Kodu { get; set; }

        [StringLength(25)]
        public string so_SrmMerkezi { get; set; }

        [StringLength(25)]
        public string so_ProjeKodu { get; set; }

        public int? so_Depo { get; set; }

        public int? so_MaliYil { get; set; }

        public byte? so_Donem { get; set; }

        public byte? so_HareketCins { get; set; }

        public double? so_TalepMiktar { get; set; }

        public double? so_TalepKarsilanan { get; set; }

        public double? so_TalepKapanan { get; set; }

        public double? so_TeminMiktar { get; set; }

        public double? so_TeminKarsilanan { get; set; }

        public double? so_TeminKapanan { get; set; }
    }
}
