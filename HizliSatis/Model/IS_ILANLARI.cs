namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IS_ILANLARI
    {
        [Key]
        public int iln_RECno { get; set; }

        public short iln_RECid_DBCno { get; set; }

        public int iln_RECid_RECno { get; set; }

        public int? iln_SpecRECno { get; set; }

        public bool? iln_iptal { get; set; }

        public short? iln_fileid { get; set; }

        public bool? iln_hidden { get; set; }

        public bool? iln_kilitli { get; set; }

        public bool? iln_degisti { get; set; }

        public int? iln_checksum { get; set; }

        public short? iln_create_user { get; set; }

        public DateTime? iln_create_date { get; set; }

        public short? iln_lastup_user { get; set; }

        public DateTime? iln_lastup_date { get; set; }

        [StringLength(4)]
        public string iln_special1 { get; set; }

        [StringLength(4)]
        public string iln_special2 { get; set; }

        [StringLength(4)]
        public string iln_special3 { get; set; }

        [StringLength(25)]
        public string iln_kodu { get; set; }

        [StringLength(50)]
        public string iln_aciklama { get; set; }

        public short? iln_tecrube { get; set; }

        public byte? iln_cinsiyet { get; set; }

        public double? iln_net_ucret { get; set; }

        public byte? iln_doviz_cinsi { get; set; }

        public DateTime? iln_ilk_tarih { get; set; }

        public DateTime? iln_son_tarih { get; set; }

        public short? iln_kisi_sayisi { get; set; }
    }
}
