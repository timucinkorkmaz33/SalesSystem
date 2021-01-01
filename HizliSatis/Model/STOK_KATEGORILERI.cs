namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_KATEGORILERI
    {
        [Key]
        public int ktg_RECno { get; set; }

        public short ktg_RECid_DBCno { get; set; }

        public int ktg_RECid_RECno { get; set; }

        public int? ktg_SpecRECno { get; set; }

        public bool? ktg_iptal { get; set; }

        public short? ktg_fileid { get; set; }

        public bool? ktg_hidden { get; set; }

        public bool? ktg_kilitli { get; set; }

        public bool? ktg_degisti { get; set; }

        public int? ktg_checksum { get; set; }

        public short? ktg_create_user { get; set; }

        public DateTime? ktg_create_date { get; set; }

        public short? ktg_lastup_user { get; set; }

        public DateTime? ktg_lastup_date { get; set; }

        [StringLength(4)]
        public string ktg_special1 { get; set; }

        [StringLength(4)]
        public string ktg_special2 { get; set; }

        [StringLength(4)]
        public string ktg_special3 { get; set; }

        [StringLength(25)]
        public string ktg_kod { get; set; }

        [StringLength(50)]
        public string ktg_isim { get; set; }

        [StringLength(90)]
        public string ktg_aciklama { get; set; }
    }
}
