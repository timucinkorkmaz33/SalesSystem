namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EBELGE_EVRAK_HAREKETLERI
    {
        [Key]
        public int ebh_RECno { get; set; }

        public short ebh_RECid_DBCno { get; set; }

        public int ebh_RECid_RECno { get; set; }

        public int? ebh_SpecRecNo { get; set; }

        public bool? ebh_iptal { get; set; }

        public short? ebh_fileid { get; set; }

        public bool? ebh_hidden { get; set; }

        public bool? ebh_kilitli { get; set; }

        public bool? ebh_degisti { get; set; }

        public int? ebh_CheckSum { get; set; }

        public short? ebh_create_user { get; set; }

        public DateTime? ebh_create_date { get; set; }

        public short? ebh_lastup_user { get; set; }

        public DateTime? ebh_lastup_date { get; set; }

        [StringLength(4)]
        public string ebh_special1 { get; set; }

        [StringLength(4)]
        public string ebh_special2 { get; set; }

        [StringLength(4)]
        public string ebh_special3 { get; set; }

        public byte? ebh_hareket_tipi { get; set; }

        public short? ebh_related_DBCno { get; set; }

        public int? ebh_related_RECno { get; set; }

        public byte? ebh_odeme_sekli { get; set; }

        [StringLength(50)]
        public string ebh_odeme_aciklama { get; set; }

        [StringLength(50)]
        public string ebh_odeme_aracisi { get; set; }

        [StringLength(50)]
        public string ebh_satisin_webadresi { get; set; }

        public DateTime? ebh_gonderi_tarihi { get; set; }

        [StringLength(25)]
        public string ebh_gonderi_tasiyan { get; set; }

        [StringLength(25)]
        public string ebh_gonderi_no { get; set; }

        [StringLength(25)]
        public string ebh_iade_fat_no1 { get; set; }

        public DateTime? ebh_iade_fat_tarihi1 { get; set; }

        [StringLength(120)]
        public string ebh_ekli_dosya { get; set; }

        [StringLength(30)]
        public string ebh_mukellefiyetdosyano { get; set; }

        public DateTime? ebh_mukellefiyetdonembasi { get; set; }

        public DateTime? ebh_mukellefiyetdonemsonu { get; set; }
    }
}
