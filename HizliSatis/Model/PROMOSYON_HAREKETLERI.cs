namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROMOSYON_HAREKETLERI
    {
        [Key]
        public int prh_RECno { get; set; }

        public short prh_RECid_DBCno { get; set; }

        public int prh_RECid_RECno { get; set; }

        public int? prh_Spec_Rec_no { get; set; }

        public bool? prh_iptal { get; set; }

        public short? prh_fileid { get; set; }

        public bool? prh_hidden { get; set; }

        public bool? prh_kilitli { get; set; }

        public bool? prh_degisti { get; set; }

        public int? prh_checksum { get; set; }

        public short? prh_create_user { get; set; }

        public DateTime? prh_create_date { get; set; }

        public short? prh_lastup_user { get; set; }

        public DateTime? prh_lastup_date { get; set; }

        [StringLength(4)]
        public string prh_special1 { get; set; }

        [StringLength(4)]
        public string prh_special2 { get; set; }

        [StringLength(4)]
        public string prh_special3 { get; set; }

        public int? prh_firmano { get; set; }

        public int? prh_subeno { get; set; }

        [StringLength(25)]
        public string prh_promo_kodu { get; set; }

        public byte? prh_evrak_kaynak { get; set; }

        public byte? prh_sth_evraktip { get; set; }

        public byte? prh_evrak_cins { get; set; }

        [StringLength(6)]
        public string prh_sth_evrakno_seri { get; set; }

        public int? prh_sth_evrakno_sira { get; set; }

        public int? prh_sth_satirno { get; set; }

        public byte? prh_urun_cinsi { get; set; }

        [StringLength(25)]
        public string prh_stok_kodu { get; set; }

        [StringLength(25)]
        public string prh_cari_kodu { get; set; }

        public DateTime? prh_tarih { get; set; }

        [StringLength(25)]
        public string prh_plasiyer_kodu { get; set; }

        public double? prh_miktar { get; set; }

        public double? prh_tutar { get; set; }

        public double? prh_yansiyan_promo_tutari { get; set; }

        public short? prh_promosyon_tipi { get; set; }

        public short? prh_uygulama_tipi { get; set; }
    }
}
