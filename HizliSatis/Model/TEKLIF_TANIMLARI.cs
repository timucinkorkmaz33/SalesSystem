namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEKLIF_TANIMLARI
    {
        [Key]
        public int teklif_RECno { get; set; }

        public short teklif_RECid_DBCno { get; set; }

        public int teklif_RECid_RECno { get; set; }

        public int? teklif_SpecRECno { get; set; }

        public bool? teklif_iptal { get; set; }

        public short? teklif_fileid { get; set; }

        public bool? teklif_hidden { get; set; }

        public bool? teklif_kilitli { get; set; }

        public bool? teklif_degisti { get; set; }

        public int? teklif_checksum { get; set; }

        public short? teklif_create_user { get; set; }

        public DateTime? teklif_create_date { get; set; }

        public short? teklif_lastup_user { get; set; }

        public DateTime? teklif_lastup_date { get; set; }

        [StringLength(4)]
        public string teklif_special1 { get; set; }

        [StringLength(4)]
        public string teklif_special2 { get; set; }

        [StringLength(4)]
        public string teklif_special3 { get; set; }

        [StringLength(25)]
        public string teklif_kodu { get; set; }

        [StringLength(50)]
        public string teklif_ismi { get; set; }

        [StringLength(50)]
        public string teklif_aciklama { get; set; }

        [StringLength(25)]
        public string teklif_proje { get; set; }

        [StringLength(25)]
        public string teklif_srmmrk { get; set; }

        [StringLength(25)]
        public string teklif_sorumlu { get; set; }

        public DateTime? teklif_baslangictarihi { get; set; }

        public DateTime? teklif_gecerliliksuresi { get; set; }

        public DateTime? teklif_istenenteslimtarihi { get; set; }
    }
}
