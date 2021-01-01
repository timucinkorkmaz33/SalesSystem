namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_ROTALARI
    {
        [Key]
        public int URt_RECno { get; set; }

        public short URt_RECid_DBCno { get; set; }

        public int URt_RECid_RECno { get; set; }

        public int? URt_SpecRECNo { get; set; }

        public bool? URt_iptal { get; set; }

        public short? URt_fileid { get; set; }

        public bool? URt_hidden { get; set; }

        public bool? URt_kilitli { get; set; }

        public bool? URt_degisti { get; set; }

        public int? URt_CheckSum { get; set; }

        public short? URt_create_user { get; set; }

        public DateTime? URt_create_date { get; set; }

        public short? URt_lastup_user { get; set; }

        public DateTime? URt_lastup_date { get; set; }

        [StringLength(4)]
        public string URt_special1 { get; set; }

        [StringLength(4)]
        public string URt_special2 { get; set; }

        [StringLength(4)]
        public string URt_special3 { get; set; }

        [StringLength(25)]
        public string URt_RotaUrunKodu { get; set; }

        public byte? URt_cinsi { get; set; }

        public int? URt_SatirNo { get; set; }

        public short? URt_ID { get; set; }

        public short? URt_BagliRotaID { get; set; }

        [StringLength(25)]
        public string URt_OpKod { get; set; }

        public byte? URt_RotaIsMerkeziveSureTespitTipi { get; set; }

        public byte? URt_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string URt_IsmerkeziveyaGrupKod { get; set; }

        public int? URt_SabitHazirlikSuresi { get; set; }

        public int? URt_DegiskenOperasyonSuresi { get; set; }

        public double? URt_UretimMiktari { get; set; }

        public int? URt_SabitOperasyonSuresi { get; set; }

        public double? URt_CikisPartiMiktari { get; set; }

        public double? URt_OperasyonSureCarpani { get; set; }

        public byte? URt_OperasyonTekrarSayisi { get; set; }

        public double? URt_Enerji1_miktari { get; set; }

        public double? URt_Enerji2_miktari { get; set; }

        [StringLength(80)]
        public string URt_Aciklama { get; set; }

        public short? URt_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string URt_KalipKodu { get; set; }

        public double? URt_HazirlikElemanIhtiyaci { get; set; }

        public double? URt_OperasyonElemanIhtiyaci { get; set; }
    }
}
