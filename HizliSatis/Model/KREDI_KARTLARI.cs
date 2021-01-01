namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KREDI_KARTLARI
    {
        [Key]
        public int kka_RECno { get; set; }

        public short kka_RECid_DBCno { get; set; }

        public int kka_RECid_RECno { get; set; }

        public int? kka_SpecRECno { get; set; }

        public bool? kka_iptal { get; set; }

        public short? kka_fileid { get; set; }

        public bool? kka_hidden { get; set; }

        public bool? kka_kilitli { get; set; }

        public bool? kka_degisti { get; set; }

        public int? kka_checksum { get; set; }

        public short? kka_create_user { get; set; }

        public DateTime? kka_create_date { get; set; }

        public short? kka_lastup_user { get; set; }

        public DateTime? kka_lastup_date { get; set; }

        [StringLength(4)]
        public string kka_special1 { get; set; }

        [StringLength(4)]
        public string kka_special2 { get; set; }

        [StringLength(4)]
        public string kka_special3 { get; set; }

        public short? kka_yetkili_DBCno { get; set; }

        public int? kka_yetkili_RECno { get; set; }

        [StringLength(16)]
        public string kka_no { get; set; }

        [StringLength(4)]
        public string kka_cvc_no { get; set; }

        [StringLength(2)]
        public string kka_sonay { get; set; }

        [StringLength(2)]
        public string kka_sonyil { get; set; }

        public byte? kka_tipi { get; set; }

        [StringLength(50)]
        public string kka_isim { get; set; }

        [StringLength(4)]
        public string kka_BankaKodu { get; set; }
    }
}
