namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_MALIYIL_ISLETME_TANIMLARI
    {
        [Key]
        public int fmit_RECno { get; set; }

        public short fmit_RECid_DBCno { get; set; }

        public int fmit_RECid_RECno { get; set; }

        public int? fmit_SpecRECno { get; set; }

        public bool? fmit_iptal { get; set; }

        public short? fmit_fileid { get; set; }

        public bool? fmit_hidden { get; set; }

        public bool? fmit_kilitli { get; set; }

        public bool? fmit_degisti { get; set; }

        public int? fmit_checksum { get; set; }

        public short? fmit_create_user { get; set; }

        public DateTime? fmit_create_date { get; set; }

        public short? fmit_lastup_user { get; set; }

        public DateTime? fmit_lastup_date { get; set; }

        [StringLength(4)]
        public string fmit_special1 { get; set; }

        [StringLength(4)]
        public string fmit_special2 { get; set; }

        [StringLength(4)]
        public string fmit_special3 { get; set; }

        public int? fmit_firmasirano { get; set; }

        public int? fmit_maliyil { get; set; }

        public double? fmit_isletme_devir_vergi { get; set; }

        public double? fmit_isletme_devir_atik_vergi { get; set; }

        public bool? fmit_isletme_atik_kdv_dokulmesin { get; set; }

        public double? fmit_isletme_asgarikarhaddi { get; set; }

        [StringLength(25)]
        public string fmit_amortisman_demirbas { get; set; }

        [StringLength(25)]
        public string fmit_amortisman_makine { get; set; }

        [StringLength(25)]
        public string fmit_brut_ucret_imalat { get; set; }

        [StringLength(25)]
        public string fmit_isveren_sgk_imalat { get; set; }

        [StringLength(25)]
        public string fmit_isveren_iss_imalat { get; set; }

        [StringLength(25)]
        public string fmit_brut_ucret_pazarlama { get; set; }

        [StringLength(25)]
        public string fmit_isveren_sgk_pazarlama { get; set; }

        [StringLength(25)]
        public string fmit_isveren_iss_pazarlama { get; set; }

        [StringLength(25)]
        public string fmit_brut_ucret_genel { get; set; }

        [StringLength(25)]
        public string fmit_isveren_sgk_genel { get; set; }

        [StringLength(25)]
        public string fmit_isveren_iss_genel { get; set; }

        [StringLength(25)]
        public string fmit_isveren_his_tesvik { get; set; }

        [StringLength(25)]
        public string fmit_demirbas_satis_kar { get; set; }

        [StringLength(25)]
        public string fmit_demirbas_satis_zarar { get; set; }

        [StringLength(25)]
        public string fmit_demirbas_satis_vergi { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_0 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_1 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_2 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_3 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_4 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_5 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_6 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_7 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_8 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_9 { get; set; }

        [StringLength(25)]
        public string fmit_stok_alis_10 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_0 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_1 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_2 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_3 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_4 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_5 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_6 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_7 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_8 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_9 { get; set; }

        [StringLength(25)]
        public string fmit_stok_satis_10 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_0 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_1 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_2 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_3 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_4 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_5 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_6 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_7 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_8 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_9 { get; set; }

        [StringLength(25)]
        public string fmit_masraf_alis_10 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_0 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_1 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_2 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_3 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_4 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_5 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_6 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_7 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_8 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_9 { get; set; }

        [StringLength(25)]
        public string fmit_hizmet_satis_10 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_0 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_1 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_2 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_3 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_4 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_5 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_6 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_7 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_8 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_9 { get; set; }

        [StringLength(25)]
        public string fmit_smm_alis_10 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_0 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_1 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_2 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_3 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_4 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_5 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_6 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_7 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_8 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_9 { get; set; }

        [StringLength(25)]
        public string fmit_smm_satis_10 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_0 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_1 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_2 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_3 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_4 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_5 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_6 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_7 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_8 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_9 { get; set; }

        [StringLength(25)]
        public string fmit_gider_makbuzu_10 { get; set; }
    }
}
