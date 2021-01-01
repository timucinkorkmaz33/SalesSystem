namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_HAREKET_MALIYET_DETAYLARI
    {
        [Key]
        public int shd_RECno { get; set; }

        public short shd_RECid_DBCno { get; set; }

        public int shd_RECid_RECno { get; set; }

        public int? shd_SpecRECno { get; set; }

        public bool? shd_iptal { get; set; }

        public short? shd_fileid { get; set; }

        public bool? shd_hidden { get; set; }

        public bool? shd_kilitli { get; set; }

        public bool? shd_degisti { get; set; }

        public int? shd_checksum { get; set; }

        public short? shd_create_user { get; set; }

        public DateTime? shd_create_date { get; set; }

        public short? shd_lastup_user { get; set; }

        public DateTime? shd_lastup_date { get; set; }

        [StringLength(4)]
        public string shd_special1 { get; set; }

        [StringLength(4)]
        public string shd_special2 { get; set; }

        [StringLength(4)]
        public string shd_special3 { get; set; }

        public byte? shd_tipi { get; set; }

        [StringLength(25)]
        public string shd_hesap_kodu { get; set; }

        [StringLength(25)]
        public string shd_srm_merkezi { get; set; }

        public double? shd_yuklenen_maliyet_ana { get; set; }

        public double? shd_yuklenen_maliyet_alt { get; set; }

        public double? shd_yuklenen_maliyet_orj { get; set; }

        public int? shd_stok_hareket_recno { get; set; }

        public int? shd_tuketim_stok_giris_recno { get; set; }

        public double? shd_tuketim_stok_miktari { get; set; }
    }
}
