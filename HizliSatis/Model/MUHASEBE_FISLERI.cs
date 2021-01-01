namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_FISLERI
    {
        [Key]
        public int fis_RECno { get; set; }

        public short fis_RECid_DBCno { get; set; }

        public int fis_RECid_RECno { get; set; }

        public int? fis_SpecRECno { get; set; }

        public bool? fis_iptal { get; set; }

        public short? fis_fileid { get; set; }

        public bool? fis_hidden { get; set; }

        public bool? fis_kilitli { get; set; }

        public bool? fis_degisti { get; set; }

        public int? fis_checksum { get; set; }

        public short? fis_create_user { get; set; }

        public DateTime? fis_create_date { get; set; }

        public short? fis_lastup_user { get; set; }

        public DateTime? fis_lastup_date { get; set; }

        [StringLength(4)]
        public string fis_special1 { get; set; }

        [StringLength(4)]
        public string fis_special2 { get; set; }

        [StringLength(4)]
        public string fis_special3 { get; set; }

        public int? fis_firmano { get; set; }

        public int? fis_subeno { get; set; }

        public int? fis_maliyil { get; set; }

        public DateTime? fis_tarih { get; set; }

        public int? fis_sira_no { get; set; }

        public byte? fis_tur { get; set; }

        [StringLength(25)]
        public string fis_hesap_kod { get; set; }

        public int? fis_satir_no { get; set; }

        [StringLength(127)]
        public string fis_aciklama1 { get; set; }

        public double? fis_meblag0 { get; set; }

        public double? fis_meblag1 { get; set; }

        public double? fis_meblag2 { get; set; }

        public double? fis_meblag3 { get; set; }

        public double? fis_meblag4 { get; set; }

        public double? fis_meblag5 { get; set; }

        public double? fis_meblag6 { get; set; }

        [StringLength(25)]
        public string fis_sorumluluk_kodu { get; set; }

        public byte? fis_ticari_tip { get; set; }

        public short? fis_ticari_DBCno { get; set; }

        public int? fis_ticari_RECno { get; set; }

        public bool? fis_kurfarkifl { get; set; }

        public byte? fis_ticari_evraktip { get; set; }

        [StringLength(6)]
        public string fis_tic_evrak_seri { get; set; }

        public int? fis_tic_evrak_sira { get; set; }

        [StringLength(20)]
        public string fis_tic_belgeno { get; set; }

        public DateTime? fis_tic_belgetarihi { get; set; }

        public int? fis_yevmiye_no { get; set; }

        public short? fis_katagori { get; set; }

        public short? fis_evrak_DBCno { get; set; }

        public byte? fis_fmahsup_tipi { get; set; }

        [StringLength(25)]
        public string fis_fozelmahkod { get; set; }

        [StringLength(4)]
        public string fis_grupkodu { get; set; }

        public byte? fis_aktif_pasif { get; set; }

        [StringLength(25)]
        public string fis_proje_kodu { get; set; }
    }
}
