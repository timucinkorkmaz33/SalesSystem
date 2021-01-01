namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_MALZEME_PLANLAMA
    {
        [Key]
        public int upl_RECno { get; set; }

        public short upl_RECid_DBCno { get; set; }

        public int upl_RECid_RECno { get; set; }

        public int? upl_SpecRECno { get; set; }

        public bool? upl_iptal { get; set; }

        public short? upl_fileid { get; set; }

        public bool? upl_hidden { get; set; }

        public bool? upl_kilitli { get; set; }

        public bool? upl_degisti { get; set; }

        public int? upl_checksum { get; set; }

        public short? upl_create_user { get; set; }

        public DateTime? upl_create_date { get; set; }

        public short? upl_lastup_user { get; set; }

        public DateTime? upl_lastup_date { get; set; }

        [StringLength(4)]
        public string upl_special1 { get; set; }

        [StringLength(4)]
        public string upl_special2 { get; set; }

        [StringLength(4)]
        public string upl_special3 { get; set; }

        [StringLength(25)]
        public string upl_isemri { get; set; }

        public int? upl_satirno { get; set; }

        public byte? upl_uretim_tuket { get; set; }

        [StringLength(25)]
        public string upl_kodu { get; set; }

        [StringLength(25)]
        public string upl_fasoncukod { get; set; }

        public DateTime? upl_har_tarih { get; set; }

        public double? upl_miktar { get; set; }

        [StringLength(40)]
        public string upl_aciklama { get; set; }

        public int? upl_depno { get; set; }

        [StringLength(25)]
        public string upl_urstokkod { get; set; }

        public double? upl_uret_miktar { get; set; }

        [StringLength(25)]
        public string upl_parti_kod { get; set; }

        public int? upl_lotno { get; set; }

        public byte? upl_sarfturu { get; set; }

        public double? upl_sarfmiktari { get; set; }

        public short? upl_safhano { get; set; }

        public byte? upl_PlanlamaTipi { get; set; }

        public byte? upl_nereden { get; set; }

        public byte? upl_hesap_tipi { get; set; }

        public DateTime? upl_gecerlilik_tarihi { get; set; }

        public double? upl_rezervasyon_miktari { get; set; }

        public double? upl_rezerveden_teslim_edilen { get; set; }

        [StringLength(25)]
        public string upl_recete_tanim_kodu { get; set; }

        public byte? upl_recete_cinsi { get; set; }
    }
}
