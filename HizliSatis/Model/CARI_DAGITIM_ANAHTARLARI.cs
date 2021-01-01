namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_DAGITIM_ANAHTARLARI
    {
        [Key]
        public int cdaganah_RECno { get; set; }

        public short cdaganah_RECid_DBCno { get; set; }

        public int cdaganah_RECid_RECno { get; set; }

        public int? cdaganah_SpecRECno { get; set; }

        public bool? cdaganah_iptal { get; set; }

        public short? cdaganah_fileid { get; set; }

        public bool? cdaganah_hidden { get; set; }

        public bool? cdaganah_kilitli { get; set; }

        public bool? cdaganah_degisti { get; set; }

        public int? cdaganah_checksum { get; set; }

        public short? cdaganah_create_user { get; set; }

        public DateTime? cdaganah_create_date { get; set; }

        public short? cdaganah_lastup_user { get; set; }

        public DateTime? cdaganah_lastup_date { get; set; }

        [StringLength(4)]
        public string cdaganah_special1 { get; set; }

        [StringLength(4)]
        public string cdaganah_special2 { get; set; }

        [StringLength(4)]
        public string cdaganah_special3 { get; set; }

        [StringLength(25)]
        public string cdaganah_kod { get; set; }

        public DateTime? cdaganah_gecerliliktarihi { get; set; }

        public int? cdaganah_satirno { get; set; }

        [StringLength(50)]
        public string cdaganah_ismi { get; set; }

        [StringLength(25)]
        public string cdaganah_hesapkodu { get; set; }

        [StringLength(25)]
        public string cdaganah_proje { get; set; }

        [StringLength(25)]
        public string cdaganah_srmmrk { get; set; }

        public double? cdaganah_puan { get; set; }
    }
}
