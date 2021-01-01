namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_HAREKETLERI_EK
    {
        [Key]
        public int sthek_RECno { get; set; }

        public short sthek_RECid_DBCno { get; set; }

        public int sthek_RECid_RECno { get; set; }

        public int? sthek_SpecRECno { get; set; }

        public bool? sthek_iptal { get; set; }

        public short? sthek_fileid { get; set; }

        public bool? sthek_hidden { get; set; }

        public bool? sthek_kilitli { get; set; }

        public bool? sthek_degisti { get; set; }

        public int? sthek_checksum { get; set; }

        public short? sthek_create_user { get; set; }

        public DateTime? sthek_create_date { get; set; }

        public short? sthek_lastup_user { get; set; }

        public DateTime? sthek_lastup_date { get; set; }

        [StringLength(4)]
        public string sthek_special1 { get; set; }

        [StringLength(4)]
        public string sthek_special2 { get; set; }

        [StringLength(4)]
        public string sthek_special3 { get; set; }

        public short? sthek_related_DBCno { get; set; }

        public int? sthek_related_RECno { get; set; }

        public short? sth_subesip_recid_dbcno { get; set; }

        public int? sth_subesip_recid_recno { get; set; }

        public short? sth_bkm_recid_dbcno { get; set; }

        public int? sth_bkm_recid_recno { get; set; }

        public short? sth_karsikons_recid_dbcno { get; set; }

        public int? sth_karsikons_recid_recno { get; set; }

        public short? sth_rez_recid_dbcno { get; set; }

        public int? sth_rez_recid_recno { get; set; }

        public short? sth_optamam_recid_dbcno { get; set; }

        public int? sth_optamam_recid_recno { get; set; }

        public short? sth_iadeTlp_recid_dbcno { get; set; }

        public int? sth_iadeTlp_recid_recno { get; set; }

        public short? sth_HalSatisRecid_dbcno { get; set; }

        public int? sth_HalSatisRecid_recno { get; set; }

        public short? sth_ciroprim_dbcno { get; set; }

        public int? sth_ciroprim_recno { get; set; }

        [StringLength(6)]
        public string sth_iade_evrak_seri { get; set; }

        public int? sth_iade_evrak_sira { get; set; }

        [StringLength(25)]
        public string sth_yat_tes_kodu { get; set; }

        [StringLength(4)]
        public string sth_ihracat_kredi_kodu { get; set; }

        [StringLength(25)]
        public string sth_diib_belge_no { get; set; }

        public byte? sth_diib_satir_no { get; set; }

        public byte? sth_mensey_ulke_tipi { get; set; }

        [StringLength(4)]
        public string sth_mensey_ulke_kodu { get; set; }

        public double? sth_halrehmiktari { get; set; }

        public double? sth_halrehfiyati { get; set; }

        public double? sth_halsandikmiktari { get; set; }

        public double? sth_halsandikfiyati { get; set; }

        public double? sth_halsandikkdvtutari { get; set; }

        public double? sth_HalKomisyonuKdv { get; set; }

        public double? sth_HalRusum { get; set; }

        public byte? sth_satistipi { get; set; }

        public DateTime? sth_vardiya_tarihi { get; set; }

        public byte? sth_vardiya_no { get; set; }

        public double? sth_direkt_iscilik_1 { get; set; }

        public double? sth_direkt_iscilik_2 { get; set; }

        public double? sth_direkt_iscilik_3 { get; set; }

        public double? sth_direkt_iscilik_4 { get; set; }

        public double? sth_direkt_iscilik_5 { get; set; }

        public double? sth_genel_uretim_1 { get; set; }

        public double? sth_genel_uretim_2 { get; set; }

        public double? sth_genel_uretim_3 { get; set; }

        public double? sth_genel_uretim_4 { get; set; }

        public double? sth_genel_uretim_5 { get; set; }

        public DateTime? sth_fis_tarihi2 { get; set; }

        public int? sth_fis_sirano2 { get; set; }

        [StringLength(6)]
        public string sth_fiyfark_esas_evrak_seri { get; set; }

        public int? sth_fiyfark_esas_evrak_sira { get; set; }

        public int? sth_fiyfark_esas_satir_no { get; set; }

        [StringLength(5)]
        public string sth_istisna { get; set; }

        public byte? sth_otv_tevkifat_turu { get; set; }

        public double? sth_otv_tevkifat_tutari { get; set; }

        public short? sth_servishar_recid_dbcno { get; set; }

        public int? sth_servishar_recid_recno { get; set; }

        public short? sth_bakimsarf_recid_dbcno { get; set; }

        public int? sth_bakimsarf_recid_recno { get; set; }
    }
}
