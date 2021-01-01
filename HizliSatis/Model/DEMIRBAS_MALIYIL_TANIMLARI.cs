namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DEMIRBAS_MALIYIL_TANIMLARI
    {
        [Key]
        public int amy_RECno { get; set; }

        public short amy_RECid_DBCno { get; set; }

        public int amy_RECid_RECno { get; set; }

        public int? amy_SpecRECno { get; set; }

        public bool? amy_iptal { get; set; }

        public short? amy_fileid { get; set; }

        public bool? amy_hidden { get; set; }

        public bool? amy_kilitli { get; set; }

        public bool? amy_degisti { get; set; }

        public int? amy_checksum { get; set; }

        public short? amy_create_user { get; set; }

        public DateTime? amy_create_date { get; set; }

        public short? amy_lastup_user { get; set; }

        public DateTime? amy_lastup_date { get; set; }

        [StringLength(4)]
        public string amy_special1 { get; set; }

        [StringLength(4)]
        public string amy_special2 { get; set; }

        [StringLength(4)]
        public string amy_special3 { get; set; }

        [StringLength(25)]
        public string amy_kod { get; set; }

        public int? amy_maliyil { get; set; }

        public double? amy_dvr_birikmis_amortisman { get; set; }

        public double? amy_dvr_birikmis_amortisman_alt { get; set; }

        public double? amy_dvr_birikmis_amortisman_orj { get; set; }

        public double? amy_dvr_miktar { get; set; }

        public double? amy_dvr_bil_ak_dgr { get; set; }

        public double? amy_dvr_bil_ak_dgr_alt { get; set; }

        public double? amy_dvr_bil_ak_dgr_orj { get; set; }

        public double? amy_dvr_ydf { get; set; }

        public double? amy_dvr_ydf_alt { get; set; }

        public double? amy_dvr_ydf_orj { get; set; }

        public double? amy_dvr_sanal_brk_amortisman { get; set; }

        public double? amy_dvr_sanal_brk_amortisman_alt { get; set; }

        public double? amy_dvr_sanal_brk_amortisman_orj { get; set; }

        public double? amy_dvr_emlak_brk_amortisman { get; set; }

        public double? amy_dvr_emlak_brk_amortisman_alt { get; set; }

        public double? amy_dvr_emlak_brk_amortisman_orj { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl1 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl2 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl3 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl4 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl5 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl6 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl7 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl8 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl9 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl10 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl11 { get; set; }

        public bool? amy_yeniden_dgrlm_yok_fl12 { get; set; }

        public double? amy_satilan_miktar1 { get; set; }

        public double? amy_satilan_miktar2 { get; set; }

        public double? amy_satilan_miktar3 { get; set; }

        public double? amy_satilan_miktar4 { get; set; }

        public double? amy_satilan_miktar5 { get; set; }

        public double? amy_satilan_miktar6 { get; set; }

        public double? amy_satilan_miktar7 { get; set; }

        public double? amy_satilan_miktar8 { get; set; }

        public double? amy_satilan_miktar9 { get; set; }

        public double? amy_satilan_miktar10 { get; set; }

        public double? amy_satilan_miktar11 { get; set; }

        public double? amy_satilan_miktar12 { get; set; }

        public bool? amy_srmy_art1 { get; set; }

        public bool? amy_srmy_art2 { get; set; }

        public bool? amy_srmy_art3 { get; set; }

        public bool? amy_srmy_art4 { get; set; }

        public bool? amy_srmy_art5 { get; set; }

        public bool? amy_srmy_art6 { get; set; }

        public bool? amy_srmy_art7 { get; set; }

        public bool? amy_srmy_art8 { get; set; }

        public bool? amy_srmy_art9 { get; set; }

        public bool? amy_srmy_art10 { get; set; }

        public bool? amy_srmy_art11 { get; set; }

        public bool? amy_srmy_art12 { get; set; }

        public double? amy_dvr_birikmis_amortisman_ufrs { get; set; }

        public double? amy_dvr_birikmis_amortisman_alt_ufrs { get; set; }

        public double? amy_dvr_birikmis_amortisman_orj_ufrs { get; set; }

        public double? amy_dvr_bil_ak_dgr_ufrs { get; set; }

        public double? amy_dvr_bil_ak_dgr_alt_ufrs { get; set; }

        public double? amy_dvr_bil_ak_dgr_orj_ufrs { get; set; }

        public double? amy_dvr_sanal_brk_amortisman_ufrs { get; set; }

        public double? amy_dvr_sanal_brk_amortisman_alt_ufrs { get; set; }

        public double? amy_dvr_sanal_brk_amortisman_orj_ufrs { get; set; }

        public double? amy_dvr_emlak_brk_amortisman_ufrs { get; set; }

        public double? amy_dvr_emlak_brk_amortisman_alt_ufrs { get; set; }

        public double? amy_dvr_emlak_brk_amortisman_orj_ufrs { get; set; }
    }
}
