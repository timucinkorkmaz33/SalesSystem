namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVM_CARI_HASILAT_HAREKETLERI
    {
        [Key]
        public int CH_RECno { get; set; }

        public short CH_RECid_DBCno { get; set; }

        public int CH_RECid_RECno { get; set; }

        public int? CH_Spec_Rec_no { get; set; }

        public bool? CH_iptal { get; set; }

        public short? CH_fileid { get; set; }

        public bool? CH_hidden { get; set; }

        public bool? CH_kilitli { get; set; }

        public bool? CH_degisti { get; set; }

        public int? CH_checksum { get; set; }

        public short? CH_create_user { get; set; }

        public DateTime? CH_create_date { get; set; }

        public short? CH_lastup_user { get; set; }

        public DateTime? CH_lastup_date { get; set; }

        [StringLength(4)]
        public string CH_special1 { get; set; }

        [StringLength(4)]
        public string CH_special2 { get; set; }

        [StringLength(4)]
        public string CH_special3 { get; set; }

        public int? CH_firmano { get; set; }

        public int? CH_subeno { get; set; }

        public DateTime? CH_evraktarihi { get; set; }

        [StringLength(6)]
        public string CH_evrakseri { get; set; }

        public int? CH_evraksira { get; set; }

        public int? CH_evraksatir { get; set; }

        [StringLength(25)]
        public string CH_carikodu { get; set; }

        [StringLength(25)]
        public string CH_carisrmmrk { get; set; }

        public DateTime? CH_tarihi { get; set; }

        [StringLength(25)]
        public string CH_hizmetkodu { get; set; }

        [StringLength(40)]
        public string CH_aciklama { get; set; }

        public double? CH_fiyati { get; set; }

        public byte? CH_grupno { get; set; }

        public int? CH_opno { get; set; }

        [StringLength(25)]
        public string CH_srmmrkkodu { get; set; }

        public byte? CH_doviz_cins { get; set; }

        public double? CH_doviz_kur { get; set; }

        public double? CH_alt_doviz_kur { get; set; }

        public short? CH_OnaylayanKulNo { get; set; }

        public bool? CH_cagrilabilir_fl { get; set; }

        public double? CH_CiroKiraOrani { get; set; }

        public double? CH_CiroKirasi { get; set; }

        public bool? CH_SozlesmeOlustu_fl { get; set; }

        [StringLength(25)]
        public string CH_KiraKodu { get; set; }

        public int? CH_FisSayisi { get; set; }

        public double? CH_AsgariKira { get; set; }

        public double? CH_KesGerekCiroKirasi { get; set; }

        public double? CH_KesGerekCiroKuru { get; set; }

        public byte? CH_vergi_pntr { get; set; }

        public double? CH_vergi { get; set; }

        public bool? CHHesaplandi_fl { get; set; }

        public double? CH_OrtakGider { get; set; }

        [StringLength(25)]
        public string CH_ProjeKodu { get; set; }

        public double? CH_Dvzfiyati { get; set; }

        public double? CH_AnaKesGerekCiroKirasi { get; set; }

        public bool? CH_Oran1_fl { get; set; }

        public bool? CH_Oran2_fl { get; set; }

        public bool? CH_Oran3_fl { get; set; }
    }
}
