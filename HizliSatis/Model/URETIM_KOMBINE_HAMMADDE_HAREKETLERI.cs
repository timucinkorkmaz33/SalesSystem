namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_KOMBINE_HAMMADDE_HAREKETLERI
    {
        [Key]
        public int kmh_RECno { get; set; }

        public short kmh_RECid_DBCno { get; set; }

        public int kmh_RECid_RECno { get; set; }

        public int? kmh_SpecRecno { get; set; }

        public bool? kmh_iptal { get; set; }

        public short? kmh_fileid { get; set; }

        public bool? kmh_hidden { get; set; }

        public bool? kmh_kilitli { get; set; }

        public bool? kmh_degisti { get; set; }

        public int? kmh_checksum { get; set; }

        public short? kmh_create_user { get; set; }

        public DateTime? kmh_create_date { get; set; }

        public short? kmh_lastup_user { get; set; }

        public DateTime? kmh_lastup_date { get; set; }

        [StringLength(4)]
        public string kmh_special1 { get; set; }

        [StringLength(4)]
        public string kmh_special2 { get; set; }

        [StringLength(4)]
        public string kmh_special3 { get; set; }

        [StringLength(6)]
        public string kmh_ust_seri { get; set; }

        [StringLength(15)]
        public string kmh_ust_grup { get; set; }

        public int? kmh_ust_kombine_sira { get; set; }

        [StringLength(25)]
        public string kmh_ust_isemri { get; set; }

        public int? kmh_satirno { get; set; }

        [StringLength(25)]
        public string kmh_hamkodu { get; set; }

        public double? kmh_miktar { get; set; }

        public int? kmh_evraksirano { get; set; }

        public bool? kmh_hamm_bittiFl { get; set; }

        public bool? kmh_hammBitYapFl { get; set; }

        public double? kmh_kalanmiktar { get; set; }

        [StringLength(10)]
        public string kmh_operatorNo { get; set; }

        [StringLength(10)]
        public string kmh_referansno { get; set; }

        public DateTime? kmh_BaslamaZamani { get; set; }

        public DateTime? kmh_BitisZamani { get; set; }

        public DateTime? kmh_sevktarihi { get; set; }

        public int? kmh_depono { get; set; }

        public int? kmh_evraksatirno { get; set; }

        public double? kmh_miktar2 { get; set; }

        public byte? kmh_hamm_cinsno { get; set; }

        public byte? kmh_harekettip { get; set; }

        [StringLength(25)]
        public string kmh_fasoncu_kodu { get; set; }

        [StringLength(25)]
        public string kmh_Parti { get; set; }

        public int? kmh_lot_no { get; set; }
    }
}
