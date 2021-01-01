namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_PAKET_TANIMLARI
    {
        [Key]
        public int pak_RECno { get; set; }

        public short pak_RECid_DBCno { get; set; }

        public int pak_RECid_RECno { get; set; }

        public int? pak_SpecRECno { get; set; }

        public bool? pak_iptal { get; set; }

        public short? pak_fileid { get; set; }

        public bool? pak_hidden { get; set; }

        public bool? pak_kilitli { get; set; }

        public bool? pak_degisti { get; set; }

        public int? pak_checksum { get; set; }

        public short? pak_create_user { get; set; }

        public DateTime? pak_create_date { get; set; }

        public short? pak_lastup_user { get; set; }

        public DateTime? pak_lastup_date { get; set; }

        [StringLength(4)]
        public string pak_special1 { get; set; }

        [StringLength(4)]
        public string pak_special2 { get; set; }

        [StringLength(4)]
        public string pak_special3 { get; set; }

        [StringLength(25)]
        public string pak_kod { get; set; }

        [StringLength(25)]
        public string pak_stokkod { get; set; }

        public double? pak_miktar { get; set; }

        [StringLength(50)]
        public string pak_aciklama { get; set; }

        public int? pak_satirno { get; set; }

        public double? pak_fiyat { get; set; }

        public byte? pak_vergidahilfl { get; set; }

        public byte? pak_master_tip { get; set; }

        public byte? pak_detay_tip { get; set; }

        public byte? pak_doviz_cins { get; set; }

        public byte? pak_ve_veya { get; set; }

        [StringLength(50)]
        public string pak_ismi { get; set; }
    }
}
