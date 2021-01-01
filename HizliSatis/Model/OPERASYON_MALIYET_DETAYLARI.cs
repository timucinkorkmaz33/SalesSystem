namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OPERASYON_MALIYET_DETAYLARI
    {
        [Key]
        public int mkn_RECno { get; set; }

        public short mkn_RECid_DBCno { get; set; }

        public int mkn_RECid_RECno { get; set; }

        public int? mkn_SpecRECno { get; set; }

        public bool? mkn_iptal { get; set; }

        public short? mkn_fileid { get; set; }

        public bool? mkn_hidden { get; set; }

        public bool? mkn_kilitli { get; set; }

        public bool? mkn_degisti { get; set; }

        public int? mkn_checksum { get; set; }

        public short? mkn_create_user { get; set; }

        public DateTime? mkn_create_date { get; set; }

        public short? mkn_lastup_user { get; set; }

        public DateTime? mkn_lastup_date { get; set; }

        [StringLength(4)]
        public string mkn_special1 { get; set; }

        [StringLength(4)]
        public string mkn_special2 { get; set; }

        [StringLength(4)]
        public string mkn_special3 { get; set; }

        [StringLength(25)]
        public string mkn_hesap_kodu { get; set; }

        [StringLength(25)]
        public string mkn_srm_merkezi { get; set; }

        public byte? mkn_dagitim_sekli { get; set; }

        public double? mkn_dagitilan_anahtar { get; set; }

        public double? mkn_dagitilan_maliyet_ana { get; set; }

        public double? mkn_dagitilan_maliyet_alt { get; set; }

        public double? mkn_dagitilan_maliyet_orj { get; set; }

        public int? mkn_optamam_recno { get; set; }

        public byte? mkn_masraf_nereye { get; set; }
    }
}
