namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALINAN_TEKLIFLER
    {
        [Key]
        public int altkl_RECno { get; set; }

        public short altkl_RECid_DBCno { get; set; }

        public int altkl_RECid_RECno { get; set; }

        public int? altkl_SpecRECno { get; set; }

        public bool? altkl_iptal { get; set; }

        public short? altkl_fileid { get; set; }

        public bool? altkl_hidden { get; set; }

        public bool? altkl_kilitli { get; set; }

        public bool? altkl_degisti { get; set; }

        public int? altkl_checksum { get; set; }

        public short? altkl_create_user { get; set; }

        public DateTime? altkl_create_date { get; set; }

        public short? altkl_lastup_user { get; set; }

        public DateTime? altkl_lastup_date { get; set; }

        [StringLength(4)]
        public string altkl_special1 { get; set; }

        [StringLength(4)]
        public string altkl_special2 { get; set; }

        [StringLength(4)]
        public string altkl_special3 { get; set; }

        public int? altkl_firmano { get; set; }

        public int? altkl_subeno { get; set; }

        [StringLength(25)]
        public string altkl_teklif_kodu { get; set; }

        public int? altkl_sira_no { get; set; }

        public int? altkl_satirno { get; set; }

        public DateTime? altkl_tarihi { get; set; }

        [StringLength(20)]
        public string altkl_belge_no { get; set; }

        public DateTime? altkl_belge_tarih { get; set; }

        [StringLength(25)]
        public string altkl_cari_kodu { get; set; }

        public int? altkl_cari_adres_no { get; set; }

        public short? altkl_cari_yetkili_recid_dbcno { get; set; }

        public int? altkl_cari_yetkili_recid_recno { get; set; }

        public DateTime? altkl_teslimat_tarihi { get; set; }

        public int? altkl_odeme_plani { get; set; }

        [StringLength(4)]
        public string altkl_teslim_turu { get; set; }

        [StringLength(25)]
        public string altkl_proje_kodu { get; set; }

        [StringLength(25)]
        public string altkl_srmmrk_kodu { get; set; }

        [StringLength(25)]
        public string altkl_sorumlu_kodu { get; set; }

        public byte? altkl_hareket_tipi { get; set; }

        [StringLength(25)]
        public string altkl_hareket_kodu { get; set; }

        public double? altkl_miktar { get; set; }

        public double? altkl_birim_fiyati { get; set; }

        public double? altkl_tutar { get; set; }

        public byte? altkl_doviz_cins { get; set; }

        public double? altkl_doviz_kur { get; set; }

        public double? altkl_alt_doviz_kur { get; set; }

        public double? altkl_iskonto1 { get; set; }

        public double? altkl_iskonto2 { get; set; }

        public double? altkl_iskonto3 { get; set; }

        public double? altkl_iskonto4 { get; set; }

        public double? altkl_iskonto5 { get; set; }

        public double? altkl_iskonto6 { get; set; }

        public double? altkl_masraf1 { get; set; }

        public double? altkl_masraf2 { get; set; }

        public double? altkl_masraf3 { get; set; }

        public double? altkl_masraf4 { get; set; }

        public byte? altkl_vergi_pntr { get; set; }

        public double? altkl_vergi { get; set; }

        public byte? altkl_masraf_vergi_pnt { get; set; }

        public double? altkl_masraf_vergi { get; set; }

        public byte? altkl_isk_mas1 { get; set; }

        public byte? altkl_isk_mas2 { get; set; }

        public byte? altkl_isk_mas3 { get; set; }

        public byte? altkl_isk_mas4 { get; set; }

        public byte? altkl_isk_mas5 { get; set; }

        public byte? altkl_isk_mas6 { get; set; }

        public byte? altkl_isk_mas7 { get; set; }

        public byte? altkl_isk_mas8 { get; set; }

        public byte? altkl_isk_mas9 { get; set; }

        public byte? altkl_isk_mas10 { get; set; }

        public bool? altkl_sat_iskmas1 { get; set; }

        public bool? altkl_sat_iskmas2 { get; set; }

        public bool? altkl_sat_iskmas3 { get; set; }

        public bool? altkl_sat_iskmas4 { get; set; }

        public bool? altkl_sat_iskmas5 { get; set; }

        public bool? altkl_sat_iskmas6 { get; set; }

        public bool? altkl_sat_iskmas7 { get; set; }

        public bool? altkl_sat_iskmas8 { get; set; }

        public bool? altkl_sat_iskmas9 { get; set; }

        public bool? altkl_sat_iskmas10 { get; set; }

        public bool? altkl_vergisiz_fl { get; set; }

        public int? altkl_fiyat_liste_no { get; set; }

        [StringLength(25)]
        public string altkl_paket_kod { get; set; }

        public int? altkl_teslimdepo { get; set; }

        [StringLength(50)]
        public string altkl_aciklama { get; set; }

        public short? altkl_onaylayan_kullanici { get; set; }

        public byte? altkl_durumu { get; set; }

        public short? altkl_satal_talep_RecId_DBCno { get; set; }

        public int? altkl_satal_talep_RecId_RECno { get; set; }

        public short? altkl_siparis_RecId_DBCno { get; set; }

        public int? altkl_siparis_RecId_RECno { get; set; }

        public short? altkl_prosiparis_RecId_DBCno { get; set; }

        public int? altkl_prosiparis_RecId_RECno { get; set; }
    }
}
