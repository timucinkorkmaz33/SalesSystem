namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_PLAN_MATRISI
    {
        [Key]
        public int mtrs_RECno { get; set; }

        public short mtrs_RECid_DBCno { get; set; }

        public int mtrs_RECid_RECno { get; set; }

        public int? mtrs_SpecRECno { get; set; }

        public bool? mtrs_iptal { get; set; }

        public short? mtrs_fileid { get; set; }

        public bool? mtrs_hidden { get; set; }

        public bool? mtrs_kilitli { get; set; }

        public bool? mtrs_degisti { get; set; }

        public int? mtrs_checksum { get; set; }

        public short? mtrs_create_user { get; set; }

        public DateTime? mtrs_create_date { get; set; }

        public short? mtrs_lastup_user { get; set; }

        public DateTime? mtrs_lastup_date { get; set; }

        [StringLength(4)]
        public string mtrs_special1 { get; set; }

        [StringLength(4)]
        public string mtrs_special2 { get; set; }

        [StringLength(4)]
        public string mtrs_special3 { get; set; }

        [StringLength(25)]
        public string mtrs_kodu { get; set; }

        [StringLength(90)]
        public string mtrs_aciklama { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi1 { get; set; }

        public DateTime? mtrs_bastar1 { get; set; }

        public DateTime? mtrs_bittar1 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi2 { get; set; }

        public DateTime? mtrs_bastar2 { get; set; }

        public DateTime? mtrs_bittar2 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi3 { get; set; }

        public DateTime? mtrs_bastar3 { get; set; }

        public DateTime? mtrs_bittar3 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi4 { get; set; }

        public DateTime? mtrs_bastar4 { get; set; }

        public DateTime? mtrs_bittar4 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi5 { get; set; }

        public DateTime? mtrs_bastar5 { get; set; }

        public DateTime? mtrs_bittar5 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi6 { get; set; }

        public DateTime? mtrs_bastar6 { get; set; }

        public DateTime? mtrs_bittar6 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi7 { get; set; }

        public DateTime? mtrs_bastar7 { get; set; }

        public DateTime? mtrs_bittar7 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi8 { get; set; }

        public DateTime? mtrs_bastar8 { get; set; }

        public DateTime? mtrs_bittar8 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi9 { get; set; }

        public DateTime? mtrs_bastar9 { get; set; }

        public DateTime? mtrs_bittar9 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi10 { get; set; }

        public DateTime? mtrs_bastar10 { get; set; }

        public DateTime? mtrs_bittar10 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi11 { get; set; }

        public DateTime? mtrs_bastar11 { get; set; }

        public DateTime? mtrs_bittar11 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi12 { get; set; }

        public DateTime? mtrs_bastar12 { get; set; }

        public DateTime? mtrs_bittar12 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi13 { get; set; }

        public DateTime? mtrs_bastar13 { get; set; }

        public DateTime? mtrs_bittar13 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi14 { get; set; }

        public DateTime? mtrs_bastar14 { get; set; }

        public DateTime? mtrs_bittar14 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi15 { get; set; }

        public DateTime? mtrs_bastar15 { get; set; }

        public DateTime? mtrs_bittar15 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi16 { get; set; }

        public DateTime? mtrs_bastar16 { get; set; }

        public DateTime? mtrs_bittar16 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi17 { get; set; }

        public DateTime? mtrs_bastar17 { get; set; }

        public DateTime? mtrs_bittar17 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi18 { get; set; }

        public DateTime? mtrs_bastar18 { get; set; }

        public DateTime? mtrs_bittar18 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi19 { get; set; }

        public DateTime? mtrs_bastar19 { get; set; }

        public DateTime? mtrs_bittar19 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi20 { get; set; }

        public DateTime? mtrs_bastar20 { get; set; }

        public DateTime? mtrs_bittar20 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi21 { get; set; }

        public DateTime? mtrs_bastar21 { get; set; }

        public DateTime? mtrs_bittar21 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi22 { get; set; }

        public DateTime? mtrs_bastar22 { get; set; }

        public DateTime? mtrs_bittar22 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi23 { get; set; }

        public DateTime? mtrs_bastar23 { get; set; }

        public DateTime? mtrs_bittar23 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi24 { get; set; }

        public DateTime? mtrs_bastar24 { get; set; }

        public DateTime? mtrs_bittar24 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi25 { get; set; }

        public DateTime? mtrs_bastar25 { get; set; }

        public DateTime? mtrs_bittar25 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi26 { get; set; }

        public DateTime? mtrs_bastar26 { get; set; }

        public DateTime? mtrs_bittar26 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi27 { get; set; }

        public DateTime? mtrs_bastar27 { get; set; }

        public DateTime? mtrs_bittar27 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi28 { get; set; }

        public DateTime? mtrs_bastar28 { get; set; }

        public DateTime? mtrs_bittar28 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi29 { get; set; }

        public DateTime? mtrs_bastar29 { get; set; }

        public DateTime? mtrs_bittar29 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi30 { get; set; }

        public DateTime? mtrs_bastar30 { get; set; }

        public DateTime? mtrs_bittar30 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi31 { get; set; }

        public DateTime? mtrs_bastar31 { get; set; }

        public DateTime? mtrs_bittar31 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi32 { get; set; }

        public DateTime? mtrs_bastar32 { get; set; }

        public DateTime? mtrs_bittar32 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi33 { get; set; }

        public DateTime? mtrs_bastar33 { get; set; }

        public DateTime? mtrs_bittar33 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi34 { get; set; }

        public DateTime? mtrs_bastar34 { get; set; }

        public DateTime? mtrs_bittar34 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi35 { get; set; }

        public DateTime? mtrs_bastar35 { get; set; }

        public DateTime? mtrs_bittar35 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi36 { get; set; }

        public DateTime? mtrs_bastar36 { get; set; }

        public DateTime? mtrs_bittar36 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi37 { get; set; }

        public DateTime? mtrs_bastar37 { get; set; }

        public DateTime? mtrs_bittar37 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi38 { get; set; }

        public DateTime? mtrs_bastar38 { get; set; }

        public DateTime? mtrs_bittar38 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi39 { get; set; }

        public DateTime? mtrs_bastar39 { get; set; }

        public DateTime? mtrs_bittar39 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi40 { get; set; }

        public DateTime? mtrs_bastar40 { get; set; }

        public DateTime? mtrs_bittar40 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi41 { get; set; }

        public DateTime? mtrs_bastar41 { get; set; }

        public DateTime? mtrs_bittar41 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi42 { get; set; }

        public DateTime? mtrs_bastar42 { get; set; }

        public DateTime? mtrs_bittar42 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi43 { get; set; }

        public DateTime? mtrs_bastar43 { get; set; }

        public DateTime? mtrs_bittar43 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi44 { get; set; }

        public DateTime? mtrs_bastar44 { get; set; }

        public DateTime? mtrs_bittar44 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi45 { get; set; }

        public DateTime? mtrs_bastar45 { get; set; }

        public DateTime? mtrs_bittar45 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi46 { get; set; }

        public DateTime? mtrs_bastar46 { get; set; }

        public DateTime? mtrs_bittar46 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi47 { get; set; }

        public DateTime? mtrs_bastar47 { get; set; }

        public DateTime? mtrs_bittar47 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi48 { get; set; }

        public DateTime? mtrs_bastar48 { get; set; }

        public DateTime? mtrs_bittar48 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi49 { get; set; }

        public DateTime? mtrs_bastar49 { get; set; }

        public DateTime? mtrs_bittar49 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi50 { get; set; }

        public DateTime? mtrs_bastar50 { get; set; }

        public DateTime? mtrs_bittar50 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi51 { get; set; }

        public DateTime? mtrs_bastar51 { get; set; }

        public DateTime? mtrs_bittar51 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi52 { get; set; }

        public DateTime? mtrs_bastar52 { get; set; }

        public DateTime? mtrs_bittar52 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi53 { get; set; }

        public DateTime? mtrs_bastar53 { get; set; }

        public DateTime? mtrs_bittar53 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi54 { get; set; }

        public DateTime? mtrs_bastar54 { get; set; }

        public DateTime? mtrs_bittar54 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi55 { get; set; }

        public DateTime? mtrs_bastar55 { get; set; }

        public DateTime? mtrs_bittar55 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi56 { get; set; }

        public DateTime? mtrs_bastar56 { get; set; }

        public DateTime? mtrs_bittar56 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi57 { get; set; }

        public DateTime? mtrs_bastar57 { get; set; }

        public DateTime? mtrs_bittar57 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi58 { get; set; }

        public DateTime? mtrs_bastar58 { get; set; }

        public DateTime? mtrs_bittar58 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi59 { get; set; }

        public DateTime? mtrs_bastar59 { get; set; }

        public DateTime? mtrs_bittar59 { get; set; }

        [StringLength(25)]
        public string mtrs_donemadi60 { get; set; }

        public DateTime? mtrs_bastar60 { get; set; }

        public DateTime? mtrs_bittar60 { get; set; }
    }
}
