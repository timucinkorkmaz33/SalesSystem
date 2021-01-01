namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KREDI_SOZLESMESI_TAKSIT_TANIMLARI
    {
        [Key]
        public int krsoztaksit_RECno { get; set; }

        public short krsoztaksit_RECid_DBCno { get; set; }

        public int krsoztaksit_RECid_RECno { get; set; }

        public int? krsoztaksit_Spec_Rec_no { get; set; }

        public bool? krsoztaksit_iptal { get; set; }

        public short? krsoztaksit_fileid { get; set; }

        public bool? krsoztaksit_hidden { get; set; }

        public bool? krsoztaksit_kilitli { get; set; }

        public bool? krsoztaksit_degisti { get; set; }

        public int? krsoztaksit_checksum { get; set; }

        public short? krsoztaksit_create_user { get; set; }

        public DateTime? krsoztaksit_create_date { get; set; }

        public short? krsoztaksit_lastup_user { get; set; }

        public DateTime? krsoztaksit_lastup_date { get; set; }

        [StringLength(4)]
        public string krsoztaksit_special1 { get; set; }

        [StringLength(4)]
        public string krsoztaksit_special2 { get; set; }

        [StringLength(4)]
        public string krsoztaksit_special3 { get; set; }

        [StringLength(25)]
        public string krsoztaksit_sozkodu { get; set; }

        public short? krsoztaksit_taksitno { get; set; }

        public DateTime? krsoztaksit_vade { get; set; }

        public double? krsoztaksit_taksit { get; set; }

        public double? krsoztaksit_anapara { get; set; }

        public double? krsoztaksit_faizorani { get; set; }

        public double? krsoztaksit_faiz { get; set; }

        public double? krsoztaksit_bsmv { get; set; }

        public double? krsoztaksit_kkdf { get; set; }

        public double? krsoztaksit_kalananapara { get; set; }

        public double? krsoztaksit_gunlukerkenodemeind { get; set; }

        [StringLength(6)]
        public string krsoztaksit_odemeevrakseri { get; set; }

        public int? krsoztaksit_odemeevraksira { get; set; }

        public double? krsoztaksit_odenen_ana { get; set; }

        public double? krsoztaksit_odenen_alt { get; set; }

        public double? krsoztaksit_odenen_orj { get; set; }
    }
}
