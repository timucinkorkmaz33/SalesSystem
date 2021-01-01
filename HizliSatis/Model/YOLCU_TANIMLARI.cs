namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class YOLCU_TANIMLARI
    {
        [Key]
        public int ylc_RECno { get; set; }

        public short ylc_RECid_DBCno { get; set; }

        public int ylc_RECid_RECno { get; set; }

        public int? ylc_SpecRECNo { get; set; }

        public bool? ylc_iptal { get; set; }

        public short? ylc_fileid { get; set; }

        public bool? ylc_hidden { get; set; }

        public bool? ylc_kilitli { get; set; }

        public bool? ylc_degisti { get; set; }

        public int? ylc_CheckSum { get; set; }

        public short? ylc_create_user { get; set; }

        public DateTime? ylc_create_date { get; set; }

        public short? ylc_lastup_user { get; set; }

        public DateTime? ylc_lastup_date { get; set; }

        [StringLength(4)]
        public string ylc_special1 { get; set; }

        [StringLength(4)]
        public string ylc_special2 { get; set; }

        [StringLength(4)]
        public string ylc_special3 { get; set; }

        [StringLength(25)]
        public string ylc_kodu { get; set; }

        [StringLength(50)]
        public string ylc_adi { get; set; }

        [StringLength(50)]
        public string ylc_soyadi { get; set; }

        [StringLength(20)]
        public string ylc_pasaportno { get; set; }

        public DateTime? ylc_pasaporttarihi { get; set; }

        [StringLength(5)]
        public string ylc_uyruk { get; set; }

        [StringLength(15)]
        public string ylc_sehir { get; set; }

        [StringLength(15)]
        public string ylc_ulke { get; set; }

        [StringLength(50)]
        public string ylc_bankahesap { get; set; }

        [StringLength(50)]
        public string ylc_bankaadi { get; set; }

        [StringLength(50)]
        public string ylc_bankasube { get; set; }
    }
}
