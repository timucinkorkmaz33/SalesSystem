namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KASALAR")]
    public partial class KASALAR
    {
        [Key]
        public int kas_RECno { get; set; }

        public short kas_RECid_DBCno { get; set; }

        public int kas_RECid_RECno { get; set; }

        public int? kas_SpecRecno { get; set; }

        public bool? kas_iptal { get; set; }

        public short? kas_fileid { get; set; }

        public bool? kas_hidden { get; set; }

        public bool? kas_kilitli { get; set; }

        public bool? kas_degisti { get; set; }

        public int? kas_checksum { get; set; }

        public short? kas_create_user { get; set; }

        public DateTime? kas_create_date { get; set; }

        public short? kas_lastup_user { get; set; }

        public DateTime? kas_lastup_date { get; set; }

        [StringLength(4)]
        public string kas_special1 { get; set; }

        [StringLength(4)]
        public string kas_special2 { get; set; }

        [StringLength(4)]
        public string kas_special3 { get; set; }

        public byte? kas_tip { get; set; }

        public int? kas_firma_no { get; set; }

        [StringLength(25)]
        public string kas_kod { get; set; }

        [StringLength(40)]
        public string kas_isim { get; set; }

        [StringLength(40)]
        public string kas_muh_kod { get; set; }

        public byte? kas_doviz_cinsi { get; set; }

        [StringLength(25)]
        public string kas_bankakodu { get; set; }

        public bool? kas_nakakincelenmesi { get; set; }

        [StringLength(40)]
        public string kas_ufrs_muh_kod { get; set; }
    }
}
