namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHOP_PROMOSYON_KONTROL
    {
        [Key]
        public int spk_RECno { get; set; }

        public short spk_RECid_DBCno { get; set; }

        public int spk_RECid_RECno { get; set; }

        public int? spk_SpecRECNo { get; set; }

        public bool? spk_iptal { get; set; }

        public short? spk_fileid { get; set; }

        public bool? spk_hidden { get; set; }

        public bool? spk_kilitli { get; set; }

        public bool? spk_degisti { get; set; }

        public int? spk_CheckSum { get; set; }

        public short? spk_create_user { get; set; }

        public DateTime? spk_create_date { get; set; }

        public short? spk_lastup_user { get; set; }

        public DateTime? spk_lastup_date { get; set; }

        [StringLength(4)]
        public string spk_special1 { get; set; }

        [StringLength(4)]
        public string spk_special2 { get; set; }

        [StringLength(4)]
        public string spk_special3 { get; set; }

        public int? spk_testid { get; set; }

        public byte? spk_datatip { get; set; }

        [StringLength(25)]
        public string spk_OrnekKodu { get; set; }

        [StringLength(25)]
        public string spk_PromosyonKodu { get; set; }

        public int? spk_satirno { get; set; }

        [StringLength(25)]
        public string spk_stok_kod { get; set; }

        [StringLength(25)]
        public string spk_stok_barkod { get; set; }

        public int? spk_stok_renkID { get; set; }

        public int? spk_stok_bedenID { get; set; }

        public byte? spk_cari_cinsi { get; set; }

        [StringLength(25)]
        public string spk_cari_kodu { get; set; }

        public byte? spk_cari_grup_no { get; set; }

        public double? spk_miktar { get; set; }

        public double? spk_tutar { get; set; }

        public double? spk_iskontoSatir { get; set; }

        public double? spk_iskontoGenel { get; set; }

        public double? spk_masrafSatir { get; set; }

        public double? spk_masrafGenel { get; set; }

        public double? spk_vergi { get; set; }

        public double? spk_masraf_vergi { get; set; }

        public double? spk_otv_vergi { get; set; }

        public double? spk_otvtutari { get; set; }

        public double? spk_oiv_vergi { get; set; }

        public double? spk_oivtutari { get; set; }

        public int? spk_OdemeTipi { get; set; }

        public int? spk_TaksitTipi { get; set; }

        [StringLength(25)]
        public string spk_PuanKodu { get; set; }

        public double? spk_OdemeToplam { get; set; }

        public bool? spk_PromoOK { get; set; }
    }
}
