namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_TARIHCESI
    {
        [Key]
        public int kt_RECno { get; set; }

        public short kt_RECid_DBCno { get; set; }

        public int kt_RECid_RECno { get; set; }

        public int? kt_SpecRECno { get; set; }

        public bool? kt_iptal { get; set; }

        public short? kt_fileid { get; set; }

        public bool? kt_hidden { get; set; }

        public bool? kt_kilitli { get; set; }

        public bool? kt_degisti { get; set; }

        public int? kt_checksum { get; set; }

        public short? kt_create_user { get; set; }

        public DateTime? kt_create_date { get; set; }

        public short? kt_lastup_user { get; set; }

        public DateTime? kt_lastup_date { get; set; }

        [StringLength(4)]
        public string kt_special1 { get; set; }

        [StringLength(4)]
        public string kt_special2 { get; set; }

        [StringLength(4)]
        public string kt_special3 { get; set; }

        [StringLength(25)]
        public string kt_kadrokodu { get; set; }

        public int? kt_sirano { get; set; }

        [StringLength(25)]
        public string kt_personelkodu { get; set; }

        public DateTime? kt_atamatarihi { get; set; }

        public DateTime? kt_ayrilmatarihi { get; set; }

        [StringLength(50)]
        public string kt_ayrilmasebebi { get; set; }
    }
}
