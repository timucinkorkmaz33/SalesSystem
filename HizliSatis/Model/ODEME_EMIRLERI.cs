namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ODEME_EMIRLERI
    {
        [Key]
        public int sck_RECno { get; set; }

        public short sck_RECid_DBCno { get; set; }

        public int sck_RECid_RECno { get; set; }

        public int? sck_SpecRECno { get; set; }

        public bool? sck_iptal { get; set; }

        public short? sck_fileid { get; set; }

        public bool? sck_hidden { get; set; }

        public bool? sck_kilitli { get; set; }

        public bool? sck_degisti { get; set; }

        public int? sck_checksum { get; set; }

        public short? sck_create_user { get; set; }

        public DateTime? sck_create_date { get; set; }

        public short? sck_lastup_user { get; set; }

        public DateTime? sck_lastup_date { get; set; }

        [StringLength(4)]
        public string sck_special1 { get; set; }

        [StringLength(4)]
        public string sck_special2 { get; set; }

        [StringLength(4)]
        public string sck_special3 { get; set; }

        public int? sck_firmano { get; set; }

        public int? sck_subeno { get; set; }

        public byte? sck_tip { get; set; }

        [StringLength(25)]
        public string sck_refno { get; set; }

        [StringLength(25)]
        public string sck_bankano { get; set; }

        [StringLength(50)]
        public string sck_borclu { get; set; }

        [StringLength(40)]
        public string sck_vdaire_no { get; set; }

        public DateTime? sck_vade { get; set; }

        public double? sck_tutar { get; set; }

        public byte? sck_doviz { get; set; }

        public double? sck_odenen { get; set; }

        public byte? sck_degerleme_islendi { get; set; }

        [StringLength(50)]
        public string sck_banka_adres1 { get; set; }

        [StringLength(50)]
        public string sck_sube_adres2 { get; set; }

        [StringLength(15)]
        public string sck_borclu_tel { get; set; }

        [StringLength(30)]
        public string sck_hesapno_sehir { get; set; }

        [StringLength(25)]
        public string sck_no { get; set; }

        public DateTime? sck_duzen_tarih { get; set; }

        public byte? sck_sahip_cari_cins { get; set; }

        [StringLength(25)]
        public string sck_sahip_cari_kodu { get; set; }

        public byte? sck_sahip_cari_grupno { get; set; }

        public byte? sck_nerede_cari_cins { get; set; }

        [StringLength(25)]
        public string sck_nerede_cari_kodu { get; set; }

        public byte? sck_nerede_cari_grupno { get; set; }

        public DateTime? sck_ilk_hareket_tarihi { get; set; }

        [StringLength(6)]
        public string sck_ilk_evrak_seri { get; set; }

        public int? sck_ilk_evrak_sira_no { get; set; }

        public int? sck_ilk_evrak_satir_no { get; set; }

        public DateTime? sck_son_hareket_tarihi { get; set; }

        public double? sck_doviz_kur { get; set; }

        public byte? sck_sonpoz { get; set; }

        public byte? sck_imza { get; set; }

        [StringLength(25)]
        public string sck_srmmrk { get; set; }

        [StringLength(14)]
        public string sck_kesideyeri { get; set; }

        [StringLength(4)]
        public string Sck_TCMB_Banka_kodu { get; set; }

        [StringLength(8)]
        public string Sck_TCMB_Sube_kodu { get; set; }

        [StringLength(3)]
        public string Sck_TCMB_il_kodu { get; set; }

        public bool? SckTasra_fl { get; set; }

        [StringLength(25)]
        public string sck_projekodu { get; set; }

        public double? sck_masraf1 { get; set; }

        public byte? sck_masraf1_isleme { get; set; }

        public double? sck_masraf2 { get; set; }

        public byte? sck_masraf2_isleme { get; set; }

        public double? sck_odul_katkisi_tutari { get; set; }

        public double? sck_servis_komisyon_tutari { get; set; }

        public double? sck_erken_odeme_faiz_tutari { get; set; }

        public bool? sck_odul_katkisi_tutari_islendi_fl { get; set; }

        public bool? sck_servis_komisyon_tutari_islendi_fl { get; set; }

        public bool? sck_erken_odeme_faiz_tutari_islendi_fl { get; set; }

        public byte? sck_kredi_karti_tipi { get; set; }

        public short? sck_taksit_sayisi { get; set; }

        public short? sck_kacinci_taksit { get; set; }

        [StringLength(25)]
        public string sck_uye_isyeri_no { get; set; }

        [StringLength(16)]
        public string sck_kredi_karti_no { get; set; }

        [StringLength(10)]
        public string sck_provizyon_kodu { get; set; }
    }
}
