namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASORTI_TANIMLARI
    {
        [Key]
        public int Asorti_RECno { get; set; }

        public short Asorti_RECid_DBCno { get; set; }

        public int Asorti_RECid_RECno { get; set; }

        public int? Asorti_SpecRECno { get; set; }

        public bool? Asorti_iptal { get; set; }

        public short? Asorti_fileid { get; set; }

        public bool? Asorti_hidden { get; set; }

        public bool? Asorti_kilitli { get; set; }

        public bool? Asorti_degisti { get; set; }

        public int? Asorti_checksum { get; set; }

        public short? Asorti_create_user { get; set; }

        public DateTime? Asorti_create_date { get; set; }

        public short? Asorti_lastup_user { get; set; }

        public DateTime? Asorti_lastup_date { get; set; }

        [StringLength(4)]
        public string Asorti_special1 { get; set; }

        [StringLength(4)]
        public string Asorti_special2 { get; set; }

        [StringLength(4)]
        public string Asorti_special3 { get; set; }

        [StringLength(25)]
        public string Asorti_StokKodu { get; set; }

        [StringLength(25)]
        public string Asorti_TanimKodu { get; set; }

        public short? Asorti_BedenNo { get; set; }

        public double? Asorti_Miktar { get; set; }
    }
}
