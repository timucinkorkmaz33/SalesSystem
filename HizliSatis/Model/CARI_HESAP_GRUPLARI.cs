namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_GRUPLARI
    {
        [Key]
        public int crg_RECno { get; set; }

        public short crg_RECid_DBCno { get; set; }

        public int crg_RECid_RECno { get; set; }

        public int? crg_SpecRECNo { get; set; }

        public bool? crg_iptal { get; set; }

        public short? crg_fileid { get; set; }

        public bool? crg_hidden { get; set; }

        public bool? crg_kilitli { get; set; }

        public bool? crg_degisti { get; set; }

        public int? crg_CheckSum { get; set; }

        public short? crg_create_user { get; set; }

        public DateTime? crg_create_date { get; set; }

        public short? crg_lastup_user { get; set; }

        public DateTime? crg_lastup_date { get; set; }

        [StringLength(4)]
        public string crg_special1 { get; set; }

        [StringLength(4)]
        public string crg_special2 { get; set; }

        [StringLength(4)]
        public string crg_special3 { get; set; }

        [StringLength(25)]
        public string crg_kod { get; set; }

        [StringLength(90)]
        public string crg_isim { get; set; }

        [StringLength(4)]
        public string crg_muhasebe_kodu { get; set; }
    }
}
