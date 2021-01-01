namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_KOD_ALTERNATIFLERI
    {
        [Key]
        public int sak_RECNo { get; set; }

        public short sak_RECid_DBCno { get; set; }

        public int sak_RECid_RECno { get; set; }

        public int? sak_SpecRECno { get; set; }

        public bool? sak_iptal { get; set; }

        public short? sak_fileid { get; set; }

        public bool? sak_hidden { get; set; }

        public bool? sak_kilitli { get; set; }

        public bool? sak_degisti { get; set; }

        public int? sak_checksum { get; set; }

        public short? sak_create_user { get; set; }

        public DateTime? sak_create_date { get; set; }

        public short? sak_lastup_user { get; set; }

        public DateTime? sak_lastup_date { get; set; }

        [StringLength(4)]
        public string sak_special1 { get; set; }

        [StringLength(4)]
        public string sak_special2 { get; set; }

        [StringLength(4)]
        public string sak_special3 { get; set; }

        public short? sak_altgrupno { get; set; }

        public short? sak_altalanno { get; set; }

        [StringLength(25)]
        public string sak_altkodu { get; set; }

        [StringLength(50)]
        public string sak_altaciklama { get; set; }
    }
}
