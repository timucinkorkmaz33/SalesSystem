namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISEMRI_MUHASEBE_GRUPLARI
    {
        [Key]
        public int ismuh_RECno { get; set; }

        public short ismuh_RECid_DBCno { get; set; }

        public int ismuh_RECid_RECno { get; set; }

        public int? ismuh_SpecRECno { get; set; }

        public bool? ismuh_iptal { get; set; }

        public short? ismuh_fileid { get; set; }

        public bool? ismuh_hidden { get; set; }

        public bool? ismuh_kilitli { get; set; }

        public bool? ismuh_degisti { get; set; }

        public int? ismuh_checksum { get; set; }

        public short? ismuh_create_user { get; set; }

        public DateTime? ismuh_create_date { get; set; }

        public short? ismuh_lastup_user { get; set; }

        public DateTime? ismuh_lastup_date { get; set; }

        [StringLength(4)]
        public string ismuh_special1 { get; set; }

        [StringLength(4)]
        public string ismuh_special2 { get; set; }

        [StringLength(4)]
        public string ismuh_special3 { get; set; }

        [StringLength(25)]
        public string ismuh_kod { get; set; }

        [StringLength(90)]
        public string ismuh_ismi { get; set; }

        [StringLength(40)]
        public string ismuh_muh_kod { get; set; }

        [StringLength(40)]
        public string ismuh_StokBirikMuhKod { get; set; }

        [StringLength(40)]
        public string ismuh_HizmetBirikMuhKod { get; set; }

        [StringLength(40)]
        public string ismuh_StokYansitMuhKod { get; set; }

        [StringLength(40)]
        public string ismuh_HizmetYansitMuhKo { get; set; }

        [StringLength(40)]
        public string ismuh_yarimamulbirikimmuhko { get; set; }

        [StringLength(40)]
        public string ismuh_yarimamulyansitmamuhko { get; set; }

        [StringLength(40)]
        public string ismuh_MakineMalYanMuhKo { get; set; }

        [StringLength(40)]
        public string ismuh_ElemanMalYanMuhKo { get; set; }

        [StringLength(40)]
        public string ismuh_YariMamulMuhKod { get; set; }

        [StringLength(40)]
        public string ismuh_GenMalYanMuhKod_1 { get; set; }

        [StringLength(40)]
        public string ismuh_GenMalYanMuhKod_2 { get; set; }

        [StringLength(40)]
        public string ismuh_GenMalYanMuhKod_3 { get; set; }

        [StringLength(40)]
        public string ismuh_GenMalYanMuhKod_4 { get; set; }

        [StringLength(40)]
        public string ismuh_GenMalYanMuhKod_5 { get; set; }

        [StringLength(40)]
        public string ismuh_GenUrtMalYanMuhKod_1 { get; set; }

        [StringLength(40)]
        public string ismuh_GenUrtMalYanMuhKod_2 { get; set; }

        [StringLength(40)]
        public string ismuh_GenUrtMalYanMuhKod_3 { get; set; }

        [StringLength(40)]
        public string ismuh_GenUrtMalYanMuhKod_4 { get; set; }

        [StringLength(40)]
        public string ismuh_GenUrtMalYanMuhKod_5 { get; set; }
    }
}
