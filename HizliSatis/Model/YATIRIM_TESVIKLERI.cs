namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YATIRIM_TESVIKLERI
    {
        [Key]
        public int YTTS_RECno { get; set; }

        public short YTTS_RECid_DBCno { get; set; }

        public int YTTS_RECid_RECno { get; set; }

        public int? YTTS_Spec_Rec_no { get; set; }

        public bool? YTTS_iptal { get; set; }

        public short? YTTS_fileid { get; set; }

        public bool? YTTS_hidden { get; set; }

        public bool? YTTS_kilitli { get; set; }

        public bool? YTTS_degisti { get; set; }

        public int? YTTS_checksum { get; set; }

        public short? YTTS_create_user { get; set; }

        public DateTime? YTTS_create_date { get; set; }

        public short? YTTS_lastup_user { get; set; }

        public DateTime? YTTS_lastup_date { get; set; }

        [StringLength(4)]
        public string YTTS_special1 { get; set; }

        [StringLength(4)]
        public string YTTS_special2 { get; set; }

        [StringLength(4)]
        public string YTTS_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string YTTS_kodu { get; set; }

        [StringLength(50)]
        public string YTTS_ismi { get; set; }

        [StringLength(10)]
        public string YTTS_muhkodartikeli { get; set; }

        [StringLength(10)]
        public string YTTS_yurtici_muhartikeli { get; set; }

        [StringLength(10)]
        public string YTTS_yurtdisi_muhartikeli { get; set; }

        public DateTime? YTTS_tarihi { get; set; }

        [StringLength(15)]
        public string YTTS_sayisi { get; set; }

        public byte? YTTS_fobdoviz { get; set; }
    }
}
