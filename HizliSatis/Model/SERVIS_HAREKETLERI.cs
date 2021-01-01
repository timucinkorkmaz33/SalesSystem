namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVIS_HAREKETLERI
    {
        [Key]
        public int srvh_RECno { get; set; }

        public short srvh_RECid_DBCno { get; set; }

        public int srvh_RECid_RECno { get; set; }

        public int? srvh_SpecRECNo { get; set; }

        public bool? srvh_iptal { get; set; }

        public short? srvh_fileid { get; set; }

        public bool? srvh_hidden { get; set; }

        public bool? srvh_kilitli { get; set; }

        public bool? srvh_degisti { get; set; }

        public int? srvh_CheckSum { get; set; }

        public short? srvh_create_user { get; set; }

        public DateTime? srvh_create_date { get; set; }

        public short? srvh_lastup_user { get; set; }

        public DateTime? srvh_lastup_date { get; set; }

        [StringLength(4)]
        public string srvh_special1 { get; set; }

        [StringLength(4)]
        public string srvh_special2 { get; set; }

        [StringLength(4)]
        public string srvh_special3 { get; set; }

        public int? srvh_firmano { get; set; }

        public int? srvh_subeno { get; set; }

        [StringLength(6)]
        public string srvh_evrakno_seri { get; set; }

        public int? srvh_evrakno_sira { get; set; }

        [StringLength(20)]
        public string srvh_belgeno { get; set; }

        public DateTime? srvh_belge_tarih { get; set; }

        public short? srvh_isemri_recid_dbcno { get; set; }

        public int? srvh_isemri_recid_recno { get; set; }

        [StringLength(25)]
        public string srvh_referans_no { get; set; }

        public DateTime? srvh_tarih { get; set; }

        public short? srvh_yetkili_recid_dbcno { get; set; }

        public int? srvh_yetkili_recid_recno { get; set; }

        public int? srvh_calisma_saati { get; set; }

        [StringLength(120)]
        public string srvh_yapilan_islemler1 { get; set; }

        [StringLength(120)]
        public string srvh_yapilan_islemler2 { get; set; }

        [StringLength(120)]
        public string srvh_yapilan_islemler3 { get; set; }

        public DateTime? srvh_baslama_saati { get; set; }

        public DateTime? srvh_bitis_saati { get; set; }

        [StringLength(25)]
        public string srvh_arac_plaka { get; set; }

        public double? srvh_toplam_yol { get; set; }

        public int? srvh_satirno { get; set; }

        public byte? srvh_hareket_tipi { get; set; }

        [StringLength(25)]
        public string srvh_stok_hizmet_kodu { get; set; }

        [StringLength(40)]
        public string srvh_aciklama { get; set; }

        public double? srvh_miktari { get; set; }

        public byte? srvh_fatura_garanti_tipi { get; set; }

        public byte? srvh_durumu { get; set; }

        public int? srvh_depo_no { get; set; }

        [StringLength(25)]
        public string srvh_sormerk { get; set; }

        [StringLength(25)]
        public string srvh_projekodu { get; set; }

        public byte? srvh_doviz_cinsi { get; set; }

        public byte? srvh_sip_tip { get; set; }

        public short? srvh_sip_recid_dbcno { get; set; }

        public int? srvh_sip_recid_recno { get; set; }

        public byte? srvh_chz_mak_tipi { get; set; }

        public byte? srvh_ariza_tespiti_yapan_tipi { get; set; }

        [StringLength(25)]
        public string srvh_ariza_tespiti_yapan_ekip { get; set; }

        public byte? srvh_ise_atanan_tipi { get; set; }

        [StringLength(25)]
        public string srvh_ise_atanan_ekip { get; set; }

        public byte? srvh_isi_yapan_tipi { get; set; }

        [StringLength(25)]
        public string srvh_isi_yapan_ekip { get; set; }
    }
}
