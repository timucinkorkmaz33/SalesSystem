namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_NITELIK_TANIMLARI
    {
        [Key]
        public int nt_RECno { get; set; }

        public short nt_RECid_DBCno { get; set; }

        public int nt_RECid_RECno { get; set; }

        public int? nt_SpecRECno { get; set; }

        public bool? nt_iptal { get; set; }

        public short? nt_fileid { get; set; }

        public bool? nt_hidden { get; set; }

        public bool? nt_kilitli { get; set; }

        public bool? nt_degisti { get; set; }

        public int? nt_checksum { get; set; }

        public short? nt_create_user { get; set; }

        public DateTime? nt_create_date { get; set; }

        public short? nt_lastup_user { get; set; }

        public DateTime? nt_lastup_date { get; set; }

        [StringLength(4)]
        public string nt_special1 { get; set; }

        [StringLength(4)]
        public string nt_special2 { get; set; }

        [StringLength(4)]
        public string nt_special3 { get; set; }

        [StringLength(25)]
        public string nt_kod { get; set; }

        [StringLength(40)]
        public string nt_aciklama { get; set; }

        public byte? nt_tipi { get; set; }

        public byte? nt_aktif { get; set; }

        public double? nt_maxpuan { get; set; }

        public double? nt_toplamdakipayi { get; set; }

        [StringLength(127)]
        public string nt_sozelpuanlar { get; set; }
    }
}
