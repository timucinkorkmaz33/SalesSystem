namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERIYODIK_EVRAKLAR
    {
        [Key]
        public int PE_RECno { get; set; }

        public short PE_RECid_DBCno { get; set; }

        public int PE_RECid_RECno { get; set; }

        public int? PE_Spec_Rec_no { get; set; }

        public bool? PE_iptal { get; set; }

        public short? PE_fileid { get; set; }

        public bool? PE_hidden { get; set; }

        public bool? PE_kilitli { get; set; }

        public bool? PE_degisti { get; set; }

        public int? PE_checksum { get; set; }

        public short? PE_create_user { get; set; }

        public DateTime? PE_create_date { get; set; }

        public short? PE_lastup_user { get; set; }

        public DateTime? PE_lastup_date { get; set; }

        [StringLength(4)]
        public string PE_special1 { get; set; }

        [StringLength(4)]
        public string PE_special2 { get; set; }

        [StringLength(4)]
        public string PE_special3 { get; set; }

        public int? PE_firmano { get; set; }

        public int? PE_subeno { get; set; }

        public byte? PE_tip { get; set; }

        public DateTime? PE_evraktarihi { get; set; }

        [StringLength(6)]
        public string PE_evrakseri { get; set; }

        public int? PE_evraksira { get; set; }

        public int? PE_evraksatir { get; set; }

        [StringLength(20)]
        public string PE_belgeno { get; set; }

        public DateTime? PE_belge_tarih { get; set; }

        [StringLength(25)]
        public string PE_carikodu { get; set; }

        [StringLength(25)]
        public string PE_carisrmmrk { get; set; }

        public int? PE_adresno { get; set; }

        public DateTime? PE_sonrakifaturatarihi { get; set; }

        public short? PE_periyot { get; set; }

        public byte? PE_periyottipi { get; set; }

        public int? PE_adet { get; set; }

        [StringLength(40)]
        public string PE_genelaciklama { get; set; }

        public byte? PE_harekettipi { get; set; }

        [StringLength(25)]
        public string PE_hareketkodu { get; set; }

        [StringLength(40)]
        public string PE_satiraciklama { get; set; }

        public double? PE_miktari { get; set; }

        public double? PE_fiyati { get; set; }

        public double? PE_iskonto_1 { get; set; }

        public double? PE_iskonto_2 { get; set; }

        public double? PE_iskonto_3 { get; set; }

        public double? PE_iskonto_4 { get; set; }

        public double? PE_iskonto_5 { get; set; }

        public double? PE_iskonto_6 { get; set; }

        public double? PE_masraf_1 { get; set; }

        public double? PE_masraf_2 { get; set; }

        public double? PE_masraf_3 { get; set; }

        public double? PE_masraf_4 { get; set; }

        public byte? PE_iskonto1 { get; set; }

        public byte? PE_iskonto2 { get; set; }

        public byte? PE_iskonto3 { get; set; }

        public byte? PE_iskonto4 { get; set; }

        public byte? PE_iskonto5 { get; set; }

        public byte? PE_iskonto6 { get; set; }

        public byte? PE_masraf1 { get; set; }

        public byte? PE_masraf2 { get; set; }

        public byte? PE_masraf3 { get; set; }

        public byte? PE_masraf4 { get; set; }

        public bool? PE_isk1 { get; set; }

        public bool? PE_isk2 { get; set; }

        public bool? PE_isk3 { get; set; }

        public bool? PE_isk4 { get; set; }

        public bool? PE_isk5 { get; set; }

        public bool? PE_isk6 { get; set; }

        public bool? PE_mas1 { get; set; }

        public bool? PE_mas2 { get; set; }

        public bool? PE_mas3 { get; set; }

        public bool? PE_mas4 { get; set; }

        public byte? PE_vergipntr { get; set; }

        public int? PE_opno { get; set; }

        public byte? PE_grupno { get; set; }

        public byte? PE_doviz_cins { get; set; }

        public double? PE_doviz_kur { get; set; }

        public byte? PE_karsidcinsi { get; set; }

        public double? PE_karsid_kur { get; set; }

        public byte? PE_faturalamakuru { get; set; }

        [StringLength(25)]
        public string PE_srmmrkkodu { get; set; }

        [StringLength(25)]
        public string PE_projekodu { get; set; }

        [StringLength(25)]
        public string PE_plasiyerkodu { get; set; }

        public bool? PE_pasif { get; set; }

        [StringLength(5)]
        public string PE_Istisna { get; set; }
    }
}
