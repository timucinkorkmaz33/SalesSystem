namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_ICRA_ODEMELERI
    {
        [Key]
        public int pio_RECno { get; set; }

        public short? pio_RECid_DBCno { get; set; }

        public int pio_RECid_RECno { get; set; }

        public int? pio_SpecRECno { get; set; }

        public bool? pio_iptal { get; set; }

        public short? pio_fileid { get; set; }

        public bool? pio_hidden { get; set; }

        public bool? pio_kilitli { get; set; }

        public bool? pio_degisti { get; set; }

        public int? pio_checksum { get; set; }

        public short? pio_create_user { get; set; }

        public DateTime? pio_create_date { get; set; }

        public short? pio_lastup_user { get; set; }

        public DateTime? pio_lastup_date { get; set; }

        [StringLength(4)]
        public string pio_special1 { get; set; }

        [StringLength(4)]
        public string pio_special2 { get; set; }

        [StringLength(4)]
        public string pio_special3 { get; set; }

        [StringLength(25)]
        public string pio_perkodu { get; set; }

        public int? pio_icrasira { get; set; }

        public int? pio_taksitno { get; set; }

        public int? pio_maliyil { get; set; }

        public short? pio_tah_ay { get; set; }

        public short? pio_tahno { get; set; }

        public double? pio_ucretten_odenen { get; set; }

        public double? pio_izin_ucretten_odenen { get; set; }

        public double? pio_ekkazanctan_odenen { get; set; }

        public double? pio_sosyarddan_odenen { get; set; }

        public double? pio_tazminattan_odenen { get; set; }

        public double? pio_agiden_odenen { get; set; }

        public short? pio_virman_recid_dbcno { get; set; }

        public int? pio_virman_recid_recno { get; set; }

        public short? pio_odeme_recid_dbcno { get; set; }

        public int? pio_odeme_recid_recno { get; set; }
    }
}
