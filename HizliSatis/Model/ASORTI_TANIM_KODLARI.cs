namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ASORTI_TANIM_KODLARI
    {
        [Key]
        public int AsortiTan_RECno { get; set; }

        public short AsortiTan_RECid_DBCno { get; set; }

        public int AsortiTan_RECid_RECno { get; set; }

        public int? AsortiTan_SpecRECno { get; set; }

        public bool? AsortiTan_iptal { get; set; }

        public short? AsortiTan_fileid { get; set; }

        public bool? AsortiTan_hidden { get; set; }

        public bool? AsortiTan_kilitli { get; set; }

        public bool? AsortiTan_degisti { get; set; }

        public int? AsortiTan_checksum { get; set; }

        public short? AsortiTan_create_user { get; set; }

        public DateTime? AsortiTan_create_date { get; set; }

        public short? AsortiTan_lastup_user { get; set; }

        public DateTime? AsortiTan_lastup_date { get; set; }

        [StringLength(4)]
        public string AsortiTan_special1 { get; set; }

        [StringLength(4)]
        public string AsortiTan_special2 { get; set; }

        [StringLength(4)]
        public string AsortiTan_special3 { get; set; }

        [StringLength(25)]
        public string AsortiTan_Kodu { get; set; }

        [StringLength(127)]
        public string AsortiTan_Aciklama { get; set; }
    }
}
