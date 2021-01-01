namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KISA_MESAJ_SABLONLARI
    {
        [Key]
        public int sbl_RECno { get; set; }

        public short sbl_RECid_DBCno { get; set; }

        public int sbl_RECid_RECno { get; set; }

        public int? sbl_SpecRECno { get; set; }

        public bool? sbl_iptal { get; set; }

        public short? sbl_fileid { get; set; }

        public bool? sbl_hidden { get; set; }

        public bool? sbl_kilitli { get; set; }

        public bool? sbl_degisti { get; set; }

        public int? sbl_checksum { get; set; }

        public short? sbl_create_user { get; set; }

        public DateTime? sbl_create_date { get; set; }

        public short? sbl_lastup_user { get; set; }

        public DateTime? sbl_lastup_date { get; set; }

        [StringLength(4)]
        public string sbl_special1 { get; set; }

        [StringLength(4)]
        public string sbl_special2 { get; set; }

        [StringLength(4)]
        public string sbl_special3 { get; set; }

        [StringLength(25)]
        public string sbl_kodu { get; set; }

        [StringLength(40)]
        public string sbl_adi { get; set; }

        [StringLength(80)]
        public string sbl_metni { get; set; }

        public byte? sbl_functipi1 { get; set; }

        public byte? sbl_functipi2 { get; set; }

        public byte? sbl_functipi3 { get; set; }

        public byte? sbl_functipi4 { get; set; }

        public byte? sbl_functipi5 { get; set; }

        public byte? sbl_functipi6 { get; set; }

        public byte? sbl_functipi7 { get; set; }

        public byte? sbl_functipi8 { get; set; }

        public byte? sbl_functipi9 { get; set; }

        public byte? sbl_functipi10 { get; set; }
    }
}
