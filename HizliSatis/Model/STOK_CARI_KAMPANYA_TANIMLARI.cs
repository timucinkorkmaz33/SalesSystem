namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_CARI_KAMPANYA_TANIMLARI
    {
        [Key]
        public int kampanya_RECno { get; set; }

        public short kampanya_RECid_DBCno { get; set; }

        public int kampanya_RECid_RECno { get; set; }

        public int? kampanya_SpecRECno { get; set; }

        public bool? kampanya_iptal { get; set; }

        public short? kampanya_fileid { get; set; }

        public bool? kampanya_hidden { get; set; }

        public bool? kampanya_kilitli { get; set; }

        public bool? kampanya_degisti { get; set; }

        public int? kampanya_checksum { get; set; }

        public short? kampanya_create_user { get; set; }

        public DateTime? kampanya_create_date { get; set; }

        public short? kampanya_lastup_user { get; set; }

        public DateTime? kampanya_lastup_date { get; set; }

        [StringLength(4)]
        public string kampanya_special1 { get; set; }

        [StringLength(4)]
        public string kampanya_special2 { get; set; }

        [StringLength(4)]
        public string kampanya_special3 { get; set; }

        [StringLength(4)]
        public string kampanya_stok_kod { get; set; }

        [StringLength(4)]
        public string kampanya_cari_kod { get; set; }

        [StringLength(50)]
        public string kampanya_aciklama { get; set; }

        public int? kampanya_ilave_vade { get; set; }

        public double? kampanya_ilave_iskonto { get; set; }

        public byte? kampanya_iskonto_no { get; set; }
    }
}
