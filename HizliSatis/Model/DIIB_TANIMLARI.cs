namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIIB_TANIMLARI
    {
        [Key]
        public int di_RECno { get; set; }

        public short di_RECid_DBCno { get; set; }

        public int di_RECid_RECno { get; set; }

        public int? di_SpecRecNo { get; set; }

        public bool? di_iptal { get; set; }

        public short? di_fileid { get; set; }

        public bool? di_hidden { get; set; }

        public bool? di_kilitli { get; set; }

        public bool? di_degisti { get; set; }

        public int? di_checksum { get; set; }

        public short? di_create_user { get; set; }

        public DateTime? di_create_date { get; set; }

        public short? di_lastup_user { get; set; }

        public DateTime? di_lastup_date { get; set; }

        [StringLength(4)]
        public string di_special1 { get; set; }

        [StringLength(4)]
        public string di_special2 { get; set; }

        [StringLength(4)]
        public string di_special3 { get; set; }

        [StringLength(25)]
        public string di_nosu { get; set; }

        public DateTime? di_tarih { get; set; }

        public byte? di_tipi { get; set; }

        public DateTime? di_bitis_tarihi { get; set; }
    }
}
