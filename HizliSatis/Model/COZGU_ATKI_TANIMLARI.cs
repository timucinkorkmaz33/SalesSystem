namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class COZGU_ATKI_TANIMLARI
    {
        [Key]
        public int ca_RECno { get; set; }

        public short ca_RECid_DBCno { get; set; }

        public int ca_RECid_RECno { get; set; }

        public int? ca_SpecRECno { get; set; }

        public bool? ca_iptal { get; set; }

        public short? ca_fileid { get; set; }

        public bool? ca_hidden { get; set; }

        public bool? ca_kilitli { get; set; }

        public bool? ca_degisti { get; set; }

        public int? ca_checksum { get; set; }

        public short? ca_create_user { get; set; }

        public DateTime? ca_create_date { get; set; }

        public short? ca_lastup_user { get; set; }

        public DateTime? ca_lastup_date { get; set; }

        [StringLength(4)]
        public string ca_special1 { get; set; }

        [StringLength(4)]
        public string ca_special2 { get; set; }

        [StringLength(4)]
        public string ca_special3 { get; set; }

        public byte? ca_cozgu_atki { get; set; }

        [StringLength(25)]
        public string ca_stok_kodu { get; set; }

        public byte? ca_rapor_iplik { get; set; }

        public int? ca_id { get; set; }

        public int? ca_parent_id { get; set; }

        [StringLength(25)]
        public string ca_adi { get; set; }

        public int? ca_tekrar_tel_sayisi { get; set; }

        public byte? ca_rapor_tipi { get; set; }

        public double? ca_rapor_boyu { get; set; }
    }
}
