namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_KALKON
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int skk_RECno { get; set; }

        public short skk_RECid_DBCno { get; set; }

        public int skk_RECid_RECno { get; set; }

        public int? skk_SpecRECno { get; set; }

        public bool? skk_iptal { get; set; }

        public short? skk_fileid { get; set; }

        public bool? skk_hidden { get; set; }

        public bool? skk_kilitli { get; set; }

        public bool? skk_degisti { get; set; }

        public int? skk_checksum { get; set; }

        public short? skk_create_user { get; set; }

        public DateTime? skk_create_date { get; set; }

        public short? skk_lastup_user { get; set; }

        public DateTime? skk_lastup_date { get; set; }

        [StringLength(4)]
        public string skk_special1 { get; set; }

        [StringLength(4)]
        public string skk_special2 { get; set; }

        [StringLength(4)]
        public string skk_special3 { get; set; }

        [Key]
        [Column(Order = 0)]
        public byte skk_tipi { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string skk_kodu { get; set; }

        [StringLength(25)]
        public string skk_olcadi1 { get; set; }

        public double? skk_olcmin1 { get; set; }

        public double? skk_olcmax1 { get; set; }

        public double? skk_olcideal1 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama1 { get; set; }

        [StringLength(25)]
        public string skk_olcadi2 { get; set; }

        public double? skk_olcmin2 { get; set; }

        public double? skk_olcmax2 { get; set; }

        public double? skk_olcideal2 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama2 { get; set; }

        [StringLength(25)]
        public string skk_olcadi3 { get; set; }

        public double? skk_olcmin3 { get; set; }

        public double? skk_olcmax3 { get; set; }

        public double? skk_olcideal3 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama3 { get; set; }

        [StringLength(25)]
        public string skk_olcadi4 { get; set; }

        public double? skk_olcmin4 { get; set; }

        public double? skk_olcmax4 { get; set; }

        public double? skk_olcideal4 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama4 { get; set; }

        [StringLength(25)]
        public string skk_olcadi5 { get; set; }

        public double? skk_olcmin5 { get; set; }

        public double? skk_olcmax5 { get; set; }

        public double? skk_olcideal5 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama5 { get; set; }

        [StringLength(25)]
        public string skk_olcadi6 { get; set; }

        public double? skk_olcmin6 { get; set; }

        public double? skk_olcmax6 { get; set; }

        public double? skk_olcideal6 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama6 { get; set; }

        [StringLength(25)]
        public string skk_olcadi7 { get; set; }

        public double? skk_olcmin7 { get; set; }

        public double? skk_olcmax7 { get; set; }

        public double? skk_olcideal7 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama7 { get; set; }

        [StringLength(25)]
        public string skk_olcadi8 { get; set; }

        public double? skk_olcmin8 { get; set; }

        public double? skk_olcmax8 { get; set; }

        public double? skk_olcideal8 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama8 { get; set; }

        [StringLength(25)]
        public string skk_olcadi9 { get; set; }

        public double? skk_olcmin9 { get; set; }

        public double? skk_olcmax9 { get; set; }

        public double? skk_olcideal9 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama9 { get; set; }

        [StringLength(25)]
        public string skk_olcadi10 { get; set; }

        public double? skk_olcmin10 { get; set; }

        public double? skk_olcmax10 { get; set; }

        public double? skk_olcideal10 { get; set; }

        [StringLength(25)]
        public string skk_olcaciklama10 { get; set; }
    }
}
