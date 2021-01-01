namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PROJELER")]
    public partial class PROJELER
    {
        [Key]
        public int pro_RECno { get; set; }

        public short pro_RECid_DBCno { get; set; }

        public int pro_RECid_RECno { get; set; }

        public int? pro_SpecRECno { get; set; }

        public bool? pro_iptal { get; set; }

        public short? pro_fileid { get; set; }

        public bool? pro_hidden { get; set; }

        public bool? pro_kilitli { get; set; }

        public bool? pro_degisti { get; set; }

        public int? pro_checksum { get; set; }

        public short? pro_create_user { get; set; }

        public DateTime? pro_create_date { get; set; }

        public short? pro_lastup_user { get; set; }

        public DateTime? pro_lastup_date { get; set; }

        [StringLength(4)]
        public string pro_special1 { get; set; }

        [StringLength(4)]
        public string pro_special2 { get; set; }

        [StringLength(4)]
        public string pro_special3 { get; set; }

        [StringLength(25)]
        public string pro_kodu { get; set; }

        [StringLength(40)]
        public string pro_adi { get; set; }

        [StringLength(25)]
        public string pro_musterikodu { get; set; }

        [StringLength(25)]
        public string pro_sormerkodu { get; set; }

        [StringLength(25)]
        public string pro_bolgekodu { get; set; }

        [StringLength(25)]
        public string pro_sektorkodu { get; set; }

        [StringLength(25)]
        public string pro_grupkodu { get; set; }

        [StringLength(10)]
        public string pro_muh_kod_artikeli { get; set; }

        public byte? pro_durumu { get; set; }

        [StringLength(50)]
        public string pro_aciklama { get; set; }

        [StringLength(25)]
        public string pro_ana_projekodu { get; set; }

        public int? pro_planlanan_sure { get; set; }

        public DateTime? pro_planlanan_bastarih { get; set; }

        public DateTime? pro_planlanan_bittarih { get; set; }

        public DateTime? pro_gerceklesen_bastarih { get; set; }

        public DateTime? pro_gerceklesen_bittarih { get; set; }

        [StringLength(50)]
        public string pro_baslangic_gecikmesebep { get; set; }

        [StringLength(50)]
        public string pro_bitis_gecikmesebep { get; set; }

        public double? pro_performans_orani { get; set; }

        public byte? pro_teminat_sekli { get; set; }

        public byte? pro_teminat_doviz_cinsi { get; set; }

        public double? pro_teminat { get; set; }

        public byte? pro_isavansi_sekli { get; set; }

        public byte? pro_isavansi_doviz_cinsi { get; set; }

        public double? pro_isavansi { get; set; }
    }
}
