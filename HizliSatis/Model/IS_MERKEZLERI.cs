namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IS_MERKEZLERI
    {
        [Key]
        public int IsM_RECno { get; set; }

        public short IsM_RECid_DBCno { get; set; }

        public int IsM_RECid_RECno { get; set; }

        public int? IsM_SpecRECNo { get; set; }

        public bool? IsM_iptal { get; set; }

        public short? IsM_fileid { get; set; }

        public bool? IsM_hidden { get; set; }

        public bool? IsM_kilitli { get; set; }

        public bool? IsM_degisti { get; set; }

        public int? IsM_CheckSum { get; set; }

        public short? IsM_create_user { get; set; }

        public DateTime? IsM_create_date { get; set; }

        public short? IsM_lastup_user { get; set; }

        public DateTime? IsM_lastup_date { get; set; }

        [StringLength(4)]
        public string IsM_special1 { get; set; }

        [StringLength(4)]
        public string IsM_special2 { get; set; }

        [StringLength(4)]
        public string IsM_special3 { get; set; }

        [StringLength(25)]
        public string IsM_Kodu { get; set; }

        [StringLength(40)]
        public string IsM_Aciklama { get; set; }

        [StringLength(4)]
        public string IsM_GrupKodu1 { get; set; }

        [StringLength(4)]
        public string IsM_GrupKodu2 { get; set; }

        [StringLength(4)]
        public string IsM_GrupKodu3 { get; set; }

        [StringLength(4)]
        public string IsM_GrupKodu4 { get; set; }

        [StringLength(4)]
        public string IsM_GrupKodu5 { get; set; }

        public byte? IsM_CalisanSayisi { get; set; }

        [StringLength(25)]
        public string IsM_MakinaKodu { get; set; }

        [StringLength(25)]
        public string IsM_Smkodu { get; set; }

        [StringLength(4)]
        public string IsM_TakvimKodu { get; set; }

        public bool? IsM_CokluIsEmri_fl { get; set; }

        public double? IsM_Kapasitesi { get; set; }

        [StringLength(10)]
        public string IsM_KapasiteBirimi { get; set; }

        public double? IsM_Hizi { get; set; }

        [StringLength(10)]
        public string IsM_HizBirimi { get; set; }

        [StringLength(10)]
        public string IsM_HizZamanBirimi { get; set; }

        public byte? IsM_ZamanPlanlamasiYapilacak { get; set; }

        public int? IsM_Renk { get; set; }
    }
}
