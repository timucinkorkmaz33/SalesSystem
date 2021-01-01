namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SON_KULLANICILAR
    {
        [Key]
        public int tuk_RECno { get; set; }

        public short tuk_RECid_DBCno { get; set; }

        public int tuk_RECid_RECno { get; set; }

        public int? tuk_Spec_Rec_no { get; set; }

        public bool? tuk_iptal { get; set; }

        public short? tuk_fileid { get; set; }

        public bool? tuk_hidden { get; set; }

        public bool? tuk_kilitli { get; set; }

        public bool? tuk_degisti { get; set; }

        public int? tuk_checksum { get; set; }

        public short? tuk_create_user { get; set; }

        public DateTime? tuk_create_date { get; set; }

        public short? tuk_lastup_user { get; set; }

        public DateTime? tuk_lastup_date { get; set; }

        [StringLength(4)]
        public string tuk_special1 { get; set; }

        [StringLength(4)]
        public string tuk_special2 { get; set; }

        [StringLength(4)]
        public string tuk_special3 { get; set; }

        [StringLength(25)]
        public string tuk_kodu { get; set; }

        [StringLength(50)]
        public string tuk_ismi { get; set; }

        [StringLength(50)]
        public string tuk_Adr1_Cadde { get; set; }

        [StringLength(50)]
        public string tuk_Adr1_mahalle { get; set; }

        [StringLength(50)]
        public string tuk_Adr1_Sokak { get; set; }

        [StringLength(25)]
        public string tuk_Adr1_Semt { get; set; }

        [StringLength(10)]
        public string tuk_Adr1_Apt_No { get; set; }

        [StringLength(10)]
        public string tuk_Adr1_Daire_No { get; set; }

        [StringLength(8)]
        public string tuk_Adr1_Postakodu { get; set; }

        [StringLength(15)]
        public string tuk_Adr1_Ilce { get; set; }

        [StringLength(15)]
        public string tuk_Adr1_Il { get; set; }

        [StringLength(15)]
        public string tuk_Adr1_Ulke { get; set; }

        [StringLength(10)]
        public string tuk_Adr1_Adres_kodu { get; set; }

        [StringLength(50)]
        public string tuk_Adr2_Cadde { get; set; }

        [StringLength(50)]
        public string tuk_Adr2_mahalle { get; set; }

        [StringLength(50)]
        public string tuk_Adr2_Sokak { get; set; }

        [StringLength(25)]
        public string tuk_Adr2_Semt { get; set; }

        [StringLength(10)]
        public string tuk_Adr2_Apt_No { get; set; }

        [StringLength(10)]
        public string tuk_Adr2_Daire_No { get; set; }

        [StringLength(8)]
        public string tuk_Adr2_Postakodu { get; set; }

        [StringLength(15)]
        public string tuk_Adr2_Ilce { get; set; }

        [StringLength(15)]
        public string tuk_Adr2_Il { get; set; }

        [StringLength(15)]
        public string tuk_Adr2_Ulke { get; set; }

        [StringLength(10)]
        public string tuk_Adr2_Adres_kodu { get; set; }

        [StringLength(5)]
        public string tuk_Tel1_Ulkekod { get; set; }

        [StringLength(5)]
        public string tuk_Tel1_Bolgekod { get; set; }

        [StringLength(10)]
        public string tuk_Tel1_TelNo1 { get; set; }

        [StringLength(10)]
        public string tuk_Tel1_TelNo2 { get; set; }

        [StringLength(10)]
        public string tuk_Tel1_FaxNo { get; set; }

        [StringLength(10)]
        public string tuk_Tel1_ModemNo { get; set; }

        [StringLength(5)]
        public string tuk_Tel2_Ulkekod { get; set; }

        [StringLength(5)]
        public string tuk_Tel2_Bolgekod { get; set; }

        [StringLength(10)]
        public string tuk_Tel2_TelNo1 { get; set; }

        [StringLength(10)]
        public string tuk_Tel2_TelNo2 { get; set; }

        [StringLength(10)]
        public string tuk_Tel2_FaxNo { get; set; }

        [StringLength(10)]
        public string tuk_Tel2_ModemNo { get; set; }

        [StringLength(50)]
        public string tuk_yetkili1 { get; set; }

        [StringLength(50)]
        public string tuk_yetkili2 { get; set; }

        [StringLength(20)]
        public string tuk_ceptel1 { get; set; }

        [StringLength(20)]
        public string tuk_ceptel2 { get; set; }

        [StringLength(70)]
        public string tuk_email1 { get; set; }

        [StringLength(70)]
        public string tuk_email2 { get; set; }

        [StringLength(25)]
        public string tuk_GrpKodu { get; set; }

        [StringLength(25)]
        public string tuk_MuhKodu { get; set; }

        public bool? tuk_kilitli_flg { get; set; }

        [StringLength(25)]
        public string tuk_cari_kodu { get; set; }

        [StringLength(25)]
        public string tuk_sektor_kodu { get; set; }

        [StringLength(25)]
        public string tuk_bolge_kodu { get; set; }
    }
}
