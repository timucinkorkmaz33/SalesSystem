namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_SATIS_SOZLESMELERI
    {
        [Key]
        public int HSS_RECno { get; set; }

        public short HSS_RECid_DBCno { get; set; }

        public int HSS_RECid_RECno { get; set; }

        public int? HSS_Spec_Rec_no { get; set; }

        public bool? HSS_iptal { get; set; }

        public short? HSS_fileid { get; set; }

        public bool? HSS_hidden { get; set; }

        public bool? HSS_kilitli { get; set; }

        public bool? HSS_degisti { get; set; }

        public int? HSS_checksum { get; set; }

        public short? HSS_create_user { get; set; }

        public DateTime? HSS_create_date { get; set; }

        public short? HSS_lastup_user { get; set; }

        public DateTime? HSS_lastup_date { get; set; }

        [StringLength(4)]
        public string HSS_special1 { get; set; }

        [StringLength(4)]
        public string HSS_special2 { get; set; }

        [StringLength(4)]
        public string HSS_special3 { get; set; }

        public int? HSS_firmano { get; set; }

        public int? HSS_subeno { get; set; }

        public DateTime? HSS_evraktarihi { get; set; }

        [StringLength(6)]
        public string HSS_evrakseri { get; set; }

        public int? HSS_evraksira { get; set; }

        public int? HSS_evraksatir { get; set; }

        [StringLength(25)]
        public string HSS_carikodu { get; set; }

        [StringLength(25)]
        public string HSS_carisrmmrk { get; set; }

        public DateTime? HSS_tarihi { get; set; }

        [StringLength(25)]
        public string HSS_hizmetkodu { get; set; }

        [StringLength(40)]
        public string HSS_aciklama { get; set; }

        public double? HSS_fiyati { get; set; }

        public int? HSS_opno { get; set; }

        [StringLength(6)]
        public string HSS_kesfatseri { get; set; }

        public int? HSS_kesfatsira { get; set; }

        [StringLength(25)]
        public string HSS_srmmrkkodu { get; set; }

        [StringLength(25)]
        public string HSS_projekodu { get; set; }

        public double? HSS_miktari { get; set; }

        public short? HSS_OnaylayanKulNo { get; set; }

        public bool? HSS_cagrilabilir_fl { get; set; }

        [StringLength(25)]
        public string HSS_carisozlesmekodu { get; set; }

        public byte? HSS_carisozlesmeakttipi { get; set; }

        public byte? HSS_grupno { get; set; }

        public byte? HSS_doviz_cins { get; set; }

        public double? HSS_doviz_kur { get; set; }

        public double? HSS_alt_doviz_kur { get; set; }

        public short? HSS_chasgir_recid_dbcno { get; set; }

        public int? HSS_chasgir_recid_recno { get; set; }

        [StringLength(25)]
        public string HSS_BagliKiraKodu { get; set; }

        public byte? HSS_BagliKiraTipi { get; set; }

        public byte? HSS_BagliKiraBlmNo { get; set; }

        public byte? HSS_BagliKiraBlmDonemNo { get; set; }

        public bool? HSS_Guncellendi_fl { get; set; }

        public double? HSS_GuncOncekifiyati { get; set; }

        public double? HSS_GuncOncekiEndeks { get; set; }

        [StringLength(25)]
        public string HSS_saticikodu { get; set; }

        [StringLength(20)]
        public string HSS_belgeno { get; set; }

        public DateTime? HSS_belge_tarih { get; set; }
    }
}
