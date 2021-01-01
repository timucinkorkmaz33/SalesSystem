namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_MUHASEBE_GRUPLARI
    {
        [Key]
        public int stmuh_RECno { get; set; }

        public short stmuh_RECid_DBCno { get; set; }

        public int stmuh_RECid_RECno { get; set; }

        public int? stmuh_SpecRECno { get; set; }

        public bool? stmuh_iptal { get; set; }

        public short? stmuh_fileid { get; set; }

        public bool? stmuh_hidden { get; set; }

        public bool? stmuh_kilitli { get; set; }

        public bool? stmuh_degisti { get; set; }

        public int? stmuh_checksum { get; set; }

        public short? stmuh_create_user { get; set; }

        public DateTime? stmuh_create_date { get; set; }

        public short? stmuh_lastup_user { get; set; }

        public DateTime? stmuh_lastup_date { get; set; }

        [StringLength(4)]
        public string stmuh_special1 { get; set; }

        [StringLength(4)]
        public string stmuh_special2 { get; set; }

        [StringLength(4)]
        public string stmuh_special3 { get; set; }

        [StringLength(25)]
        public string stmuh_kod { get; set; }

        [StringLength(90)]
        public string stmuh_ismi { get; set; }

        [StringLength(40)]
        public string stmuh_muh_kod { get; set; }

        [StringLength(40)]
        public string stmuh_iade_muh_kod { get; set; }

        [StringLength(40)]
        public string stmuh_YurtIciSatMuhK { get; set; }

        [StringLength(40)]
        public string stmuh_SatIadeMuhKod { get; set; }

        [StringLength(40)]
        public string stmuh_SatIskMuhKod { get; set; }

        [StringLength(40)]
        public string stmuh_Al_IskMKod { get; set; }

        [StringLength(40)]
        public string stmuh_SatMalMuhKod { get; set; }

        [StringLength(40)]
        public string stmuh_YurtDisiSatMuh { get; set; }

        [StringLength(40)]
        public string stmuh_ilavemasmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_yatirimtesmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_depsatmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_depsatmalmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatIadmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatIskmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_satfiyfarkmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_yurtdisisatmalmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatmalmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_sifirbedsatmalmuhkod { get; set; }

        [StringLength(40)]
        public string stmuh_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_iade_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_yurticisat_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_satiade_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_satisk_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_alisk_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_satmal_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_yurtdisisat_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_ilavemas_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_yatirimtes_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_depsat_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_depsatmal_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsat_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatiade_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatisk_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_satfiyfark_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_yurtdisisatmal_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_bagortsatmal_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_sifirbedsatmal_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_uretimmaliyet_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_uretimkapasite_ufrsfark_kod { get; set; }

        [StringLength(40)]
        public string stmuh_degerdusuklugu_ufrs_kod { get; set; }
    }
}
