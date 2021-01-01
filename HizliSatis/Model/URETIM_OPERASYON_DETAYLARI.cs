namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYON_DETAYLARI
    {
        [Key]
        public int Opd_RECno { get; set; }

        public short Opd_RECid_DBCno { get; set; }

        public int Opd_RECid_RECno { get; set; }

        public int? Opd_SpecRECNo { get; set; }

        public bool? Opd_iptal { get; set; }

        public short? Opd_fileid { get; set; }

        public bool? Opd_hidden { get; set; }

        public bool? Opd_kilitli { get; set; }

        public bool? Opd_degisti { get; set; }

        public int? Opd_CheckSum { get; set; }

        public short? Opd_create_user { get; set; }

        public DateTime? Opd_create_date { get; set; }

        public short? Opd_lastup_user { get; set; }

        public DateTime? Opd_lastup_date { get; set; }

        [StringLength(4)]
        public string Opd_special1 { get; set; }

        [StringLength(4)]
        public string Opd_special2 { get; set; }

        [StringLength(4)]
        public string Opd_special3 { get; set; }

        [StringLength(25)]
        public string Opd_OpKodu { get; set; }

        public int? Opd_SatirNo { get; set; }

        public byte? Opd_Oncelik { get; set; }

        public double? Opd_Asgari_Miktar { get; set; }

        public double? Opd_Azami_Miktar { get; set; }

        public byte? Opd_ismerkezi_tipi { get; set; }

        [StringLength(25)]
        public string Opd_IsmerkeziorGrupKod { get; set; }

        public int? Opd_SabitHazirlikSuresi { get; set; }

        public int? Opd_OperasyonSuresi { get; set; }

        public double? Opd_UretimMiktari { get; set; }

        public int? Opd_SabitOperasyonSuresi { get; set; }

        [StringLength(25)]
        public string Opd_KalipKodu { get; set; }

        public double? Opd_HazirlikElemanIhtiyaci { get; set; }

        public double? Opd_OperasyonElemanIhtiyaci { get; set; }
    }
}
