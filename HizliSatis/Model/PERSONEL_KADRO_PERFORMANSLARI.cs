namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_KADRO_PERFORMANSLARI
    {
        [Key]
        public int kp_RECno { get; set; }

        public short kp_RECid_DBCno { get; set; }

        public int kp_RECid_RECno { get; set; }

        public int? kp_SpecRECno { get; set; }

        public bool? kp_iptal { get; set; }

        public short? kp_fileid { get; set; }

        public bool? kp_hidden { get; set; }

        public bool? kp_kilitli { get; set; }

        public bool? kp_degisti { get; set; }

        public int? kp_checksum { get; set; }

        public short? kp_create_user { get; set; }

        public DateTime? kp_create_date { get; set; }

        public short? kp_lastup_user { get; set; }

        public DateTime? kp_lastup_date { get; set; }

        [StringLength(4)]
        public string kp_special1 { get; set; }

        [StringLength(4)]
        public string kp_special2 { get; set; }

        [StringLength(4)]
        public string kp_special3 { get; set; }

        [StringLength(25)]
        public string kp_kadrokod { get; set; }

        public int? kp_kadrosirano { get; set; }

        public int? kp_satirno { get; set; }

        public byte? kp_performanstipi { get; set; }

        [StringLength(25)]
        public string kp_performanskod { get; set; }

        public DateTime? kp_gecerliliktarihi { get; set; }
    }
}
