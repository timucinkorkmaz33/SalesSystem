namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VERGI_MUHASEBE_KODLARI
    {
        [Key]
        public int vmk_RECno { get; set; }

        public short vmk_RECid_DBCno { get; set; }

        public int vmk_RECid_RECno { get; set; }

        public int? vmk_SpecRECno { get; set; }

        public bool? vmk_iptal { get; set; }

        public short? vmk_fileid { get; set; }

        public bool? vmk_hidden { get; set; }

        public bool? vmk_kilitli { get; set; }

        public bool? vmk_degisti { get; set; }

        public int? vmk_checksum { get; set; }

        public short? vmk_create_user { get; set; }

        public DateTime? vmk_create_date { get; set; }

        public short? vmk_lastup_user { get; set; }

        public DateTime? vmk_lastup_date { get; set; }

        [StringLength(4)]
        public string vmk_special1 { get; set; }

        [StringLength(4)]
        public string vmk_special2 { get; set; }

        [StringLength(4)]
        public string vmk_special3 { get; set; }

        public int? vmk_firmano { get; set; }

        public int? vmk_maliyil { get; set; }

        public int? vmk_kayitID { get; set; }

        [StringLength(40)]
        public string vmk_hesaplanankdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_indirilenkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_satisiadekdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_alisiadekdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_indirilenkdvtevmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_odenecekkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_ilaveedilecekkdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_ihrackarskdvmuhkodu { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut31 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut91 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut21 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut32 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut61 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut45 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodutam { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut102 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut105 { get; set; }

        [StringLength(40)]
        public string vmk_satistevmuhkodut107 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut31 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut91 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut21 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut32 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut61 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut45 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodutam { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut102 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut105 { get; set; }

        [StringLength(40)]
        public string vmk_alistevmuhkodut107 { get; set; }

        [StringLength(5)]
        public string vmk_satistevislemturu102 { get; set; }

        [StringLength(5)]
        public string vmk_satistevislemturu105 { get; set; }

        [StringLength(5)]
        public string vmk_satistevislemturu107 { get; set; }

        [StringLength(5)]
        public string vmk_satistevislemturu91 { get; set; }

        [StringLength(5)]
        public string vmk_alistevislemturu102 { get; set; }

        [StringLength(5)]
        public string vmk_alistevislemturu105 { get; set; }

        [StringLength(5)]
        public string vmk_alistevislemturu107 { get; set; }

        [StringLength(5)]
        public string vmk_alistevislemturu91 { get; set; }

        [StringLength(5)]
        public string vmk_alistevislemturutam { get; set; }

        [StringLength(5)]
        public string vmk_ihrackarsislemturu { get; set; }
    }
}
