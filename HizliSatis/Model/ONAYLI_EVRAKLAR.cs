namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ONAYLI_EVRAKLAR
    {
        [Key]
        public int oe_RECno { get; set; }

        public short oe_RECid_DBCno { get; set; }

        public int oe_RECid_RECno { get; set; }

        public int? oe_SpecRECno { get; set; }

        public bool? oe_iptal { get; set; }

        public short? oe_fileid { get; set; }

        public bool? oe_hidden { get; set; }

        public bool? oe_kilitli { get; set; }

        public bool? oe_degisti { get; set; }

        public int? oe_checksum { get; set; }

        public short? oe_create_user { get; set; }

        public DateTime? oe_create_date { get; set; }

        public short? oe_lastup_user { get; set; }

        public DateTime? oe_lastup_date { get; set; }

        [StringLength(4)]
        public string oe_special1 { get; set; }

        [StringLength(4)]
        public string oe_special2 { get; set; }

        [StringLength(4)]
        public string oe_special3 { get; set; }

        public short? oe_tablo_no { get; set; }

        public int? oe_firma_no { get; set; }

        public byte? oe_evrak_tip { get; set; }

        public byte? oe_cins_tip { get; set; }

        [StringLength(6)]
        public string oe_evrak_seri { get; set; }

        public int? oe_evrak_sira { get; set; }

        [StringLength(25)]
        public string oe_evrak_kodu { get; set; }

        public int? oe_onaylayan_1 { get; set; }

        public DateTime? oe_onaylama_tarihi_1 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi1_1 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi2_1 { get; set; }

        public double? oe_kullanici_limiti_1 { get; set; }

        public byte? oe_kullanici_yetki_tipi_1 { get; set; }

        public double? oe_evrak_yekun_1 { get; set; }

        public int? oe_onaylayan_2 { get; set; }

        public DateTime? oe_onaylama_tarihi_2 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi1_2 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi2_2 { get; set; }

        public double? oe_kullanici_limiti_2 { get; set; }

        public byte? oe_kullanici_yetki_tipi_2 { get; set; }

        public double? oe_evrak_yekun_2 { get; set; }

        public int? oe_onaylayan_3 { get; set; }

        public DateTime? oe_onaylama_tarihi_3 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi1_3 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi2_3 { get; set; }

        public double? oe_kullanici_limiti_3 { get; set; }

        public byte? oe_kullanici_yetki_tipi_3 { get; set; }

        public double? oe_evrak_yekun_3 { get; set; }

        public int? oe_onaylayan_4 { get; set; }

        public DateTime? oe_onaylama_tarihi_4 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi1_4 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi2_4 { get; set; }

        public double? oe_kullanici_limiti_4 { get; set; }

        public byte? oe_kullanici_yetki_tipi_4 { get; set; }

        public double? oe_evrak_yekun_4 { get; set; }

        public int? oe_onaylayan_5 { get; set; }

        public DateTime? oe_onaylama_tarihi_5 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi1_5 { get; set; }

        [StringLength(127)]
        public string oe_onay_aciklamasi2_5 { get; set; }

        public double? oe_kullanici_limiti_5 { get; set; }

        public byte? oe_kullanici_yetki_tipi_5 { get; set; }

        public double? oe_evrak_yekun_5 { get; set; }

        public bool? oe_onay_tamamlandi_fl { get; set; }

        public short? oe_kaynak_dbcno { get; set; }

        public int? oe_kaynak_recno { get; set; }
    }
}
