namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YUKLEME_KABUL_DETAY
    {
        [Key]
        public int ykd_RECno { get; set; }

        public short ykd_RECid_DBCno { get; set; }

        public int ykd_RECid_RECno { get; set; }

        public int? ykd_SpecRECno { get; set; }

        public bool? ykd_iptal { get; set; }

        public short? ykd_fileid { get; set; }

        public bool? ykd_hidden { get; set; }

        public bool? ykd_kilitli { get; set; }

        public bool? ykd_degisti { get; set; }

        public int? ykd_checksum { get; set; }

        public short? ykd_create_user { get; set; }

        public DateTime? ykd_create_date { get; set; }

        public short? ykd_lastup_user { get; set; }

        public DateTime? ykd_lastup_date { get; set; }

        [StringLength(4)]
        public string ykd_special1 { get; set; }

        [StringLength(4)]
        public string ykd_special2 { get; set; }

        [StringLength(4)]
        public string ykd_special3 { get; set; }

        public byte? ykd_tipi { get; set; }

        [StringLength(25)]
        public string ykd_yukleme_kabul_kodu { get; set; }

        public short? ykd_siparis_RecId_DBCno { get; set; }

        public int? ykd_siparis_RecId_RECno { get; set; }

        public double? ykd_miktar { get; set; }

        [StringLength(25)]
        public string ykd_parti_kodu { get; set; }

        public int? ykd_lot_no { get; set; }

        [StringLength(127)]
        public string ykd_aciklama { get; set; }

        public int? ykd_onaylayan_kullanici { get; set; }

        public byte? ykd_durumu { get; set; }

        public int? ykd_depono { get; set; }

        public double? ykd_teslim_miktar { get; set; }

        public int? ykd_sirano { get; set; }
    }
}
