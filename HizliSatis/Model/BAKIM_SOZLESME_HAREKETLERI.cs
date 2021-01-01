namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAKIM_SOZLESME_HAREKETLERI
    {
        [Key]
        public int bsoz_RECno { get; set; }

        public short bsoz_RECid_DBCno { get; set; }

        public int bsoz_RECid_RECno { get; set; }

        public int? bsoz_Spec_Rec_no { get; set; }

        public bool? bsoz_iptal { get; set; }

        public short? bsoz_fileid { get; set; }

        public bool? bsoz_hidden { get; set; }

        public bool? bsoz_kilitli { get; set; }

        public bool? bsoz_degisti { get; set; }

        public int? bsoz_checksum { get; set; }

        public short? bsoz_create_user { get; set; }

        public DateTime? bsoz_create_date { get; set; }

        public short? bsoz_lastup_user { get; set; }

        public DateTime? bsoz_lastup_date { get; set; }

        [StringLength(4)]
        public string bsoz_special1 { get; set; }

        [StringLength(4)]
        public string bsoz_special2 { get; set; }

        [StringLength(4)]
        public string bsoz_special3 { get; set; }

        public int? bsoz_firmano { get; set; }

        public int? bsoz_subeno { get; set; }

        public DateTime? bsoz_tarihi { get; set; }

        [StringLength(6)]
        public string bsoz_evrakno_seri { get; set; }

        public int? bsoz_evrakno_sira { get; set; }

        public int? bsoz_satirno { get; set; }

        [StringLength(20)]
        public string bsoz_belgeno { get; set; }

        public DateTime? bsoz_belge_tarihi { get; set; }

        [StringLength(25)]
        public string bsoz_cari_kodu { get; set; }

        public byte? bsoz_doviz_cinsi { get; set; }

        public DateTime? bsoz_baslangic_tarihi { get; set; }

        public DateTime? bsoz_bitis_tarihi { get; set; }

        public double? bsoz_iscilik_bedeli { get; set; }

        public double? bsoz_km_yol_bedeli { get; set; }

        public double? bsoz_kontrol_bedeli { get; set; }

        [StringLength(60)]
        public string bsoz_aciklama { get; set; }

        [StringLength(25)]
        public string bsoz_stok_kodu { get; set; }

        [StringLength(25)]
        public string bsoz_seri_no { get; set; }

        [StringLength(25)]
        public string bsoz_bakim_recete_kodu { get; set; }

        public double? bsoz_bakim_bedeli { get; set; }

        public byte? bsoz_bakim_peryodu { get; set; }

        public byte? bsoz_bakim_tipi { get; set; }
    }
}
