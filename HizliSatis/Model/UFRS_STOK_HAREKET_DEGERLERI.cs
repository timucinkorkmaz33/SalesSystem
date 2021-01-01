namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UFRS_STOK_HAREKET_DEGERLERI
    {
        [Key]
        public int ushd_RECno { get; set; }

        public short ushd_RECid_DBCno { get; set; }

        public int ushd_RECid_RECno { get; set; }

        public int? ushd_SpecRECno { get; set; }

        public bool? ushd_iptal { get; set; }

        public short? ushd_fileid { get; set; }

        public bool? ushd_hidden { get; set; }

        public bool? ushd_kilitli { get; set; }

        public bool? ushd_degisti { get; set; }

        public int? ushd_checksum { get; set; }

        public short? ushd_create_user { get; set; }

        public DateTime? ushd_create_date { get; set; }

        public short? ushd_lastup_user { get; set; }

        public DateTime? ushd_lastup_date { get; set; }

        [StringLength(4)]
        public string ushd_special1 { get; set; }

        [StringLength(4)]
        public string ushd_special2 { get; set; }

        [StringLength(4)]
        public string ushd_special3 { get; set; }

        public short? ushd_baglihar_dbcno { get; set; }

        public int? ushd_baglihar_recno { get; set; }

        public double? ushd_tutar { get; set; }

        public double? ushd_iskonto1 { get; set; }

        public double? ushd_iskonto2 { get; set; }

        public double? ushd_iskonto3 { get; set; }

        public double? ushd_iskonto4 { get; set; }

        public double? ushd_iskonto5 { get; set; }

        public double? ushd_iskonto6 { get; set; }

        public double? ushd_masraf1 { get; set; }

        public double? ushd_masraf2 { get; set; }

        public double? ushd_masraf3 { get; set; }

        public double? ushd_masraf4 { get; set; }

        public double? ushd_maliyet_ana { get; set; }

        public double? ushd_maliyet_alternatif { get; set; }

        public double? ushd_maliyet_orjinal { get; set; }

        public double? ushd_urunilkmaddedegeri { get; set; }

        public double? ushd_mamulyarimamuldegeri { get; set; }

        public double? ushd_direkt_iscilik_1 { get; set; }

        public double? ushd_direkt_iscilik_2 { get; set; }

        public double? ushd_direkt_iscilik_3 { get; set; }

        public double? ushd_direkt_iscilik_4 { get; set; }

        public double? ushd_direkt_iscilik_5 { get; set; }

        public double? ushd_genel_uretim_1 { get; set; }

        public double? ushd_genel_uretim_2 { get; set; }

        public double? ushd_genel_uretim_3 { get; set; }

        public double? ushd_genel_uretim_4 { get; set; }

        public double? ushd_genel_uretim_5 { get; set; }

        public double? ushd_degerfarki { get; set; }

        public short? ushd_fat_recid_dbcno { get; set; }

        public int? ushd_fat_recid_recno { get; set; }

        public byte? ushd_evraktip { get; set; }

        [StringLength(6)]
        public string ushd_evrakno_seri { get; set; }

        public int? ushd_evrakno_sira { get; set; }
    }
}
