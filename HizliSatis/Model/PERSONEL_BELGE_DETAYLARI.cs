namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BELGE_DETAYLARI
    {
        [Key]
        public int bdt_RECno { get; set; }

        public short bdt_RECid_DBCno { get; set; }

        public int bdt_RECid_RECno { get; set; }

        public int? bdt_SpecRECno { get; set; }

        public bool? bdt_iptal { get; set; }

        public short? bdt_fileid { get; set; }

        public bool? bdt_hidden { get; set; }

        public bool? bdt_kilitli { get; set; }

        public bool? bdt_degisti { get; set; }

        public int? bdt_checksum { get; set; }

        public short? bdt_create_user { get; set; }

        public DateTime? bdt_create_date { get; set; }

        public short? bdt_lastup_user { get; set; }

        public DateTime? bdt_lastup_date { get; set; }

        [StringLength(4)]
        public string bdt_special1 { get; set; }

        [StringLength(4)]
        public string bdt_special2 { get; set; }

        [StringLength(4)]
        public string bdt_special3 { get; set; }

        [StringLength(25)]
        public string bdt_pers_kod { get; set; }

        [StringLength(25)]
        public string bdt_belge_kod { get; set; }

        [StringLength(30)]
        public string bdt_belge_no { get; set; }

        [StringLength(40)]
        public string bdt_belge_yeri { get; set; }

        [StringLength(4)]
        public string bdt_ulke_kodu { get; set; }

        public DateTime? bdt_belge_baslangic { get; set; }

        public DateTime? bdt_belge_bitis { get; set; }

        public byte? bdt_pozisyon { get; set; }

        [StringLength(25)]
        public string bdt_sorumlu { get; set; }

        public DateTime? bdt_pozisyon_degisim_tarihi { get; set; }

        [StringLength(40)]
        public string bdt_pozisyon_aciklama { get; set; }
    }
}
