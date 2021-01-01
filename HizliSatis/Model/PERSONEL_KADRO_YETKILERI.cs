namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_YETKILERI
    {
        [Key]
        public int ky_RECno { get; set; }

        public short ky_RECid_DBCno { get; set; }

        public int ky_RECid_RECno { get; set; }

        public int? ky_SpecRECno { get; set; }

        public bool? ky_iptal { get; set; }

        public short? ky_fileid { get; set; }

        public bool? ky_hidden { get; set; }

        public bool? ky_kilitli { get; set; }

        public bool? ky_degisti { get; set; }

        public int? ky_checksum { get; set; }

        public short? ky_create_user { get; set; }

        public DateTime? ky_create_date { get; set; }

        public short? ky_lastup_user { get; set; }

        public DateTime? ky_lastup_date { get; set; }

        [StringLength(4)]
        public string ky_special1 { get; set; }

        [StringLength(4)]
        public string ky_special2 { get; set; }

        [StringLength(4)]
        public string ky_special3 { get; set; }

        [StringLength(25)]
        public string ky_kadrokod { get; set; }

        public int? ky_kadrosirano { get; set; }

        public int? ky_satirno { get; set; }

        [StringLength(25)]
        public string ky_yetkikod { get; set; }

        public DateTime? ky_gecerliliktarihi { get; set; }
    }
}
