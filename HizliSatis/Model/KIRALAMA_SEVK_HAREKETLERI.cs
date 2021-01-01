namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KIRALAMA_SEVK_HAREKETLERI
    {
        [Key]
        public int ksvk_RECno { get; set; }

        public short ksvk_RECid_DBCno { get; set; }

        public int ksvk_RECid_RECno { get; set; }

        public int? ksvk_Spec_Rec_no { get; set; }

        public bool? ksvk_iptal { get; set; }

        public short? ksvk_fileid { get; set; }

        public bool? ksvk_hidden { get; set; }

        public bool? ksvk_kilitli { get; set; }

        public bool? ksvk_degisti { get; set; }

        public int? ksvk_checksum { get; set; }

        public short? ksvk_create_user { get; set; }

        public DateTime? ksvk_create_date { get; set; }

        public short? ksvk_lastup_user { get; set; }

        public DateTime? ksvk_lastup_date { get; set; }

        [StringLength(4)]
        public string ksvk_special1 { get; set; }

        [StringLength(4)]
        public string ksvk_special2 { get; set; }

        [StringLength(4)]
        public string ksvk_special3 { get; set; }

        public int? ksvk_firmano { get; set; }

        public int? ksvk_subeno { get; set; }

        public DateTime? ksvk_tarihi { get; set; }

        [StringLength(6)]
        public string ksvk_evrakno_seri { get; set; }

        public int? ksvk_evrakno_sira { get; set; }

        public int? ksvk_satirno { get; set; }

        [StringLength(20)]
        public string ksvk_belgeno { get; set; }

        public DateTime? ksvk_belge_tarihi { get; set; }

        [StringLength(25)]
        public string ksvk_cari_kodu { get; set; }

        public int? ksvk_adres_no { get; set; }

        [StringLength(25)]
        public string ksvk_kirakodu { get; set; }

        public byte? ksvk_giris_cikis { get; set; }

        public int? ksvk_depono { get; set; }

        [StringLength(25)]
        public string ksvk_nakliye_cari_kodu { get; set; }

        [StringLength(25)]
        public string ksvk_hareket_kodu { get; set; }

        [StringLength(25)]
        public string ksvk_seri_no { get; set; }

        public DateTime? ksvk_Sevktarihi { get; set; }

        [StringLength(60)]
        public string ksvk_satir_aciklama { get; set; }

        public short? ksvk_khar_recid_dbcno { get; set; }

        public int? ksvk_khar_recid_recno { get; set; }

        public int? ksvk_kmsayac { get; set; }

        public short? ksvk_sis_recid_dbcno { get; set; }

        public int? ksvk_sis_recid_recno { get; set; }
    }
}
