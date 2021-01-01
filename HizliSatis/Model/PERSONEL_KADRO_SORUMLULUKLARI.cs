namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_SORUMLULUKLARI
    {
        [Key]
        public int ks_RECno { get; set; }

        public short ks_RECid_DBCno { get; set; }

        public int ks_RECid_RECno { get; set; }

        public int? ks_SpecRECno { get; set; }

        public bool? ks_iptal { get; set; }

        public short? ks_fileid { get; set; }

        public bool? ks_hidden { get; set; }

        public bool? ks_kilitli { get; set; }

        public bool? ks_degisti { get; set; }

        public int? ks_checksum { get; set; }

        public short? ks_create_user { get; set; }

        public DateTime? ks_create_date { get; set; }

        public short? ks_lastup_user { get; set; }

        public DateTime? ks_lastup_date { get; set; }

        [StringLength(4)]
        public string ks_special1 { get; set; }

        [StringLength(4)]
        public string ks_special2 { get; set; }

        [StringLength(4)]
        public string ks_special3 { get; set; }

        [StringLength(25)]
        public string ks_kadrokod { get; set; }

        public int? ks_kadrosirano { get; set; }

        public int? ks_satirno { get; set; }

        [StringLength(25)]
        public string ks_sorumlulukkod { get; set; }

        public DateTime? ks_gecerliliktarihi { get; set; }
    }
}
