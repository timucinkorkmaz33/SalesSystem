namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_NITELIKLERI
    {
        [Key]
        public int kn_RECno { get; set; }

        public short kn_RECid_DBCno { get; set; }

        public int kn_RECid_RECno { get; set; }

        public int? kn_SpecRECno { get; set; }

        public bool? kn_iptal { get; set; }

        public short? kn_fileid { get; set; }

        public bool? kn_hidden { get; set; }

        public bool? kn_kilitli { get; set; }

        public bool? kn_degisti { get; set; }

        public int? kn_checksum { get; set; }

        public short? kn_create_user { get; set; }

        public DateTime? kn_create_date { get; set; }

        public short? kn_lastup_user { get; set; }

        public DateTime? kn_lastup_date { get; set; }

        [StringLength(4)]
        public string kn_special1 { get; set; }

        [StringLength(4)]
        public string kn_special2 { get; set; }

        [StringLength(4)]
        public string kn_special3 { get; set; }

        [StringLength(25)]
        public string kn_kadrokod { get; set; }

        public int? kn_kadrosirano { get; set; }

        public int? kn_satirno { get; set; }

        [StringLength(25)]
        public string kn_nitelikkod { get; set; }

        public DateTime? kn_gecerliliktarihi { get; set; }
    }
}
