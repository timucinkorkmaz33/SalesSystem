namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMKIRA_TANIMLARI
    {
        [Key]
        public int Avmk_RECno { get; set; }

        public short Avmk_RECid_DBCno { get; set; }

        public int Avmk_RECid_RECno { get; set; }

        public int? Avmk_SpecRECno { get; set; }

        public bool? Avmk_iptal { get; set; }

        public short? Avmk_fileid { get; set; }

        public bool? Avmk_hidden { get; set; }

        public bool? Avmk_kilitli { get; set; }

        public bool? Avmk_degisti { get; set; }

        public int? Avmk_checksum { get; set; }

        public short? Avmk_create_user { get; set; }

        public DateTime? Avmk_create_date { get; set; }

        public short? Avmk_lastup_user { get; set; }

        public DateTime? Avmk_lastup_date { get; set; }

        [StringLength(4)]
        public string Avmk_special1 { get; set; }

        [StringLength(4)]
        public string Avmk_special2 { get; set; }

        [StringLength(4)]
        public string Avmk_special3 { get; set; }

        [StringLength(25)]
        public string Avmk_kira_kodu { get; set; }

        [StringLength(50)]
        public string Avmk_kira_ismi { get; set; }

        public DateTime? Avmk_baslangictarihi { get; set; }

        public DateTime? Avmk_bitistarihi { get; set; }

        public DateTime? Avmk_sozlesmetarihi { get; set; }

        public DateTime? Avmk_yertestarihi { get; set; }

        public byte? Avmk_kirayontemi { get; set; }

        [StringLength(25)]
        public string Avmk_srmrkkodu { get; set; }

        [StringLength(25)]
        public string Avmk_Kiratan1kirablmkodu { get; set; }

        public double? Avmk_Kiratan1kirablmbrutalan { get; set; }

        public double? Avmk_Kiratan1kirablmnetalan { get; set; }

        public double? Avmk_Kiratan1kirablmkiratutari { get; set; }

        public byte? Avmk_Kiratan1kirablmkiradvzcinsi { get; set; }

        public byte? Avmk_Kiratan1kirablmkiraperyodu { get; set; }

        public byte? Avmk_Kiratan1kirablmdvzdegerleme { get; set; }

        public short? Avmk_Kiratan1kirablmperyodaraligi { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes1Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes1Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes1ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes1EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes2Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes2Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes2ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes2EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes3Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes3Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes3ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes3EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes4Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes4Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes4ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes4EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes5Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes5Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes5ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes5EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes6Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes6Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes6ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes6EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes7Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes7Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes7ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes7EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes8Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes8Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes8ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes8EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes9Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes9Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes9ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes9EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes10Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes10Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes10ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes10EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes11Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes11Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes11ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes11EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes12Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes12Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes12ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes12EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes13Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes13Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes13ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes13EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes14Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes14Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes14ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes14EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes15Bastar { get; set; }

        public DateTime? Avmk_Kiratan1kirablmHes15Bittar { get; set; }

        public byte? Avmk_Kiratan1kirablmHes15ArtisSekli { get; set; }

        public double? Avmk_Kiratan1kirablmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan1kirablmHes15EndxFormul { get; set; }

        public byte? Avmk_Kiratan1kirablmHesaplamaTipi { get; set; }

        [StringLength(25)]
        public string Avmk_Kiratan2kirablmkodu { get; set; }

        public double? Avmk_Kiratan2kirablmbrutalan { get; set; }

        public double? Avmk_Kiratan2kirablmnetalan { get; set; }

        public double? Avmk_Kiratan2kirablmkiratutari { get; set; }

        public byte? Avmk_Kiratan2kirablmkiradvzcinsi { get; set; }

        public byte? Avmk_Kiratan2kirablmkiraperyodu { get; set; }

        public byte? Avmk_Kiratan2kirablmdvzdegerleme { get; set; }

        public short? Avmk_Kiratan2kirablmperyodaraligi { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes1Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes1Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes1ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes1EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes2Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes2Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes2ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes2EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes3Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes3Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes3ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes3EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes4Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes4Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes4ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes4EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes5Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes5Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes5ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes5EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes6Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes6Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes6ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes6EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes7Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes7Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes7ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes7EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes8Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes8Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes8ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes8EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes9Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes9Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes9ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes9EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes10Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes10Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes10ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes10EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes11Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes11Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes11ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes11EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes12Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes12Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes12ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes12EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes13Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes13Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes13ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes13EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes14Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes14Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes14ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes14EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes15Bastar { get; set; }

        public DateTime? Avmk_Kiratan2kirablmHes15Bittar { get; set; }

        public byte? Avmk_Kiratan2kirablmHes15ArtisSekli { get; set; }

        public double? Avmk_Kiratan2kirablmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan2kirablmHes15EndxFormul { get; set; }

        public byte? Avmk_Kiratan2kirablmHesaplamaTipi { get; set; }

        [StringLength(25)]
        public string Avmk_Kiratan3kirablmkodu { get; set; }

        public double? Avmk_Kiratan3kirablmbrutalan { get; set; }

        public double? Avmk_Kiratan3kirablmnetalan { get; set; }

        public double? Avmk_Kiratan3kirablmkiratutari { get; set; }

        public byte? Avmk_Kiratan3kirablmkiradvzcinsi { get; set; }

        public byte? Avmk_Kiratan3kirablmkiraperyodu { get; set; }

        public byte? Avmk_Kiratan3kirablmdvzdegerleme { get; set; }

        public short? Avmk_Kiratan3kirablmperyodaraligi { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes1Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes1Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes1ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes1EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes2Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes2Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes2ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes2EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes3Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes3Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes3ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes3EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes4Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes4Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes4ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes4EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes5Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes5Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes5ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes5EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes6Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes6Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes6ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes6EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes7Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes7Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes7ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes7EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes8Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes8Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes8ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes8EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes9Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes9Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes9ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes9EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes10Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes10Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes10ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes10EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes11Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes11Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes11ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes11EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes12Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes12Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes12ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes12EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes13Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes13Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes13ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes13EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes14Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes14Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes14ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes14EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes15Bastar { get; set; }

        public DateTime? Avmk_Kiratan3kirablmHes15Bittar { get; set; }

        public byte? Avmk_Kiratan3kirablmHes15ArtisSekli { get; set; }

        public double? Avmk_Kiratan3kirablmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan3kirablmHes15EndxFormul { get; set; }

        public byte? Avmk_Kiratan3kirablmHesaplamaTipi { get; set; }

        [StringLength(25)]
        public string Avmk_Kiratan4kirablmkodu { get; set; }

        public double? Avmk_Kiratan4kirablmbrutalan { get; set; }

        public double? Avmk_Kiratan4kirablmnetalan { get; set; }

        public double? Avmk_Kiratan4kirablmkiratutari { get; set; }

        public byte? Avmk_Kiratan4kirablmkiradvzcinsi { get; set; }

        public byte? Avmk_Kiratan4kirablmkiraperyodu { get; set; }

        public byte? Avmk_Kiratan4kirablmdvzdegerleme { get; set; }

        public short? Avmk_Kiratan4kirablmperyodaraligi { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes1Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes1Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes1ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes1EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes2Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes2Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes2ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes2EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes3Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes3Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes3ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes3EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes4Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes4Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes4ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes4EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes5Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes5Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes5ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes5EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes6Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes6Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes6ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes6EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes7Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes7Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes7ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes7EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes8Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes8Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes8ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes8EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes9Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes9Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes9ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes9EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes10Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes10Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes10ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes10EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes11Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes11Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes11ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes11EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes12Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes12Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes12ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes12EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes13Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes13Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes13ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes13EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes14Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes14Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes14ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes14EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes15Bastar { get; set; }

        public DateTime? Avmk_Kiratan4kirablmHes15Bittar { get; set; }

        public byte? Avmk_Kiratan4kirablmHes15ArtisSekli { get; set; }

        public double? Avmk_Kiratan4kirablmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan4kirablmHes15EndxFormul { get; set; }

        public byte? Avmk_Kiratan4kirablmHesaplamaTipi { get; set; }

        [StringLength(25)]
        public string Avmk_Kiratan5kirablmkodu { get; set; }

        public double? Avmk_Kiratan5kirablmbrutalan { get; set; }

        public double? Avmk_Kiratan5kirablmnetalan { get; set; }

        public double? Avmk_Kiratan5kirablmkiratutari { get; set; }

        public byte? Avmk_Kiratan5kirablmkiradvzcinsi { get; set; }

        public byte? Avmk_Kiratan5kirablmkiraperyodu { get; set; }

        public byte? Avmk_Kiratan5kirablmdvzdegerleme { get; set; }

        public short? Avmk_Kiratan5kirablmperyodaraligi { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes1Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes1Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes1ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes1EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes2Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes2Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes2ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes2EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes3Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes3Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes3ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes3EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes4Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes4Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes4ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes4EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes5Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes5Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes5ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes5EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes6Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes6Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes6ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes6EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes7Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes7Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes7ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes7EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes8Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes8Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes8ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes8EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes9Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes9Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes9ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes9EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes10Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes10Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes10ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes10EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes11Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes11Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes11ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes11EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes12Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes12Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes12ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes12EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes13Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes13Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes13ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes13EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes14Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes14Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes14ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes14EndxFormul { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes15Bastar { get; set; }

        public DateTime? Avmk_Kiratan5kirablmHes15Bittar { get; set; }

        public byte? Avmk_Kiratan5kirablmHes15ArtisSekli { get; set; }

        public double? Avmk_Kiratan5kirablmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_Kiratan5kirablmHes15EndxFormul { get; set; }

        public byte? Avmk_Kiratan5kirablmHesaplamaTipi { get; set; }

        [StringLength(25)]
        public string Avmk_OrtGidtan1OrtGidblmkodu { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmbrutalan { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmnetalan { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmkatbedeli { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmdvzcinsi { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmperyodu { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmdvzdegerleme { get; set; }

        public short? Avmk_OrtGidtan1OrtGidblmperyodaraligi { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes1Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes1Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes1ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes1EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes2Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes2Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes2ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes2EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes3Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes3Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes3ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes3EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes4Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes4Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes4ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes4EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes5Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes5Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes5ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes5EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes6Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes6Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes6ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes6EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes7Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes7Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes7ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes7EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes8Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes8Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes8ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes8EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes9Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes9Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes9ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes9EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes10Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes10Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes10ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes10EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes11Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes11Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes11ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes11EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes12Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes12Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes12ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes12EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes13Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes13Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes13ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes13EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes14Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes14Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes14ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes14EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes15Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan1OrtGidblmHes15Bittar { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHes15ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan1OrtGidblmHes15EndxFormul { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmHesaplamaTipi { get; set; }

        public byte? Avmk_OrtGidtan1OrtGidblmOrtakAlanKatSkl { get; set; }

        public double? Avmk_OrtGidtan1OrtGidblmOrtakAlanUstLmt { get; set; }

        [StringLength(25)]
        public string Avmk_OrtGidtan2OrtGidblmkodu { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmbrutalan { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmnetalan { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmkatbedeli { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmdvzcinsi { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmperyodu { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmdvzdegerleme { get; set; }

        public short? Avmk_OrtGidtan2OrtGidblmperyodaraligi { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes1Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes1Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes1ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes1EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes2Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes2Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes2ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes2EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes3Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes3Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes3ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes3EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes4Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes4Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes4ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes4EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes5Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes5Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes5ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes5EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes6Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes6Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes6ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes6EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes7Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes7Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes7ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes7EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes8Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes8Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes8ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes8EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes9Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes9Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes9ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes9EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes10Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes10Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes10ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes10EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes11Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes11Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes11ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes11EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes12Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes12Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes12ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes12EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes13Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes13Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes13ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes13EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes14Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes14Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes14ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes14EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes15Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan2OrtGidblmHes15Bittar { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHes15ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan2OrtGidblmHes15EndxFormul { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmHesaplamaTipi { get; set; }

        public byte? Avmk_OrtGidtan2OrtGidblmOrtakAlanKatSkl { get; set; }

        public double? Avmk_OrtGidtan2OrtGidblmOrtakAlanUstLmt { get; set; }

        [StringLength(25)]
        public string Avmk_OrtGidtan3OrtGidblmkodu { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmbrutalan { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmnetalan { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmkatbedeli { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmdvzcinsi { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmperyodu { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmdvzdegerleme { get; set; }

        public short? Avmk_OrtGidtan3OrtGidblmperyodaraligi { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes1Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes1Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes1ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes1EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes2Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes2Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes2ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes2EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes3Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes3Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes3ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes3EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes4Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes4Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes4ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes4EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes5Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes5Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes5ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes5EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes6Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes6Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes6ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes6EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes7Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes7Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes7ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes7EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes8Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes8Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes8ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes8EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes9Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes9Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes9ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes9EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes10Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes10Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes10ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes10EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes11Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes11Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes11ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes11EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes12Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes12Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes12ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes12EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes13Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes13Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes13ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes13EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes14Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes14Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes14ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes14EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes15Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan3OrtGidblmHes15Bittar { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHes15ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan3OrtGidblmHes15EndxFormul { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmHesaplamaTipi { get; set; }

        public byte? Avmk_OrtGidtan3OrtGidblmOrtakAlanKatSkl { get; set; }

        public double? Avmk_OrtGidtan3OrtGidblmOrtakAlanUstLmt { get; set; }

        [StringLength(25)]
        public string Avmk_OrtGidtan4OrtGidblmkodu { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmbrutalan { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmnetalan { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmkatbedeli { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmdvzcinsi { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmperyodu { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmdvzdegerleme { get; set; }

        public short? Avmk_OrtGidtan4OrtGidblmperyodaraligi { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes1Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes1Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes1ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes1EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes2Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes2Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes2ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes2EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes3Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes3Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes3ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes3EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes4Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes4Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes4ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes4EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes5Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes5Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes5ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes5EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes6Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes6Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes6ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes6EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes7Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes7Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes7ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes7ndeksFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes8Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes8Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes8ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes8ndeksFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes9Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes9Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes9ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes9ndeksFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes10Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes10Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes10ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes10ndeksFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes11Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes11Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes11ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes11EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes12Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes12Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes12ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes12EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes13Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes13Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes13ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes13EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes14Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes14Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes14ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes14EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes15Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan4OrtGidblmHes15Bittar { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHes15ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan4OrtGidblmHes15EndxFormul { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmHesaplamaTipi { get; set; }

        public byte? Avmk_OrtGidtan4OrtGidblmOrtakAlanKatSkl { get; set; }

        public double? Avmk_OrtGidtan4OrtGidblmOrtakAlanUstLmt { get; set; }

        [StringLength(25)]
        public string Avmk_OrtGidtan5OrtGidblmkodu { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmbrutalan { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmnetalan { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmkatbedeli { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmdvzcinsi { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmperyodu { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmdvzdegerleme { get; set; }

        public short? Avmk_OrtGidtan5OrtGidblmperyodaraligi { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes1Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes1Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes1ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes1ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes1EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes2Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes2Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes2ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes2ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes2EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes3Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes3Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes3ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes3ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes3EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes4Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes4Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes4ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes4ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes4EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes5Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes5Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes5ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes5ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes5EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes6Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes6Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes6ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes6ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes6EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes7Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes7Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes7ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes7ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes7EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes8Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes8Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes8ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes8ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes8EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes9Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes9Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes9ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes9ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes9EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes10Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes10Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes10ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes10ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes10EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes11Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes11Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes11ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes11ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes11EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes12Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes12Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes12ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes12ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes12EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes13Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes13Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes13ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes13ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes13EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes14Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes14Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes14ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes14ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes14EndxFormul { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes15Bastar { get; set; }

        public DateTime? Avmk_OrtGidtan5OrtGidblmHes15Bittar { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHes15ArtisSekli { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmHes15ArtisOrani { get; set; }

        [StringLength(15)]
        public string Avmk_OrtGidtan5OrtGidblmHes15EndxFormul { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmHesaplamaTipi { get; set; }

        public byte? Avmk_OrtGidtan5OrtGidblmOrtakAlanKatSkl { get; set; }

        public double? Avmk_OrtGidtan5OrtGidblmOrtakAlanUstLmt { get; set; }

        public double? Avmk_brutalan { get; set; }

        public double? Avmk_netalan { get; set; }

        public double? Avmk_pesinkira { get; set; }

        public byte? Avmk_dvzcinsi { get; set; }

        public short? Avmk_asgkiraodemevadesi { get; set; }

        public double? Avmk_asgkiraodemevadfyuz { get; set; }

        public short? Avmk_ortgidodemevadesi { get; set; }

        public double? Avmk_ortgidodemevadfyuz { get; set; }

        [StringLength(25)]
        public string Avmk_sektorkodu { get; set; }

        public short? Avmk_OnaylayanKulNo { get; set; }

        public bool? Avmk_cagrilabilir_fl { get; set; }

        public bool? Avmk_SozlesmeOlustu_fl { get; set; }

        public byte? Avmk_asgkiraodemecinsi { get; set; }

        public byte? Avmk_asgkiraodemegunu { get; set; }

        public byte? Avmk_ortgidodemecinsi { get; set; }

        public byte? Avmk_ortgidodemegunu { get; set; }

        [StringLength(25)]
        public string Avmk_markakodu { get; set; }

        public bool? AvmkSozlesmeFeshedildi_fl { get; set; }

        public DateTime? AvmkSozlesmeFeshedilmeTarihi { get; set; }

        public bool? Avmk_SabitGiderSozlesmeOlustu_fl { get; set; }

        public DateTime? Avmk_MagazaAcilisTarihi { get; set; }

        public byte? Avmk_KiraTarHesSekli { get; set; }

        public short? Avmk_FaturaTebligSuresi { get; set; }

        public short? Avmk_SayacFaturaVadesi { get; set; }

        [StringLength(25)]
        public string Avmk_ProjeKodu { get; set; }

        public bool? Avmk_Malsahibi_fl { get; set; }

        [StringLength(25)]
        public string AvmkKiraciSozlesmeKodu { get; set; }

        public DateTime? Avmk_DepozitoTanimlari1DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari1DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari1DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari1DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari1DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari2DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari2DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari2DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari2DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari2DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari3DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari3DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari3DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari3DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari3DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari4DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari4DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari4DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari4DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari4DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari5DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari5DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari5DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari5DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari5DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari6DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari6DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari6DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari6DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari6DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari7DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari7DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari7DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari7DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari7DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari8DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari8DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari8DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari8DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari8DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari9DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari9DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari9DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari9DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari9DpztDvzCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari10DpztDuzTar { get; set; }

        public byte? Avmk_DepozitoTanimlari10DpztCinsi { get; set; }

        public DateTime? Avmk_DepozitoTanimlari10DpztGecTar { get; set; }

        public double? Avmk_DepozitoTanimlari10DpztTutari { get; set; }

        public byte? Avmk_DepozitoTanimlari10DpztDvzCinsi { get; set; }
    }
}
