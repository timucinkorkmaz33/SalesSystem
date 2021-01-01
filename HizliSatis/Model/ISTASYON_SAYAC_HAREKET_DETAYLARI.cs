namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_SAYAC_HAREKET_DETAYLARI
    {
        [Key]
        public int shdt_RECNo { get; set; }

        public short shdt_RECid_DBCno { get; set; }

        public int shdt_RECid_RECno { get; set; }

        public int? shdt_SpecRECno { get; set; }

        public bool? shdt_iptal { get; set; }

        public short? shdt_fileid { get; set; }

        public bool? shdt_hidden { get; set; }

        public bool? shdt_kilitli { get; set; }

        public bool? shdt_degisti { get; set; }

        public int? shdt_checksum { get; set; }

        public short? shdt_create_user { get; set; }

        public DateTime? shdt_create_date { get; set; }

        public short? shdt_lastup_user { get; set; }

        public DateTime? shdt_lastup_date { get; set; }

        [StringLength(4)]
        public string shdt_special1 { get; set; }

        [StringLength(4)]
        public string shdt_special2 { get; set; }

        [StringLength(4)]
        public string shdt_special3 { get; set; }

        public int? shdt_firma_no { get; set; }

        public int? shdt_sube_no { get; set; }

        [StringLength(25)]
        public string shdt_sayackodu { get; set; }

        public int? shdt_depo_no { get; set; }

        [StringLength(25)]
        public string shdt_stokkodu { get; set; }

        public DateTime? shdt_vardiyatarihi { get; set; }

        public byte? shdt_vardiyano { get; set; }

        [StringLength(25)]
        public string shdt_filokodu { get; set; }

        [StringLength(25)]
        public string shdt_carikodu { get; set; }

        [StringLength(25)]
        public string shdt_tagnumarasi { get; set; }

        [StringLength(25)]
        public string shdt_plaka_veya_personel { get; set; }

        public double? shdt_motorsaati { get; set; }

        public double? shdt_kilometre { get; set; }

        public byte? shdt_satistipi { get; set; }

        public DateTime? shdt_satistarihi { get; set; }

        public int? shdt_satissirano { get; set; }

        public byte? shdt_yakittipi { get; set; }

        public double? shdt_birimfiyat { get; set; }

        public double? shdt_miktar { get; set; }

        public double? shdt_tutar { get; set; }

        public byte? shdt_pompano { get; set; }

        public byte? shdt_tabancano { get; set; }

        public byte? shdt_odemeturu { get; set; }

        [StringLength(25)]
        public string shdt_aracplaka { get; set; }

        public int? shdt_fisno { get; set; }

        public double? shdt_odeme { get; set; }

        public double? shdt_indirim { get; set; }

        public double? shdt_hediyepuan { get; set; }

        public double? shdt_hediyetutar { get; set; }

        [StringLength(25)]
        public string shdt_hediyekartno { get; set; }

        public byte? shdt_hediyekartturu { get; set; }

        public double? shdt_netbirimfiyat { get; set; }

        public short? shdt_sth_recid_dbcno { get; set; }

        public int? shdt_sth_recid_recno { get; set; }
    }
}
