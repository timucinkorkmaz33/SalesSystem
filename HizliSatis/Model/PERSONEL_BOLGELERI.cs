namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_BOLGELERI
    {
        [Key]
        public int pbl_RECno { get; set; }

        public short pbl_RECid_DBCno { get; set; }

        public int pbl_RECid_RECno { get; set; }

        public int? pbl_SpecRECno { get; set; }

        public bool? pbl_iptal { get; set; }

        public short? pbl_fileid { get; set; }

        public bool? pbl_hidden { get; set; }

        public bool? pbl_kilitli { get; set; }

        public bool? pbl_degisti { get; set; }

        public int? pbl_checksum { get; set; }

        public short? pbl_create_user { get; set; }

        public DateTime? pbl_create_date { get; set; }

        public short? pbl_lastup_user { get; set; }

        public DateTime? pbl_lastup_date { get; set; }

        [StringLength(4)]
        public string pbl_special1 { get; set; }

        [StringLength(4)]
        public string pbl_special2 { get; set; }

        [StringLength(4)]
        public string pbl_special3 { get; set; }

        [StringLength(25)]
        public string pbl_bolge_kodu { get; set; }

        [StringLength(30)]
        public string pbl_bolge_adi { get; set; }
    }
}
