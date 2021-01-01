namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BUTCE_DETAY
    {
        [Key]
        public int bd_RECno { get; set; }

        public short bd_RECid_DBCno { get; set; }

        public int bd_RECid_RECno { get; set; }

        public int? bd_SpecRECno { get; set; }

        public bool? bd_iptal { get; set; }

        public short? bd_fileid { get; set; }

        public bool? bd_hidden { get; set; }

        public bool? bd_kilitli { get; set; }

        public bool? bd_degisti { get; set; }

        public int? bd_checksum { get; set; }

        public short? bd_create_user { get; set; }

        public DateTime? bd_create_date { get; set; }

        public short? bd_lastup_user { get; set; }

        public DateTime? bd_lastup_date { get; set; }

        [StringLength(4)]
        public string bd_special1 { get; set; }

        [StringLength(4)]
        public string bd_special2 { get; set; }

        [StringLength(4)]
        public string bd_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string bd_butcekodu { get; set; }

        public byte? bd_stok_hizmet { get; set; }

        [StringLength(25)]
        public string bd_sh_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_masraf_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_cari_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_sorumlu_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_depo_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_sormrk_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_proje_detay_kodu { get; set; }

        [StringLength(25)]
        public string bd_donem { get; set; }

        public double? bd_deger_hedef1 { get; set; }

        public double? bd_deger_durum1 { get; set; }

        public double? bd_deger_hedef2 { get; set; }

        public double? bd_deger_durum2 { get; set; }

        public double? bd_deger_hedef3 { get; set; }

        public double? bd_deger_durum3 { get; set; }

        public double? bd_deger_hedef4 { get; set; }

        public double? bd_deger_durum4 { get; set; }

        public double? bd_deger_hedef5 { get; set; }

        public double? bd_deger_durum5 { get; set; }
    }
}
