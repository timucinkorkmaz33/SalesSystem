namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_EGITIM_TALEPLERI
    {
        [Key]
        public int pet_RECno { get; set; }

        public short pet_RECid_DBCno { get; set; }

        public int pet_RECid_RECno { get; set; }

        public int? pet_SpecRECno { get; set; }

        public bool? pet_iptal { get; set; }

        public short? pet_fileid { get; set; }

        public bool? pet_hidden { get; set; }

        public bool? pet_kilitli { get; set; }

        public bool? pet_degisti { get; set; }

        public int? pet_checksum { get; set; }

        public short? pet_create_user { get; set; }

        public DateTime? pet_create_date { get; set; }

        public short? pet_lastup_user { get; set; }

        public DateTime? pet_lastup_date { get; set; }

        [StringLength(4)]
        public string pet_special1 { get; set; }

        [StringLength(4)]
        public string pet_special2 { get; set; }

        [StringLength(4)]
        public string pet_special3 { get; set; }

        [StringLength(25)]
        public string pet_perskodu { get; set; }

        public DateTime? pet_taleptarihi { get; set; }

        [StringLength(25)]
        public string pet_egitimkodu { get; set; }

        public byte? pet_talepdurumu { get; set; }

        public int? pet_onaylayan_kullanici { get; set; }
    }
}
