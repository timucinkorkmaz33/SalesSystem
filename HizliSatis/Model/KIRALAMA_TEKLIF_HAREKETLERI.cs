namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_TEKLIF_HAREKETLERI
    {
        [Key]
        public int ktkf_RECno { get; set; }

        public short ktkf_RECid_DBCno { get; set; }

        public int ktkf_RECid_RECno { get; set; }

        public int? ktkf_Spec_Rec_no { get; set; }

        public bool? ktkf_iptal { get; set; }

        public short? ktkf_fileid { get; set; }

        public bool? ktkf_hidden { get; set; }

        public bool? ktkf_kilitli { get; set; }

        public bool? ktkf_degisti { get; set; }

        public int? ktkf_checksum { get; set; }

        public short? ktkf_create_user { get; set; }

        public DateTime? ktkf_create_date { get; set; }

        public short? ktkf_lastup_user { get; set; }

        public DateTime? ktkf_lastup_date { get; set; }

        [StringLength(4)]
        public string ktkf_special1 { get; set; }

        [StringLength(4)]
        public string ktkf_special2 { get; set; }

        [StringLength(4)]
        public string ktkf_special3 { get; set; }

        public int? ktkf_firmano { get; set; }

        public int? ktkf_subeno { get; set; }

        public DateTime? ktkf_tarihi { get; set; }

        [StringLength(6)]
        public string ktkf_evrakno_seri { get; set; }

        public int? ktkf_evrakno_sira { get; set; }

        public int? ktkf_satirno { get; set; }

        public int? ktkf_revizyonno { get; set; }

        [StringLength(20)]
        public string ktkf_belgeno { get; set; }

        public DateTime? ktkf_belge_tarihi { get; set; }

        [StringLength(25)]
        public string ktkf_cari_kodu { get; set; }

        public byte? ktkf_doviz_cinsi { get; set; }

        [StringLength(60)]
        public string ktkf_aciklama { get; set; }

        public int? ktkf_adres_no { get; set; }

        public int? ktkf_depono { get; set; }

        [StringLength(25)]
        public string ktkf_temsilci_kodu { get; set; }

        public short? ktkf_yetkili_recid_dbcno { get; set; }

        public int? ktkf_yetkili_recid_recno { get; set; }

        public int? ktkf_opno { get; set; }

        public byte? ktkf_hareket_tipi { get; set; }

        [StringLength(25)]
        public string ktkf_hareket_kodu { get; set; }

        [StringLength(25)]
        public string ktkf_seri_no { get; set; }

        public int? ktkf_kiralama_suresi { get; set; }

        public int? ktkf_miktari { get; set; }

        public double? ktkf_gunluk_liste_fiyati { get; set; }

        public double? ktkf_haftalik_liste_fiyati { get; set; }

        public double? ktkf_aylik_liste_fiyati { get; set; }

        public double? ktkf_isktutari { get; set; }

        public double? ktkf_tutar { get; set; }

        [StringLength(60)]
        public string ktkf_satir_aciklama { get; set; }

        public short? ktkf_ktlp_recid_dbcno { get; set; }

        public int? ktkf_ktlp_recid_recno { get; set; }

        public byte? ktkf_teklif_durumu { get; set; }

        [StringLength(25)]
        public string ktkf_kapama_nedeni_kodu { get; set; }
    }
}
