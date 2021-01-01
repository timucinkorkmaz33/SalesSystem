namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PUAN_HEDIYE_CEKI_HAREKETLERI
    {
        [Key]
        public int phc_RECno { get; set; }

        public short phc_RECid_DBCno { get; set; }

        public int phc_RECid_RECno { get; set; }

        public int? phc_Spec_Rec_no { get; set; }

        public bool? phc_iptal { get; set; }

        public short? phc_fileid { get; set; }

        public bool? phc_hidden { get; set; }

        public bool? phc_kilitli { get; set; }

        public bool? phc_degisti { get; set; }

        public int? phc_checksum { get; set; }

        public short? phc_create_user { get; set; }

        public DateTime? phc_create_date { get; set; }

        public short? phc_lastup_user { get; set; }

        public DateTime? phc_lastup_date { get; set; }

        [StringLength(4)]
        public string phc_special1 { get; set; }

        [StringLength(4)]
        public string phc_special2 { get; set; }

        [StringLength(4)]
        public string phc_special3 { get; set; }

        public int? phc_firmano { get; set; }

        public int? phc_subeno { get; set; }

        public byte? phc_EvrTip { get; set; }

        [StringLength(6)]
        public string phc_evrakno_seri { get; set; }

        public int? phc_evrakno_sira { get; set; }

        public int? phc_satir_no { get; set; }

        public byte? phc_puanhcek_tipi { get; set; }

        [StringLength(25)]
        public string phc_puanhcek_kodu { get; set; }

        [StringLength(25)]
        public string phc_hcek_seri_no { get; set; }

        [StringLength(25)]
        public string phc_cari_kodu { get; set; }

        public DateTime? phc_tarih { get; set; }

        public int? phc_DepoNo { get; set; }

        public byte? phc_hareket_tipi { get; set; }

        public DateTime? phc_ilk_kullanim_tarih { get; set; }

        public DateTime? phc_son_kullanim_tarih { get; set; }

        public double? phc_miktari { get; set; }

        public double? phc_tutari { get; set; }

        public short? phc_KaynakTablo { get; set; }

        public byte? phc_Kaynak_evraktip { get; set; }

        [StringLength(6)]
        public string phc_Kaynak_evrakno_seri { get; set; }

        public int? phc_Kaynak_evrakno_sira { get; set; }

        public int? phc_Kaynak_evrak_satirno { get; set; }

        [StringLength(25)]
        public string phc_Kaynak_promosyon { get; set; }

        [StringLength(20)]
        public string phc_belge_no { get; set; }

        public DateTime? phc_belge_tarih { get; set; }

        [StringLength(25)]
        public string phc_Plasiyer { get; set; }

        [StringLength(50)]
        public string phc_Aciklama { get; set; }

        [StringLength(25)]
        public string phc_ProvizyonID { get; set; }
    }
}
