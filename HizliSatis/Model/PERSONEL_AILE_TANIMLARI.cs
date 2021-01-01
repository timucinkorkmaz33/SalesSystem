namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_AILE_TANIMLARI
    {
        [Key]
        public int PA_RECno { get; set; }

        public short? PA_RECid_DBCno { get; set; }

        public int PA_RECid_RECno { get; set; }

        public int? PA_SpecRECno { get; set; }

        public bool? PA_iptal { get; set; }

        public short? PA_fileid { get; set; }

        public bool? PA_hidden { get; set; }

        public bool? PA_kilitli { get; set; }

        public bool? PA_degisti { get; set; }

        public int? PA_checksum { get; set; }

        public short? PA_create_user { get; set; }

        public DateTime? PA_create_date { get; set; }

        public short? PA_lastup_user { get; set; }

        public DateTime? PA_lastup_date { get; set; }

        [StringLength(4)]
        public string PA_special1 { get; set; }

        [StringLength(4)]
        public string PA_special2 { get; set; }

        [StringLength(4)]
        public string PA_special3 { get; set; }

        [StringLength(25)]
        public string PA_PerKodu { get; set; }

        public byte? PA_Yakinlik { get; set; }

        public short? PA_CocukSiraNo { get; set; }

        [StringLength(40)]
        public string PA_Ad { get; set; }

        [StringLength(40)]
        public string PA_Soyad { get; set; }

        [StringLength(40)]
        public string PA_IlkSoyad { get; set; }

        [StringLength(25)]
        public string PA_TcKimlik { get; set; }

        public byte? PA_Cinsiyet { get; set; }

        public DateTime? PA_DogumTar { get; set; }

        [StringLength(40)]
        public string PA_DogumYer { get; set; }

        public byte? PA_Ucretli { get; set; }

        public byte? PA_Tahsili { get; set; }

        public byte? PA_Sakatlik { get; set; }

        [StringLength(50)]
        public string PA_Cadde { get; set; }

        [StringLength(50)]
        public string PA_Mahalle { get; set; }

        [StringLength(50)]
        public string PA_Sokak { get; set; }

        [StringLength(25)]
        public string PA_Semt { get; set; }

        [StringLength(10)]
        public string PA_Apt_No { get; set; }

        [StringLength(10)]
        public string PA_Daire_No { get; set; }

        [StringLength(8)]
        public string PA_Posta_Kodu { get; set; }

        [StringLength(15)]
        public string PA_Ilce { get; set; }

        [StringLength(15)]
        public string PA_Il { get; set; }

        [StringLength(15)]
        public string PA_Ulke { get; set; }

        [StringLength(10)]
        public string PA_Adres_kodu { get; set; }

        [StringLength(5)]
        public string PA_TelUlkeKodu { get; set; }

        [StringLength(5)]
        public string PA_TelBolgekodu { get; set; }

        [StringLength(10)]
        public string PA_TelNo1 { get; set; }

        public DateTime? PA_EvlilikTarihi { get; set; }

        public byte? PA_agine_tabii { get; set; }

        public byte? PA_OgrenimeDevamEdiyor { get; set; }

        public byte? PA_maas_banka { get; set; }

        [StringLength(30)]
        public string PA_banka_hesapno { get; set; }
    }
}
