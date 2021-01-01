namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HIZMET_MASRAF_GRUPLARI
    {
        [Key]
        public int hmgrp_RECno { get; set; }

        public short hmgrp_RECid_DBCno { get; set; }

        public int hmgrp_RECid_RECno { get; set; }

        public int? hmgrp_SpecRECno { get; set; }

        public bool? hmgrp_iptal { get; set; }

        public short? hmgrp_fileid { get; set; }

        public bool? hmgrp_hidden { get; set; }

        public bool? hmgrp_kilitli { get; set; }

        public bool? hmgrp_degisti { get; set; }

        public int? hmgrp_checksum { get; set; }

        public short? hmgrp_create_user { get; set; }

        public DateTime? hmgrp_create_date { get; set; }

        public short? hmgrp_lastup_user { get; set; }

        public DateTime? hmgrp_lastup_date { get; set; }

        [StringLength(4)]
        public string hmgrp_special1 { get; set; }

        [StringLength(4)]
        public string hmgrp_special2 { get; set; }

        [StringLength(4)]
        public string hmgrp_special3 { get; set; }

        [StringLength(25)]
        public string hmgrp_kod { get; set; }

        [StringLength(90)]
        public string hmgrp_ismi { get; set; }
    }
}
