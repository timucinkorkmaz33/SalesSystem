namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ISEMIRLERI")]
    public partial class ISEMIRLERI
    {
        [Key]
        public int is_RECno { get; set; }

        public short is_RECid_DBCno { get; set; }

        public int is_RECid_RECno { get; set; }

        public int? is_SpecRecNo { get; set; }

        public bool? is_iptal { get; set; }

        public short? is_fileid { get; set; }

        public bool? is_hidden { get; set; }

        public bool? is_kilitli { get; set; }

        public bool? is_degisti { get; set; }

        public int? is_checksum { get; set; }

        public short? is_create_user { get; set; }

        public DateTime? is_create_date { get; set; }

        public short? is_lastup_user { get; set; }

        public DateTime? is_lastup_date { get; set; }

        [StringLength(4)]
        public string is_special1 { get; set; }

        [StringLength(4)]
        public string is_special2 { get; set; }

        [StringLength(4)]
        public string is_special3 { get; set; }

        public int? is_firmano { get; set; }

        public int? is_subeno { get; set; }

        [StringLength(25)]
        public string is_Kod { get; set; }

        [StringLength(80)]
        public string is_Ismi { get; set; }

        public bool? is_Fason_Fl { get; set; }

        public byte? is_IsemriTipi { get; set; }

        public DateTime? is_BaslangicTarihi { get; set; }

        public DateTime? is_KapanisTarihi { get; set; }

        [StringLength(40)]
        public string is_StokBirikMuhKod { get; set; }

        [StringLength(40)]
        public string is_HizmetBirikMuhKod { get; set; }

        [StringLength(40)]
        public string is_StokYansitMuhKod { get; set; }

        [StringLength(40)]
        public string is_HizmetYansitMuhKo { get; set; }

        [StringLength(40)]
        public string is_yarimamul_birikim_muhkodu { get; set; }

        [StringLength(40)]
        public string is_yarimamul_yansitma_muhkodu { get; set; }

        [StringLength(40)]
        public string is_GenMalYanMuhKod_1 { get; set; }

        [StringLength(40)]
        public string is_GenMalYanMuhKod_2 { get; set; }

        [StringLength(40)]
        public string is_GenMalYanMuhKod_3 { get; set; }

        [StringLength(40)]
        public string is_GenMalYanMuhKod_4 { get; set; }

        [StringLength(40)]
        public string is_GenMalYanMuhKod_5 { get; set; }

        [StringLength(40)]
        public string is_MakineMalYanMuhKo { get; set; }

        [StringLength(40)]
        public string is_ElemanMalYanMuhKo { get; set; }

        [StringLength(40)]
        public string is_YariMamulMuhKod { get; set; }

        [StringLength(6)]
        public string is_SiparisNo_Seri { get; set; }

        public int? is_SiparisNo_Sira { get; set; }

        public int? is_SipSatirno { get; set; }

        [StringLength(1)]
        public string is_SipSafha { get; set; }

        public short? is_SipBatchId { get; set; }

        public byte? is_EmriDurumu { get; set; }

        public DateTime? is_Emri_AktiflesmeTarihi { get; set; }

        public DateTime? is_Emri_PlanBaslamaTarihi { get; set; }

        public DateTime? is_Emri_PlanBitisTarihi { get; set; }

        [StringLength(40)]
        public string is_GenUrtMalYanMuhKod_1 { get; set; }

        [StringLength(40)]
        public string is_GenUrtMalYanMuhKod_2 { get; set; }

        [StringLength(40)]
        public string is_GenUrtMalYanMuhKod_3 { get; set; }

        [StringLength(40)]
        public string is_GenUrtMalYanMuhKod_4 { get; set; }

        [StringLength(40)]
        public string is_GenUrtMalYanMuhKod_5 { get; set; }

        [StringLength(25)]
        public string is_Muhgrup_kodu { get; set; }

        [StringLength(25)]
        public string is_BagliOlduguIsemri { get; set; }

        public byte? is_BaglantiTipi { get; set; }

        public short? is_Baglanti_RECID_DBCNO { get; set; }

        public int? is_Baglanti_RECID_RECNO { get; set; }

        public short? is_OnaylayanKulNo { get; set; }

        public bool? is_Onayli_fl { get; set; }

        public byte? is_Onceligi { get; set; }

        [StringLength(25)]
        public string is_SorumlulukMerkezi { get; set; }

        [StringLength(25)]
        public string is_ProjeKodu { get; set; }

        [StringLength(40)]
        public string is_Aciklama { get; set; }

        public DateTime? is_KaynakPlanlamaTerminTarihi { get; set; }
    }
}
