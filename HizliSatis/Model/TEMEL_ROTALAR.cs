namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMEL_ROTALAR
    {
        [Key]
        public int Rt_RECno { get; set; }

        public short Rt_RECid_DBCno { get; set; }

        public int Rt_RECid_RECno { get; set; }

        public int? Rt_SpecRECNo { get; set; }

        public bool? Rt_iptal { get; set; }

        public short? Rt_fileid { get; set; }

        public bool? Rt_hidden { get; set; }

        public bool? Rt_kilitli { get; set; }

        public bool? Rt_degisti { get; set; }

        public int? Rt_CheckSum { get; set; }

        public short? Rt_create_user { get; set; }

        public DateTime? Rt_create_date { get; set; }

        public short? Rt_lastup_user { get; set; }

        public DateTime? Rt_lastup_date { get; set; }

        [StringLength(4)]
        public string Rt_special1 { get; set; }

        [StringLength(4)]
        public string Rt_special2 { get; set; }

        [StringLength(4)]
        public string Rt_special3 { get; set; }

        [StringLength(25)]
        public string Rt_RotaUrunKodu { get; set; }

        [StringLength(50)]
        public string Rt_UstAciklama { get; set; }

        public int? Rt_SatirNo { get; set; }

        public short? Rt_ID { get; set; }

        public short? Rt_BagliRotaID { get; set; }

        [StringLength(25)]
        public string Rt_OpKod { get; set; }

        public byte? Rt_RotaIsMerkeziveSureTespitTipi { get; set; }

        public byte? Rt_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string Rt_IsmerkeziveyaGrupKod { get; set; }

        public int? Rt_SabitHazirlikSuresi { get; set; }

        public int? Rt_DegiskenOperasyonSuresi { get; set; }

        public double? Rt_UretimMiktari { get; set; }

        public int? Rt_SabitOperasyonSuresi { get; set; }

        public double? Rt_CikisPartiMiktari { get; set; }

        public double? Rt_OperasyonSureCarpani { get; set; }

        public byte? Rt_OperasyonTekrarSayisi { get; set; }

        public double? Rt_Enerji1_Miktari { get; set; }

        public double? Rt_Enerji2_Miktari { get; set; }

        [StringLength(80)]
        public string Rt_Aciklama { get; set; }

        public short? Rt_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string Rt_KalipKodu { get; set; }

        public double? Rt_HazirlikElemanIhtiyaci { get; set; }

        public double? Rt_OperasyonElemanIhtiyaci { get; set; }
    }
}
