namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KARGO_TANIMLARI
    {
        [Key]
        public int krg_RECno { get; set; }

        public short krg_RECid_DBCno { get; set; }

        public int krg_RECid_RECno { get; set; }

        public int? krg_SpecRECNo { get; set; }

        public bool? krg_iptal { get; set; }

        public short? krg_fileid { get; set; }

        public bool? krg_hidden { get; set; }

        public bool? krg_kilitli { get; set; }

        public bool? krg_degisti { get; set; }

        public int? krg_CheckSum { get; set; }

        public short? krg_create_user { get; set; }

        public DateTime? krg_create_date { get; set; }

        public short? krg_lastup_user { get; set; }

        public DateTime? krg_lastup_date { get; set; }

        [StringLength(4)]
        public string krg_special1 { get; set; }

        [StringLength(4)]
        public string krg_special2 { get; set; }

        [StringLength(4)]
        public string krg_special3 { get; set; }

        [StringLength(25)]
        public string krg_kodu { get; set; }

        [StringLength(50)]
        public string krg_adi { get; set; }

        public byte? krg_tipi { get; set; }

        [StringLength(30)]
        public string krg_yetkili { get; set; }

        [StringLength(15)]
        public string krg_tel { get; set; }

        [StringLength(15)]
        public string krg_fax { get; set; }

        [StringLength(50)]
        public string krg_email { get; set; }
    }
}
