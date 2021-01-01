namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZIYARET_HAREKETLERI
    {
        [Key]
        public int zyrt_RECno { get; set; }

        public short zyrt_RECid_DBCno { get; set; }

        public int zyrt_RECid_RECno { get; set; }

        public int? zyrt_Spec_Rec_no { get; set; }

        public bool? zyrt_iptal { get; set; }

        public short? zyrt_fileid { get; set; }

        public bool? zyrt_hidden { get; set; }

        public bool? zyrt_kilitli { get; set; }

        public bool? zyrt_degisti { get; set; }

        public int? zyrt_checksum { get; set; }

        public short? zyrt_create_user { get; set; }

        public DateTime? zyrt_create_date { get; set; }

        public short? zyrt_lastup_user { get; set; }

        public DateTime? zyrt_lastup_date { get; set; }

        [StringLength(4)]
        public string zyrt_special1 { get; set; }

        [StringLength(4)]
        public string zyrt_special2 { get; set; }

        [StringLength(4)]
        public string zyrt_special3 { get; set; }

        public int? zyrt_firmano { get; set; }

        public int? zyrt_subeno { get; set; }

        public DateTime? zyrt_bas_zamani { get; set; }

        public DateTime? zyrt_bit_zamani { get; set; }

        [StringLength(25)]
        public string zyrt_CariKodu { get; set; }

        [StringLength(25)]
        public string zyrt_PersonelKodu { get; set; }

        public bool? zyrt_tamamlandi_fl { get; set; }

        public int? zyrt_AdresNo { get; set; }

        [StringLength(30)]
        public string zyrt_Yetkili_ismi { get; set; }

        [StringLength(50)]
        public string zyrt_Aciklama { get; set; }

        [StringLength(25)]
        public string zyrt_kodu { get; set; }

        [StringLength(25)]
        public string zyrt_Sor_MrkKodu { get; set; }

        [StringLength(25)]
        public string zyrt_ProjeKodu { get; set; }

        [StringLength(6)]
        public string zyrt_bkm_evrak_seri { get; set; }

        public int? zyrt_bkm_evrak_sira { get; set; }
    }
}
