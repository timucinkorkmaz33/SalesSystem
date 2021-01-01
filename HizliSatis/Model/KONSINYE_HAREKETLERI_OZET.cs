namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KONSINYE_HAREKETLERI_OZET
    {
        [Key]
        public int kho_RECno { get; set; }

        public int? kho_firmano { get; set; }

        public int? kho_subeno { get; set; }

        [StringLength(25)]
        public string kho_StokKodu { get; set; }

        [StringLength(25)]
        public string kho_SrmMerkezi { get; set; }

        [StringLength(25)]
        public string kho_ProjeKodu { get; set; }

        public int? kho_Depo { get; set; }

        public int? kho_MaliYil { get; set; }

        public byte? kho_Donem { get; set; }

        public byte? kho_HareketCins { get; set; }

        public double? kho_GirisNormal { get; set; }

        public double? kho_GirisIade { get; set; }

        public double? kho_CikisNormal { get; set; }

        public double? kho_CikisIade { get; set; }

        public double? kho_GirisNormal_2 { get; set; }

        public double? kho_GirisIade_2 { get; set; }

        public double? kho_CikisNormal_2 { get; set; }

        public double? kho_CikisIade_2 { get; set; }

        public double? kho_Belge_Ana_Giris { get; set; }

        public double? kho_Belge_Ana_GirisIade { get; set; }

        public double? kho_Belge_Ana_Cikis { get; set; }

        public double? kho_Belge_Ana_CikisIade { get; set; }

        public double? kho_Belge_Alt_Giris { get; set; }

        public double? kho_Belge_Alt_GirisIade { get; set; }

        public double? kho_Belge_Alt_Cikis { get; set; }

        public double? kho_Belge_Alt_CikisIade { get; set; }

        public double? kho_Belge_Orj_Giris { get; set; }

        public double? kho_Belge_Orj_GirisIade { get; set; }

        public double? kho_Belge_Orj_Cikis { get; set; }

        public double? kho_Belge_Orj_CikisIade { get; set; }

        public double? kho_FaturalananGirisNormal { get; set; }

        public double? kho_FaturalananGirisIade { get; set; }

        public double? kho_FaturalananCikisNormal { get; set; }

        public double? kho_FaturalananCikisIade { get; set; }

        public double? kho_Faturalanan_Belge_Ana_Giris { get; set; }

        public double? kho_Faturalanan_Belge_Ana_GirisIade { get; set; }

        public double? kho_Faturalanan_Belge_Ana_Cikis { get; set; }

        public double? kho_Faturalanan_Belge_Ana_CikisIade { get; set; }

        public double? kho_Faturalanan_Belge_Alt_Giris { get; set; }

        public double? kho_Faturalanan_Belge_Alt_GirisIade { get; set; }

        public double? kho_Faturalanan_Belge_Alt_Cikis { get; set; }

        public double? kho_Faturalanan_Belge_Alt_CikisIade { get; set; }

        public double? kho_Faturalanan_Belge_Orj_Giris { get; set; }

        public double? kho_Faturalanan_Belge_Orj_GirisIade { get; set; }

        public double? kho_Faturalanan_Belge_Orj_Cikis { get; set; }

        public double? kho_Faturalanan_Belge_Orj_CikisIade { get; set; }

        public double? kho_IslemGorenGirisNormal { get; set; }

        public double? kho_IslemGorenGirisIade { get; set; }

        public double? kho_IslemGorenCikisNormal { get; set; }

        public double? kho_IslemGorenCikisIade { get; set; }

        public double? kho_IslemGorenGirisNormal_2 { get; set; }

        public double? kho_IslemGorenGirisIade_2 { get; set; }

        public double? kho_IslemGorenCikisNormal_2 { get; set; }

        public double? kho_IslemGorenCikisIade_2 { get; set; }
    }
}
