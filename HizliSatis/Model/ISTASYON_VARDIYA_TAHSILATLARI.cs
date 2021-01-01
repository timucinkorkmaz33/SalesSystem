namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_VARDIYA_TAHSILATLARI
    {
        [Key]
        public int vn_RECno { get; set; }

        public short vn_RECid_DBCno { get; set; }

        public int vn_RECid_RECno { get; set; }

        public int? vn_SpecRECno { get; set; }

        public bool? vn_iptal { get; set; }

        public short? vn_fileid { get; set; }

        public bool? vn_hidden { get; set; }

        public bool? vn_kilitli { get; set; }

        public bool? vn_degisti { get; set; }

        public int? vn_checksum { get; set; }

        public short? vn_create_user { get; set; }

        public DateTime? vn_create_date { get; set; }

        public short? vn_lastup_user { get; set; }

        public DateTime? vn_lastup_date { get; set; }

        [StringLength(4)]
        public string vn_special1 { get; set; }

        [StringLength(4)]
        public string vn_special2 { get; set; }

        [StringLength(4)]
        public string vn_special3 { get; set; }

        public int? vn_firmano { get; set; }

        public int? vn_subeno { get; set; }

        public byte? vn_vardiyahesaptip { get; set; }

        public DateTime? vn_Tarihi { get; set; }

        public byte? vn_Numarasi { get; set; }

        [StringLength(25)]
        public string vn_pers_kodu { get; set; }

        public int? vn_sira_no { get; set; }

        [StringLength(25)]
        public string vn_kasa_banka_kodu { get; set; }

        public byte? vn_Tahsilat_sekli { get; set; }

        public double? vn_Tutar { get; set; }

        public double? vn_Musteri_Komisyon { get; set; }

        public DateTime? vn_VadeTarihi { get; set; }
    }
}
