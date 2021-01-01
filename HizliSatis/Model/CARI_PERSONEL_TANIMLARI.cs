namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_PERSONEL_TANIMLARI
    {
        [Key]
        public int cari_per_RECno { get; set; }

        public short cari_per_RECid_DBCno { get; set; }

        public int cari_per_RECid_RECno { get; set; }

        public int? cari_per_SpecRECno { get; set; }

        public bool? cari_per_iptal { get; set; }

        public short? cari_per_fileid { get; set; }

        public bool? cari_per_hidden { get; set; }

        public bool? cari_per_kilitli { get; set; }

        public bool? cari_per_degisti { get; set; }

        public int? cari_per_checksum { get; set; }

        public short? cari_per_create_user { get; set; }

        public DateTime? cari_per_create_date { get; set; }

        public short? cari_per_lastup_user { get; set; }

        public DateTime? cari_per_lastup_date { get; set; }

        [StringLength(4)]
        public string cari_per_special1 { get; set; }

        [StringLength(4)]
        public string cari_per_special2 { get; set; }

        [StringLength(4)]
        public string cari_per_special3 { get; set; }

        [StringLength(25)]
        public string cari_per_kod { get; set; }

        [StringLength(50)]
        public string cari_per_adi { get; set; }

        [StringLength(50)]
        public string cari_per_soyadi { get; set; }

        public byte? cari_per_tip { get; set; }

        public byte? cari_per_doviz_cinsi { get; set; }

        [StringLength(40)]
        public string cari_per_muhkod0 { get; set; }

        [StringLength(40)]
        public string cari_per_muhkod1 { get; set; }

        [StringLength(40)]
        public string cari_per_muhkod2 { get; set; }

        [StringLength(40)]
        public string cari_per_muhkod3 { get; set; }

        [StringLength(40)]
        public string cari_per_muhkod4 { get; set; }

        [StringLength(4)]
        public string cari_per_banka_tcmb_kod { get; set; }

        [StringLength(8)]
        public string cari_per_banka_tcmb_subekod { get; set; }

        [StringLength(3)]
        public string cari_per_banka_tcmb_ilkod { get; set; }

        [StringLength(30)]
        public string cari_per_banka_hesapno { get; set; }

        [StringLength(25)]
        public string cari_per_banka_swiftkodu { get; set; }

        public double? cari_per_prim_adet { get; set; }

        public double? cari_per_prim_yuzde { get; set; }

        public double? cari_per_prim_carpani { get; set; }

        public double? cari_per_basmprimcirotav1 { get; set; }

        public double? cari_per_basmprimyuz1 { get; set; }

        public double? cari_per_basmprimcirotav2 { get; set; }

        public double? cari_per_basmprimyuz2 { get; set; }

        public double? cari_per_basmprimcirotav3 { get; set; }

        public double? cari_per_basmprimyuz3 { get; set; }

        public double? cari_per_basmprimcirotav4 { get; set; }

        public double? cari_per_basmprimyuz4 { get; set; }

        public double? cari_per_basmprimcirotav5 { get; set; }

        public double? cari_per_basmprimyuz5 { get; set; }

        [StringLength(25)]
        public string cari_per_kasiyerkodu { get; set; }

        [StringLength(127)]
        public string cari_per_kasiyersifresi { get; set; }

        [StringLength(25)]
        public string cari_per_kasiyerAmiri { get; set; }

        public int? cari_per_userno { get; set; }

        public int? cari_per_depono { get; set; }

        [StringLength(15)]
        public string cari_per_cepno { get; set; }

        [StringLength(50)]
        public string cari_per_mail { get; set; }

        [StringLength(4)]
        public string cari_takvim_kodu { get; set; }

        [StringLength(15)]
        public string cari_per_kasiyerfirmaid { get; set; }

        [StringLength(80)]
        public string cari_per_KEP_adresi { get; set; }
    }
}
