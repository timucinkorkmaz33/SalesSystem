namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SUBELER")]
    public partial class SUBELER
    {
        [Key]
        public int Sube_RECno { get; set; }

        public short Sube_RECid_DBCno { get; set; }

        public int Sube_RECid_RECno { get; set; }

        public int? Sube_SpecRECno { get; set; }

        public bool? Sube_iptal { get; set; }

        public short? Sube_fileid { get; set; }

        public bool? Sube_hidden { get; set; }

        public bool? Sube_kilitli { get; set; }

        public bool? Sube_degisti { get; set; }

        public int? Sube_checksum { get; set; }

        public short? Sube_create_user { get; set; }

        public DateTime? Sube_create_date { get; set; }

        public short? Sube_lastup_user { get; set; }

        public DateTime? Sube_lastup_date { get; set; }

        [StringLength(4)]
        public string Sube_special1 { get; set; }

        [StringLength(4)]
        public string Sube_special2 { get; set; }

        [StringLength(4)]
        public string Sube_special3 { get; set; }

        public int? Sube_bag_firma { get; set; }

        public int? Sube_no { get; set; }

        [StringLength(50)]
        public string Sube_adi { get; set; }

        [StringLength(15)]
        public string Sube_kodu { get; set; }

        [StringLength(25)]
        public string Sube_MersisNo { get; set; }

        [StringLength(10)]
        public string sube_muhgrupkodu { get; set; }

        public bool? sube_muhasebelesmeye { get; set; }

        [StringLength(6)]
        public string sube_Mn_muhfserino { get; set; }

        [StringLength(50)]
        public string sube_yetkili_email { get; set; }

        [StringLength(50)]
        public string sube_Cadde { get; set; }

        [StringLength(50)]
        public string sube_Mahalle { get; set; }

        [StringLength(50)]
        public string sube_Sokak { get; set; }

        [StringLength(25)]
        public string sube_Semt { get; set; }

        [StringLength(10)]
        public string sube_Apt_No { get; set; }

        [StringLength(10)]
        public string sube_Daire_No { get; set; }

        [StringLength(8)]
        public string sube_Posta_Kodu { get; set; }

        [StringLength(15)]
        public string sube_Ilce { get; set; }

        [StringLength(15)]
        public string sube_Il { get; set; }

        [StringLength(15)]
        public string sube_Ulke { get; set; }

        [StringLength(10)]
        public string sube_Adres_kodu { get; set; }

        public double? sube_gps_enlem { get; set; }

        public double? sube_gps_boylam { get; set; }

        [StringLength(5)]
        public string sube_TelUlkeKodu { get; set; }

        [StringLength(5)]
        public string sube_TelBolgekodu { get; set; }

        [StringLength(10)]
        public string sube_TelNo1 { get; set; }

        [StringLength(10)]
        public string sube_TelNo2 { get; set; }

        [StringLength(10)]
        public string sube_TelFaxno { get; set; }

        [StringLength(10)]
        public string sube_TelModem { get; set; }

        public int? sube_datacenterno { get; set; }

        [StringLength(25)]
        public string sube_eIskurNo { get; set; }

        [StringLength(20)]
        public string sube_eIskurTCNo { get; set; }

        [StringLength(127)]
        public string sube_eIskurSifre { get; set; }

        public double? sube_RusumOrani { get; set; }

        [StringLength(15)]
        public string sube_emutabakatsubekodu { get; set; }

        public byte? sube_eFaturaMukellefiyetTipi { get; set; }

        [StringLength(25)]
        public string sube_eFaturaMukellefiyetKodu { get; set; }
    }
}
