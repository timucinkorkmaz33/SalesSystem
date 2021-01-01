namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GIDER_KATILIM_SOZLESMELERI
    {
        [Key]
        public int gks_RECno { get; set; }

        public short gks_RECid_DBCno { get; set; }

        public int gks_RECid_RECno { get; set; }

        public int? gks_Spec_Rec_no { get; set; }

        public bool? gks_iptal { get; set; }

        public short? gks_fileid { get; set; }

        public bool? gks_hidden { get; set; }

        public bool? gks_kilitli { get; set; }

        public bool? gks_degisti { get; set; }

        public int? gks_checksum { get; set; }

        public short? gks_create_user { get; set; }

        public DateTime? gks_create_date { get; set; }

        public short? gks_lastup_user { get; set; }

        public DateTime? gks_lastup_date { get; set; }

        [StringLength(4)]
        public string gks_special1 { get; set; }

        [StringLength(4)]
        public string gks_special2 { get; set; }

        [StringLength(4)]
        public string gks_special3 { get; set; }

        public int? gks_firmano { get; set; }

        public int? gks_subeno { get; set; }

        public DateTime? gks_evraktarihi { get; set; }

        [StringLength(6)]
        public string gks_evrakseri { get; set; }

        public int? gks_evraksira { get; set; }

        public int? gks_evraksatir { get; set; }

        [StringLength(25)]
        public string gks_carikodu { get; set; }

        public byte? gks_grupno { get; set; }

        [StringLength(25)]
        public string gks_carisrmmrk { get; set; }

        [StringLength(25)]
        public string gks_proje { get; set; }

        [StringLength(25)]
        public string gks_hizmetkodu { get; set; }

        [StringLength(25)]
        public string gks_srmmrkkodu { get; set; }

        public DateTime? gks_gecerliliktarihi { get; set; }

        [StringLength(40)]
        public string gks_aciklama { get; set; }

        public byte? gks_tipi { get; set; }

        public double? gks_miktar { get; set; }

        public double? gks_karorani { get; set; }

        public double? gks_sabittutar { get; set; }

        [StringLength(25)]
        public string gks_dagitimanahtari { get; set; }

        public double? gks_mintutar { get; set; }

        public double? gks_maxtutar { get; set; }

        public int? gks_opno { get; set; }

        [StringLength(6)]
        public string gks_kesfatseri { get; set; }

        public int? gks_kesfatsira { get; set; }
    }
}
