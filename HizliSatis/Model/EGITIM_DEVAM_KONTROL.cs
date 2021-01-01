namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EGITIM_DEVAM_KONTROL
    {
        [Key]
        public int dk_RECno { get; set; }

        public short dk_RECid_DBCno { get; set; }

        public int dk_RECid_RECno { get; set; }

        public int? dk_SpecRECno { get; set; }

        public bool? dk_iptal { get; set; }

        public short? dk_fileid { get; set; }

        public bool? dk_hidden { get; set; }

        public bool? dk_kilitli { get; set; }

        public bool? dk_degisti { get; set; }

        public int? dk_checksum { get; set; }

        public short? dk_create_user { get; set; }

        public DateTime? dk_create_date { get; set; }

        public short? dk_lastup_user { get; set; }

        public DateTime? dk_lastup_date { get; set; }

        [StringLength(4)]
        public string dk_special1 { get; set; }

        [StringLength(4)]
        public string dk_special2 { get; set; }

        [StringLength(4)]
        public string dk_special3 { get; set; }

        [StringLength(6)]
        public string dk_evrakno_seri { get; set; }

        public int? dk_evrakno_sira { get; set; }

        public int? dk_satirno { get; set; }

        [StringLength(25)]
        public string dk_egitimkodu { get; set; }

        [StringLength(25)]
        public string dk_perskod { get; set; }

        public DateTime? dk_tarih { get; set; }

        public DateTime? dk_girsaat { get; set; }

        public DateTime? dk_ciksaat { get; set; }

        [StringLength(50)]
        public string dk_mazeret { get; set; }
    }
}
