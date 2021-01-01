namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISLETME_HAREKETLERI
    {
        [Key]
        public int dfis_RECno { get; set; }

        public short dfis_RECid_DBCno { get; set; }

        public int dfis_RECid_RECno { get; set; }

        public int? dfis_SpecRECno { get; set; }

        public bool? dfis_iptal { get; set; }

        public short? dfis_fileid { get; set; }

        public bool? dfis_hidden { get; set; }

        public bool? dfis_kilitli { get; set; }

        public bool? dfis_degisti { get; set; }

        public int? dfis_checksum { get; set; }

        public short? dfis_create_user { get; set; }

        public DateTime? dfis_create_date { get; set; }

        public short? dfis_lastup_user { get; set; }

        public DateTime? dfis_lastup_date { get; set; }

        [StringLength(4)]
        public string dfis_special1 { get; set; }

        [StringLength(4)]
        public string dfis_special2 { get; set; }

        [StringLength(4)]
        public string dfis_special3 { get; set; }

        public int? dfis_firmano { get; set; }

        public int? dfis_subeno { get; set; }

        public int? dfis_maliyil { get; set; }

        public DateTime? dfis_tarih { get; set; }

        [StringLength(25)]
        public string dfis_hesap_kod { get; set; }

        [StringLength(65)]
        public string dfis_aciklama1 { get; set; }

        public double? dfis_meblag0 { get; set; }

        public double? dfis_meblag1 { get; set; }

        public double? dfis_meblag2 { get; set; }

        public double? dfis_meblag3 { get; set; }

        public double? dfis_meblag4 { get; set; }

        public double? dfis_meblag5 { get; set; }

        public double? dfis_meblag6 { get; set; }

        public DateTime? dfis_fevraktarih { get; set; }

        public byte? dfis_fcinsi { get; set; }

        public byte? dfis_fvergipnt { get; set; }

        public double? dfis_Fvergi { get; set; }

        public byte? dfis_ftip { get; set; }

        public byte? dfis_ticari_tip { get; set; }

        public byte? dfis_ticari_evraktip { get; set; }

        [StringLength(15)]
        public string dfis_evrakno_seri { get; set; }

        public int? dfis_evrakno_sira { get; set; }

        [StringLength(25)]
        public string dfis_fozelmahkod { get; set; }

        public byte? dfis_evraktip { get; set; }
    }
}
