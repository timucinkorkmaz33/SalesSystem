namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NAKAKSRV")]
    public partial class NAKAKSRV
    {
        [Key]
        public int Nakak_RECno { get; set; }

        public short Nakak_RECid_DBCno { get; set; }

        public int Nakak_RECid_RECno { get; set; }

        public int? Nakak_SpecRECNo { get; set; }

        public bool? Nakak_iptal { get; set; }

        public short? Nakak_fileid { get; set; }

        public bool? Nakak_hidden { get; set; }

        public bool? Nakak_kilitli { get; set; }

        public bool? Nakak_degisti { get; set; }

        public int? Nakak_CheckSum { get; set; }

        public short? Nakak_create_user { get; set; }

        public DateTime? Nakak_create_date { get; set; }

        public short? Nakak_lastup_user { get; set; }

        public DateTime? Nakak_lastup_date { get; set; }

        [StringLength(4)]
        public string Nakak_special1 { get; set; }

        [StringLength(4)]
        public string Nakak_special2 { get; set; }

        [StringLength(4)]
        public string Nakak_special3 { get; set; }

        [StringLength(25)]
        public string Nakak_naveritabani { get; set; }

        public int? Nakak_nafirmano { get; set; }

        public DateTime? Nakak_navade { get; set; }

        public byte? Nakak_natip { get; set; }

        [StringLength(25)]
        public string Nakak_naref { get; set; }

        [StringLength(120)]
        public string Nakak_naaciklama { get; set; }

        public double? Nakak_natutar { get; set; }

        public double? Nakak_naAltDovTutar { get; set; }

        public double? Nakak_naOrjDovTutar { get; set; }

        public byte? Nakak_nacaricins { get; set; }

        [StringLength(25)]
        public string Nakak_nakod { get; set; }

        [StringLength(30)]
        public string Nakak_naisim { get; set; }

        public byte? Nakak_naOrjDovCinsi { get; set; }

        [StringLength(25)]
        public string Nakak_proje { get; set; }

        [StringLength(25)]
        public string Nakak_srmmrk { get; set; }
    }
}
