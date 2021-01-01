namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PROFORMA_SIPARISLER
    {
        [Key]
        public int pro_RECno { get; set; }

        public short pro_RECid_DBCno { get; set; }

        public int pro_RECid_RECno { get; set; }

        public int? pro_SpecRecNo { get; set; }

        public bool? pro_iptal { get; set; }

        public short? pro_fileid { get; set; }

        public bool? pro_hidden { get; set; }

        public bool? pro_kilitli { get; set; }

        public bool? pro_degisti { get; set; }

        public int? pro_checksum { get; set; }

        public short? pro_create_user { get; set; }

        public DateTime? pro_create_date { get; set; }

        public short? pro_lastup_user { get; set; }

        public DateTime? pro_lastup_date { get; set; }

        [StringLength(4)]
        public string pro_special1 { get; set; }

        [StringLength(4)]
        public string pro_special2 { get; set; }

        [StringLength(4)]
        public string pro_special3 { get; set; }

        public int? pro_firmano { get; set; }

        public int? pro_subeno { get; set; }

        public DateTime? pro_tarihi { get; set; }

        public DateTime? pro_testarihi { get; set; }

        public byte? pro_tipi { get; set; }

        public byte? pro_cinsi { get; set; }

        [StringLength(6)]
        public string pro_evrakno_seri { get; set; }

        public int? pro_evrakno_sira { get; set; }

        public int? pro_satirno { get; set; }

        [StringLength(20)]
        public string pro_belge_no { get; set; }

        public DateTime? pro_belge_tarihi { get; set; }

        [StringLength(25)]
        public string pro_saticikodu { get; set; }

        [StringLength(25)]
        public string pro_mustkodu { get; set; }

        [StringLength(25)]
        public string pro_stokkodu { get; set; }

        public double? pro_bfiyati { get; set; }

        public double? pro_miktar { get; set; }

        public byte? pro_birim_pntr { get; set; }

        public double? pro_tesmiktari { get; set; }

        public double? pro_tutari { get; set; }

        public double? pro_iskonto1 { get; set; }

        public double? pro_iskonto2 { get; set; }

        public double? pro_iskonto3 { get; set; }

        public double? pro_iskonto4 { get; set; }

        public double? pro_iskonto5 { get; set; }

        public double? pro_iskonto6 { get; set; }

        public double? pro_masraf1 { get; set; }

        public double? pro_masraf2 { get; set; }

        public double? pro_masraf3 { get; set; }

        public double? pro_masraf4 { get; set; }

        public byte? pro_vergipntr { get; set; }

        public double? pro_vergi { get; set; }

        public byte? pro_masrafvergipntr { get; set; }

        public double? pro_masrafvergi { get; set; }

        public int? pro_opno { get; set; }

        [StringLength(50)]
        public string pro_aciklama { get; set; }

        [StringLength(50)]
        public string pro_aciklama2 { get; set; }

        public int? pro_depono { get; set; }

        public short? pro_onaylayanKul_no { get; set; }

        public bool? pro_vergisiz { get; set; }

        public bool? pro_kapat { get; set; }

        public bool? pro_promosyon_fl { get; set; }

        [StringLength(25)]
        public string pro_cari_sormerk { get; set; }

        [StringLength(25)]
        public string pro_stok_sormerk { get; set; }

        public byte? pro_cari_grupno { get; set; }

        public byte? pro_dovizcinsi { get; set; }

        public double? pro_dovizkuru { get; set; }

        public double? pro_altdovizkuru { get; set; }

        public int? pro_adresno { get; set; }

        [StringLength(4)]
        public string pro_teslimturu { get; set; }

        public bool? pro_cagrilabilir_fl { get; set; }

        public short? pro_sipDbID { get; set; }

        public int? pro_sipRecID { get; set; }

        public byte? pro_isk_mas_1 { get; set; }

        public byte? pro_isk_mas_2 { get; set; }

        public byte? pro_isk_mas_3 { get; set; }

        public byte? pro_isk_mas_4 { get; set; }

        public byte? pro_isk_mas_5 { get; set; }

        public byte? pro_isk_mas_6 { get; set; }

        public byte? pro_isk_mas_7 { get; set; }

        public byte? pro_isk_mas_8 { get; set; }

        public byte? pro_isk_mas_9 { get; set; }

        public byte? pro_isk_mas_10 { get; set; }

        public bool? pro_sat_isk_mas1 { get; set; }

        public bool? pro_sat_isk_mas2 { get; set; }

        public bool? pro_sat_isk_mas3 { get; set; }

        public bool? pro_sat_isk_mas4 { get; set; }

        public bool? pro_sat_isk_mas5 { get; set; }

        public bool? pro_sat_isk_mas6 { get; set; }

        public bool? pro_sat_isk_mas7 { get; set; }

        public bool? pro_sat_isk_mas8 { get; set; }

        public bool? pro_sat_isk_mas9 { get; set; }

        public bool? pro_sat_isk_mas10 { get; set; }

        [StringLength(25)]
        public string pro_Exp_Imp_Kodu { get; set; }

        public double? pro_karoani { get; set; }

        public byte? pro_durumu { get; set; }

        public short? pro_stalRecId_DBCno { get; set; }

        public int? pro_stalRecId_RECno { get; set; }

        public double? pro_planlananmiktar { get; set; }

        public short? pro_teklifRecId_DBCno { get; set; }

        public int? pro_teklifRecId_RECno { get; set; }

        [StringLength(25)]
        public string pro_parti_kodu { get; set; }

        public int? pro_lot_no { get; set; }

        [StringLength(25)]
        public string pro_projekodu { get; set; }

        public int? pro_fiyat_liste_no { get; set; }

        public byte? pro_Otv_Pntr { get; set; }

        public double? pro_Otv_Vergi { get; set; }

        public double? pro_otvtutari { get; set; }

        public byte? pro_OtvVergisiz_Fl { get; set; }

        [StringLength(25)]
        public string pro_paket_kod { get; set; }

        public short? pro_RezRecId_DBCno { get; set; }

        public int? pro_RezRecId_RECno { get; set; }

        public byte? pro_harekettipi { get; set; }

        public short? pro_yetkili_recid_dbcno { get; set; }

        public int? pro_yetkili_recid_recno { get; set; }

        [StringLength(25)]
        public string pro_kapatmanedenkod { get; set; }

        public DateTime? pro_gecerlilik_tarihi { get; set; }

        public byte? pro_onodeme_evrak_tip { get; set; }

        [StringLength(6)]
        public string pro_onodeme_evrak_seri { get; set; }

        public int? pro_onodeme_evrak_sira { get; set; }

        public double? pro_rezervasyon_miktari { get; set; }

        public double? pro_rezerveden_teslim_edilen { get; set; }
    }
}
