namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MALI_TABLOLAR
    {
        [Key]
        public int mt_RECno { get; set; }

        public short? mt_RECid_DBCno { get; set; }

        public int mt_RECid_RECno { get; set; }

        public int? mt_SpecRECNo { get; set; }

        public bool? mt_iptal { get; set; }

        public short? mt_fileid { get; set; }

        public bool? mt_hidden { get; set; }

        public bool? mt_kilitli { get; set; }

        public bool? mt_degisti { get; set; }

        public int? mt_CheckSum { get; set; }

        public short? mt_create_user { get; set; }

        public DateTime? mt_create_date { get; set; }

        public short? mt_lastup_user { get; set; }

        public DateTime? mt_lastup_date { get; set; }

        [StringLength(4)]
        public string mt_special1 { get; set; }

        [StringLength(4)]
        public string mt_special2 { get; set; }

        [StringLength(4)]
        public string mt_special3 { get; set; }

        public byte? mt_Tablo { get; set; }

        public int? mt_Sirano { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiT { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiE { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiG { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiA { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiR { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiB { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiP { get; set; }

        [StringLength(127)]
        public string mt_DilAciklamasiK { get; set; }

        public int? mt_Tipi { get; set; }

        [StringLength(127)]
        public string mt_HesapVeyaFormul { get; set; }

        public double? mt_Giris { get; set; }

        public double? mt_EskiDonem { get; set; }

        public int? mt_Seviye { get; set; }
    }
}
