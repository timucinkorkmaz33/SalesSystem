namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VERGI_TAHAKKUKLARI
    {
        [Key]
        public int fh_RECno { get; set; }

        public short fh_RECid_DBCno { get; set; }

        public int fh_RECid_RECno { get; set; }

        public int? fh_SpecRECno { get; set; }

        public bool? fh_iptal { get; set; }

        public short? fh_fileid { get; set; }

        public bool? fh_hidden { get; set; }

        public bool? fh_kilitli { get; set; }

        public bool? fh_degisti { get; set; }

        public int? fh_checksum { get; set; }

        public short? fh_create_user { get; set; }

        public DateTime? fh_create_date { get; set; }

        public short? fh_lastup_user { get; set; }

        public DateTime? fh_lastup_date { get; set; }

        [StringLength(4)]
        public string fh_special1 { get; set; }

        [StringLength(4)]
        public string fh_special2 { get; set; }

        [StringLength(4)]
        public string fh_special3 { get; set; }

        public int? fh_firmano { get; set; }

        public DateTime? fh_tarih { get; set; }

        public short? fh_islem { get; set; }

        public short? fh_donem { get; set; }

        public double? fh_tutar { get; set; }

        public byte? fh_tip { get; set; }

        [StringLength(6)]
        public string fh_evrno_seri { get; set; }

        public int? fh_evrno_sira { get; set; }

        public byte? fh_sekli { get; set; }

        [StringLength(20)]
        public string fh_aciklama { get; set; }

        [StringLength(20)]
        public string fh_yeri { get; set; }

        public double? fh_matrah { get; set; }

        public double? fh_mahsup { get; set; }

        public int? fh_SatirNo { get; set; }

        public DateTime? fh_Vade { get; set; }

        [StringLength(8)]
        public string fh_OdemeNo { get; set; }

        [StringLength(25)]
        public string fh_TahhakkukNo { get; set; }

        [StringLength(25)]
        public string fh_dbkodu { get; set; }
    }
}
