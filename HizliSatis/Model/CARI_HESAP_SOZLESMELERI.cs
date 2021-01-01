namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HESAP_SOZLESMELERI
    {
        [Key]
        public int csoz_RECno { get; set; }

        public short csoz_RECid_DBCno { get; set; }

        public int csoz_RECid_RECno { get; set; }

        public int? csoz_SpecRECno { get; set; }

        public bool? csoz_iptal { get; set; }

        public short? csoz_fileid { get; set; }

        public bool? csoz_hidden { get; set; }

        public bool? csoz_kilitli { get; set; }

        public bool? csoz_degisti { get; set; }

        public int? csoz_checksum { get; set; }

        public short? csoz_create_user { get; set; }

        public DateTime? csoz_create_date { get; set; }

        public short? csoz_lastup_user { get; set; }

        public DateTime? csoz_lastup_date { get; set; }

        [StringLength(4)]
        public string csoz_special1 { get; set; }

        [StringLength(4)]
        public string csoz_special2 { get; set; }

        [StringLength(4)]
        public string csoz_special3 { get; set; }

        [StringLength(25)]
        public string csoz_sozlesmekodu { get; set; }

        [StringLength(50)]
        public string csoz_sozlesmeaciklamasi { get; set; }

        [StringLength(25)]
        public string csoz_baglicarikod { get; set; }

        public DateTime? csoz_sozlesmebaslamatarihi { get; set; }

        public DateTime? csoz_sozlesmebitistarihi { get; set; }

        public byte? csoz_sozlesmeuygulama { get; set; }
    }
}
