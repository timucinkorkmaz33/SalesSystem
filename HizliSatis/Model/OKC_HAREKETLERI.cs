namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OKC_HAREKETLERI
    {
        [Key]
        public int okc_RECno { get; set; }

        public short? okc_RECid_DBCno { get; set; }

        public int okc_RECid_RECno { get; set; }

        public int? okc_SpecRECNo { get; set; }

        public bool? okc_iptal { get; set; }

        public short? okc_fileid { get; set; }

        public bool? okc_hidden { get; set; }

        public bool? okc_kilitli { get; set; }

        public bool? okc_degisti { get; set; }

        public int? okc_CheckSum { get; set; }

        public short? okc_create_user { get; set; }

        public DateTime? okc_create_date { get; set; }

        public short? okc_lastup_user { get; set; }

        public DateTime? okc_lastup_date { get; set; }

        [StringLength(4)]
        public string okc_special1 { get; set; }

        [StringLength(4)]
        public string okc_special2 { get; set; }

        [StringLength(4)]
        public string okc_special3 { get; set; }

        public int? okc_fis_no { get; set; }

        public byte? okc_fis_tipi { get; set; }

        public DateTime? okc_fis_tarihi { get; set; }

        public int? okc_Zrapor_no { get; set; }

        public DateTime? okc_fis_irsaliye_tarihi { get; set; }

        [StringLength(25)]
        public string okc_seri_no { get; set; }

        [StringLength(40)]
        public string okc_uuid { get; set; }
    }
}
