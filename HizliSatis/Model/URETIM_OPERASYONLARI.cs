namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYONLARI
    {
        [Key]
        public int Op_RECno { get; set; }

        public short Op_RECid_DBCno { get; set; }

        public int Op_RECid_RECno { get; set; }

        public int? Op_SpecRECNo { get; set; }

        public bool? Op_iptal { get; set; }

        public short? Op_fileid { get; set; }

        public bool? Op_hidden { get; set; }

        public bool? Op_kilitli { get; set; }

        public bool? Op_degisti { get; set; }

        public int? Op_CheckSum { get; set; }

        public short? Op_create_user { get; set; }

        public DateTime? Op_create_date { get; set; }

        public short? Op_lastup_user { get; set; }

        public DateTime? Op_lastup_date { get; set; }

        [StringLength(4)]
        public string Op_special1 { get; set; }

        [StringLength(4)]
        public string Op_special2 { get; set; }

        [StringLength(4)]
        public string Op_special3 { get; set; }

        [StringLength(25)]
        public string Op_Kodu { get; set; }

        [StringLength(50)]
        public string Op_Aciklama { get; set; }

        public byte? Op_Birimi { get; set; }

        public bool? Op_UrunGirisOlustur { get; set; }

        public bool? Op_UretimeSevkOlustur { get; set; }

        public double? Op_SabitMaliyet { get; set; }

        public double? Op_DegiskenMaliyet { get; set; }

        [StringLength(25)]
        public string Op_SorumlulukMerkezi { get; set; }

        public bool? Op_AraOperasyon { get; set; }

        public bool? Op_PlanlamaTarihiniEtkilemez { get; set; }

        public double? Op_IscilikMaliyet { get; set; }

        public double? Op_GenelUretimMaliyet { get; set; }

        public byte? Op_ZamanPlanlamasiYapilacak { get; set; }

        public bool? Op_MiktarSureyiEtkilemez { get; set; }
    }
}
