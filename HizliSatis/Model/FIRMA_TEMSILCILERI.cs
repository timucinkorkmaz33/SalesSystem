namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_TEMSILCILERI
    {
        [Key]
        public int tms_RECno { get; set; }

        public short tms_RECid_DBCno { get; set; }

        public int tms_RECid_RECno { get; set; }

        public int? tms_SpecRECno { get; set; }

        public bool? tms_iptal { get; set; }

        public short? tms_fileid { get; set; }

        public bool? tms_hidden { get; set; }

        public bool? tms_kilitli { get; set; }

        public bool? tms_degisti { get; set; }

        public int? tms_checksum { get; set; }

        public short? tms_create_user { get; set; }

        public DateTime? tms_create_date { get; set; }

        public short? tms_lastup_user { get; set; }

        public DateTime? tms_lastup_date { get; set; }

        [StringLength(4)]
        public string tms_reserved1 { get; set; }

        [StringLength(4)]
        public string tms_reserved2 { get; set; }

        [StringLength(4)]
        public string tms_reserved3 { get; set; }

        public int? tms_Bag_Firma_No { get; set; }

        [StringLength(25)]
        public string tms_Kodu { get; set; }

        [StringLength(40)]
        public string tms_Adi { get; set; }

        [StringLength(40)]
        public string tms_Soyadi { get; set; }

        public byte? tms_Sifat { get; set; }

        [StringLength(10)]
        public string tms_VDaire { get; set; }

        [StringLength(20)]
        public string tms_VKimlikNo { get; set; }

        public double? tms_Hisse { get; set; }

        [StringLength(20)]
        public string tms_TicOdaSicilNo { get; set; }

        [StringLength(15)]
        public string tms_TcKimlikNo { get; set; }

        [StringLength(25)]
        public string tms_Babaadi { get; set; }

        [StringLength(25)]
        public string tms_Anneadi { get; set; }

        [StringLength(25)]
        public string tms_Dogyeri { get; set; }

        public DateTime? tms_Dogtarihi { get; set; }

        public byte? tms_Medenihal { get; set; }

        [StringLength(15)]
        public string tms_Uyruk { get; set; }

        [StringLength(80)]
        public string tms_Email { get; set; }

        [StringLength(5)]
        public string tms_MobTelUlKod1 { get; set; }

        [StringLength(5)]
        public string tms_MobTelKod1 { get; set; }

        [StringLength(10)]
        public string tms_MobTelNo1 { get; set; }

        [StringLength(5)]
        public string tms_MobTelUlKod2 { get; set; }

        [StringLength(5)]
        public string tms_MobTelKod2 { get; set; }

        [StringLength(10)]
        public string tms_MobTelNo2 { get; set; }

        [StringLength(5)]
        public string tms_IsTelUlKod { get; set; }

        [StringLength(5)]
        public string tms_IsTelKod { get; set; }

        [StringLength(10)]
        public string tms_IsTelNo1 { get; set; }

        [StringLength(10)]
        public string tms_IsTelNo2 { get; set; }

        [StringLength(10)]
        public string tms_IsFaxNo { get; set; }

        [StringLength(10)]
        public string tms_IsModemNo { get; set; }

        [StringLength(50)]
        public string tms_IsCadde { get; set; }

        [StringLength(50)]
        public string tms_IsMahalle { get; set; }

        [StringLength(50)]
        public string tms_IsSokak { get; set; }

        [StringLength(25)]
        public string tms_IsSemt { get; set; }

        [StringLength(10)]
        public string tms_IsApt_No { get; set; }

        [StringLength(10)]
        public string tms_IsDaire_No { get; set; }

        [StringLength(8)]
        public string tms_IsPosta_Kodu { get; set; }

        [StringLength(15)]
        public string tms_IsIlce { get; set; }

        [StringLength(15)]
        public string tms_IsIl { get; set; }

        [StringLength(15)]
        public string tms_IsUlke { get; set; }

        [StringLength(10)]
        public string tms_IsAdres_kodu { get; set; }

        [StringLength(5)]
        public string tms_IkmTelUlKod { get; set; }

        [StringLength(5)]
        public string tms_IkmTelKod { get; set; }

        [StringLength(10)]
        public string tms_IkmTelNo { get; set; }

        [StringLength(50)]
        public string tms_IkmCadde { get; set; }

        [StringLength(50)]
        public string tms_IkmMahalle { get; set; }

        [StringLength(50)]
        public string tms_IkmSokak { get; set; }

        [StringLength(25)]
        public string tms_IkmSemt { get; set; }

        [StringLength(10)]
        public string tms_IkmApt_No { get; set; }

        [StringLength(10)]
        public string tms_IkmDaire_No { get; set; }

        [StringLength(8)]
        public string tms_IkmPosta_Kodu { get; set; }

        [StringLength(15)]
        public string tms_IkmIlce { get; set; }

        [StringLength(15)]
        public string tms_IkmIl { get; set; }

        [StringLength(15)]
        public string tms_IkmUlke { get; set; }

        [StringLength(10)]
        public string tms_IkmAdres_kodu { get; set; }

        [StringLength(10)]
        public string tms_nuf_ciltno { get; set; }

        [StringLength(10)]
        public string tms_nuf_sayfano { get; set; }

        [StringLength(10)]
        public string tms_nuf_kutukno { get; set; }

        [StringLength(20)]
        public string tms_nuf_il { get; set; }

        [StringLength(127)]
        public string tms_TNB_sifre { get; set; }

        public DateTime? tms_sozlesme_tarihi { get; set; }

        [StringLength(25)]
        public string tms_sozlesme_no { get; set; }

        [StringLength(50)]
        public string tms_sozlesme_aciklama { get; set; }

        public bool? tms_TNB_kullan_fl { get; set; }

        public byte? tms_TNB_kimlik_tipi { get; set; }
    }
}
