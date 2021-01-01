namespace HizliSatis.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Sepet")]
    public partial class Sepet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int sep_RECno { get; set; }

        
        public short sep_RECid_DBCno { get; set; }

        public int? sep_RECid_RECno { get; set; }

        public int? sep_SpecRECno { get; set; }

        public bool? sep_iptal { get; set; }

        public short? sep_fileid { get; set; }

        public bool? sep_hidden { get; set; }

        public bool? sep_kilitli { get; set; }

        public bool? sep_degisti { get; set; }

        public int? sep_checksum { get; set; }

        public short? sep_create_user { get; set; }

        public DateTime? sep_create_date { get; set; }

        public short? sep_lastup_user { get; set; }

        public DateTime? sep_lastup_date { get; set; }

        [StringLength(4)]
        public string sep_special1 { get; set; }

        [StringLength(4)]
        public string sep_special2 { get; set; }

        [StringLength(4)]
        public string sep_special3 { get; set; }

        public int? sep_firmano { get; set; }

        public int? sep_subeno { get; set; }

        public DateTime? sep_tarih { get; set; }

        public DateTime? sep_teslim_tarih { get; set; }

        public byte? sep_tip { get; set; }

        public byte? sep_cins { get; set; }

        [StringLength(6)]
        public string sep_evrakno_seri { get; set; }

        public int? sep_evrakno_sira { get; set; }

        public int? sep_satirno { get; set; }

        [StringLength(20)]
        public string sep_belgeno { get; set; }

        public DateTime? sep_belge_tarih { get; set; }

        [StringLength(25)]
        public string sep_satici_kod { get; set; }

        [StringLength(25)]
        public string sep_musteri_kod { get; set; }

        [StringLength(25)]
        public string sep_stok_kod { get; set; }

        public string sep_b_fiyat { get; set; }

        [StringLength(50)]
        public string sep_miktar { get; set; }

        public byte? sep_birim_pntr { get; set; }

        public double? sep_teslim_miktar { get; set; }

        public string sep_tutar { get; set; }

        public double? sep_iskonto_1 { get; set; }

        public double? sep_iskonto_2 { get; set; }

        public double? sep_iskonto_3 { get; set; }

        public double? sep_iskonto_4 { get; set; }

        public double? sep_iskonto_5 { get; set; }

        public double? sep_iskonto_6 { get; set; }

        public double? sep_masraf_1 { get; set; }

        public double? sep_masraf_2 { get; set; }

        public double? sep_masraf_3 { get; set; }

        public double? sep_masraf_4 { get; set; }

        public byte? sep_vergi_pntr { get; set; }

        [StringLength(50)]
        public string sep_vergi { get; set; }

        public byte? sep_masvergi_pntr { get; set; }

        public double? sep_masvergi { get; set; }

        public int? sep_opno { get; set; }

        [StringLength(50)]
        public string sep_aciklama { get; set; }

        [StringLength(50)]
        public string sep_aciklama2 { get; set; }

        public int? sep_depono { get; set; }

        public short? sep_OnaylayanKulNo { get; set; }

        public bool? sep_vergisiz_fl { get; set; }

        public bool? sep_kapat_fl { get; set; }

        public bool? sep_promosyon_fl { get; set; }

        [StringLength(25)]
        public string sep_cari_sormerk { get; set; }

        [StringLength(25)]
        public string sep_stok_sormerk { get; set; }

        public byte? sep_cari_grupno { get; set; }

        public byte? sep_doviz_cinsi { get; set; }

        public double? sep_doviz_kuru { get; set; }

        public double? sep_alt_doviz_kuru { get; set; }

        public int? sep_adresno { get; set; }

        [StringLength(4)]
        public string sep_teslimturu { get; set; }

        public bool? sep_cagrilabilir_fl { get; set; }

        public short? sep_proseprecDbId { get; set; }

        public int? sep_proseprecrecI { get; set; }

        public double? sep_iskonto1 { get; set; }

        public byte? sep_iskonto2 { get; set; }

        public byte? sep_iskonto3 { get; set; }

        public byte? sep_iskonto4 { get; set; }

        public byte? sep_iskonto5 { get; set; }

        public byte? sep_iskonto6 { get; set; }

        public byte? sep_masraf1 { get; set; }

        public byte? sep_masraf2 { get; set; }

        public byte? sep_masraf3 { get; set; }

        public byte? sep_masraf4 { get; set; }

        public bool? sep_isk1 { get; set; }

        public bool? sep_isk2 { get; set; }

        public bool? sep_isk3 { get; set; }

        public bool? sep_isk4 { get; set; }

        public bool? sep_isk5 { get; set; }

        public bool? sep_isk6 { get; set; }

        public bool? sep_mas1 { get; set; }

        public bool? sep_mas2 { get; set; }

        public bool? sep_mas3 { get; set; }

        public bool? sep_mas4 { get; set; }

        [StringLength(25)]
        public string sep_Exp_Imp_Kodu { get; set; }

        public double? sep_kar_orani { get; set; }

        public byte? sep_durumu { get; set; }

        public short? sep_stalRecId_DBCno { get; set; }

        public int? sep_stalRecId_RECno { get; set; }

        public double? sep_planlananmiktar { get; set; }

        public short? sep_teklifRecId_DBCno { get; set; }

        public int? sep_teklifRecId_RECno { get; set; }

        [StringLength(25)]
        public string sep_parti_kodu { get; set; }

        public int? sep_lot_no { get; set; }

        [StringLength(25)]
        public string sep_projekodu { get; set; }

        public int? sep_fiyat_liste_no { get; set; }

        public byte? sep_Otv_Pntr { get; set; }

        public double? sep_Otv_Vergi { get; set; }

        public double? sep_otvtutari { get; set; }

        public byte? sep_OtvVergisiz_Fl { get; set; }

        [StringLength(25)]
        public string sep_paket_kod { get; set; }

        public short? sep_RezRecId_DBCno { get; set; }

        public int? sep_RezRecId_RECno { get; set; }

        public byte? sep_harekettipi { get; set; }

        public short? sep_yetkili_recid_dbcno { get; set; }

        public int? sep_yetkili_recid_recno { get; set; }

        [StringLength(25)]
        public string sep_kapatmanedenkod { get; set; }

        public DateTime? sep_gecerlilik_tarihi { get; set; }

        public byte? sep_onodeme_evrak_tip { get; set; }

        [StringLength(6)]
        public string sep_onodeme_evrak_seri { get; set; }

        public int? sep_onodeme_evrak_sira { get; set; }

        public double? sep_rezervasyon_miktari { get; set; }

        public double? sep_rezerveden_teslim_edilen { get; set; }

        public string sep_urun_adi { get; set; }

        public string sep_user_name { get; set; }

        public string sep_birim_adi { get; set; }

        public int? sep_sepetno { get; set; }
        public string sep_urun_barkod_no { get; set; }
    }
}
