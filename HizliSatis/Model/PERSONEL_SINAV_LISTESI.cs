namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SINAV_LISTESI
    {
        [Key]
        public int slt_RECno { get; set; }

        public short slt_RECid_DBCno { get; set; }

        public int slt_RECid_RECno { get; set; }

        public int? slt_SpecRECno { get; set; }

        public bool? slt_iptal { get; set; }

        public short? slt_fileid { get; set; }

        public bool? slt_hidden { get; set; }

        public bool? slt_kilitli { get; set; }

        public bool? slt_degisti { get; set; }

        public int? slt_checksum { get; set; }

        public short? slt_create_user { get; set; }

        public DateTime? slt_create_date { get; set; }

        public short? slt_lastup_user { get; set; }

        public DateTime? slt_lastup_date { get; set; }

        [StringLength(4)]
        public string slt_special1 { get; set; }

        [StringLength(4)]
        public string slt_special2 { get; set; }

        [StringLength(4)]
        public string slt_special3 { get; set; }

        public DateTime? slt_tarih { get; set; }

        [StringLength(25)]
        public string slt_sinav_kodu { get; set; }

        public bool? slt_katilmadi { get; set; }

        public byte? slt_kapsam { get; set; }

        [StringLength(25)]
        public string slt_kapsam_kodu { get; set; }

        [StringLength(80)]
        public string slt_aciklama { get; set; }
    }
}
