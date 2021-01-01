namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BUTCELENEN_NAKIT_AKIS
    {
        [Key]
        public int bna_RECNo { get; set; }

        public short bna_RECid_DBCno { get; set; }

        public int bna_RECid_RECno { get; set; }

        public int? bna_SpecRECno { get; set; }

        public bool? bna_iptal { get; set; }

        public short? bna_fileid { get; set; }

        public bool? bna_hidden { get; set; }

        public bool? bna_kilitli { get; set; }

        public bool? bna_degisti { get; set; }

        public int? bna_checksum { get; set; }

        public short? bna_create_user { get; set; }

        public DateTime? bna_create_date { get; set; }

        public short? bna_lastup_user { get; set; }

        public DateTime? bna_lastup_date { get; set; }

        [StringLength(4)]
        public string bna_special1 { get; set; }

        [StringLength(4)]
        public string bna_special2 { get; set; }

        [StringLength(4)]
        public string bna_special3 { get; set; }

        public int? bna_firmano { get; set; }

        public byte? bna_giris_cikis { get; set; }

        public DateTime? bna_vade { get; set; }

        [StringLength(50)]
        public string bna_aciklama { get; set; }

        public double? bna_tutar { get; set; }

        public byte? bna_dovizcinsi { get; set; }

        public bool? bna_tamamlandi { get; set; }

        [StringLength(25)]
        public string bna_proje { get; set; }

        [StringLength(25)]
        public string bna_srmmrk { get; set; }
    }
}
