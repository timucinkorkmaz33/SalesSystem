namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROMOPUAN_TANIMLARI
    {
        [Key]
        public int Puan_RECno { get; set; }

        public short Puan_RECid_DBCno { get; set; }

        public int Puan_RECid_RECno { get; set; }

        public int? Puan_SpecRECNo { get; set; }

        public bool? Puan_iptal { get; set; }

        public short? Puan_fileid { get; set; }

        public bool? Puan_hidden { get; set; }

        public bool? Puan_kilitli { get; set; }

        public bool? Puan_degisti { get; set; }

        public int? Puan_CheckSum { get; set; }

        public short? Puan_create_user { get; set; }

        public DateTime? Puan_create_date { get; set; }

        public short? Puan_lastup_user { get; set; }

        public DateTime? Puan_lastup_date { get; set; }

        [StringLength(4)]
        public string Puan_special1 { get; set; }

        [StringLength(4)]
        public string Puan_special2 { get; set; }

        [StringLength(4)]
        public string Puan_special3 { get; set; }

        public byte? Puan_tipi { get; set; }

        [StringLength(25)]
        public string Puan_kodu { get; set; }

        [StringLength(50)]
        public string Puan_ismi { get; set; }

        public byte? Puan_BagliPosOdemeTipi { get; set; }

        [StringLength(25)]
        public string Puan_bazpuan_kodu { get; set; }

        [StringLength(25)]
        public string Puan_kampanya_kodu { get; set; }

        [StringLength(25)]
        public string Puan_satis_hizmet_kodu { get; set; }

        public DateTime? Puan_ilk_kullanim_tarihi { get; set; }

        public int? Puan_kullanim_baslangici { get; set; }

        public DateTime? Puan_son_kullanma_tarihi { get; set; }

        public int? Puan_gecerlilik_suresi { get; set; }

        [StringLength(50)]
        public string Puan_seri_no_yapisi { get; set; }

        [StringLength(25)]
        public string Puan_harcama_stok_kod_yapisi { get; set; }

        [StringLength(127)]
        public string Puan_harcama_stok_sorgu_cumlesi { get; set; }

        public double? Puan_deger { get; set; }

        public double? Puan_evrakta_max_kullanim { get; set; }

        public double? Puan_harcama_min_evrak_tutari { get; set; }

        public byte? Puan_Yansitma_Iskonto_index { get; set; }

        public byte? Puan_YetersizIadedeYapilacak { get; set; }

        public bool? Puan_PromosyonlariDurdurur { get; set; }

        public byte? Puan_GuvenlikKontrolu { get; set; }
    }
}
