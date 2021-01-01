namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HAREKET_ODEME_VADELERI
    {
        [Key]
        public int cop_RECno { get; set; }

        public short cop_RECid_DBCno { get; set; }

        public int cop_RECid_RECno { get; set; }

        public int? cop_SpecRECno { get; set; }

        public bool? cop_iptal { get; set; }

        public short? cop_fileid { get; set; }

        public bool? cop_hidden { get; set; }

        public bool? cop_kilitli { get; set; }

        public bool? cop_degisti { get; set; }

        public int? cop_checksum { get; set; }

        public short? cop_create_user { get; set; }

        public DateTime? cop_create_date { get; set; }

        public short? cop_lastup_user { get; set; }

        public DateTime? cop_lastup_date { get; set; }

        [StringLength(4)]
        public string cop_special1 { get; set; }

        [StringLength(4)]
        public string cop_special2 { get; set; }

        [StringLength(4)]
        public string cop_special3 { get; set; }

        public byte? cop_evrak_tip { get; set; }

        [StringLength(6)]
        public string cop_evrakno_seri { get; set; }

        public int? cop_evrakno_sira { get; set; }

        public DateTime? cop_vade { get; set; }

        public double? cop_tutar { get; set; }
    }
}
