namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAGIMSIZ_BOLUM_TANIMLARI
    {
        [Key]
        public int blm_RECno { get; set; }

        public short blm_RECid_DBCno { get; set; }

        public int blm_RECid_RECno { get; set; }

        public int? blm_SpecRECno { get; set; }

        public bool? blm_iptal { get; set; }

        public short? blm_fileid { get; set; }

        public bool? blm_hidden { get; set; }

        public bool? blm_kilitli { get; set; }

        public bool? blm_degisti { get; set; }

        public int? blm_checksum { get; set; }

        public short? blm_create_user { get; set; }

        public DateTime? blm_create_date { get; set; }

        public short? blm_lastup_user { get; set; }

        public DateTime? blm_lastup_date { get; set; }

        [StringLength(4)]
        public string blm_special1 { get; set; }

        [StringLength(4)]
        public string blm_special2 { get; set; }

        [StringLength(4)]
        public string blm_special3 { get; set; }

        [StringLength(25)]
        public string blm_sitekod { get; set; }

        [StringLength(25)]
        public string blm_blokkod { get; set; }

        [StringLength(25)]
        public string blm_katkod { get; set; }

        [StringLength(25)]
        public string blm_kod { get; set; }

        [StringLength(90)]
        public string blm_ismi { get; set; }

        public byte? blm_acikkapali { get; set; }

        public byte? blm_turu { get; set; }

        public double? blm_iccephe { get; set; }

        public double? blm_discephe { get; set; }

        public double? blm_vitrinsinifi { get; set; }

        public double? blm_brutalan { get; set; }

        public double? blm_netalan { get; set; }

        public byte? blm_Cinsi { get; set; }

        [StringLength(25)]
        public string blm_KiraHizmetKodu { get; set; }

        [StringLength(25)]
        public string blm_OrtakGiderHizmetKodu { get; set; }
    }
}
