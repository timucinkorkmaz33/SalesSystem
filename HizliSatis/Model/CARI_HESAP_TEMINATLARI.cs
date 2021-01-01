namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_TEMINATLARI
    {
        [Key]
        public int ct_RECno { get; set; }

        public short ct_RECid_DBCno { get; set; }

        public int ct_RECid_RECno { get; set; }

        public int? ct_SpecRECno { get; set; }

        public bool? ct_iptal { get; set; }

        public short? ct_fileid { get; set; }

        public bool? ct_hidden { get; set; }

        public bool? ct_kilitli { get; set; }

        public bool? ct_degisti { get; set; }

        public int? ct_checksum { get; set; }

        public short? ct_create_user { get; set; }

        public DateTime? ct_create_date { get; set; }

        public short? ct_lastup_user { get; set; }

        public DateTime? ct_lastup_date { get; set; }

        [StringLength(4)]
        public string ct_special1 { get; set; }

        [StringLength(4)]
        public string ct_special2 { get; set; }

        [StringLength(4)]
        public string ct_special3 { get; set; }

        [Required]
        [StringLength(25)]
        public string ct_carikodu { get; set; }

        public byte? ct_Aciklama_no { get; set; }

        public double? ct_tutari { get; set; }

        public byte? ct_DovizCinsi { get; set; }

        public DateTime? ct_vade { get; set; }

        public byte? ct_icerigi { get; set; }

        public int? ct_GecerliFirma { get; set; }

        public DateTime? ct_GirisTarihi { get; set; }

        [StringLength(25)]
        public string ct_srmrkkodu { get; set; }

        public byte? ct_bgevrak_tip { get; set; }

        [StringLength(6)]
        public string ct_bgevrakno_seri { get; set; }

        public int? ct_bgevrakno_sira { get; set; }
    }
}
