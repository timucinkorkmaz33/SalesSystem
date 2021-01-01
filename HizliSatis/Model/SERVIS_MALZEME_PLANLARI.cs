namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVIS_MALZEME_PLANLARI
    {
        [Key]
        public int smpl_RECno { get; set; }

        public short smpl_RECid_DBCno { get; set; }

        public int smpl_RECid_RECno { get; set; }

        public int? smpl_SpecRECno { get; set; }

        public bool? smpl_iptal { get; set; }

        public short? smpl_fileid { get; set; }

        public bool? smpl_hidden { get; set; }

        public bool? smpl_kilitli { get; set; }

        public bool? smpl_degisti { get; set; }

        public int? smpl_checksum { get; set; }

        public short? smpl_create_user { get; set; }

        public DateTime? smpl_create_date { get; set; }

        public short? smpl_lastup_user { get; set; }

        public DateTime? smpl_lastup_date { get; set; }

        [StringLength(4)]
        public string smpl_special1 { get; set; }

        [StringLength(4)]
        public string smpl_special2 { get; set; }

        [StringLength(4)]
        public string smpl_special3 { get; set; }

        [StringLength(25)]
        public string smpl_isemri_kodu { get; set; }

        public int? smpl_satirno { get; set; }

        public DateTime? smpl_har_tarihi { get; set; }

        [StringLength(25)]
        public string smpl_malzeme_kodu { get; set; }

        public double? smpl_miktar { get; set; }

        public double? smpl_tutar { get; set; }

        public double? smpl_iskonto { get; set; }

        [StringLength(80)]
        public string smpl_aciklama { get; set; }

        public int? smpl_depono { get; set; }

        public bool? smpl_garanti_dahili_fl { get; set; }

        public bool? smpl_onaylandi_fl { get; set; }
    }
}
