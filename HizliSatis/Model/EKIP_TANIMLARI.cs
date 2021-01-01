namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EKIP_TANIMLARI
    {
        [Key]
        public int ekp_RECno { get; set; }

        public short ekp_RECid_DBCno { get; set; }

        public int ekp_RECid_RECno { get; set; }

        public int? ekp_SpecRECNo { get; set; }

        public bool? ekp_iptal { get; set; }

        public short? ekp_fileid { get; set; }

        public bool? ekp_hidden { get; set; }

        public bool? ekp_kilitli { get; set; }

        public bool? ekp_degisti { get; set; }

        public int? ekp_CheckSum { get; set; }

        public short? ekp_create_user { get; set; }

        public DateTime? ekp_create_date { get; set; }

        public short? ekp_lastup_user { get; set; }

        public DateTime? ekp_lastup_date { get; set; }

        [StringLength(4)]
        public string ekp_special1 { get; set; }

        [StringLength(4)]
        public string ekp_special2 { get; set; }

        [StringLength(4)]
        public string ekp_special3 { get; set; }

        [StringLength(25)]
        public string ekp_kodu { get; set; }

        [StringLength(50)]
        public string ekp_adi { get; set; }

        [StringLength(25)]
        public string ekp_cari_kodu { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu1 { get; set; }

        public double? ekp_personel_agirlik_puan1 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu2 { get; set; }

        public double? ekp_personel_agirlik_puan2 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu3 { get; set; }

        public double? ekp_personel_agirlik_puan3 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu4 { get; set; }

        public double? ekp_personel_agirlik_puan4 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu5 { get; set; }

        public double? ekp_personel_agirlik_puan5 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu6 { get; set; }

        public double? ekp_personel_agirlik_puan6 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu7 { get; set; }

        public double? ekp_personel_agirlik_puan7 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu8 { get; set; }

        public double? ekp_personel_agirlik_puan8 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu9 { get; set; }

        public double? ekp_personel_agirlik_puan9 { get; set; }

        [StringLength(25)]
        public string ekp_personel_kodu10 { get; set; }

        public double? ekp_personel_agirlik_puan10 { get; set; }
    }
}
