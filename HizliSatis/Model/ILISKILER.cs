namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ILISKILER")]
    public partial class ILISKILER
    {
        [Key]
        public int il_RECno { get; set; }

        public short il_RECid_DBCno { get; set; }

        public int il_RECid_RECno { get; set; }

        public int? il_SpecRECno { get; set; }

        public bool? il_iptal { get; set; }

        public short? il_fileid { get; set; }

        public bool? il_hidden { get; set; }

        public bool? il_kilitli { get; set; }

        public bool? il_degisti { get; set; }

        public int? il_checksum { get; set; }

        public short? il_create_user { get; set; }

        public DateTime? il_create_date { get; set; }

        public short? il_lastup_user { get; set; }

        public DateTime? il_lastup_date { get; set; }

        [StringLength(4)]
        public string il_special1 { get; set; }

        [StringLength(4)]
        public string il_special2 { get; set; }

        [StringLength(4)]
        public string il_special3 { get; set; }

        public DateTime? il_baszaman { get; set; }

        public DateTime? il_bitzaman { get; set; }

        [StringLength(25)]
        public string il_sorumlu_personel { get; set; }

        public byte? il_iliski_tipi { get; set; }

        [StringLength(25)]
        public string il_carikodu { get; set; }

        public int? il_adres_no { get; set; }

        public short? il_yetkiliRecID_DBCno { get; set; }

        public int? il_yetkiliRecID_RECno { get; set; }

        [StringLength(50)]
        public string il_yetkiliadi { get; set; }

        [StringLength(80)]
        public string il_yer { get; set; }

        [StringLength(80)]
        public string il_konu { get; set; }

        [StringLength(25)]
        public string il_refno { get; set; }

        [StringLength(25)]
        public string il_projekodu { get; set; }

        public byte? il_oncelik { get; set; }

        public byte? il_cari_tipi { get; set; }
    }
}
