namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAKIM_HAREKETLERI
    {
        [Key]
        public int bkm_RECno { get; set; }

        public short bkm_RECid_DBCno { get; set; }

        public int bkm_RECid_RECno { get; set; }

        public int? bkm_Spec_Rec_no { get; set; }

        public bool? bkm_iptal { get; set; }

        public short? bkm_fileid { get; set; }

        public bool? bkm_hidden { get; set; }

        public bool? bkm_kilitli { get; set; }

        public bool? bkm_degisti { get; set; }

        public int? bkm_checksum { get; set; }

        public short? bkm_create_user { get; set; }

        public DateTime? bkm_create_date { get; set; }

        public short? bkm_lastup_user { get; set; }

        public DateTime? bkm_lastup_date { get; set; }

        [StringLength(4)]
        public string bkm_special1 { get; set; }

        [StringLength(4)]
        public string bkm_special2 { get; set; }

        [StringLength(4)]
        public string bkm_special3 { get; set; }

        public int? bkm_firmano { get; set; }

        public int? bkm_subeno { get; set; }

        public DateTime? bkm_tarihi { get; set; }

        [StringLength(6)]
        public string bkm_evrakno_seri { get; set; }

        public int? bkm_evrakno_sira { get; set; }

        public int? bkm_satirno { get; set; }

        [StringLength(20)]
        public string bkm_belgeno { get; set; }

        public DateTime? bkm_belge_tarihi { get; set; }

        [StringLength(25)]
        public string bkm_tuketici_kodu { get; set; }

        [StringLength(25)]
        public string bkm_cihaz_serino { get; set; }

        [StringLength(25)]
        public string bkm_fis_stok_kodu { get; set; }

        public DateTime? bkm_teslim_alinma_tarihi { get; set; }

        public DateTime? bkm_teslim_edilme_tarihi { get; set; }

        public byte? bkm_teslim_edilme_sekli { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu1 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu2 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu3 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu4 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu5 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu6 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu7 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu8 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu9 { get; set; }

        [StringLength(25)]
        public string bkm_ariza_kodu10 { get; set; }

        [StringLength(25)]
        public string bkm_ekip_kodu { get; set; }

        public int? bkm_depono { get; set; }

        [StringLength(80)]
        public string bkm_aciklama { get; set; }

        public byte? bkm_hareket_tipi { get; set; }

        [StringLength(25)]
        public string bkm_stok_hizmet_kodu { get; set; }

        public double? bkm_miktari { get; set; }

        public double? bkm_birim_fiyati { get; set; }

        public double? bkm_tutari { get; set; }

        public double? bkm_iskonto1 { get; set; }

        public double? bkm_iskonto2 { get; set; }

        public double? bkm_iskonto3 { get; set; }

        public double? bkm_iskonto4 { get; set; }

        public double? bkm_iskonto5 { get; set; }

        public double? bkm_iskonto6 { get; set; }

        public double? bkm_masraf1 { get; set; }

        public double? bkm_masraf2 { get; set; }

        public double? bkm_masraf3 { get; set; }

        public double? bkm_masraf4 { get; set; }

        public byte? bkm_vergi_pntr { get; set; }

        public double? bkm_vergi { get; set; }

        public byte? bkm_masraf_vergi_pnt { get; set; }

        public double? bkm_masraf_vergi { get; set; }

        public byte? bkm_isk_mas1 { get; set; }

        public byte? bkm_isk_mas2 { get; set; }

        public byte? bkm_isk_mas3 { get; set; }

        public byte? bkm_isk_mas4 { get; set; }

        public byte? bkm_isk_mas5 { get; set; }

        public byte? bkm_isk_mas6 { get; set; }

        public byte? bkm_isk_mas7 { get; set; }

        public byte? bkm_isk_mas8 { get; set; }

        public byte? bkm_isk_mas9 { get; set; }

        public byte? bkm_isk_mas10 { get; set; }

        public bool? bkm_sat_isk_mas1 { get; set; }

        public bool? bkm_sat_isk_mas2 { get; set; }

        public bool? bkm_sat_isk_mas3 { get; set; }

        public bool? bkm_sat_isk_mas4 { get; set; }

        public bool? bkm_sat_isk_mas5 { get; set; }

        public bool? bkm_sat_isk_mas6 { get; set; }

        public bool? bkm_sat_isk_mas7 { get; set; }

        public bool? bkm_sat_isk_mas8 { get; set; }

        public bool? bkm_sat_isk_mas9 { get; set; }

        public bool? bkm_sat_isk_mas10 { get; set; }

        public byte? bkm_doviz_cins { get; set; }

        public double? bkm_doviz_kur { get; set; }

        public double? bkm_alt_doviz_kur { get; set; }

        public bool? bkm_vergisiz_fl { get; set; }

        [StringLength(50)]
        public string bkm_satir_aciklama { get; set; }

        public bool? bkm_faturalandi_fl { get; set; }

        [StringLength(25)]
        public string bkm_ziyaret_kodu { get; set; }

        public DateTime? bkm_ziy_ac_tar { get; set; }

        public DateTime? bkm_ziy_cik_zmn { get; set; }

        public DateTime? bkm_ziy_bas_zmn { get; set; }

        public DateTime? bkm_ziy_son_zmn { get; set; }

        public DateTime? bkm_ziy_don_zmn { get; set; }

        public short? bkm_kabul_RECid_DBCno { get; set; }

        public int? bkm_kabul_RECid_RECno { get; set; }

        public short? bkm_isemri_RECid_DBCno { get; set; }

        public int? bkm_isemri_RECid_RECno { get; set; }

        public DateTime? bkm_cihazdurumbastarihi1 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi1 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu1 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu1 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi2 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi2 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu2 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu2 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi3 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi3 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu3 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu3 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi4 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi4 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu4 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu4 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi5 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi5 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu5 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu5 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi6 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi6 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu6 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu6 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi7 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi7 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu7 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu7 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi8 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi8 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu8 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu8 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi9 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi9 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu9 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu9 { get; set; }

        public DateTime? bkm_cihazdurumbastarihi10 { get; set; }

        public DateTime? bkm_cihazdurumbittarihi10 { get; set; }

        [StringLength(25)]
        public string bkm_cihazdurumkodu10 { get; set; }

        [StringLength(25)]
        public string bkm_cihazserviselemanikodu10 { get; set; }

        public int? bkm_fiyat_liste_no { get; set; }

        [StringLength(25)]
        public string bkm_parti_kodu { get; set; }

        public int? bkm_lot_no { get; set; }

        public byte? bkm_servis_turu { get; set; }

        [StringLength(25)]
        public string bkm_prj_kodu { get; set; }

        [StringLength(25)]
        public string bkm_srm_kodu { get; set; }

        public int? bkm_adres_no { get; set; }
    }
}
