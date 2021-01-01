namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOP_PROMOSYON_UYGULAMA_TANIMLARI
    {
        [Key]
        public int pru_RECno { get; set; }

        public short pru_RECid_DBCno { get; set; }

        public int pru_RECid_RECno { get; set; }

        public int? pru_SpecRECNo { get; set; }

        public bool? pru_iptal { get; set; }

        public short? pru_fileid { get; set; }

        public bool? pru_hidden { get; set; }

        public bool? pru_kilitli { get; set; }

        public bool? pru_degisti { get; set; }

        public int? pru_CheckSum { get; set; }

        public short? pru_create_user { get; set; }

        public DateTime? pru_create_date { get; set; }

        public short? pru_lastup_user { get; set; }

        public DateTime? pru_lastup_date { get; set; }

        [StringLength(4)]
        public string pru_special1 { get; set; }

        [StringLength(4)]
        public string pru_special2 { get; set; }

        [StringLength(4)]
        public string pru_special3 { get; set; }

        [StringLength(25)]
        public string pru_Promosyon { get; set; }

        [StringLength(25)]
        public string pru_Kod { get; set; }

        [StringLength(100)]
        public string pru_Aciklama { get; set; }

        public int? pru_UygulamaKodu { get; set; }

        [StringLength(127)]
        public string pru_Urunler { get; set; }

        public bool? pru_XXXDbl_aktif { get; set; }

        [StringLength(127)]
        public string pru_Miktar { get; set; }

        [StringLength(127)]
        public string pru_Deger { get; set; }

        public double? pru_MiktarDbl { get; set; }

        public double? pru_DegerDbl { get; set; }

        public byte? pru_OzelDurum { get; set; }

        public byte? pru_Ozellikler { get; set; }

        public byte? pru_iskonto_dagitim_sekli { get; set; }

        public byte? pru_iskonto_index { get; set; }

        public byte? pru_yuvarlama_tipi { get; set; }

        public double? pru_yuvarlama_miktar { get; set; }

        [StringLength(127)]
        public string pru_eksikse_mesaj { get; set; }

        [StringLength(127)]
        public string pru_kasa_mesaji { get; set; }

        [StringLength(127)]
        public string pru_ekbilgi { get; set; }
    }
}
