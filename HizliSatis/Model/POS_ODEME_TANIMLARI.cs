namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class POS_ODEME_TANIMLARI
    {
        [Key]
        public int POT_RECno { get; set; }

        public short POT_RECid_DBCno { get; set; }

        public int POT_RECid_RECno { get; set; }

        public int? POT_Spec_Rec_no { get; set; }

        public bool? POT_iptal { get; set; }

        public short? POT_fileid { get; set; }

        public bool? POT_hidden { get; set; }

        public bool? POT_kilitli { get; set; }

        public bool? POT_degisti { get; set; }

        public int? POT_checksum { get; set; }

        public short? POT_create_user { get; set; }

        public DateTime? POT_create_date { get; set; }

        public short? POT_lastup_user { get; set; }

        public DateTime? POT_lastup_date { get; set; }

        [StringLength(4)]
        public string POT_special1 { get; set; }

        [StringLength(4)]
        public string POT_special2 { get; set; }

        [StringLength(4)]
        public string POT_special3 { get; set; }

        public byte? POT_No { get; set; }

        [StringLength(25)]
        public string POT_Adi { get; set; }

        public byte? POT_CariCinsi { get; set; }

        [StringLength(25)]
        public string POT_CariKodu { get; set; }

        public byte? POT_DovizCinsi { get; set; }

        public byte? POT_Tipi { get; set; }

        public byte? POT_KrediKartVadesi { get; set; }

        public byte? POT_TaksitSayisi { get; set; }

        [StringLength(2)]
        public string POT_NixdorfDvz { get; set; }

        public int? POT_FiyatKodu { get; set; }

        [StringLength(25)]
        public string POT_CariGrupKodu { get; set; }

        [StringLength(4)]
        public string POT_TCMB_Kodu { get; set; }

        public bool? POT_TCMB_Puan { get; set; }

        public byte? POT_GuvenlikKontrolu { get; set; }

        public byte? POT_Shop9000_OdemeTipi { get; set; }

        public byte? POT_Ibm4694_000_OdemeTipi { get; set; }

        public byte? POT_Genius220_OdemeTipi { get; set; }

        public byte? POT_GeniusIII_OdemeTipi { get; set; }

        public byte? POT_Wincor143_OdemeTipi { get; set; }

        public byte? POT_Wincor148_OdemeTipi { get; set; }

        public byte? POT_Wincor150_OdemeTipi { get; set; }

        public byte? POT_Ncr_OdemeTipi { get; set; }

        public byte? POT_IntPOS_OdemeTipi { get; set; }

        public byte? POT_IntMPOS2001_OdemeTipi { get; set; }

        public byte? POT_EsPOS_OdemeTipi { get; set; }

        public byte? POT_EsPOS4000_OdemeTipi { get; set; }

        public byte? POT_Tera_OdemeTipi { get; set; }

        public byte? POT_OLE5700_OdemeTipi { get; set; }

        public byte? POT_EsPOS5000_OdemeTipi { get; set; }

        public byte? POT_Genius2_SQL_OdemeTipi { get; set; }

        public byte? POT_HuginPOS_OdemeTipi { get; set; }

        public byte? POT_NCR_ASR_OdemeTipi { get; set; }

        public byte? POT_Beko_500_OdemeTipi { get; set; }

        public byte? POT_EnPOS_YNOKC_OdemeTipi { get; set; }

        public byte? POT_Olivetti_PBT_OdemeTipi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim1_Adi { get; set; }

        public int? PT_TaksitTanim1_Odeme { get; set; }

        public int? PT_TaksitTanim1_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim1_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim1_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim2_Adi { get; set; }

        public int? PT_TaksitTanim2_Odeme { get; set; }

        public int? PT_TaksitTanim2_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim2_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim2_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim3_Adi { get; set; }

        public int? PT_TaksitTanim3_Odeme { get; set; }

        public int? PT_TaksitTanim3_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim3_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim3_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim4_Adi { get; set; }

        public int? PT_TaksitTanim4_Odeme { get; set; }

        public int? PT_TaksitTanim4_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim4_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim4_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim5_Adi { get; set; }

        public int? PT_TaksitTanim5_Odeme { get; set; }

        public int? PT_TaksitTanim5_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim5_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim5_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim6_Adi { get; set; }

        public int? PT_TaksitTanim6_Odeme { get; set; }

        public int? PT_TaksitTanim6_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim6_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim6_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim7_Adi { get; set; }

        public int? PT_TaksitTanim7_Odeme { get; set; }

        public int? PT_TaksitTanim7_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim7_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim7_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim8_Adi { get; set; }

        public int? PT_TaksitTanim8_Odeme { get; set; }

        public int? PT_TaksitTanim8_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim8_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim8_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim9_Adi { get; set; }

        public int? PT_TaksitTanim9_Odeme { get; set; }

        public int? PT_TaksitTanim9_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim9_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim9_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim10_Adi { get; set; }

        public int? PT_TaksitTanim10_Odeme { get; set; }

        public int? PT_TaksitTanim10_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim10_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim10_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim11_Adi { get; set; }

        public int? PT_TaksitTanim11_Odeme { get; set; }

        public int? PT_TaksitTanim11_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim11_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim11_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim12_Adi { get; set; }

        public int? PT_TaksitTanim12_Odeme { get; set; }

        public int? PT_TaksitTanim12_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim12_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim12_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim13_Adi { get; set; }

        public int? PT_TaksitTanim13_Odeme { get; set; }

        public int? PT_TaksitTanim13_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim13_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim13_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim14_Adi { get; set; }

        public int? PT_TaksitTanim14_Odeme { get; set; }

        public int? PT_TaksitTanim14_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim14_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim14_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim15_Adi { get; set; }

        public int? PT_TaksitTanim15_Odeme { get; set; }

        public int? PT_TaksitTanim15_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim15_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim15_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim16_Adi { get; set; }

        public int? PT_TaksitTanim16_Odeme { get; set; }

        public int? PT_TaksitTanim16_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim16_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim16_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim17_Adi { get; set; }

        public int? PT_TaksitTanim17_Odeme { get; set; }

        public int? PT_TaksitTanim17_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim17_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim17_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim18_Adi { get; set; }

        public int? PT_TaksitTanim18_Odeme { get; set; }

        public int? PT_TaksitTanim18_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim18_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim18_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim19_Adi { get; set; }

        public int? PT_TaksitTanim19_Odeme { get; set; }

        public int? PT_TaksitTanim19_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim19_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim19_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim20_Adi { get; set; }

        public int? PT_TaksitTanim20_Odeme { get; set; }

        public int? PT_TaksitTanim20_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim20_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim20_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim21_Adi { get; set; }

        public int? PT_TaksitTanim21_Odeme { get; set; }

        public int? PT_TaksitTanim21_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim21_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim21_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim22_Adi { get; set; }

        public int? PT_TaksitTanim22_Odeme { get; set; }

        public int? PT_TaksitTanim22_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim22_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim22_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim23_Adi { get; set; }

        public int? PT_TaksitTanim23_Odeme { get; set; }

        public int? PT_TaksitTanim23_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim23_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim23_KKartTaksitSayisi { get; set; }

        [StringLength(20)]
        public string PT_TaksitTanim24_Adi { get; set; }

        public int? PT_TaksitTanim24_Odeme { get; set; }

        public int? PT_TaksitTanim24_FiyatKodu { get; set; }

        public byte? PT_TaksitTanim24_GuvenlikKontrolu { get; set; }

        public byte? PT_TaksitTanim24_KKartTaksitSayisi { get; set; }
    }
}
