namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_HAREKETLERI_OZET
    {
        [Key]
        public int cho_RECno { get; set; }

        public int? cho_firmano { get; set; }

        public int? cho_subeno { get; set; }

        public byte? cho_Cinsi { get; set; }

        [StringLength(25)]
        public string cho_CariKodu { get; set; }

        [StringLength(25)]
        public string cho_ProjeKodu { get; set; }

        [StringLength(25)]
        public string cho_SrmMerkezi { get; set; }

        public byte? cho_GrupNo { get; set; }

        public int? cho_MaliYil { get; set; }

        public byte? cho_Donem { get; set; }

        public byte? cho_HareketCins { get; set; }

        public double? cho_Ana_Borc { get; set; }

        public double? cho_Ana_Alacak { get; set; }

        public double? cho_Alt_Borc { get; set; }

        public double? cho_Alt_Alacak { get; set; }

        public double? cho_Orj_Borc { get; set; }

        public double? cho_Orj_Alacak { get; set; }
    }
}
