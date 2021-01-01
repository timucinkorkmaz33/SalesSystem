namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FINANSAL_SOZLESMELER
    {
        [Key]
        public int FS_RECno { get; set; }

        public short FS_RECid_DBCno { get; set; }

        public int FS_RECid_RECno { get; set; }

        public int? FS_Spec_Rec_no { get; set; }

        public bool? FS_iptal { get; set; }

        public short? FS_fileid { get; set; }

        public bool? FS_hidden { get; set; }

        public bool? FS_kilitli { get; set; }

        public bool? FS_degisti { get; set; }

        public int? FS_checksum { get; set; }

        public short? FS_create_user { get; set; }

        public DateTime? FS_create_date { get; set; }

        public short? FS_lastup_user { get; set; }

        public DateTime? FS_lastup_date { get; set; }

        [StringLength(4)]
        public string FS_special1 { get; set; }

        [StringLength(4)]
        public string FS_special2 { get; set; }

        [StringLength(4)]
        public string FS_special3 { get; set; }

        public int? FS_firmano { get; set; }

        public int? FS_subeno { get; set; }

        [StringLength(25)]
        public string FS_sozkodu { get; set; }

        [StringLength(50)]
        public string FS_sozaciklama { get; set; }

        [StringLength(25)]
        public string FS_sozcarikodu { get; set; }

        [StringLength(40)]
        public string FS_KVertfingidkodu { get; set; }

        [StringLength(40)]
        public string FS_UVertfingidkodu { get; set; }

        [StringLength(40)]
        public string FS_finasmangidkodu { get; set; }

        [StringLength(40)]
        public string FS_KVfinkiraborckodu { get; set; }

        [StringLength(40)]
        public string FS_UVfinkiraborckodu { get; set; }

        public short? FS_TaksitSayisi { get; set; }

        public byte? FS_dovizcinsi { get; set; }
    }
}
