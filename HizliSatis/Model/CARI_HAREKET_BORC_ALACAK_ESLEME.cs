namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HAREKET_BORC_ALACAK_ESLEME
    {
        [Key]
        public int chk_RECno { get; set; }

        public short chk_RECid_DBCno { get; set; }

        public int chk_RECid_RECno { get; set; }

        public int? chk_SpecRECno { get; set; }

        public bool? chk_iptal { get; set; }

        public short? chk_fileid { get; set; }

        public bool? chk_hidden { get; set; }

        public bool? chk_kilitli { get; set; }

        public bool? chk_degisti { get; set; }

        public int? chk_checksum { get; set; }

        public short? chk_create_user { get; set; }

        public DateTime? chk_create_date { get; set; }

        public short? chk_lastup_user { get; set; }

        public DateTime? chk_lastup_date { get; set; }

        [StringLength(4)]
        public string chk_special1 { get; set; }

        [StringLength(4)]
        public string chk_special2 { get; set; }

        [StringLength(4)]
        public string chk_special3 { get; set; }

        public byte? chk_ChCinsi { get; set; }

        [StringLength(25)]
        public string chk_ChKodu { get; set; }

        public short? chk_BorcDBid { get; set; }

        public int? chk_BorcRECid { get; set; }

        public DateTime? chk_BorcVade { get; set; }

        public double? chk_Tutar { get; set; }

        public short? chk_AlcDBid { get; set; }

        public int? chk_AlcRECid { get; set; }

        public DateTime? chk_Alacakvade { get; set; }

        [StringLength(80)]
        public string chk_Aciklama1 { get; set; }

        [StringLength(80)]
        public string chk_Aciklama2 { get; set; }

        public double? chk_OrjBorcTutar { get; set; }

        public double? chk_OrjAlacakTutar { get; set; }
    }
}
