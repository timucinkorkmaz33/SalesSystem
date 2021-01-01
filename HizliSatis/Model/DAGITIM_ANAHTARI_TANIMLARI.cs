namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DAGITIM_ANAHTARI_TANIMLARI
    {
        [Key]
        public int dan_RECno { get; set; }

        public short dan_RECid_DBCno { get; set; }

        public int dan_RECid_RECno { get; set; }

        public int? dan_SpecRECno { get; set; }

        public bool? dan_iptal { get; set; }

        public short? dan_fileid { get; set; }

        public bool? dan_hidden { get; set; }

        public bool? dan_kilitli { get; set; }

        public bool? dan_degisti { get; set; }

        public int? dan_checksum { get; set; }

        public short? dan_create_user { get; set; }

        public DateTime? dan_create_date { get; set; }

        public short? dan_lastup_user { get; set; }

        public DateTime? dan_lastup_date { get; set; }

        [StringLength(4)]
        public string dan_special1 { get; set; }

        [StringLength(4)]
        public string dan_special2 { get; set; }

        [StringLength(4)]
        public string dan_special3 { get; set; }

        [StringLength(25)]
        public string dan_kod { get; set; }

        public DateTime? dan_gecerliliktarihi { get; set; }

        public int? dan_satirno { get; set; }

        [StringLength(50)]
        public string dan_ismi { get; set; }

        public byte? dan_tipi { get; set; }

        [StringLength(25)]
        public string dan_hesap_kodu { get; set; }

        [StringLength(25)]
        public string dan_srmmrk_kodu { get; set; }

        [StringLength(25)]
        public string dan_proje_kodu { get; set; }

        public double? dan_puan { get; set; }

        public byte? dan_puantipi { get; set; }
    }
}
