namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_DEVAM_KONTROL_NEDENLERI
    {
        [Key]
        public int pdn_RECno { get; set; }

        public short pdn_RECid_DBCno { get; set; }

        public int pdn_RECid_RECno { get; set; }

        public int? pdn_SpecRECno { get; set; }

        public bool? pdn_iptal { get; set; }

        public short? pdn_fileid { get; set; }

        public bool? pdn_hidden { get; set; }

        public bool? pdn_kilitli { get; set; }

        public bool? pdn_degisti { get; set; }

        public int? pdn_checksum { get; set; }

        public short? pdn_create_user { get; set; }

        public DateTime? pdn_create_date { get; set; }

        public short? pdn_lastup_user { get; set; }

        public DateTime? pdn_lastup_date { get; set; }

        [StringLength(4)]
        public string pdn_special1 { get; set; }

        [StringLength(4)]
        public string pdn_special2 { get; set; }

        [StringLength(4)]
        public string pdn_special3 { get; set; }

        [StringLength(25)]
        public string pdn_neden_kodu { get; set; }

        [StringLength(40)]
        public string pdn_aciklama { get; set; }
    }
}
