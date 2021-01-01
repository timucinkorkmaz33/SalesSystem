namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_NITELIKLERI
    {
        [Key]
        public int pn_RECno { get; set; }

        public short pn_RECid_DBCno { get; set; }

        public int pn_RECid_RECno { get; set; }

        public int? pn_SpecRECno { get; set; }

        public bool? pn_iptal { get; set; }

        public short? pn_fileid { get; set; }

        public bool? pn_hidden { get; set; }

        public bool? pn_kilitli { get; set; }

        public bool? pn_degisti { get; set; }

        public int? pn_checksum { get; set; }

        public short? pn_create_user { get; set; }

        public DateTime? pn_create_date { get; set; }

        public short? pn_lastup_user { get; set; }

        public DateTime? pn_lastup_date { get; set; }

        [StringLength(4)]
        public string pn_special1 { get; set; }

        [StringLength(4)]
        public string pn_special2 { get; set; }

        [StringLength(4)]
        public string pn_special3 { get; set; }

        [StringLength(25)]
        public string pn_perskod { get; set; }

        public int? pn_satirno { get; set; }

        [StringLength(25)]
        public string pn_nitelikkod { get; set; }

        public double? pn_puan { get; set; }

        public byte? pn_sozelpuan { get; set; }
    }
}
