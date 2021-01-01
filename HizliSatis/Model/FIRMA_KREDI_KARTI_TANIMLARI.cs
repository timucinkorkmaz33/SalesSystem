namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FIRMA_KREDI_KARTI_TANIMLARI
    {
        [Key]
        public int fkk_RECno { get; set; }

        public short fkk_RECid_DBCno { get; set; }

        public int fkk_RECid_RECno { get; set; }

        public int? fkk_SpecRecno { get; set; }

        public bool? fkk_iptal { get; set; }

        public short? fkk_fileid { get; set; }

        public bool? fkk_hidden { get; set; }

        public bool? fkk_kilitli { get; set; }

        public bool? fkk_degisti { get; set; }

        public int? fkk_checksum { get; set; }

        public short? fkk_create_user { get; set; }

        public DateTime? fkk_create_date { get; set; }

        public short? fkk_lastup_user { get; set; }

        public DateTime? fkk_lastup_date { get; set; }

        [StringLength(4)]
        public string fkk_special1 { get; set; }

        [StringLength(4)]
        public string fkk_special2 { get; set; }

        [StringLength(4)]
        public string fkk_special3 { get; set; }

        public int? fkk_firma_no { get; set; }

        [StringLength(25)]
        public string fkk_kod { get; set; }

        [StringLength(40)]
        public string fkk_isim { get; set; }

        [StringLength(25)]
        public string fkk_kartno { get; set; }

        public byte? fkk_tip { get; set; }

        public byte? fkk_cins { get; set; }

        [StringLength(25)]
        public string fkk_bagli_asil_kart_kodu { get; set; }

        [StringLength(25)]
        public string fkk_bagli_banka_kodu { get; set; }

        [StringLength(25)]
        public string fkk_bagli_cari_pers_kodu { get; set; }

        public DateTime? fkk_sonkullanim_tarihi { get; set; }

        public short? fkk_hesap_kesim_gunu { get; set; }

        public byte? fkk_doviz_cinsi { get; set; }

        public double? fkk_harcama_limiti { get; set; }

        public double? fkk_nakit_limiti { get; set; }

        [StringLength(40)]
        public string fkk_donem_ici_muh_kod { get; set; }

        [StringLength(40)]
        public string fkk_gerceklesmis_donem_muh_kod { get; set; }

        [StringLength(25)]
        public string fkk_bagli_kredi_kart_kodu { get; set; }

        public byte? fkk_durumu { get; set; }
    }
}
