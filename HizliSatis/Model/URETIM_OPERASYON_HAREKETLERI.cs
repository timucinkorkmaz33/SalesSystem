namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYON_HAREKETLERI
    {
        [Key]
        public int OpT_RECno { get; set; }

        public short OpT_RECid_DBCno { get; set; }

        public int OpT_RECid_RECno { get; set; }

        public int? OpT_SpecRECNo { get; set; }

        public bool? OpT_iptal { get; set; }

        public short? OpT_fileid { get; set; }

        public bool? OpT_hidden { get; set; }

        public bool? OpT_kilitli { get; set; }

        public bool? OpT_degisti { get; set; }

        public int? OpT_CheckSum { get; set; }

        public short? OpT_create_user { get; set; }

        public DateTime? OpT_create_date { get; set; }

        public short? OpT_lastup_user { get; set; }

        public DateTime? OpT_lastup_date { get; set; }

        [StringLength(4)]
        public string OpT_special1 { get; set; }

        [StringLength(4)]
        public string OpT_special2 { get; set; }

        [StringLength(4)]
        public string OpT_special3 { get; set; }

        public int? OpT_firmano { get; set; }

        public int? OpT_subeno { get; set; }

        [StringLength(6)]
        public string OpT_EvrakNoSeri { get; set; }

        public int? OpT_EvrakNoSira { get; set; }

        public int? OpT_EvrakSatirNo { get; set; }

        public short? OpT_RotaPlanRecID_DBCno { get; set; }

        public int? OpT_RotaPlanRecID_RECno { get; set; }

        public DateTime? OpT_baslamatarihi { get; set; }

        public DateTime? OpT_bitis_tarihi { get; set; }

        [StringLength(25)]
        public string OpT_IsEmriKodu { get; set; }

        [StringLength(25)]
        public string OpT_UrunKodu { get; set; }

        public short? OpT_OperasyonSafhaNo { get; set; }

        [StringLength(25)]
        public string OpT_OperasyonKodu { get; set; }

        public short? Opt_SonrakiSafhaNo { get; set; }

        [StringLength(25)]
        public string OpT_ismerkezi { get; set; }

        public double? OpT_ismerkezi_hizi { get; set; }

        [StringLength(25)]
        public string OpT_PersonelKodu { get; set; }

        public double? OpT_TamamlananMiktar { get; set; }

        public double? Opt_TamamlananMiktar2 { get; set; }

        public double? Opt_TamamlananMiktar3 { get; set; }

        public double? Opt_TamamlananMiktar4 { get; set; }

        public double? Opt_BozukMiktar { get; set; }

        public double? Opt_BozukMiktar2 { get; set; }

        public double? Opt_BozukMiktar3 { get; set; }

        public double? Opt_BozukMiktar4 { get; set; }

        public int? Opt_SetupSuresi { get; set; }

        public int? OpT_TamamlananSure { get; set; }

        public int? Opt_Gecikme_suresi { get; set; }

        public double? Opt_iscilik_Maliyet_ana { get; set; }

        public double? Opt_iscilik_Maliyet_Alt { get; set; }

        public double? Opt_iscilik_Maliyet_Orj { get; set; }

        public double? Opt_Genel_uretim_Maliyet_ana { get; set; }

        public double? Opt_Genel_uretim_Maliyet_Alt { get; set; }

        public double? Opt_Genel_uretim_Maliyet_Orj { get; set; }

        public bool? Opt_Kapat_fl { get; set; }

        public double? Opt_calisan_adam { get; set; }

        public double? Opt_islenen_alan { get; set; }

        public double? Opt_islenen_hacim { get; set; }

        public double? Opt_islenen_agirlik { get; set; }

        public double? Opt_tuketilen_enerji1 { get; set; }

        public double? Opt_tuketilen_enerji2 { get; set; }

        [StringLength(80)]
        public string Opt_aciklama { get; set; }

        public double? Opt_ufrs_iscilik_maliyet_ana { get; set; }

        public double? Opt_ufrs_iscilik_maliyet_alt { get; set; }

        public double? Opt_ufrs_iscilik_maliyet_orj { get; set; }

        public double? Opt_ufrs_genel_uretim_maliyet_ana { get; set; }

        public double? Opt_ufrs_genel_uretim_maliyet_alt { get; set; }

        public double? Opt_ufrs_genel_uretim_maliyet_orj { get; set; }

        [StringLength(25)]
        public string Opt_kalipkodu { get; set; }

        public double? Opt_HazirlikElemanSayisi { get; set; }

        public double? Opt_OperasyonElemanSayisi { get; set; }
    }
}
