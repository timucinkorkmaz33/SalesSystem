namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_GECIKME_NEDENLERI
    {
        [Key]
        public int GckNdn_RECno { get; set; }

        public short GckNdn_RECid_DBCno { get; set; }

        public int GckNdn_RECid_RECno { get; set; }

        public int? GckNdn_SpecRECNo { get; set; }

        public bool? GckNdn_iptal { get; set; }

        public short? GckNdn_fileid { get; set; }

        public bool? GckNdn_hidden { get; set; }

        public bool? GckNdn_kilitli { get; set; }

        public bool? GckNdn_degisti { get; set; }

        public int? GckNdn_CheckSum { get; set; }

        public short? GckNdn_create_user { get; set; }

        public DateTime? GckNdn_create_date { get; set; }

        public short? GckNdn_lastup_user { get; set; }

        public DateTime? GckNdn_lastup_date { get; set; }

        [StringLength(4)]
        public string GckNdn_special1 { get; set; }

        [StringLength(4)]
        public string GckNdn_special2 { get; set; }

        [StringLength(4)]
        public string GckNdn_special3 { get; set; }

        [StringLength(25)]
        public string GckNdn_kod { get; set; }

        [StringLength(90)]
        public string GckNdn_aciklama { get; set; }

        public bool? GckNdn_PersonelKaynakli_fl { get; set; }

        public byte? GckNdn_MaliyeteEtkiTipi { get; set; }
    }
}
