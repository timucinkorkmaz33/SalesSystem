namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_TAHAKKUKLARI
    {
        [Key]
        public int pt_RECno { get; set; }

        public short pt_RECid_DBCno { get; set; }

        public int pt_RECid_RECno { get; set; }

        public int? pt_SpecRECno { get; set; }

        public bool? pt_iptal { get; set; }

        public short? pt_fileid { get; set; }

        public bool? pt_hidden { get; set; }

        public bool? pt_kilitli { get; set; }

        public bool? pt_degisti { get; set; }

        public int? pt_checksum { get; set; }

        public short? pt_create_user { get; set; }

        public DateTime? pt_create_date { get; set; }

        public short? pt_lastup_user { get; set; }

        public DateTime? pt_lastup_date { get; set; }

        [StringLength(4)]
        public string pt_special1 { get; set; }

        [StringLength(4)]
        public string pt_special2 { get; set; }

        [StringLength(4)]
        public string pt_special3 { get; set; }

        [StringLength(25)]
        public string pt_pkod { get; set; }

        public int? pt_maliyil { get; set; }

        public short? pt_tah_ay { get; set; }

        public short? pt_tahno { get; set; }

        public short? pt_kayit { get; set; }

        public bool? pt_kesin { get; set; }

        public byte? pt_ucrettipi { get; set; }

        public double? pt_brutucret { get; set; }

        public short? pt_kazanc1_tkgun { get; set; }

        public double? pt_kazanc1_tksaat { get; set; }

        public short? pt_kazanc1_tkyarim_isgunu { get; set; }

        public double? pt_kazanc1_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc1_tktutar { get; set; }

        public short? pt_kazanc2_tkgun { get; set; }

        public double? pt_kazanc2_tksaat { get; set; }

        public short? pt_kazanc2_tkyarim_isgunu { get; set; }

        public double? pt_kazanc2_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc2_tktutar { get; set; }

        public short? pt_kazanc3_tkgun { get; set; }

        public double? pt_kazanc3_tksaat { get; set; }

        public short? pt_kazanc3_tkyarim_isgunu { get; set; }

        public double? pt_kazanc3_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc3_tktutar { get; set; }

        public short? pt_kazanc4_tkgun { get; set; }

        public double? pt_kazanc4_tksaat { get; set; }

        public short? pt_kazanc4_tkyarim_isgunu { get; set; }

        public double? pt_kazanc4_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc4_tktutar { get; set; }

        public short? pt_kazanc5_tkgun { get; set; }

        public double? pt_kazanc5_tksaat { get; set; }

        public short? pt_kazanc5_tkyarim_isgunu { get; set; }

        public double? pt_kazanc5_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc5_tktutar { get; set; }

        public short? pt_kazanc6_tkgun { get; set; }

        public double? pt_kazanc6_tksaat { get; set; }

        public short? pt_kazanc6_tkyarim_isgunu { get; set; }

        public double? pt_kazanc6_tkyarim_isgun_saat { get; set; }

        public double? pt_kazanc6_tktutar { get; set; }

        public double? pt_KazancBNCarpan { get; set; }

        public short? pt_ekkazanc1_tkgun { get; set; }

        public double? pt_ekkazanc1_tksaat { get; set; }

        public double? pt_ekkazanc1_tktutar { get; set; }

        public short? pt_ekkazanc2_tkgun { get; set; }

        public double? pt_ekkazanc2_tksaat { get; set; }

        public double? pt_ekkazanc2_tktutar { get; set; }

        public short? pt_ekkazanc3_tkgun { get; set; }

        public double? pt_ekkazanc3_tksaat { get; set; }

        public double? pt_ekkazanc3_tktutar { get; set; }

        public short? pt_ekkazanc4_tkgun { get; set; }

        public double? pt_ekkazanc4_tksaat { get; set; }

        public double? pt_ekkazanc4_tktutar { get; set; }

        public short? pt_ekkazanc5_tkgun { get; set; }

        public double? pt_ekkazanc5_tksaat { get; set; }

        public double? pt_ekkazanc5_tktutar { get; set; }

        public short? pt_ekkazanc6_tkgun { get; set; }

        public double? pt_ekkazanc6_tksaat { get; set; }

        public double? pt_ekkazanc6_tktutar { get; set; }

        public short? pt_ekkazanc7_tkgun { get; set; }

        public double? pt_ekkazanc7_tksaat { get; set; }

        public double? pt_ekkazanc7_tktutar { get; set; }

        public short? pt_ekkazanc8_tkgun { get; set; }

        public double? pt_ekkazanc8_tksaat { get; set; }

        public double? pt_ekkazanc8_tktutar { get; set; }

        public short? pt_ekkazanc9_tkgun { get; set; }

        public double? pt_ekkazanc9_tksaat { get; set; }

        public double? pt_ekkazanc9_tktutar { get; set; }

        public short? pt_ekkazanc10_tkgun { get; set; }

        public double? pt_ekkazanc10_tksaat { get; set; }

        public double? pt_ekkazanc10_tktutar { get; set; }

        public short? pt_ekkazanc11_tkgun { get; set; }

        public double? pt_ekkazanc11_tksaat { get; set; }

        public double? pt_ekkazanc11_tktutar { get; set; }

        public double? pt_EkKazancBNCarpan1 { get; set; }

        public double? pt_EkKazancBNCarpan2 { get; set; }

        public double? pt_EkKazancBNCarpan3 { get; set; }

        public double? pt_EkKazancBNCarpan4 { get; set; }

        public double? pt_EkKazancBNCarpan5 { get; set; }

        public double? pt_EkKazancBNCarpan6 { get; set; }

        public double? pt_EkKazancBNCarpan7 { get; set; }

        public double? pt_EkKazancBNCarpan8 { get; set; }

        public double? pt_EkKazancBNCarpan9 { get; set; }

        public double? pt_EkKazancBNCarpan10 { get; set; }

        public double? pt_EkKazancBNCarpan11 { get; set; }

        public short? pt_sosyolgun { get; set; }

        public short? pt_sosyemekgun { get; set; }

        public double? pt_sosyrdm1 { get; set; }

        public double? pt_sosyrdm2 { get; set; }

        public double? pt_sosyrdm3 { get; set; }

        public double? pt_sosyrdm4 { get; set; }

        public double? pt_sosyrdm5 { get; set; }

        public double? pt_sosyrdm6 { get; set; }

        public double? pt_sosyrdm7 { get; set; }

        public double? pt_sosyrdm8 { get; set; }

        public double? pt_sosyrdm9 { get; set; }

        public double? pt_sosyrdm10 { get; set; }

        public double? pt_sosyrdm11 { get; set; }

        public double? pt_sosyrdm12 { get; set; }

        public double? pt_sosyrdm13 { get; set; }

        public double? pt_sosyrdm14 { get; set; }

        public double? pt_sosyrdm15 { get; set; }

        public double? pt_sosyrdm16 { get; set; }

        public double? pt_sosyrdm17 { get; set; }

        public double? pt_sosyrdm18 { get; set; }

        public double? pt_sosyrdm19 { get; set; }

        public double? pt_sosyrdm20 { get; set; }

        public double? pt_sosyrdm21 { get; set; }

        public double? pt_sosyrdm22 { get; set; }

        public double? pt_sosyrdm23 { get; set; }

        public double? pt_sosyrdm24 { get; set; }

        public double? pt_sosyrdm25 { get; set; }

        public double? pt_sosyrdm26 { get; set; }

        public double? pt_sosyrdm27 { get; set; }

        public double? pt_sosyrdm28 { get; set; }

        public double? pt_sosyrdm29 { get; set; }

        public double? pt_sosyrdm30 { get; set; }

        public double? pt_sosyrdm31 { get; set; }

        public double? pt_sosyrdm32 { get; set; }

        public double? pt_SosYardBNCarpan1 { get; set; }

        public double? pt_SosYardBNCarpan2 { get; set; }

        public double? pt_SosYardBNCarpan3 { get; set; }

        public double? pt_SosYardBNCarpan4 { get; set; }

        public double? pt_SosYardBNCarpan5 { get; set; }

        public double? pt_SosYardBNCarpan6 { get; set; }

        public double? pt_SosYardBNCarpan7 { get; set; }

        public double? pt_SosYardBNCarpan8 { get; set; }

        public double? pt_SosYardBNCarpan9 { get; set; }

        public double? pt_SosYardBNCarpan10 { get; set; }

        public double? pt_SosYardBNCarpan11 { get; set; }

        public double? pt_SosYardBNCarpan12 { get; set; }

        public double? pt_SosYardBNCarpan13 { get; set; }

        public double? pt_SosYardBNCarpan14 { get; set; }

        public double? pt_SosYardBNCarpan15 { get; set; }

        public double? pt_SosYardBNCarpan16 { get; set; }

        public double? pt_SosYardBNCarpan17 { get; set; }

        public double? pt_SosYardBNCarpan18 { get; set; }

        public double? pt_SosYardBNCarpan19 { get; set; }

        public double? pt_SosYardBNCarpan20 { get; set; }

        public double? pt_SosYardBNCarpan21 { get; set; }

        public double? pt_SosYardBNCarpan22 { get; set; }

        public double? pt_SosYardBNCarpan23 { get; set; }

        public double? pt_SosYardBNCarpan24 { get; set; }

        public double? pt_SosYardBNCarpan25 { get; set; }

        public double? pt_SosYardBNCarpan26 { get; set; }

        public double? pt_SosYardBNCarpan27 { get; set; }

        public double? pt_SosYardBNCarpan28 { get; set; }

        public double? pt_SosYardBNCarpan29 { get; set; }

        public double? pt_SosYardBNCarpan30 { get; set; }

        public double? pt_SosYardBNCarpan31 { get; set; }

        public double? pt_SosYardBNCarpan32 { get; set; }

        public double? pt_ozksnt1 { get; set; }

        public double? pt_ozksnt2 { get; set; }

        public double? pt_ozksnt3 { get; set; }

        public double? pt_ozksnt4 { get; set; }

        public double? pt_ozksnt5 { get; set; }

        public double? pt_ozksnt6 { get; set; }

        public double? pt_ozksnt7 { get; set; }

        public double? pt_ozksnt8 { get; set; }

        public double? pt_ozksnt9 { get; set; }

        public double? pt_ozksnt10 { get; set; }

        public double? pt_ozksnt11 { get; set; }

        public double? pt_ozksnt12 { get; set; }

        public double? pt_ozksnt13 { get; set; }

        public double? pt_ozksnt14 { get; set; }

        public double? pt_ozksnt15 { get; set; }

        public double? pt_ozksnt16 { get; set; }

        public double? pt_ozksnt17 { get; set; }

        public double? pt_ozksnt18 { get; set; }

        public double? pt_ozksnt19 { get; set; }

        public double? pt_ozksnt20 { get; set; }

        public double? pt_ozksnt21 { get; set; }

        public double? pt_ozksnt22 { get; set; }

        public double? pt_ozksnt23 { get; set; }

        public double? pt_ozksnt24 { get; set; }

        public double? pt_sskprimi { get; set; }

        public double? pt_gv { get; set; }

        public double? pt_dv { get; set; }

        public double? pt_normalkazanc { get; set; }

        public double? pt_ekkazanc { get; set; }

        public double? pt_sosyrdm { get; set; }

        public double? pt_yasksnt { get; set; }

        public double? pt_ozksnt { get; set; }

        public double? pt_kazanc { get; set; }

        public double? pt_kesinti { get; set; }

        public double? pt_net { get; set; }

        public short? pt_sskgunu { get; set; }

        public double? pt_sskbrut { get; set; }

        public short? pt_izingunu { get; set; }

        public double? pt_izinmatrah { get; set; }

        public double? pt_tersbakiye { get; set; }

        public double? pt_yuvfarki { get; set; }

        public double? pt_sskisvhis { get; set; }

        public double? pt_sskkonfon { get; set; }

        public short? pt_gayrisafikaz { get; set; }

        public double? pt_gs { get; set; }

        public double? pt_verind { get; set; }

        public double? pt_gocverind { get; set; }

        public double? pt_sakverind { get; set; }

        public double? pt_digverindgv { get; set; }

        public double? pt_digverindssk { get; set; }

        public double? pt_toplamind { get; set; }

        public double? pt_devsskmatrah { get; set; }

        public double? pt_devgvmatrah { get; set; }

        public double? pt_sskbrutmatrah { get; set; }

        public double? pt_gvmatrah { get; set; }

        public double? pt_gvbrut { get; set; }

        public double? pt_arge5746gvmuafiyeti { get; set; }

        public double? pt_vergi_iadesi { get; set; }

        public double? pt_digverinddv { get; set; }

        public short? pt_dsiz { get; set; }

        public double? pt_vidv { get; set; }

        public double? pt_netvergiiadesi { get; set; }

        public double? pt_dvmatrah { get; set; }

        public byte? pt_tahakkuklog { get; set; }

        public byte? pt_sskkonutfonukad { get; set; }

        public double? pt_hayatsigortasi { get; set; }

        public double? pt_ssdfonu { get; set; }

        public byte? pt_HesapTipi { get; set; }

        public double? pt_iszlksigperpayi { get; set; }

        public double? pt_iszlksigisvpayi { get; set; }

        public double? pt_iszlksigmatrah { get; set; }

        public double? pt_iszlksigbrut { get; set; }

        public double? pt_digersigorta_isveren { get; set; }

        public double? pt_digersigorta_calisan { get; set; }

        public double? pt_bireyselsigorta_isveren { get; set; }

        public double? pt_bireyselsigorta_calisan { get; set; }

        [StringLength(25)]
        public string pt_EksikCalismaNedeni { get; set; }

        public byte? pt_eksikcalismanedensecimli { get; set; }

        public double? pt_AskerBorclanmasi { get; set; }

        public double? pt_IsvHisTesvInd { get; set; }

        public DateTime? pt_KurTarihi { get; set; }

        [StringLength(25)]
        public string pt_DepartmanKodu { get; set; }

        [StringLength(25)]
        public string pt_GorevKodu { get; set; }

        [StringLength(25)]
        public string pt_BolgeKodu { get; set; }

        public double? pt_asgarigecimindirimi { get; set; }

        public double? pt_sonrayadevredensskmatrahi { get; set; }

        public double? pt_gecenaylardankullanilanssk { get; set; }

        public double? pt_sgkyatabiitopkazanc { get; set; }

        public double? pt_sgkyatabiitopekkazanc { get; set; }

        public double? pt_sgkyatabiitopsosyalyardim { get; set; }

        public double? pt_sgkpriminetabiikazanc { get; set; }

        public double? pt_sgkpriminetabiiekkazanc { get; set; }

        public double? pt_sgkpriminetabiisosyalyardim { get; set; }

        public double? pt_sgkprimikazanctan { get; set; }

        public double? pt_sgkprimiekkazanctan { get; set; }

        public double? pt_sgkprimisosyalyardimdan { get; set; }

        public byte? pt_tabiioldugukanun { get; set; }

        public byte? pt_tabiioldugukanun2 { get; set; }

        public double? pt_kultur5225gvmuafiyeti { get; set; }

        public double? pt_hazinekanunugvindirimi { get; set; }

        public byte? pt_dovizcins { get; set; }

        public double? pt_dovizkur { get; set; }

        public double? pt_altdovizkur { get; set; }

        public double? pt_bagkurprimi { get; set; }

        public byte? pt_tabiioldugubelgeturu { get; set; }

        public byte? pt_tabiioldugukanun3 { get; set; }

        public double? pt_Az102KanunVergiIndirimi { get; set; }

        public double? pt_AzHastalikUcretFarki { get; set; }

        public double? pt_AzHastalikUcretFarkVergisi { get; set; }

        public double? pt_brutlesmeyenodeme { get; set; }

        public double? pt_sanalgvmatrah { get; set; }

        public double? pt_sanalgv { get; set; }

        public double? pt_sanaldvmatrah { get; set; }

        public double? pt_sanaldv { get; set; }

        public double? pt_perskgtesvikind { get; set; }

        public double? pt_perisssigtesvikind { get; set; }

        public short? pt_izin1_tkgun { get; set; }

        public double? pt_izin1_tksaat { get; set; }

        public short? pt_izin1_tkyarim_isgunu { get; set; }

        public double? pt_izin1_tkyarim_isgun_saat { get; set; }

        public double? pt_izin1_tktutar { get; set; }

        public short? pt_izin2_tkgun { get; set; }

        public double? pt_izin2_tksaat { get; set; }

        public short? pt_izin2_tkyarim_isgunu { get; set; }

        public double? pt_izin2_tkyarim_isgun_saat { get; set; }

        public double? pt_izin2_tktutar { get; set; }

        public short? pt_izin3_tkgun { get; set; }

        public double? pt_izin3_tksaat { get; set; }

        public short? pt_izin3_tkyarim_isgunu { get; set; }

        public double? pt_izin3_tkyarim_isgun_saat { get; set; }

        public double? pt_izin3_tktutar { get; set; }

        public short? pt_izin4_tkgun { get; set; }

        public double? pt_izin4_tksaat { get; set; }

        public short? pt_izin4_tkyarim_isgunu { get; set; }

        public double? pt_izin4_tkyarim_isgun_saat { get; set; }

        public double? pt_izin4_tktutar { get; set; }

        public short? pt_izin5_tkgun { get; set; }

        public double? pt_izin5_tksaat { get; set; }

        public short? pt_izin5_tkyarim_isgunu { get; set; }

        public double? pt_izin5_tkyarim_isgun_saat { get; set; }

        public double? pt_izin5_tktutar { get; set; }

        public short? pt_izin6_tkgun { get; set; }

        public double? pt_izin6_tksaat { get; set; }

        public short? pt_izin6_tkyarim_isgunu { get; set; }

        public double? pt_izin6_tkyarim_isgun_saat { get; set; }

        public double? pt_izin6_tktutar { get; set; }

        public short? pt_izin7_tkgun { get; set; }

        public double? pt_izin7_tksaat { get; set; }

        public short? pt_izin7_tkyarim_isgunu { get; set; }

        public double? pt_izin7_tkyarim_isgun_saat { get; set; }

        public double? pt_izin7_tktutar { get; set; }

        public short? pt_izin8_tkgun { get; set; }

        public double? pt_izin8_tksaat { get; set; }

        public short? pt_izin8_tkyarim_isgunu { get; set; }

        public double? pt_izin8_tkyarim_isgun_saat { get; set; }

        public double? pt_izin8_tktutar { get; set; }

        public short? pt_izin9_tkgun { get; set; }

        public double? pt_izin9_tksaat { get; set; }

        public short? pt_izin9_tkyarim_isgunu { get; set; }

        public double? pt_izin9_tkyarim_isgun_saat { get; set; }

        public double? pt_izin9_tktutar { get; set; }

        public short? pt_izin10_tkgun { get; set; }

        public double? pt_izin10_tksaat { get; set; }

        public short? pt_izin10_tkyarim_isgunu { get; set; }

        public double? pt_izin10_tkyarim_isgun_saat { get; set; }

        public double? pt_izin10_tktutar { get; set; }

        public short? pt_izin11_tkgun { get; set; }

        public double? pt_izin11_tksaat { get; set; }

        public short? pt_izin11_tkyarim_isgunu { get; set; }

        public double? pt_izin11_tkyarim_isgun_saat { get; set; }

        public double? pt_izin11_tktutar { get; set; }

        public short? pt_izin12_tkgun { get; set; }

        public double? pt_izin12_tksaat { get; set; }

        public short? pt_izin12_tkyarim_isgunu { get; set; }

        public double? pt_izin12_tkyarim_isgun_saat { get; set; }

        public double? pt_izin12_tktutar { get; set; }

        public short? pt_izin13_tkgun { get; set; }

        public double? pt_izin13_tksaat { get; set; }

        public short? pt_izin13_tkyarim_isgunu { get; set; }

        public double? pt_izin13_tkyarim_isgun_saat { get; set; }

        public double? pt_izin13_tktutar { get; set; }

        public short? pt_izin14_tkgun { get; set; }

        public double? pt_izin14_tksaat { get; set; }

        public short? pt_izin14_tkyarim_isgunu { get; set; }

        public double? pt_izin14_tkyarim_isgun_saat { get; set; }

        public double? pt_izin14_tktutar { get; set; }

        public short? pt_izin15_tkgun { get; set; }

        public double? pt_izin15_tksaat { get; set; }

        public short? pt_izin15_tkyarim_isgunu { get; set; }

        public double? pt_izin15_tkyarim_isgun_saat { get; set; }

        public double? pt_izin15_tktutar { get; set; }

        public short? pt_izin16_tkgun { get; set; }

        public double? pt_izin16_tksaat { get; set; }

        public short? pt_izin16_tkyarim_isgunu { get; set; }

        public double? pt_izin16_tkyarim_isgun_saat { get; set; }

        public double? pt_izin16_tktutar { get; set; }

        public double? pt_hayatsigorta_isveren { get; set; }

        public double? pt_hayatsigorta_calisan { get; set; }

        public double? pt_kanungvindirimi { get; set; }

        public double? pt_kanundvindirimi { get; set; }

        public double? pt_isssigisvpayi_tesvind { get; set; }

        public bool? pt_hazine_destegine_tabi_fl { get; set; }

        public int? pt_hazine_destegi_gunu { get; set; }

        public double? pt_ilave_agi { get; set; }

        public double? pt_saatlik_izin_suresi { get; set; }

        public double? pt_saatlik_izin_tutari { get; set; }

        public double? pt_otobes_tutari { get; set; }

        public double? pt_hazinekanunudvindirimi { get; set; }
    }
}
