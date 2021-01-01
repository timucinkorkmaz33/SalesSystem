namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIPARIS_ESLEME
    {
        [Key]
        public int se_RECno { get; set; }

        public short se_RECid_DBCno { get; set; }

        public int se_RECid_RECno { get; set; }

        public int? se_SpecRECno { get; set; }

        public bool? se_iptal { get; set; }

        public short? se_fileid { get; set; }

        public bool? se_hidden { get; set; }

        public bool? se_kilitli { get; set; }

        public bool? se_degisti { get; set; }

        public int? se_checksum { get; set; }

        public short? se_create_user { get; set; }

        public DateTime? se_create_date { get; set; }

        public short? se_lastup_user { get; set; }

        public DateTime? se_lastup_date { get; set; }

        [StringLength(4)]
        public string se_special1 { get; set; }

        [StringLength(4)]
        public string se_special2 { get; set; }

        [StringLength(4)]
        public string se_special3 { get; set; }

        public byte? se_Talep_TabloId { get; set; }

        public short? se_Talep_DbId { get; set; }

        public int? se_Talep_RecId { get; set; }

        public byte? se_Temin_TabloId { get; set; }

        public short? se_Temin_DbId { get; set; }

        public int? se_Temin_RecId { get; set; }

        public double? se_eslesen_miktar { get; set; }

        [StringLength(80)]
        public string se_aciklama { get; set; }

        public double? se_teslim_miktar { get; set; }

        public byte? se_kayit_tipi { get; set; }
    }
}
