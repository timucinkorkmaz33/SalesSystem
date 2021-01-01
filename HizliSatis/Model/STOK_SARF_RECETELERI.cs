namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_SARF_RECETELERI
    {
        [Key]
        public int sr_sr_no { get; set; }

        public short sr_sr_id_DBCno { get; set; }

        public int sr_sr_id_sr_no { get; set; }

        public int? sr_Specsr_no { get; set; }

        public bool? sr_iptal { get; set; }

        public short? sr_fileid { get; set; }

        public bool? sr_hidden { get; set; }

        public bool? sr_kilitli { get; set; }

        public bool? sr_degisti { get; set; }

        public int? sr_checksum { get; set; }

        public short? sr_create_user { get; set; }

        public DateTime? sr_create_date { get; set; }

        public short? sr_lastup_user { get; set; }

        public DateTime? sr_lastup_date { get; set; }

        [StringLength(4)]
        public string sr_special1 { get; set; }

        [StringLength(4)]
        public string sr_special2 { get; set; }

        [StringLength(4)]
        public string sr_special3 { get; set; }

        [StringLength(25)]
        public string sr_anakod { get; set; }

        public DateTime? sr_tarih { get; set; }

        [StringLength(50)]
        public string sr_aciklama { get; set; }

        public byte? sr_anabirim { get; set; }

        public double? sr_anamiktar { get; set; }

        [StringLength(25)]
        public string sr_tuketim_kod { get; set; }

        public double? sr_tuketim_miktar { get; set; }

        public byte? sr_tuketim_birim { get; set; }

        public int? sr_satirno { get; set; }

        [StringLength(50)]
        public string sr_satir_acik { get; set; }

        public int? sr_depono { get; set; }

        public double? sr_fireyuzde { get; set; }

        public double? sr_parti_miktari { get; set; }

        public byte? sr_recetecinsi { get; set; }
    }
}
