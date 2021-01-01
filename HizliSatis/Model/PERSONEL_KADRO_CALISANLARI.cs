namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_CALISANLARI
    {
        [Key]
        public int kdrc_RECno { get; set; }

        public short kdrc_RECid_DBCno { get; set; }

        public int kdrc_RECid_RECno { get; set; }

        public int? kdrc_SpecRECno { get; set; }

        public bool? kdrc_iptal { get; set; }

        public short? kdrc_fileid { get; set; }

        public bool? kdrc_hidden { get; set; }

        public bool? kdrc_kilitli { get; set; }

        public bool? kdrc_degisti { get; set; }

        public int? kdrc_checksum { get; set; }

        public short? kdrc_create_user { get; set; }

        public DateTime? kdrc_create_date { get; set; }

        public short? kdrc_lastup_user { get; set; }

        public DateTime? kdrc_lastup_date { get; set; }

        [StringLength(4)]
        public string kdrc_special1 { get; set; }

        [StringLength(4)]
        public string kdrc_special2 { get; set; }

        [StringLength(4)]
        public string kdrc_special3 { get; set; }

        [StringLength(25)]
        public string kdrc_kod { get; set; }

        public int? kdrc_sirano { get; set; }

        [StringLength(25)]
        public string kdrc_personel { get; set; }

        public byte? kdrc_pers_asil_vekil { get; set; }

        [StringLength(25)]
        public string kdrc_yedek_personel { get; set; }

        public bool? kdrc_semada_gosterme { get; set; }

        public DateTime? kdrc_atamatarihi { get; set; }

        public int? kdrc_idari_amir_no { get; set; }

        public int? kdrc_teknik_amir_no { get; set; }

        public int? kdrc_raporlama_yap_kadro_no { get; set; }

        public int? kdrc_vekalet_kadro_no { get; set; }

        [StringLength(25)]
        public string kdrc_bolge_kodu { get; set; }

        [StringLength(25)]
        public string kdrc_bolum_kodu { get; set; }

        [StringLength(25)]
        public string kdrc_departman_kodu { get; set; }

        [StringLength(30)]
        public string kdrc_ulke { get; set; }

        [StringLength(25)]
        public string kdrc_sormrkz { get; set; }

        [StringLength(25)]
        public string kdrc_alt_departman_kodu { get; set; }

        public double? kdrc_butcesi { get; set; }
    }
}
