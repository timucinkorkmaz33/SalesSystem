namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CEKI_LISTESI
    {
        [Key]
        public int Ckl_RECno { get; set; }

        public short Ckl_RECid_DBCno { get; set; }

        public int Ckl_RECid_RECno { get; set; }

        public int? Ckl_SpecRECNo { get; set; }

        public bool? Ckl_iptal { get; set; }

        public short? Ckl_fileid { get; set; }

        public bool? Ckl_hidden { get; set; }

        public bool? Ckl_kilitli { get; set; }

        public bool? Ckl_degisti { get; set; }

        public int? Ckl_CheckSum { get; set; }

        public short? Ckl_create_user { get; set; }

        public DateTime? Ckl_create_date { get; set; }

        public short? Ckl_lastup_user { get; set; }

        public DateTime? Ckl_lastup_date { get; set; }

        [StringLength(4)]
        public string Ckl_special1 { get; set; }

        [StringLength(4)]
        public string Ckl_special2 { get; set; }

        [StringLength(4)]
        public string Ckl_special3 { get; set; }

        public byte? Ckl_EvrakTip { get; set; }

        [StringLength(6)]
        public string Ckl_EvrakSeri { get; set; }

        public int? Ckl_EvrakSira { get; set; }

        [StringLength(25)]
        public string Ckl_StokKodu { get; set; }

        public byte? Ckl_BedenPntr { get; set; }

        public double? Ckl_Miktari { get; set; }

        public short? Ckl_AnaAmbalajNo { get; set; }

        public short? Ckl_AltAmbalajNo { get; set; }
    }
}
