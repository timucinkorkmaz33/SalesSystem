namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class POZISYON_BAYRAKLARI
    {
        [Key]
        public int pb_RECno { get; set; }

        public short pb_RECid_DBCno { get; set; }

        public int pb_RECid_RECno { get; set; }

        public int? pb_SpecRECno { get; set; }

        public bool? pb_iptal { get; set; }

        public short? pb_fileid { get; set; }

        public bool? pb_hidden { get; set; }

        public bool? pb_kilitli { get; set; }

        public bool? pb_degisti { get; set; }

        public int? pb_checksum { get; set; }

        public short? pb_create_user { get; set; }

        public DateTime? pb_create_date { get; set; }

        public short? pb_lastup_user { get; set; }

        public DateTime? pb_lastup_date { get; set; }

        [StringLength(4)]
        public string pb_special1 { get; set; }

        [StringLength(4)]
        public string pb_special2 { get; set; }

        [StringLength(4)]
        public string pb_special3 { get; set; }

        [StringLength(25)]
        public string pb_kod { get; set; }

        [StringLength(50)]
        public string pb_ismi { get; set; }

        public byte? pb_detay_takip { get; set; }

        public byte? pb_satis_dursun { get; set; }

        public byte? pb_siparis_dursun { get; set; }

        public byte? pb_malkabul_dursun { get; set; }

        public bool? pb_malkabul_gun1 { get; set; }

        public bool? pb_malkabul_gun2 { get; set; }

        public bool? pb_malkabul_gun3 { get; set; }

        public bool? pb_malkabul_gun4 { get; set; }

        public bool? pb_malkabul_gun5 { get; set; }

        public bool? pb_malkabul_gun6 { get; set; }

        public bool? pb_malkabul_gun7 { get; set; }

        public bool? pb_siparis_gun1 { get; set; }

        public bool? pb_siparis_gun2 { get; set; }

        public bool? pb_siparis_gun3 { get; set; }

        public bool? pb_siparis_gun4 { get; set; }

        public bool? pb_siparis_gun5 { get; set; }

        public bool? pb_siparis_gun6 { get; set; }

        public bool? pb_siparis_gun7 { get; set; }

        [StringLength(25)]
        public string pb_yer_kod { get; set; }

        public bool? pb_pasif_fl { get; set; }

        public byte? pb_etiket_bas { get; set; }

        public byte? pb_elk_etk_tipi { get; set; }

        public byte? pb_raf_etiketli { get; set; }

        public short? pb_RafOmru { get; set; }
    }
}
