namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_PERFORMANS_KRITERLERI
    {
        [Key]
        public int cpk_RECno { get; set; }

        public short cpk_RECid_DBCno { get; set; }

        public int cpk_RECid_RECno { get; set; }

        public int? cpk_SpecRECno { get; set; }

        public bool? cpk_iptal { get; set; }

        public short? cpk_fileid { get; set; }

        public bool? cpk_hidden { get; set; }

        public bool? cpk_kilitli { get; set; }

        public bool? cpk_degisti { get; set; }

        public int? cpk_checksum { get; set; }

        public short? cpk_create_user { get; set; }

        public DateTime? cpk_create_date { get; set; }

        public short? cpk_lastup_user { get; set; }

        public DateTime? cpk_lastup_date { get; set; }

        [StringLength(4)]
        public string cpk_special1 { get; set; }

        [StringLength(4)]
        public string cpk_special2 { get; set; }

        [StringLength(4)]
        public string cpk_special3 { get; set; }

        [StringLength(25)]
        public string cpk_kodu { get; set; }

        [StringLength(40)]
        public string cpk_adi { get; set; }

        [StringLength(50)]
        public string cpk_aciklama1 { get; set; }

        [StringLength(50)]
        public string cpk_aciklama2 { get; set; }

        public byte? cpk_aktif { get; set; }

        public double? cpk_maxpuan { get; set; }

        public double? cpk_toplamdakipayi { get; set; }

        [StringLength(127)]
        public string cpk_sozelpuanlar { get; set; }

        public byte? cpk_otoveritipi { get; set; }
    }
}
