namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_REZERVASYONLARI
    {
        [Key]
        public int stokrez_RECno { get; set; }

        public short stokrez_RECid_DBCno { get; set; }

        public int stokrez_RECid_RECno { get; set; }

        public int? stokrez_SpecRECno { get; set; }

        public bool? stokrez_iptal { get; set; }

        public short? stokrez_fileid { get; set; }

        public bool? stokrez_hidden { get; set; }

        public bool? stokrez_kilitli { get; set; }

        public bool? stokrez_degisti { get; set; }

        public int? stokrez_checksum { get; set; }

        public short? stokrez_create_user { get; set; }

        public DateTime? stokrez_create_date { get; set; }

        public short? stokrez_lastup_user { get; set; }

        public DateTime? stokrez_lastup_date { get; set; }

        [StringLength(4)]
        public string stokrez_special1 { get; set; }

        [StringLength(4)]
        public string stokrez_special2 { get; set; }

        [StringLength(4)]
        public string stokrez_special3 { get; set; }

        public int? stokrez_firmano { get; set; }

        public int? stokrez_subeno { get; set; }

        public DateTime? stokrez_tarih { get; set; }

        [StringLength(6)]
        public string stokrez_evrakno_seri { get; set; }

        public int? stokrez_evrakno_sira { get; set; }

        public int? stokrez_satirno { get; set; }

        [StringLength(25)]
        public string stokrez_stok_kod { get; set; }

        public int? stokrez_depono { get; set; }

        public double? stokrez_miktar { get; set; }

        [StringLength(50)]
        public string stokrez_aciklama { get; set; }

        public byte? stokrez_durumu { get; set; }

        public DateTime? stokrez_gecerliliktarihi { get; set; }

        [StringLength(25)]
        public string stokrez_cari_kod { get; set; }

        [StringLength(25)]
        public string stokrez_parti_kodu { get; set; }

        public int? stokrez_lot_no { get; set; }

        public byte? stokrez_kaynaktablo { get; set; }

        public short? stokrez_kaynak_DBCno { get; set; }

        public int? stokrez_kaynak_RECno { get; set; }

        public bool? stokrez_urungirisi_fl { get; set; }

        public double? stokrez_teslimedilen { get; set; }

        public double? stokrez_alinan_on_odeme { get; set; }

        public short? stokrez_bagliesleme_DBCno { get; set; }

        public int? stokrez_bagliesleme_RECno { get; set; }

        public short? stokrez_aktarim_durum { get; set; }

        public short? stokrez_bedencihaz_aktarim_durum { get; set; }
    }
}
