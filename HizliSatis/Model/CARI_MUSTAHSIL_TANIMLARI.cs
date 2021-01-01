namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_MUSTAHSIL_TANIMLARI
    {
        [Key]
        public int Cm_RECno { get; set; }

        public short Cm_RECid_DBCno { get; set; }

        public int Cm_RECid_RECno { get; set; }

        public int? Cm_SpecRECNo { get; set; }

        public bool? Cm_iptal { get; set; }

        public short? Cm_fileid { get; set; }

        public bool? Cm_hidden { get; set; }

        public bool? Cm_kilitli { get; set; }

        public bool? Cm_degisti { get; set; }

        public int? Cm_CheckSum { get; set; }

        public short? Cm_create_user { get; set; }

        public DateTime? Cm_create_date { get; set; }

        public short? Cm_lastup_user { get; set; }

        public DateTime? Cm_lastup_date { get; set; }

        [StringLength(4)]
        public string Cm_special1 { get; set; }

        [StringLength(4)]
        public string Cm_special2 { get; set; }

        [StringLength(4)]
        public string Cm_special3 { get; set; }

        [StringLength(25)]
        public string Cm_carikodu { get; set; }

        public bool? Cm_Bagkurlu { get; set; }

        public DateTime? Cm_BagkurBasTar { get; set; }

        public DateTime? Cm_BagkurBitTar { get; set; }

        [StringLength(15)]
        public string Cm_BabaAdi { get; set; }

        [StringLength(15)]
        public string Cm_DogumYer { get; set; }

        public DateTime? Cm_DogumTar { get; set; }

        [StringLength(20)]
        public string Cm_SosGuvDurumu { get; set; }

        public double? Cm_Donum { get; set; }

        [StringLength(20)]
        public string Cm_CuzdanNo { get; set; }

        [StringLength(20)]
        public string Cm_FabrikaKodu { get; set; }

        [StringLength(50)]
        public string Cm_FabrikaAdi { get; set; }

        [StringLength(20)]
        public string Cm_RuhsatNo { get; set; }

        [StringLength(20)]
        public string Cm_BelgeNo { get; set; }

        public DateTime? Cm_GecerlilikTarihi { get; set; }

        [StringLength(50)]
        public string Cm_ZiraatOdasi { get; set; }

        [StringLength(20)]
        public string Cm_BagkurNo { get; set; }

        [StringLength(20)]
        public string Cm_TCKimlikNo { get; set; }

        [StringLength(50)]
        public string Cm_Kooperatif { get; set; }

        [StringLength(50)]
        public string Cm_UrunBirligi { get; set; }

        public bool? Cm_HastaliktanAriBelgesi { get; set; }

        public bool? Cm_ABSertifikasi { get; set; }

        public bool? Cm_DamizlikPrimi { get; set; }

        public bool? Cm_TesvikAliyor { get; set; }

        public DateTime? Cm_MuafiyetBaslangic { get; set; }

        public DateTime? Cm_MuafiyetBitis { get; set; }
    }
}
