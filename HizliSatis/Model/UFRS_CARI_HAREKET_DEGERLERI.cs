namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UFRS_CARI_HAREKET_DEGERLERI
    {
        [Key]
        public int uchd_RECno { get; set; }

        public short uchd_RECid_DBCno { get; set; }

        public int uchd_RECid_RECno { get; set; }

        public int? uchd_SpecRECno { get; set; }

        public bool? uchd_iptal { get; set; }

        public short? uchd_fileid { get; set; }

        public bool? uchd_hidden { get; set; }

        public bool? uchd_kilitli { get; set; }

        public bool? uchd_degisti { get; set; }

        public int? uchd_checksum { get; set; }

        public short? uchd_create_user { get; set; }

        public DateTime? uchd_create_date { get; set; }

        public short? uchd_lastup_user { get; set; }

        public DateTime? uchd_lastup_date { get; set; }

        [StringLength(4)]
        public string uchd_special1 { get; set; }

        [StringLength(4)]
        public string uchd_special2 { get; set; }

        [StringLength(4)]
        public string uchd_special3 { get; set; }

        public short? uchd_baglihar_dbcno { get; set; }

        public int? uchd_baglihar_recno { get; set; }

        public double? uchd_aratoplam { get; set; }

        public double? uchd_meblag { get; set; }

        public double? uchd_iskonto1 { get; set; }

        public double? uchd_iskonto2 { get; set; }

        public double? uchd_iskonto3 { get; set; }

        public double? uchd_iskonto4 { get; set; }

        public double? uchd_iskonto5 { get; set; }

        public double? uchd_iskonto6 { get; set; }

        public double? uchd_masraf1 { get; set; }

        public double? uchd_masraf2 { get; set; }

        public double? uchd_masraf3 { get; set; }

        public double? uchd_masraf4 { get; set; }

        public double? uchd_degerfarki { get; set; }

        public bool? uchd_entegre_olmasin_fl { get; set; }
    }
}
