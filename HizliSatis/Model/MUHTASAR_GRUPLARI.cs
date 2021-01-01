namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHTASAR_GRUPLARI
    {
        [Key]
        public int mg_RECno { get; set; }

        public short mg_RECid_DBCno { get; set; }

        public int mg_RECid_RECno { get; set; }

        public int? mg_SpecRECno { get; set; }

        public bool? mg_iptal { get; set; }

        public short? mg_fileid { get; set; }

        public bool? mg_hidden { get; set; }

        public bool? mg_kilitli { get; set; }

        public bool? mg_degisti { get; set; }

        public int? mg_checksum { get; set; }

        public short? mg_create_user { get; set; }

        public DateTime? mg_create_date { get; set; }

        public short? mg_lastup_user { get; set; }

        public DateTime? mg_lastup_date { get; set; }

        [StringLength(4)]
        public string mg_special1 { get; set; }

        [StringLength(4)]
        public string mg_special2 { get; set; }

        [StringLength(4)]
        public string mg_special3 { get; set; }

        [StringLength(25)]
        public string mg_kodu { get; set; }

        [StringLength(50)]
        public string mg_aciklama { get; set; }

        public bool? mg_isletme_fl { get; set; }

        public byte? mg_uygulamasekli { get; set; }

        [StringLength(10)]
        public string mg_vergidairesi { get; set; }

        public byte? mg_Muh_gv_tesvik { get; set; }

        public int? mg_MuhTurKodu1 { get; set; }

        public int? mg_MuhTurKodu2 { get; set; }

        public int? mg_MuhTurKodu3 { get; set; }

        public int? mg_MuhTurKodu4 { get; set; }

        public int? mg_MuhTurKodu5 { get; set; }

        public int? mg_MuhTurKodu6 { get; set; }

        public int? mg_MuhTurKodu7 { get; set; }

        public int? mg_MuhTurKodu8 { get; set; }

        public int? mg_MuhTurKodu9 { get; set; }

        public int? mg_MuhTurKodu10 { get; set; }

        public int? mg_MuhTurKodu11 { get; set; }

        public int? mg_MuhTurKodu12 { get; set; }

        public int? mg_MuhTurKodu13 { get; set; }

        public int? mg_MuhTurKodu14 { get; set; }

        public int? mg_MuhTurKodu15 { get; set; }

        public int? mg_MuhTurKodu16 { get; set; }

        public int? mg_MuhTurKodu17 { get; set; }

        public int? mg_MuhTurKodu18 { get; set; }

        public int? mg_MuhTurKodu19 { get; set; }

        public int? mg_MuhTurKodu20 { get; set; }

        public int? mg_MuhTurKodu21 { get; set; }

        public int? mg_MuhTurKodu22 { get; set; }

        public int? mg_MuhTurKodu23 { get; set; }

        public int? mg_MuhTurKodu24 { get; set; }

        public int? mg_MuhTurKodu25 { get; set; }

        public int? mg_MuhTurKodu26 { get; set; }

        public int? mg_MuhTurKodu27 { get; set; }

        public int? mg_MuhTurKodu28 { get; set; }

        public int? mg_MuhTurKodu29 { get; set; }

        public int? mg_MuhTurKodu30 { get; set; }

        public int? mg_MuhTurKodu31 { get; set; }

        public int? mg_MuhTurKodu32 { get; set; }

        public int? mg_MuhTurKodu33 { get; set; }

        public int? mg_MuhTurKodu34 { get; set; }

        public int? mg_MuhTurKodu35 { get; set; }

        public int? mg_MuhTurKodu36 { get; set; }

        public int? mg_MuhTurKodu37 { get; set; }

        public int? mg_MuhTurKodu38 { get; set; }

        public int? mg_MuhTurKodu39 { get; set; }

        public int? mg_MuhTurKodu40 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari1 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari2 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari3 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari4 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari5 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari6 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari7 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari8 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari9 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari10 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari11 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari12 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari13 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari14 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari15 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari16 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari17 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari18 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari19 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari20 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari21 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari22 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari23 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari24 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari25 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari26 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari27 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari28 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari29 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari30 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari31 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari32 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari33 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari34 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari35 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari36 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari37 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari38 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari39 { get; set; }

        [StringLength(25)]
        public string mg_MuhKodlari40 { get; set; }

        public double? mg_MuhOranlari1 { get; set; }

        public double? mg_MuhOranlari2 { get; set; }

        public double? mg_MuhOranlari3 { get; set; }

        public double? mg_MuhOranlari4 { get; set; }

        public double? mg_MuhOranlari5 { get; set; }

        public double? mg_MuhOranlari6 { get; set; }

        public double? mg_MuhOranlari7 { get; set; }

        public double? mg_MuhOranlari8 { get; set; }

        public double? mg_MuhOranlari9 { get; set; }

        public double? mg_MuhOranlari10 { get; set; }

        public double? mg_MuhOranlari11 { get; set; }

        public double? mg_MuhOranlari12 { get; set; }

        public double? mg_MuhOranlari13 { get; set; }

        public double? mg_MuhOranlari14 { get; set; }

        public double? mg_MuhOranlari15 { get; set; }

        public double? mg_MuhOranlari16 { get; set; }

        public double? mg_MuhOranlari17 { get; set; }

        public double? mg_MuhOranlari18 { get; set; }

        public double? mg_MuhOranlari19 { get; set; }

        public double? mg_MuhOranlari20 { get; set; }

        public double? mg_MuhOranlari21 { get; set; }

        public double? mg_MuhOranlari22 { get; set; }

        public double? mg_MuhOranlari23 { get; set; }

        public double? mg_MuhOranlari24 { get; set; }

        public double? mg_MuhOranlari25 { get; set; }

        public double? mg_MuhOranlari26 { get; set; }

        public double? mg_MuhOranlari27 { get; set; }

        public double? mg_MuhOranlari28 { get; set; }

        public double? mg_MuhOranlari29 { get; set; }

        public double? mg_MuhOranlari30 { get; set; }

        public double? mg_MuhOranlari31 { get; set; }

        public double? mg_MuhOranlari32 { get; set; }

        public double? mg_MuhOranlari33 { get; set; }

        public double? mg_MuhOranlari34 { get; set; }

        public double? mg_MuhOranlari35 { get; set; }

        public double? mg_MuhOranlari36 { get; set; }

        public double? mg_MuhOranlari37 { get; set; }

        public double? mg_MuhOranlari38 { get; set; }

        public double? mg_MuhOranlari39 { get; set; }

        public double? mg_MuhOranlari40 { get; set; }

        public bool? mg_EvrakOku { get; set; }

        [StringLength(25)]
        public string mg_TahsilatMuhKodlari1 { get; set; }

        [StringLength(25)]
        public string mg_TahsilatMuhKodlari2 { get; set; }

        [StringLength(25)]
        public string mg_TahsilatMuhKodlari3 { get; set; }

        [StringLength(25)]
        public string mg_TahsilatMuhKodlari4 { get; set; }

        [StringLength(25)]
        public string mg_TahsilatMuhKodlari5 { get; set; }

        public DateTime? mg_5225belgetarihi { get; set; }

        [StringLength(25)]
        public string mg_5225sayisi { get; set; }

        public byte? mg_Muh_Tesvik_Tarihi { get; set; }
    }
}
