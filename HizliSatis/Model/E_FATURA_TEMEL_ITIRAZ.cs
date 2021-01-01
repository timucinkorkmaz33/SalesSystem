namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_FATURA_TEMEL_ITIRAZ
    {
        [Key]
        public int eft_RECno { get; set; }

        public short eft_RECid_DBCno { get; set; }

        public int eft_RECid_RECno { get; set; }

        public int? eft_SpecRECno { get; set; }

        public bool? eft_iptal { get; set; }

        public short? eft_fileid { get; set; }

        public bool? eft_hidden { get; set; }

        public bool? eft_kilitli { get; set; }

        public bool? eft_degisti { get; set; }

        public int? eft_checksum { get; set; }

        public short? eft_create_user { get; set; }

        public DateTime? eft_create_date { get; set; }

        public short? eft_lastup_user { get; set; }

        public DateTime? eft_lastup_date { get; set; }

        [StringLength(4)]
        public string eft_special1 { get; set; }

        [StringLength(4)]
        public string eft_special2 { get; set; }

        [StringLength(4)]
        public string eft_special3 { get; set; }

        [StringLength(100)]
        public string eft_zarf_id { get; set; }

        [StringLength(40)]
        public string eft_uuid { get; set; }

        [StringLength(25)]
        public string eft_fatura_no { get; set; }

        [StringLength(25)]
        public string eft_vkn { get; set; }

        public byte? eft_pozisyon { get; set; }

        public byte? eft_kep_noter { get; set; }

        public DateTime? eft_belge_tarihi { get; set; }

        [StringLength(25)]
        public string eft_fatura_tur { get; set; }

        [StringLength(80)]
        public string eft_cari_unvan { get; set; }

        [StringLength(40)]
        public string eft_transaction_UIDD { get; set; }

        [StringLength(100)]
        public string eft_aciklama { get; set; }

        public byte? eft_image_tip { get; set; }
    }
}
