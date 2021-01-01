namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIHAZ_SORUNLARI
    {
        [Key]
        public int chs_RECno { get; set; }

        public short chs_RECid_DBCno { get; set; }

        public int chs_RECid_RECno { get; set; }

        public int? chs_Spec_Rec_no { get; set; }

        public bool? chs_iptal { get; set; }

        public short? chs_fileid { get; set; }

        public bool? chs_hidden { get; set; }

        public bool? chs_kilitli { get; set; }

        public bool? chs_degisti { get; set; }

        public int? chs_checksum { get; set; }

        public short? chs_create_user { get; set; }

        public DateTime? chs_create_date { get; set; }

        public short? chs_lastup_user { get; set; }

        public DateTime? chs_lastup_date { get; set; }

        [StringLength(4)]
        public string chs_special1 { get; set; }

        [StringLength(4)]
        public string chs_special2 { get; set; }

        [StringLength(4)]
        public string chs_special3 { get; set; }

        [StringLength(25)]
        public string chs_kodu { get; set; }

        [StringLength(25)]
        public string chs_cihaz { get; set; }

        [StringLength(50)]
        public string chs_sorun { get; set; }

        [StringLength(25)]
        public string chs_stok_ana_grup_kodu { get; set; }

        [StringLength(25)]
        public string chs_grup_kodu { get; set; }

        [StringLength(25)]
        public string chs_sinif_kodu { get; set; }

        public int? chs_sorun_giderme_süresi { get; set; }
    }
}
