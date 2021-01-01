namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_DEFTER_HAREKETLERI
    {
        [Key]
        public int edefter_RECno { get; set; }

        public short edefter_RECid_DBCno { get; set; }

        public int edefter_RECid_RECno { get; set; }

        public int? edefter_Spec_Rec_no { get; set; }

        public bool? edefter_iptal { get; set; }

        public short? edefter_fileid { get; set; }

        public bool? edefter_hidden { get; set; }

        public bool? edefter_kilitli { get; set; }

        public bool? edefter_degisti { get; set; }

        public int? edefter_checksum { get; set; }

        public short? edefter_create_user { get; set; }

        public DateTime? edefter_create_date { get; set; }

        public short? edefter_lastup_user { get; set; }

        public DateTime? edefter_lastup_date { get; set; }

        [StringLength(4)]
        public string edefter_special1 { get; set; }

        [StringLength(4)]
        public string edefter_special2 { get; set; }

        [StringLength(4)]
        public string edefter_special3 { get; set; }

        public int? edefter_firmano { get; set; }

        public int? edefter_maliyil { get; set; }

        public int? edefter_malidonem { get; set; }

        public int? edefter_donemsirano { get; set; }

        public int? edefter_maliyilsirano { get; set; }

        public byte? edefter_dosyalamaperiyodu { get; set; }

        public byte? edefter_aktifgrup { get; set; }

        [StringLength(50)]
        public string edefter_aciklama { get; set; }

        public bool? edefter_zamandamgasifl { get; set; }

        public DateTime? edefter_ilktarih { get; set; }

        public DateTime? edefter_sontarih { get; set; }

        public int? edefter_ilkyevmiye { get; set; }

        public int? edefter_sonyevmiye { get; set; }

        public double? edefter_dosyaboyutu { get; set; }

        public bool? edefter_olusturuldu { get; set; }

        public bool? edefter_onayliberatalindi { get; set; }

        public byte? edefter_olusturulsun { get; set; }

        public int? edefter_ilkmuteselsilno { get; set; }

        public int? edefter_sonmuteselsilno { get; set; }

        [StringLength(127)]
        public string edefter_sube_adi { get; set; }

        public int? edefter_sube_no { get; set; }

        public byte? edefter_doviz_tipi { get; set; }

        [StringLength(5)]
        public string edefter_gib_yev_durum_kod { get; set; }

        [StringLength(120)]
        public string edefter_gib_yev_durum_aciklama { get; set; }

        [StringLength(5)]
        public string edefter_gib_keb_durum_kod { get; set; }

        [StringLength(120)]
        public string edefter_gib_keb_durum_aciklama { get; set; }

        public bool? edefter_mye_yev_yuklendi { get; set; }

        public bool? edefter_mye_keb_yuklendi { get; set; }

        public bool? edefter_mye_yev_berat_yuklendi { get; set; }

        public bool? edefter_mye_keb_berat_yuklendi { get; set; }

        public bool? edefter_mye_yev_gib_berat_yuklendi { get; set; }

        public bool? edefter_mye_keb_gib_berat_yuklendi { get; set; }

        public double? edefter_borc_toplam { get; set; }

        public double? edefter_alacak_toplam { get; set; }

        [StringLength(50)]
        public string edefter_yevmiye_hash { get; set; }

        [StringLength(50)]
        public string edefter_yevmiye_zip_hash { get; set; }

        [StringLength(50)]
        public string edefter_yevmiye_berat_hash { get; set; }

        [StringLength(50)]
        public string edefter_yevmiye_berat_zip_hash { get; set; }

        [StringLength(50)]
        public string edefter_kebir_hash { get; set; }

        [StringLength(50)]
        public string edefter_kebir_zip_hash { get; set; }

        [StringLength(50)]
        public string edefter_kebir_berat_hash { get; set; }

        [StringLength(50)]
        public string edefter_kebir_berat_zip_hash { get; set; }

        public byte? edefter_maliyil_baslangic_ayi { get; set; }

        public bool? edefter_maliyil_takvim_bitisyili { get; set; }

        public byte? edefter_maliyil_baslangic_gunu { get; set; }

        [StringLength(40)]
        public string edefter_yevmiye_berat_id { get; set; }

        [StringLength(40)]
        public string edefter_kebir_berat_id { get; set; }
    }
}
