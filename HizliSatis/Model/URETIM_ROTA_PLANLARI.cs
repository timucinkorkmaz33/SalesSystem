namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_ROTA_PLANLARI
    {
        [Key]
        public int RtP_RECno { get; set; }

        public short RtP_RECid_DBCno { get; set; }

        public int RtP_RECid_RECno { get; set; }

        public int? RtP_SpecRECNo { get; set; }

        public bool? RtP_iptal { get; set; }

        public short? RtP_fileid { get; set; }

        public bool? RtP_hidden { get; set; }

        public bool? RtP_kilitli { get; set; }

        public bool? RtP_degisti { get; set; }

        public int? RtP_CheckSum { get; set; }

        public short? RtP_create_user { get; set; }

        public DateTime? RtP_create_date { get; set; }

        public short? RtP_lastup_user { get; set; }

        public DateTime? RtP_lastup_date { get; set; }

        [StringLength(4)]
        public string RtP_special1 { get; set; }

        [StringLength(4)]
        public string RtP_special2 { get; set; }

        [StringLength(4)]
        public string RtP_special3 { get; set; }

        [StringLength(25)]
        public string RtP_IsEmriKodu { get; set; }

        public int? RtP_SatirNo { get; set; }

        [StringLength(25)]
        public string RtP_UrunKodu { get; set; }

        public short? RtP_OperasyonSafhaNo { get; set; }

        [StringLength(25)]
        public string RtP_OperasyonKodu { get; set; }

        public int? RtP_PlanlananSure { get; set; }

        public int? RtP_TamamlananSure { get; set; }

        public double? RtP_PlanlananMiktar { get; set; }

        public double? RtP_TamamlananMiktar { get; set; }

        public DateTime? Rtp_PlanlananBaslamaTarihi { get; set; }

        [StringLength(25)]
        public string RtP_PlanlananIsMerkezi { get; set; }

        public int? RtP_OperasyonDetayPtr { get; set; }

        public double? RtP_BozukMiktar { get; set; }

        public short? RtP_SonrakiSafhaNo { get; set; }

        public int? RtP_PlanlananSetupSuresi { get; set; }

        public int? RtP_TamamlananSetupSuresi { get; set; }

        public bool? RtP_Kapandi_fl { get; set; }

        [StringLength(80)]
        public string RtP_Aciklama { get; set; }

        public double? RtP_PlanlananEnerji1 { get; set; }

        public double? RtP_TuketilenEnerji1 { get; set; }

        public double? RtP_PlanlananEnerji2 { get; set; }

        public double? RtP_TuketilenEnerji2 { get; set; }

        public double? Rtp_CikisPartiMiktari { get; set; }

        public short? Rtp_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string Rtp_PlanlananKalipKodu { get; set; }

        public double? Rtp_PlanlananHazirlikElemanIhtiyaci { get; set; }

        public double? Rtp_PlanlananOperasyonElemanIhtiyaci { get; set; }

        public bool? Rtp_Kilitli_fl { get; set; }

        public bool? Rtp_Is_Zamani_Belirli_fl { get; set; }

        public bool? RtP_Basladi_fl { get; set; }

        public bool? RtP_Setup_Bitti_fl { get; set; }

        public bool? RtP_Bitti_fl { get; set; }

        public DateTime? Rtp_PlanlananBitisTarihi { get; set; }
    }
}
