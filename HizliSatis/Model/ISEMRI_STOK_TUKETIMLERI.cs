namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISEMRI_STOK_TUKETIMLERI
    {
        [Key]
        public int tkt_RECno { get; set; }

        public short tkt_RECid_DBCno { get; set; }

        public int tkt_RECid_RECno { get; set; }

        public int? tkt_SpecRECno { get; set; }

        public bool? tkt_iptal { get; set; }

        public short? tkt_fileid { get; set; }

        public bool? tkt_hidden { get; set; }

        public bool? tkt_kilitli { get; set; }

        public bool? tkt_degisti { get; set; }

        public int? tkt_checksum { get; set; }

        public short? tkt_create_user { get; set; }

        public DateTime? tkt_create_date { get; set; }

        public short? tkt_lastup_user { get; set; }

        public DateTime? tkt_lastup_date { get; set; }

        [StringLength(4)]
        public string tkt_special1 { get; set; }

        [StringLength(4)]
        public string tkt_special2 { get; set; }

        [StringLength(4)]
        public string tkt_special3 { get; set; }

        [StringLength(25)]
        public string tkt_isemri { get; set; }

        public int? tkt_satirno { get; set; }

        [StringLength(25)]
        public string tkt_stokkodu { get; set; }

        [StringLength(25)]
        public string tkt_fasoncukodu { get; set; }

        [StringLength(25)]
        public string tkt_IsmerkeziKodu { get; set; }

        public double? tkt_miktari { get; set; }

        public double? tkt_DegerAna { get; set; }

        public double? tkt_DegerAlt { get; set; }

        public double? tkt_DegerOrj { get; set; }

        [StringLength(25)]
        public string tkt_UretimStokKodu { get; set; }

        public double? tkt_UretimMiktari { get; set; }

        public byte? tkt_birimpntr { get; set; }

        public byte? tkt_Uretimbirimpntr { get; set; }
    }
}
