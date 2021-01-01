namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DONEMLERE_YAYILAN_HIZMETLER
    {
        [Key]
        public int dyh_RECno { get; set; }

        public short dyh_RECid_DBCno { get; set; }

        public int dyh_RECid_RECno { get; set; }

        public int? dyh_Spec_Rec_no { get; set; }

        public bool? dyh_iptal { get; set; }

        public short? dyh_fileid { get; set; }

        public bool? dyh_hidden { get; set; }

        public bool? dyh_kilitli { get; set; }

        public bool? dyh_degisti { get; set; }

        public int? dyh_checksum { get; set; }

        public short? dyh_create_user { get; set; }

        public DateTime? dyh_create_date { get; set; }

        public short? dyh_lastup_user { get; set; }

        public DateTime? dyh_lastup_date { get; set; }

        [StringLength(4)]
        public string dyh_special1 { get; set; }

        [StringLength(4)]
        public string dyh_special2 { get; set; }

        [StringLength(4)]
        public string dyh_special3 { get; set; }

        [StringLength(25)]
        public string dyh_kodu { get; set; }

        [StringLength(50)]
        public string dyh_ismi { get; set; }

        [StringLength(50)]
        public string dyh_aciklama { get; set; }

        public byte? dyh_tipi { get; set; }

        public int? dyh_firmano { get; set; }

        public int? dyh_subeno { get; set; }

        [StringLength(25)]
        public string dyh_tipkod { get; set; }

        [StringLength(25)]
        public string dyh_sinifkod { get; set; }

        [StringLength(25)]
        public string dyh_grupkod { get; set; }

        [StringLength(25)]
        public string dyh_carikodu { get; set; }

        [StringLength(30)]
        public string dyh_belgeno { get; set; }

        public DateTime? dyh_baslangictarihi { get; set; }

        public DateTime? dyh_bitistarihi { get; set; }

        public byte? dyh_dovizcinsi { get; set; }

        public double? dyh_tutari { get; set; }

        public byte? dyh_kdvpntr { get; set; }

        public byte? dyh_stopajfonpntr { get; set; }

        [StringLength(40)]
        public string dyh_muhkod1 { get; set; }

        [StringLength(40)]
        public string dyh_muhkod2 { get; set; }

        [StringLength(25)]
        public string dyh_hizmetmasrafkodu { get; set; }

        [StringLength(25)]
        public string dyh_dagitimanahtarkodu { get; set; }

        public double? dyh_ufrs_tutari { get; set; }

        [StringLength(40)]
        public string dyh_ufrs_fark_muhkod1 { get; set; }

        [StringLength(40)]
        public string dyh_ufrs_fark_muhkod2 { get; set; }

        [StringLength(25)]
        public string dyh_projekodu { get; set; }

        [StringLength(25)]
        public string dyh_srmmrkkodu { get; set; }

        public byte? dyh_hesaplamatipi { get; set; }
    }
}
