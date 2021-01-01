namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIRO_PRIMLERI
    {
        [Key]
        public int cpr_RECno { get; set; }

        public short cpr_RECid_DBCno { get; set; }

        public int cpr_RECid_RECno { get; set; }

        public int? cpr_SpecRECno { get; set; }

        public bool? cpr_iptal { get; set; }

        public short? cpr_fileid { get; set; }

        public bool? cpr_hidden { get; set; }

        public bool? cpr_kilitli { get; set; }

        public bool? cpr_degisti { get; set; }

        public int? cpr_checksum { get; set; }

        public short? cpr_create_user { get; set; }

        public DateTime? cpr_create_date { get; set; }

        public short? cpr_lastup_user { get; set; }

        public DateTime? cpr_lastup_date { get; set; }

        [StringLength(4)]
        public string cpr_special1 { get; set; }

        [StringLength(4)]
        public string cpr_special2 { get; set; }

        [StringLength(4)]
        public string cpr_special3 { get; set; }

        public int? cpr_firmano { get; set; }

        public int? cpr_subeno { get; set; }

        [StringLength(25)]
        public string cpr_baglicarikod { get; set; }

        public int? cpr_numarasi { get; set; }

        [StringLength(25)]
        public string cpr_carisozlesmekodu { get; set; }

        public int? cpr_satirno { get; set; }

        public DateTime? cpr_tarihi { get; set; }

        [StringLength(50)]
        public string cpr_aciklama { get; set; }

        public byte? cpr_uygulamasekli { get; set; }

        public byte? cpr_iadelergozardi { get; set; }

        public byte? cpr_hesapsekli { get; set; }

        public byte? cpr_stokindex { get; set; }

        [StringLength(25)]
        public string cpr_stokbaglantikodu { get; set; }

        public byte? cpr_stokindex2 { get; set; }

        [StringLength(25)]
        public string cpr_stokbaglantikodu2 { get; set; }

        public byte? cpr_stokindex3 { get; set; }

        [StringLength(25)]
        public string cpr_stokbaglantikodu3 { get; set; }

        public byte? cpr_stokindex4 { get; set; }

        [StringLength(25)]
        public string cpr_stokbaglantikodu4 { get; set; }

        public byte? cpr_stokindex5 { get; set; }

        [StringLength(25)]
        public string cpr_stokbaglantikodu5 { get; set; }

        [StringLength(25)]
        public string cpr_srmmrkkodu { get; set; }

        [StringLength(25)]
        public string cpr_stoksrmmrkkodu { get; set; }

        [StringLength(25)]
        public string cpr_hizmetkodu { get; set; }

        public DateTime? cpr_baslangictarihi { get; set; }

        public DateTime? cpr_bitistarihi { get; set; }

        public double? cpr_primeesasdeger1 { get; set; }

        public double? cpr_primeesasdeger2 { get; set; }

        public double? cpr_primeesasdeger3 { get; set; }

        public double? cpr_primeesasdeger4 { get; set; }

        public double? cpr_primeesasdeger5 { get; set; }

        public double? cpr_primorani1 { get; set; }

        public double? cpr_primorani2 { get; set; }

        public double? cpr_primorani3 { get; set; }

        public double? cpr_primorani4 { get; set; }

        public double? cpr_primorani5 { get; set; }

        [StringLength(6)]
        public string cpr_faturaseri { get; set; }

        public int? cpr_faturasira { get; set; }

        public byte? cpr_primisrmmrkleredagit { get; set; }

        public int? cpr_odemeplani { get; set; }

        public bool? cpr_altcaridegerlendir { get; set; }

        public bool? cpr_fiyatfarkidegerlendirme { get; set; }

        public byte? cpr_ciroprimfaturatipi { get; set; }

        public byte? cpr_miktarsaltavancarpantipi { get; set; }

        public byte? cpr_primeesastavantipi { get; set; }

        public bool? cpr_primevergidahil { get; set; }

        public int? cpr_depono { get; set; }

        public bool? cpr_primvergidetayli { get; set; }

        public bool? cpr_hesapfaturatarihinden { get; set; }

        public byte? cpr_depobaglantitip1 { get; set; }

        public int? cpr_depobaglantino1 { get; set; }

        [StringLength(25)]
        public string cpr_depobaglantikodu1 { get; set; }

        public byte? cpr_depobaglantitip2 { get; set; }

        public int? cpr_depobaglantino2 { get; set; }

        [StringLength(25)]
        public string cpr_depobaglantikodu2 { get; set; }

        public byte? cpr_depobaglantitip3 { get; set; }

        public int? cpr_depobaglantino3 { get; set; }

        [StringLength(25)]
        public string cpr_depobaglantikodu3 { get; set; }

        public bool? cpr_irsaliyedegerlendir { get; set; }
    }
}
