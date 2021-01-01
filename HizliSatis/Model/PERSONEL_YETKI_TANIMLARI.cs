namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_YETKI_TANIMLARI
    {
        [Key]
        public int yt_RECno { get; set; }

        public short yt_RECid_DBCno { get; set; }

        public int yt_RECid_RECno { get; set; }

        public int? yt_SpecRECno { get; set; }

        public bool? yt_iptal { get; set; }

        public short? yt_fileid { get; set; }

        public bool? yt_hidden { get; set; }

        public bool? yt_kilitli { get; set; }

        public bool? yt_degisti { get; set; }

        public int? yt_checksum { get; set; }

        public short? yt_create_user { get; set; }

        public DateTime? yt_create_date { get; set; }

        public short? yt_lastup_user { get; set; }

        public DateTime? yt_lastup_date { get; set; }

        [StringLength(4)]
        public string yt_special1 { get; set; }

        [StringLength(4)]
        public string yt_special2 { get; set; }

        [StringLength(4)]
        public string yt_special3 { get; set; }

        [StringLength(25)]
        public string yt_kod { get; set; }

        [StringLength(40)]
        public string yt_aciklama { get; set; }
    }
}
