namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYON_HATALARI
    {
        [Key]
        public int oph_RECno { get; set; }

        public short oph_RECid_DBCno { get; set; }

        public int oph_RECid_RECno { get; set; }

        public int? oph_SpecRECNo { get; set; }

        public bool? oph_iptal { get; set; }

        public short? oph_fileid { get; set; }

        public bool? oph_hidden { get; set; }

        public bool? oph_kilitli { get; set; }

        public bool? oph_degisti { get; set; }

        public int? oph_CheckSum { get; set; }

        public short? oph_create_user { get; set; }

        public DateTime? oph_create_date { get; set; }

        public short? oph_lastup_user { get; set; }

        public DateTime? oph_lastup_date { get; set; }

        [StringLength(4)]
        public string oph_special1 { get; set; }

        [StringLength(4)]
        public string oph_special2 { get; set; }

        [StringLength(4)]
        public string oph_special3 { get; set; }

        public short? oph_OpTamamRecID_DBCno { get; set; }

        public int? oph_OpTamamRecID_RECno { get; set; }

        [StringLength(127)]
        public string oph_HataKodlari { get; set; }

        [StringLength(25)]
        public string oph_Personel { get; set; }

        public DateTime? oph_Tarih { get; set; }

        public double? oph_HataliMiktar { get; set; }
    }
}
