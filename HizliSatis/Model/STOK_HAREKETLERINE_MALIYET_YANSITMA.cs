namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_HAREKETLERINE_MALIYET_YANSITMA
    {
        [Key]
        public int shmy_RECno { get; set; }

        public short shmy_RECid_DBCno { get; set; }

        public int shmy_RECid_RECno { get; set; }

        public int? shmy_SpecRECno { get; set; }

        public bool? shmy_iptal { get; set; }

        public short? shmy_fileid { get; set; }

        public bool? shmy_hidden { get; set; }

        public bool? shmy_kilitli { get; set; }

        public bool? shmy_degisti { get; set; }

        public int? shmy_checksum { get; set; }

        public short? shmy_create_user { get; set; }

        public DateTime? shmy_create_date { get; set; }

        public short? shmy_lastup_user { get; set; }

        public DateTime? shmy_lastup_date { get; set; }

        [StringLength(4)]
        public string shmy_special1 { get; set; }

        [StringLength(4)]
        public string shmy_special2 { get; set; }

        [StringLength(4)]
        public string shmy_special3 { get; set; }

        public DateTime? shmy_tarihi { get; set; }

        [StringLength(6)]
        public string shmy_evrakno_seri { get; set; }

        public int? shmy_evrakno_sira { get; set; }

        public int? shmy_satirno { get; set; }

        public short? shmy_har_recid_dbcno { get; set; }

        public int? shmy_har_recid_recno { get; set; }

        public double? shmy_ilave_maliyet_ana { get; set; }

        public double? shmy_ilave_maliyet_alt { get; set; }

        public double? shmy_ilave_maliyet_orj { get; set; }

        [StringLength(50)]
        public string shmy_aciklama { get; set; }
    }
}
