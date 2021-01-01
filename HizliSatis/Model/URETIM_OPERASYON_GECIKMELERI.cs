namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYON_GECIKMELERI
    {
        [Key]
        public int opg_RECno { get; set; }

        public short opg_RECid_DBCno { get; set; }

        public int opg_RECid_RECno { get; set; }

        public int? opg_SpecRECNo { get; set; }

        public bool? opg_iptal { get; set; }

        public short? opg_fileid { get; set; }

        public bool? opg_hidden { get; set; }

        public bool? opg_kilitli { get; set; }

        public bool? opg_degisti { get; set; }

        public int? opg_CheckSum { get; set; }

        public short? opg_create_user { get; set; }

        public DateTime? opg_create_date { get; set; }

        public short? opg_lastup_user { get; set; }

        public DateTime? opg_lastup_date { get; set; }

        [StringLength(4)]
        public string opg_special1 { get; set; }

        [StringLength(4)]
        public string opg_special2 { get; set; }

        [StringLength(4)]
        public string opg_special3 { get; set; }

        public short? opg_OpTamamRecID_DBCno { get; set; }

        public int? opg_OpTamamRecID_RECno { get; set; }

        [StringLength(25)]
        public string opg_GecikmeKodu { get; set; }

        public DateTime? opg_GecikmeBoslukBaslangici { get; set; }

        public DateTime? opg_GecikmeBoslukSonu { get; set; }

        public int? opg_GecikmeSuresi { get; set; }

        [StringLength(127)]
        public string opg_Aciklama { get; set; }
    }
}
