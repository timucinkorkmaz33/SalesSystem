namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URUN_ROTA_DETAYLARI
    {
        [Key]
        public int urd_RECno { get; set; }

        public short urd_RECid_DBCno { get; set; }

        public int urd_RECid_RECno { get; set; }

        public int? urd_SpecRECNo { get; set; }

        public bool? urd_iptal { get; set; }

        public short? urd_fileid { get; set; }

        public bool? urd_hidden { get; set; }

        public bool? urd_kilitli { get; set; }

        public bool? urd_degisti { get; set; }

        public int? urd_CheckSum { get; set; }

        public short? urd_create_user { get; set; }

        public DateTime? urd_create_date { get; set; }

        public short? urd_lastup_user { get; set; }

        public DateTime? urd_lastup_date { get; set; }

        [StringLength(4)]
        public string urd_special1 { get; set; }

        [StringLength(4)]
        public string urd_special2 { get; set; }

        [StringLength(4)]
        public string urd_special3 { get; set; }

        public short? urd_BagliRota_RECid_DBCno { get; set; }

        public int? urd_BagliRota_RECid_RECno { get; set; }

        public int? urd_DetaySatirNo { get; set; }

        public byte? urd_KriterDegeri1 { get; set; }

        public double? urd_MaxDeger1 { get; set; }

        public double? urd_MinDeger1 { get; set; }

        public byte? urd_KriterDegeri2 { get; set; }

        public double? urd_MaxDeger2 { get; set; }

        public double? urd_MinDeger2 { get; set; }

        public byte? urd_KriterDegeri3 { get; set; }

        public double? urd_MaxDeger3 { get; set; }

        public double? urd_MinDeger3 { get; set; }

        public byte? urd_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string urd_IsmerkeziveyaGrupKod { get; set; }

        public int? urd_SabitHazirlikSuresi { get; set; }

        public int? urd_DegiskenOperasyonSuresi { get; set; }

        public int? urd_SabitOperasyonSuresi { get; set; }

        public double? urd_UretimMiktari { get; set; }

        public double? urd_CikisPartiMiktari { get; set; }

        public double? urd_Enerji1_miktari { get; set; }

        public double? urd_Enerji2_miktari { get; set; }

        [StringLength(80)]
        public string urd_Aciklama { get; set; }

        public short? urd_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string urd_KalipKodu { get; set; }

        public double? urd_HazirlikElemanIhtiyaci { get; set; }

        public double? urd_OperasyonElemanIhtiyaci { get; set; }
    }
}
