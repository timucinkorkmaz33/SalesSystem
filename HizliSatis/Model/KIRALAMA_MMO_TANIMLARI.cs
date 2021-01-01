namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_MMO_TANIMLARI
    {
        [Key]
        public int kmmo_RECno { get; set; }

        public short kmmo_RECid_DBCno { get; set; }

        public int kmmo_RECid_RECno { get; set; }

        public int? kmmo_SpecRECno { get; set; }

        public bool? kmmo_iptal { get; set; }

        public short? kmmo_fileid { get; set; }

        public bool? kmmo_hidden { get; set; }

        public bool? kmmo_kilitli { get; set; }

        public bool? kmmo_degisti { get; set; }

        public int? kmmo_checksum { get; set; }

        public short? kmmo_create_user { get; set; }

        public DateTime? kmmo_create_date { get; set; }

        public short? kmmo_lastup_user { get; set; }

        public DateTime? kmmo_lastup_date { get; set; }

        [StringLength(4)]
        public string kmmo_special1 { get; set; }

        [StringLength(4)]
        public string kmmo_special2 { get; set; }

        [StringLength(4)]
        public string kmmo_special3 { get; set; }

        public byte? kmmo_rapor_tipi { get; set; }

        [StringLength(25)]
        public string kmmo_rapor_kodu { get; set; }

        public DateTime? kmmo_kontrol_tarihi { get; set; }

        public DateTime? kmmo_rap_tarihi { get; set; }

        [StringLength(25)]
        public string kmmo_rap_no { get; set; }

        public DateTime? kmmo_gecerlilik_tarihi { get; set; }

        [StringLength(25)]
        public string kmmo_stok_kodu { get; set; }

        [StringLength(25)]
        public string kmmo_cihaz_seri { get; set; }

        [StringLength(25)]
        public string kmmo_carikodu { get; set; }

        [StringLength(6)]
        public string kmmo_fatura_seri { get; set; }

        public int? kmmo_fatura_sira { get; set; }

        public DateTime? kmmo_fatura_tarihi { get; set; }

        public double? kmmo_tutar { get; set; }

        [StringLength(60)]
        public string kmmo_aciklama { get; set; }
    }
}
