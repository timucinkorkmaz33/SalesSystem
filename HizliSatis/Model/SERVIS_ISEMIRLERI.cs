namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVIS_ISEMIRLERI
    {
        [Key]
        public int sis_RECno { get; set; }

        public short sis_RECid_DBCno { get; set; }

        public int sis_RECid_RECno { get; set; }

        public int? sis_SpecRECNo { get; set; }

        public bool? sis_iptal { get; set; }

        public short? sis_fileid { get; set; }

        public bool? sis_hidden { get; set; }

        public bool? sis_kilitli { get; set; }

        public bool? sis_degisti { get; set; }

        public int? sis_CheckSum { get; set; }

        public short? sis_create_user { get; set; }

        public DateTime? sis_create_date { get; set; }

        public short? sis_lastup_user { get; set; }

        public DateTime? sis_lastup_date { get; set; }

        [StringLength(4)]
        public string sis_special1 { get; set; }

        [StringLength(4)]
        public string sis_special2 { get; set; }

        [StringLength(4)]
        public string sis_special3 { get; set; }

        [StringLength(25)]
        public string sis_kodu { get; set; }

        [StringLength(50)]
        public string sis_adi { get; set; }

        public DateTime? sis_tarih { get; set; }

        [StringLength(25)]
        public string sis_tuketici_kodu { get; set; }

        [StringLength(25)]
        public string sis_cihaz_serino { get; set; }

        [StringLength(25)]
        public string sis_stok_kodu { get; set; }

        public DateTime? sis_servis_tarihi { get; set; }

        public DateTime? sis_servis_bitis_tarihi { get; set; }

        [StringLength(50)]
        public string sis_yetkili { get; set; }

        public byte? sis_servis_yeri { get; set; }

        public byte? sis_servis_turu { get; set; }

        public byte? sis_istek_gelis_sekli { get; set; }

        public DateTime? sis_isemri_kapanis_tarihi { get; set; }

        public byte? sis_ariza_tespiti_yapan_tipi { get; set; }

        [StringLength(25)]
        public string sis_ariza_tespiti_yapan_ekip { get; set; }

        public byte? sis_ise_atanan_tipi { get; set; }

        [StringLength(25)]
        public string sis_ise_atanan_ekip { get; set; }

        public byte? sis_isi_yapan_tipi { get; set; }

        [StringLength(25)]
        public string sis_isi_yapan_ekip { get; set; }

        public byte? sis_isemri_durumu { get; set; }

        [StringLength(6)]
        public string sis_bakim_kabul_evrak_seri { get; set; }

        public int? sis_bakim_kabul_evrak_sira { get; set; }

        public DateTime? sis_incelemede_tarihi { get; set; }

        public DateTime? sis_onay_bekliyor_tarihi { get; set; }

        public DateTime? sis_onaylandi_tarihi { get; set; }

        public DateTime? sis_servise_alindi_tarihi { get; set; }

        public DateTime? sis_tamamlandi_tarihi { get; set; }

        public DateTime? sis_kapatildi_tarihi { get; set; }

        public DateTime? sis_iptal_edildi_tarihi { get; set; }

        [StringLength(70)]
        public string sis_incelemede_aciklama { get; set; }

        [StringLength(70)]
        public string sis_onay_bekliyor_aciklama { get; set; }

        [StringLength(70)]
        public string sis_onaylandi_aciklama { get; set; }

        [StringLength(70)]
        public string sis_servise_alindi_aciklama { get; set; }

        [StringLength(70)]
        public string sis_tamamlandi_aciklama { get; set; }

        [StringLength(70)]
        public string sis_kapatildi_aciklama { get; set; }

        [StringLength(70)]
        public string sis_iptal_edildi_aciklama { get; set; }

        [StringLength(25)]
        public string sis_isemri_iptal_nedeni { get; set; }

        [StringLength(70)]
        public string sis_aciklama1 { get; set; }

        [StringLength(70)]
        public string sis_aciklama2 { get; set; }

        [StringLength(70)]
        public string sis_aciklama3 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu1 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu2 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu3 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu4 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu5 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu6 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu7 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu8 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu9 { get; set; }

        [StringLength(25)]
        public string sis_ariza_kodu10 { get; set; }

        public int? sis_kiralamadan_dusulecek_sure { get; set; }

        public int? sis_kiralamadan_dusulen_sure { get; set; }

        public byte? sis_servis_islem_turu { get; set; }

        public byte? sis_kaynak_evrak_tipi { get; set; }

        public short? sis_ktlp_recid_dbcno { get; set; }

        public int? sis_ktlp_recid_recno { get; set; }

        public int? sis_adres_no { get; set; }
    }
}
