namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_EGITIMLERI
    {
        [Key]
        public int ke_RECno { get; set; }

        public short ke_RECid_DBCno { get; set; }

        public int ke_RECid_RECno { get; set; }

        public int? ke_SpecRECno { get; set; }

        public bool? ke_iptal { get; set; }

        public short? ke_fileid { get; set; }

        public bool? ke_hidden { get; set; }

        public bool? ke_kilitli { get; set; }

        public bool? ke_degisti { get; set; }

        public int? ke_checksum { get; set; }

        public short? ke_create_user { get; set; }

        public DateTime? ke_create_date { get; set; }

        public short? ke_lastup_user { get; set; }

        public DateTime? ke_lastup_date { get; set; }

        [StringLength(4)]
        public string ke_special1 { get; set; }

        [StringLength(4)]
        public string ke_special2 { get; set; }

        [StringLength(4)]
        public string ke_special3 { get; set; }

        [StringLength(25)]
        public string ke_kadrokod { get; set; }

        public int? ke_kadrosirano { get; set; }

        public int? ke_satirno { get; set; }

        public byte? ke_tipi { get; set; }

        [StringLength(25)]
        public string ke_egitimkod { get; set; }

        public DateTime? ke_gecerliliktarihi { get; set; }

        public int? ke_tamamlama_suresi { get; set; }
    }
}
