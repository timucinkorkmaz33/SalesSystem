namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_FATURA_OPERASYON_LOGLARI
    {
        [Key]
        public int efol_RECno { get; set; }

        public short efol_RECid_DBCno { get; set; }

        public int efol_RECid_RECno { get; set; }

        public int? efol_SpecRECno { get; set; }

        public bool? efol_iptal { get; set; }

        public short? efol_fileid { get; set; }

        public bool? efol_hidden { get; set; }

        public bool? efol_kilitli { get; set; }

        public bool? efol_degisti { get; set; }

        public int? efol_checksum { get; set; }

        public short? efol_create_user { get; set; }

        public DateTime? efol_create_date { get; set; }

        public short? efol_lastup_user { get; set; }

        public DateTime? efol_lastup_date { get; set; }

        [StringLength(4)]
        public string efol_special1 { get; set; }

        [StringLength(4)]
        public string efol_special2 { get; set; }

        [StringLength(4)]
        public string efol_special3 { get; set; }

        public int? efol_firmano { get; set; }

        public byte? efol_tipi { get; set; }

        [StringLength(20)]
        public string efol_gib_fatno { get; set; }

        [StringLength(15)]
        public string efol_mus_vkn { get; set; }

        [StringLength(40)]
        public string efol_uuid { get; set; }

        public short? efol_log_kodu { get; set; }

        [StringLength(127)]
        public string efol_log_aciklama { get; set; }

        public DateTime? efol_ilktarih { get; set; }

        public DateTime? efol_sontarih { get; set; }

        [StringLength(40)]
        public string efol_islem_id { get; set; }
    }
}
