namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_TEKLIF_REVIZYONLARI
    {
        [Key]
        public int ktrv_RECno { get; set; }

        public short ktrv_RECid_DBCno { get; set; }

        public int ktrv_RECid_RECno { get; set; }

        public int? ktrv_Spec_Rec_no { get; set; }

        public bool? ktrv_iptal { get; set; }

        public short? ktrv_fileid { get; set; }

        public bool? ktrv_hidden { get; set; }

        public bool? ktrv_kilitli { get; set; }

        public bool? ktrv_degisti { get; set; }

        public int? ktrv_checksum { get; set; }

        public short? ktrv_create_user { get; set; }

        public DateTime? ktrv_create_date { get; set; }

        public short? ktrv_lastup_user { get; set; }

        public DateTime? ktrv_lastup_date { get; set; }

        [StringLength(4)]
        public string ktrv_special1 { get; set; }

        [StringLength(4)]
        public string ktrv_special2 { get; set; }

        [StringLength(4)]
        public string ktrv_special3 { get; set; }

        public int? ktrv_firmano { get; set; }

        public int? ktrv_subeno { get; set; }

        public DateTime? ktrv_tarihi { get; set; }

        [StringLength(6)]
        public string ktrv_evrakno_seri { get; set; }

        public int? ktrv_evrakno_sira { get; set; }

        public int? ktrv_revizyonno { get; set; }

        public int? ktrv_satirno { get; set; }

        public byte? ktrv_hareket_tipi { get; set; }

        [StringLength(25)]
        public string ktrv_hareket_kodu { get; set; }

        [StringLength(25)]
        public string ktrv_seri_no { get; set; }

        public int? ktrv_kiralama_suresi { get; set; }

        public int? ktrv_miktari { get; set; }

        public double? ktrv_gunluk_liste_fiyati { get; set; }

        public double? ktrv_haftalik_liste_fiyati { get; set; }

        public double? ktrv_aylik_liste_fiyati { get; set; }

        public double? ktrv_isktutari { get; set; }

        public double? ktrv_tutar { get; set; }

        [StringLength(60)]
        public string ktrv_satir_aciklama { get; set; }

        public short? ktrv_ktlp_recid_dbcno { get; set; }

        public int? ktrv_ktlp_recid_recno { get; set; }
    }
}
