namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_ICRA_TANIMLARI
    {
        [Key]
        public int pit_RECno { get; set; }

        public short? pit_RECid_DBCno { get; set; }

        public int pit_RECid_RECno { get; set; }

        public int? pit_SpecRECno { get; set; }

        public bool? pit_iptal { get; set; }

        public short? pit_fileid { get; set; }

        public bool? pit_hidden { get; set; }

        public bool? pit_kilitli { get; set; }

        public bool? pit_degisti { get; set; }

        public int? pit_checksum { get; set; }

        public short? pit_create_user { get; set; }

        public DateTime? pit_create_date { get; set; }

        public short? pit_lastup_user { get; set; }

        public DateTime? pit_lastup_date { get; set; }

        [StringLength(4)]
        public string pit_special1 { get; set; }

        [StringLength(4)]
        public string pit_special2 { get; set; }

        [StringLength(4)]
        public string pit_special3 { get; set; }

        [StringLength(25)]
        public string pit_perkodu { get; set; }

        public int? pit_sirano { get; set; }

        public byte? pit_durumu { get; set; }

        public byte? pit_tipi { get; set; }

        [StringLength(127)]
        public string pit_aciklama { get; set; }

        public DateTime? pit_tebligtarihi { get; set; }

        [StringLength(25)]
        public string pit_icradairesi { get; set; }

        [StringLength(25)]
        public string pit_carikodu { get; set; }

        [StringLength(40)]
        public string pit_dosyano { get; set; }

        public int? pit_onceliksirasi { get; set; }

        public byte? pit_kesintisekli { get; set; }

        public short? pit_kesintiay { get; set; }

        public int? pit_kesintiyil { get; set; }

        public double? pit_toplamborctutari { get; set; }

        public double? pit_pesinodenentutar { get; set; }

        public double? pit_ucrettenkesintiorani { get; set; }

        public double? pit_izinucrettenkesintiorani { get; set; }

        public double? pit_ekkazanctankesintiorani { get; set; }

        public double? pit_sosyalkesintiorani { get; set; }

        public double? pit_tazminatkesintiorani { get; set; }

        public double? pit_agikesintiorani { get; set; }

        public double? pit_aylikkesintitutari { get; set; }

        [StringLength(40)]
        public string pit_IBAN { get; set; }

        [StringLength(4)]
        public string pit_banka_tcmb_kod { get; set; }

        [StringLength(8)]
        public string pit_banka_tcmb_subekod { get; set; }

        [StringLength(3)]
        public string pit_banka_tcmb_ilkod { get; set; }

        [StringLength(30)]
        public string pit_banka_hesapno { get; set; }

        [StringLength(25)]
        public string pit_banka_swiftkodu { get; set; }

        public bool? pit_taahhutlu_fl { get; set; }
    }
}
