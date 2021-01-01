namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_ALIS_SOZLESMELERI
    {
        [Key]
        public int HAS_RECno { get; set; }

        public short HAS_RECid_DBCno { get; set; }

        public int HAS_RECid_RECno { get; set; }

        public int? HAS_Spec_Rec_no { get; set; }

        public bool? HAS_iptal { get; set; }

        public short? HAS_fileid { get; set; }

        public bool? HAS_hidden { get; set; }

        public bool? HAS_kilitli { get; set; }

        public bool? HAS_degisti { get; set; }

        public int? HAS_checksum { get; set; }

        public short? HAS_create_user { get; set; }

        public DateTime? HAS_create_date { get; set; }

        public short? HAS_lastup_user { get; set; }

        public DateTime? HAS_lastup_date { get; set; }

        [StringLength(4)]
        public string HAS_special1 { get; set; }

        [StringLength(4)]
        public string HAS_special2 { get; set; }

        [StringLength(4)]
        public string HAS_special3 { get; set; }

        public int? HAS_firmano { get; set; }

        public int? HAS_subeno { get; set; }

        public DateTime? HAS_evraktarihi { get; set; }

        [StringLength(6)]
        public string HAS_evrakseri { get; set; }

        public int? HAS_evraksira { get; set; }

        public int? HAS_evraksatir { get; set; }

        [StringLength(25)]
        public string HAS_carikodu { get; set; }

        [StringLength(25)]
        public string HAS_carisrmmrk { get; set; }

        public DateTime? HAS_tarihi { get; set; }

        [StringLength(25)]
        public string HAS_masrafkodu { get; set; }

        [StringLength(40)]
        public string HAS_aciklama { get; set; }

        public double? HAS_fiyati { get; set; }

        public int? HAS_opno { get; set; }

        [StringLength(6)]
        public string HAS_kesfatseri { get; set; }

        public int? HAS_kesfatsira { get; set; }

        [StringLength(25)]
        public string HAS_srmmrkkodu { get; set; }

        [StringLength(25)]
        public string HAS_projekodu { get; set; }

        public byte? HAS_vergipntr { get; set; }

        public short? HAS_OnaylayanKulNo { get; set; }

        public bool? HAS_cagrilabilir_fl { get; set; }

        [StringLength(25)]
        public string HAS_carisozlesmekodu { get; set; }

        public byte? HAS_carisozlesmeakttipi { get; set; }

        public byte? HAS_grupno { get; set; }

        public byte? HAS_doviz_cins { get; set; }

        public double? HAS_doviz_kur { get; set; }

        public double? HAS_alt_doviz_kur { get; set; }

        [StringLength(25)]
        public string HAS_saticikodu { get; set; }

        [StringLength(20)]
        public string HAS_belgeno { get; set; }

        public DateTime? HAS_belge_tarih { get; set; }
    }
}
