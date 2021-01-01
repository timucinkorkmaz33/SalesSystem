namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RECETE_KRITERLERI
    {
        [Key]
        public int rk_RECno { get; set; }

        public short rk_RECid_DBCno { get; set; }

        public int rk_RECid_RECno { get; set; }

        public int? rk_SpecRECno { get; set; }

        public bool? rk_iptal { get; set; }

        public short? rk_fileid { get; set; }

        public bool? rk_hidden { get; set; }

        public bool? rk_kilitli { get; set; }

        public bool? rk_degisti { get; set; }

        public int? rk_checksum { get; set; }

        public short? rk_create_user { get; set; }

        public DateTime? rk_create_date { get; set; }

        public short? rk_lastup_user { get; set; }

        public DateTime? rk_lastup_date { get; set; }

        [StringLength(4)]
        public string rk_special1 { get; set; }

        [StringLength(4)]
        public string rk_special2 { get; set; }

        [StringLength(4)]
        public string rk_special3 { get; set; }

        public short? rk_recete_recid_dbcno { get; set; }

        public int? rk_recete_recid_recno { get; set; }

        public int? rk_satirno { get; set; }

        public byte? rk_tablo { get; set; }

        [StringLength(80)]
        public string rk_alan_adi { get; set; }

        public byte? rk_islem { get; set; }

        [StringLength(80)]
        public string rk_stringdata { get; set; }

        public byte? rk_baglanti_tipi { get; set; }
    }
}
