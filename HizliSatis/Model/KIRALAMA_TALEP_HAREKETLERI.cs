namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_TALEP_HAREKETLERI
    {
        [Key]
        public int ktlp_RECno { get; set; }

        public short ktlp_RECid_DBCno { get; set; }

        public int ktlp_RECid_RECno { get; set; }

        public int? ktlp_Spec_Rec_no { get; set; }

        public bool? ktlp_iptal { get; set; }

        public short? ktlp_fileid { get; set; }

        public bool? ktlp_hidden { get; set; }

        public bool? ktlp_kilitli { get; set; }

        public bool? ktlp_degisti { get; set; }

        public int? ktlp_checksum { get; set; }

        public short? ktlp_create_user { get; set; }

        public DateTime? ktlp_create_date { get; set; }

        public short? ktlp_lastup_user { get; set; }

        public DateTime? ktlp_lastup_date { get; set; }

        [StringLength(4)]
        public string ktlp_special1 { get; set; }

        [StringLength(4)]
        public string ktlp_special2 { get; set; }

        [StringLength(4)]
        public string ktlp_special3 { get; set; }

        public int? ktlp_firmano { get; set; }

        public int? ktlp_subeno { get; set; }

        public DateTime? ktlp_tarihi { get; set; }

        [StringLength(6)]
        public string ktlp_evrakno_seri { get; set; }

        public int? ktlp_evrakno_sira { get; set; }

        public int? ktlp_satirno { get; set; }

        [StringLength(20)]
        public string ktlp_belgeno { get; set; }

        public DateTime? ktlp_belge_tarihi { get; set; }

        [StringLength(25)]
        public string ktlp_cari_kodu { get; set; }

        public byte? ktlp_talep_gelis_sekli { get; set; }

        [StringLength(60)]
        public string ktlp_aciklama { get; set; }

        public int? ktlp_adres_no { get; set; }

        [StringLength(25)]
        public string ktlp_temsilci_kodu { get; set; }

        public short? ktlp_yetkili_recid_dbcno { get; set; }

        public int? ktlp_yetkili_recid_recno { get; set; }

        public byte? ktlp_hareket_tipi { get; set; }

        [StringLength(25)]
        public string ktlp_hareket_kodu { get; set; }

        [StringLength(60)]
        public string ktlp_satir_aciklama { get; set; }

        public int? ktlp_kiralama_suresi { get; set; }

        public int? ktlp_miktari { get; set; }

        public byte? ktlp_talep_durumu { get; set; }

        [StringLength(25)]
        public string ktlp_kapama_nedeni_kodu { get; set; }

        public byte? ktlp_sip_tip { get; set; }

        public short? ktlp_sip_recid_dbcno { get; set; }

        public int? ktlp_sip_recid_recno { get; set; }

        public short? ktlp_onaylayan_kul_no { get; set; }

        public bool? ktlp_cagrilabilir_fl { get; set; }
    }
}
