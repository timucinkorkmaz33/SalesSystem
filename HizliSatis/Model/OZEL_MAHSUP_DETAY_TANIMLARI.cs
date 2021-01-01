namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OZEL_MAHSUP_DETAY_TANIMLARI
    {
        [Key]
        public int mp_RECno { get; set; }

        public short? mp_RECid_DBCno { get; set; }

        public int mp_RECid_RECno { get; set; }

        public int? mp_SpecRECNo { get; set; }

        public bool? mp_iptal { get; set; }

        public short? mp_fileid { get; set; }

        public bool? mp_hidden { get; set; }

        public bool? mp_kilitli { get; set; }

        public bool? mp_degisti { get; set; }

        public int? mp_CheckSum { get; set; }

        public short? mp_create_user { get; set; }

        public DateTime? mp_create_date { get; set; }

        public short? mp_lastup_user { get; set; }

        public DateTime? mp_lastup_date { get; set; }

        [StringLength(4)]
        public string mp_special1 { get; set; }

        [StringLength(4)]
        public string mp_special2 { get; set; }

        [StringLength(4)]
        public string mp_special3 { get; set; }

        [StringLength(25)]
        public string mp_OzMahKodu { get; set; }

        [StringLength(25)]
        public string mp_HesKodu { get; set; }

        public int? mp_SatirNo { get; set; }

        [StringLength(65)]
        public string mp_Aciklama { get; set; }

        public byte? mp_MahIslTip { get; set; }

        public double? mp_Borc { get; set; }

        public double? mp_Alacak { get; set; }

        [StringLength(25)]
        public string mp_SrmMrkzKodu { get; set; }

        [StringLength(25)]
        public string mp_ProjeKodu { get; set; }
    }
}
