namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KULLANICI_ONAY_TANIMLARI
    {
        [Key]
        public int ko_RECno { get; set; }

        public short ko_RECid_DBCno { get; set; }

        public int ko_RECid_RECno { get; set; }

        public int? ko_SpecRECno { get; set; }

        public bool? ko_iptal { get; set; }

        public short? ko_fileid { get; set; }

        public bool? ko_hidden { get; set; }

        public bool? ko_kilitli { get; set; }

        public bool? ko_degisti { get; set; }

        public int? ko_checksum { get; set; }

        public short? ko_create_user { get; set; }

        public DateTime? ko_create_date { get; set; }

        public short? ko_lastup_user { get; set; }

        public DateTime? ko_lastup_date { get; set; }

        [StringLength(4)]
        public string ko_special1 { get; set; }

        [StringLength(4)]
        public string ko_special2 { get; set; }

        [StringLength(4)]
        public string ko_special3 { get; set; }

        public int? ko_kullanici_no { get; set; }

        public int? ko_firma_no { get; set; }

        public byte? ko_evrak_tip { get; set; }

        public bool? ko_evrak_onaylayabilir { get; set; }

        public double? ko_evrak_limiti { get; set; }

        public byte? ko_evrak_yetki_tipi { get; set; }

        public byte? ko_evrak_min_onay_sayisi { get; set; }
    }
}
