namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAKIM_KABUL_HAREKETLERI
    {
        [Key]
        public int bkmkb_RECno { get; set; }

        public short bkmkb_RECid_DBCno { get; set; }

        public int bkmkb_RECid_RECno { get; set; }

        public int? bkmkb_Spec_Rec_no { get; set; }

        public bool? bkmkb_iptal { get; set; }

        public short? bkmkb_fileid { get; set; }

        public bool? bkmkb_hidden { get; set; }

        public bool? bkmkb_kilitli { get; set; }

        public bool? bkmkb_degisti { get; set; }

        public int? bkmkb_checksum { get; set; }

        public short? bkmkb_create_user { get; set; }

        public DateTime? bkmkb_create_date { get; set; }

        public short? bkmkb_lastup_user { get; set; }

        public DateTime? bkmkb_lastup_date { get; set; }

        [StringLength(4)]
        public string bkmkb_special1 { get; set; }

        [StringLength(4)]
        public string bkmkb_special2 { get; set; }

        [StringLength(4)]
        public string bkmkb_special3 { get; set; }

        public int? bkmkb_firmano { get; set; }

        public int? bkmkb_subeno { get; set; }

        public DateTime? bkmkb_tarihi { get; set; }

        [StringLength(6)]
        public string bkmkb_evrakno_seri { get; set; }

        public int? bkmkb_evrakno_sira { get; set; }

        public int? bkmkb_satirno { get; set; }

        [StringLength(20)]
        public string bkmkb_belgeno { get; set; }

        public DateTime? bkmkb_belge_tarihi { get; set; }

        [StringLength(25)]
        public string bkmkb_cihaz_serino { get; set; }

        [StringLength(25)]
        public string bkmkb_fis_stok_kodu { get; set; }

        [StringLength(25)]
        public string bkmkb_tuketici_kodu { get; set; }

        public byte? bkmkb_talep_gelis_sekli { get; set; }

        [StringLength(25)]
        public string bkmkb_gelis_kargo_kodu { get; set; }

        [StringLength(18)]
        public string bkmkb_gelis_kargo_belgeno { get; set; }

        [StringLength(18)]
        public string bkmkb_gelis_irsaliyeno { get; set; }

        public byte? bkmkb_servis_turu { get; set; }

        public byte? bkmkb_servis_yeri { get; set; }

        [StringLength(92)]
        public string bkmkb_aksesuarlar { get; set; }

        [StringLength(92)]
        public string bkmkb_bildirilen_arizalar { get; set; }

        public DateTime? bkmkb_teslim_alinma_tarihi { get; set; }

        public DateTime? bkmkb_teslim_edilme_tarihi { get; set; }

        public byte? bkmkb_teslim_edilme_sekli { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu1 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu2 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu3 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu4 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu5 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu6 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu7 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu8 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu9 { get; set; }

        [StringLength(25)]
        public string bkmkb_ariza_kodu10 { get; set; }

        public byte? bkmkb_bilgilendirme_sekli { get; set; }

        [StringLength(25)]
        public string bkmkb_inceleyecek_ekip_kodu { get; set; }

        public int? bkmkb_depono { get; set; }

        [StringLength(80)]
        public string bkmkb_aciklama { get; set; }

        public byte? bkmkb_hareket_tipi { get; set; }

        [StringLength(25)]
        public string bkmkb_stok_hizmet_kodu { get; set; }

        public int? bkmkb_operasyon_suresi { get; set; }

        public double? bkmkb_miktari { get; set; }

        [StringLength(50)]
        public string bkmkb_satir_aciklama { get; set; }

        public bool? bkmkb_planlandi_fl { get; set; }

        public int? bkmkb_adres_no { get; set; }
    }
}
