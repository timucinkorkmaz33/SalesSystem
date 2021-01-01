namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KALIP_APARAT_TANIMLARI
    {
        [Key]
        public int klp_RECno { get; set; }

        public short klp_RECid_DBCno { get; set; }

        public int klp_RECid_RECno { get; set; }

        public int? klp_SpecRECno { get; set; }

        public bool? klp_iptal { get; set; }

        public short? klp_fileid { get; set; }

        public bool? klp_hidden { get; set; }

        public bool? klp_kilitli { get; set; }

        public bool? klp_degisti { get; set; }

        public int? klp_checksum { get; set; }

        public short? klp_create_user { get; set; }

        public DateTime? klp_create_date { get; set; }

        public short? klp_lastup_user { get; set; }

        public DateTime? klp_lastup_date { get; set; }

        [StringLength(4)]
        public string klp_special1 { get; set; }

        [StringLength(4)]
        public string klp_special2 { get; set; }

        [StringLength(4)]
        public string klp_special3 { get; set; }

        [StringLength(25)]
        public string klp_kodu { get; set; }

        [StringLength(40)]
        public string klp_adi { get; set; }

        [StringLength(25)]
        public string klp_urunkodu { get; set; }

        public double? klp_uretim_miktari { get; set; }

        public bool? klp_aktif_fl { get; set; }

        [StringLength(4)]
        public string klp_calisma_takvimkodu { get; set; }

        public bool? klp_kurulum_vardiya_nosu1 { get; set; }

        public bool? klp_kurulum_vardiya_nosu2 { get; set; }

        public bool? klp_kurulum_vardiya_nosu3 { get; set; }

        public bool? klp_kurulum_vardiya_nosu4 { get; set; }

        public int? klp_kurulum_suresi { get; set; }

        [StringLength(25)]
        public string klp_kurulum_yetkilisi { get; set; }

        [StringLength(25)]
        public string klp_bakim_yetkilisi { get; set; }

        [StringLength(25)]
        public string klp_srmmrk_kodu { get; set; }

        [StringLength(25)]
        public string klp_master_kalip_kodu { get; set; }

        [StringLength(25)]
        public string klp_sabit_kiymet_kodu { get; set; }

        public short? klp_bakim_periyodu { get; set; }

        public DateTime? klp_son_bakim_tarihi { get; set; }

        public int? klp_renk { get; set; }

        public double? klp_yolluk_fire_katsayisi { get; set; }

        public short? klp_goz_sayisi { get; set; }

        [StringLength(25)]
        public string klp_imalatci_kodu { get; set; }

        public DateTime? klp_imal_tarihi { get; set; }

        public int? klp_en { get; set; }

        public int? klp_boy { get; set; }

        public int? klp_yukseklik { get; set; }

        public double? klp_agirlik { get; set; }
    }
}
