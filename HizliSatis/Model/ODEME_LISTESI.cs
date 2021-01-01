namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODEME_LISTESI
    {
        [Key]
        public int ol_RECno { get; set; }

        public short ol_RECid_DBCno { get; set; }

        public int ol_RECid_RECno { get; set; }

        public int? ol_SpecRECno { get; set; }

        public bool? ol_iptal { get; set; }

        public short? ol_fileid { get; set; }

        public bool? ol_hidden { get; set; }

        public bool? ol_kilitli { get; set; }

        public bool? ol_degisti { get; set; }

        public int? ol_checksum { get; set; }

        public short? ol_create_user { get; set; }

        public DateTime? ol_create_date { get; set; }

        public short? ol_lastup_user { get; set; }

        public DateTime? ol_lastup_date { get; set; }

        [StringLength(4)]
        public string ol_special1 { get; set; }

        [StringLength(4)]
        public string ol_special2 { get; set; }

        [StringLength(4)]
        public string ol_special3 { get; set; }

        [StringLength(25)]
        public string ol_Carikodu { get; set; }

        public double? ol_Tutari { get; set; }

        public DateTime? ol_OrtVadeTarih { get; set; }

        [StringLength(25)]
        public string ol_CekList1 { get; set; }

        [StringLength(25)]
        public string ol_CekList2 { get; set; }

        [StringLength(25)]
        public string ol_CekList3 { get; set; }

        [StringLength(25)]
        public string ol_CekList4 { get; set; }

        [StringLength(25)]
        public string ol_CekList5 { get; set; }

        [StringLength(25)]
        public string ol_CekList6 { get; set; }

        [StringLength(25)]
        public string ol_CekList7 { get; set; }

        [StringLength(25)]
        public string ol_CekList8 { get; set; }

        [StringLength(25)]
        public string ol_CekList9 { get; set; }

        [StringLength(25)]
        public string ol_CekList10 { get; set; }

        public double? ol_OdenenTutar { get; set; }

        public DateTime? ol_OdenenVade { get; set; }

        public byte? ol_OdemeCinsi { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd1 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd2 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd3 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd4 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd5 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd6 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd7 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd8 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd9 { get; set; }

        [StringLength(25)]
        public string ol_KasBankKd10 { get; set; }

        [StringLength(14)]
        public string ol_KesideYeri { get; set; }

        public int? ol_opsiyongun { get; set; }

        public byte? ol_carigrup { get; set; }

        public byte? ol_caridovizcins { get; set; }

        [StringLength(25)]
        public string ol_srmmrkkodu { get; set; }

        [StringLength(25)]
        public string ol_karsisrmmrkkodu { get; set; }

        [StringLength(40)]
        public string ol_aciklama { get; set; }

        public short? ol_onaylayankulno { get; set; }

        public bool? ol_onayli_fl { get; set; }

        public byte? ol_bakiye_sekli { get; set; }

        public byte? ol_odeme_sekli { get; set; }

        public byte? ol_alacakfatevrtip { get; set; }

        [StringLength(6)]
        public string ol_alacakfatevrno_seri { get; set; }

        public int? ol_alacakfatevrno_sira { get; set; }

        public short? ol_alacakfatRECid_DBCno { get; set; }

        public int? ol_alacakfatRECid_RECno { get; set; }

        public DateTime? ol_alacakfatvadetarihi { get; set; }

        public short? ol_odemeevragiRECid_DBCno { get; set; }

        public int? ol_odemeevragiRECid_RECno { get; set; }
    }
}
