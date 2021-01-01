namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVMKAPI_HAREKETLERI
    {
        [Key]
        public int kapih_RECno { get; set; }

        public short kapih_RECid_DBCno { get; set; }

        public int kapih_RECid_RECno { get; set; }

        public int? kapih_Spec_Rec_no { get; set; }

        public bool? kapih_iptal { get; set; }

        public short? kapih_fileid { get; set; }

        public bool? kapih_hidden { get; set; }

        public bool? kapih_kilitli { get; set; }

        public bool? kapih_degisti { get; set; }

        public int? kapih_checksum { get; set; }

        public short? kapih_create_user { get; set; }

        public DateTime? kapih_create_date { get; set; }

        public short? kapih_lastup_user { get; set; }

        public DateTime? kapih_lastup_date { get; set; }

        [StringLength(4)]
        public string kapih_special1 { get; set; }

        [StringLength(4)]
        public string kapih_special2 { get; set; }

        [StringLength(4)]
        public string kapih_special3 { get; set; }

        public int? kapih_firmano { get; set; }

        public int? kapih_subeno { get; set; }

        [StringLength(25)]
        public string kapih_kapikodu { get; set; }

        public DateTime? kapih_tarih { get; set; }

        public int? kapih_ziyaretci_sayisi { get; set; }
    }
}
