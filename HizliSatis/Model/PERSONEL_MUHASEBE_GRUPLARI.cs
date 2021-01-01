namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_MUHASEBE_GRUPLARI
    {
        [Key]
        public int pmg_RECno { get; set; }

        public short pmg_RECid_DBCno { get; set; }

        public int pmg_RECid_RECno { get; set; }

        public int? pmg_SpecRECno { get; set; }

        public bool? pmg_iptal { get; set; }

        public short? pmg_fileid { get; set; }

        public bool? pmg_hidden { get; set; }

        public bool? pmg_kilitli { get; set; }

        public bool? pmg_degisti { get; set; }

        public int? pmg_checksum { get; set; }

        public short? pmg_create_user { get; set; }

        public DateTime? pmg_create_date { get; set; }

        public short? pmg_lastup_user { get; set; }

        public DateTime? pmg_lastup_date { get; set; }

        [StringLength(4)]
        public string pmg_special1 { get; set; }

        [StringLength(4)]
        public string pmg_special2 { get; set; }

        [StringLength(4)]
        public string pmg_special3 { get; set; }

        [StringLength(25)]
        public string pmg_kodu { get; set; }

        [StringLength(40)]
        public string pmg_adi { get; set; }

        [StringLength(25)]
        public string pmg_alcnetkod { get; set; }

        [StringLength(25)]
        public string pmg_alcgvkodu { get; set; }

        [StringLength(25)]
        public string pmg_alcdvkodu { get; set; }

        [StringLength(25)]
        public string pmg_alcsskpaykod { get; set; }

        [StringLength(25)]
        public string pmg_alcztasperkod { get; set; }

        [StringLength(25)]
        public string pmg_alcsskemkod { get; set; }

        [StringLength(25)]
        public string pmg_alcsskisvhkod { get; set; }

        [StringLength(25)]
        public string pmg_alcztasisvkod { get; set; }

        [StringLength(25)]
        public string pmg_alcemkisvhkod { get; set; }

        [StringLength(25)]
        public string pmg_alcyuvfarkkod { get; set; }

        [StringLength(25)]
        public string pmg_alcissigisvpkod { get; set; }

        [StringLength(25)]
        public string pmg_alcissigperpkod { get; set; }

        [StringLength(25)]
        public string pmg_alnetetkilemeyenagikod { get; set; }

        [StringLength(25)]
        public string pmg_alfaydalanilanagikod { get; set; }

        [StringLength(25)]
        public string pmg_alfaydalanilan5746kod { get; set; }

        [StringLength(25)]
        public string pmg_alfaydalanilan5225kod { get; set; }

        [StringLength(25)]
        public string pmg_alisvhisgelirikod { get; set; }

        [StringLength(25)]
        public string pmg_alisotobeskod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz1kod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz2kod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz3kod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz4kod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz5kod { get; set; }

        [StringLength(25)]
        public string pmg_brcnorkaz6kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz1kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz2kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz3kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz4kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz5kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz6kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz7kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz8kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz9kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz10kod { get; set; }

        [StringLength(25)]
        public string pmg_brcekkaz11kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd1kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd2kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd3kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd4kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd5kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd6kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd7kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd8kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd9kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd10kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd11kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd12kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd13kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd14kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd15kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd16kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd17kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd18kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd19kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd20kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd21kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd22kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd23kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd24kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd25kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd26kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd27kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd28kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd29kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd30kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd31kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsosyrd32kod { get; set; }

        [StringLength(25)]
        public string pmg_brcsskisvgdkod { get; set; }

        [StringLength(25)]
        public string pmg_brcztasisvgdkod { get; set; }

        [StringLength(25)]
        public string pmg_brcemkisvgdkod { get; set; }

        [StringLength(25)]
        public string pmg_brcvakkesgdkod { get; set; }

        [StringLength(25)]
        public string pmg_brcyuvfarkkod { get; set; }

        [StringLength(25)]
        public string pmg_brcissigisvgkod { get; set; }

        [StringLength(25)]
        public string pmg_brcneteeklenen5746kod { get; set; }

        [StringLength(25)]
        public string pmg_brcneteeklenen5225kod { get; set; }

        public byte? pmg_alcnetcns { get; set; }

        public byte? pmg_alcgvcns { get; set; }

        public byte? pmg_alcdvcns { get; set; }

        public byte? pmg_alcztaspercns { get; set; }

        public byte? pmg_alcztascns { get; set; }

        public byte? pmg_alcsskemcns { get; set; }

        public byte? pmg_alcsskisvhcns { get; set; }

        public byte? pmg_alcztasisvcns { get; set; }

        public byte? pmg_alcemkisvhcns { get; set; }

        public byte? pmg_alcyuvfarkcns { get; set; }

        public byte? pmg_alcissigisvpcns { get; set; }

        public byte? pmg_alcissigperpcns { get; set; }

        public byte? pmg_alnetetkilemeyenagicns { get; set; }

        public byte? pmg_alfaydalanilanagicns { get; set; }

        public byte? pmg_alfaydalanilan5746cns { get; set; }

        public byte? pmg_alfaydalanilan5225cns { get; set; }

        public byte? pmg_alisvhisgeliricns { get; set; }

        public byte? pmg_alisotobescns { get; set; }

        public byte? pmg_brcnorkaz1cns { get; set; }

        public byte? pmg_brcnorkaz2cns { get; set; }

        public byte? pmg_brcnorkaz3cns { get; set; }

        public byte? pmg_brcnorkaz4cns { get; set; }

        public byte? pmg_brcnorkaz5cns { get; set; }

        public byte? pmg_brcnorkaz6cns { get; set; }

        public byte? pmg_brcekkaz1cns { get; set; }

        public byte? pmg_brcekkaz2cns { get; set; }

        public byte? pmg_brcekkaz3cns { get; set; }

        public byte? pmg_brcekkaz4cns { get; set; }

        public byte? pmg_brcekkaz5cns { get; set; }

        public byte? pmg_brcekkaz6cns { get; set; }

        public byte? pmg_brcekkaz7cns { get; set; }

        public byte? pmg_brcekkaz8cns { get; set; }

        public byte? pmg_brcekkaz9cns { get; set; }

        public byte? pmg_brcekkaz10cns { get; set; }

        public byte? pmg_brcekkaz11cns { get; set; }

        public byte? pmg_brcsosyrd1cns { get; set; }

        public byte? pmg_brcsosyrd2cns { get; set; }

        public byte? pmg_brcsosyrd3cns { get; set; }

        public byte? pmg_brcsosyrd4cns { get; set; }

        public byte? pmg_brcsosyrd5cns { get; set; }

        public byte? pmg_brcsosyrd6cns { get; set; }

        public byte? pmg_brcsosyrd7cns { get; set; }

        public byte? pmg_brcsosyrd8cns { get; set; }

        public byte? pmg_brcsosyrd9cns { get; set; }

        public byte? pmg_brcsosyrd10cns { get; set; }

        public byte? pmg_brcsosyrd11cns { get; set; }

        public byte? pmg_brcsosyrd12cns { get; set; }

        public byte? pmg_brcsosyrd13cns { get; set; }

        public byte? pmg_brcsosyrd14cns { get; set; }

        public byte? pmg_brcsosyrd15cns { get; set; }

        public byte? pmg_brcsosyrd16cns { get; set; }

        public byte? pmg_brcsosyrd17cns { get; set; }

        public byte? pmg_brcsosyrd18cns { get; set; }

        public byte? pmg_brcsosyrd19cns { get; set; }

        public byte? pmg_brcsosyrd20cns { get; set; }

        public byte? pmg_brcsosyrd21cns { get; set; }

        public byte? pmg_brcsosyrd22cns { get; set; }

        public byte? pmg_brcsosyrd23cns { get; set; }

        public byte? pmg_brcsosyrd24cns { get; set; }

        public byte? pmg_brcsosyrd25cns { get; set; }

        public byte? pmg_brcsosyrd26cns { get; set; }

        public byte? pmg_brcsosyrd27cns { get; set; }

        public byte? pmg_brcsosyrd28cns { get; set; }

        public byte? pmg_brcsosyrd29cns { get; set; }

        public byte? pmg_brcsosyrd30cns { get; set; }

        public byte? pmg_brcsosyrd31cns { get; set; }

        public byte? pmg_brcsosyrd32cns { get; set; }

        public byte? pmg_brcsskisvgdcns { get; set; }

        public byte? pmg_brcztasisvgdcns { get; set; }

        public byte? pmg_brcemkisvgdcns { get; set; }

        public byte? pmg_brcvakkesgdcns { get; set; }

        public byte? pmg_brcyuvfarkcns { get; set; }

        public byte? pmg_brcissigisvgcns { get; set; }

        public byte? pmg_brcneteeklenen5746cns { get; set; }

        public byte? pmg_brcneteeklenen5225cns { get; set; }

        public byte? pmg_alcnetcns_grupno { get; set; }

        public byte? pmg_alcgvcns_grupno { get; set; }

        public byte? pmg_alcdvcns_grupno { get; set; }

        public byte? pmg_alcztaspercns_grupno { get; set; }

        public byte? pmg_alcztascns_grupno { get; set; }

        public byte? pmg_alcsskemcns_grupno { get; set; }

        public byte? pmg_alcsskisvhcns_grupno { get; set; }

        public byte? pmg_alcztasisvcns_grupno { get; set; }

        public byte? pmg_alcemkisvhcns_grupno { get; set; }

        public byte? pmg_alcyuvfarkcns_grupno { get; set; }

        public byte? pmg_alcissigisvpcns_grupno { get; set; }

        public byte? pmg_alcissigperpcns_grupno { get; set; }

        public byte? pmg_alnetetkilemeyenagi_grupno { get; set; }

        public byte? pmg_alfaydalanilanagi_grupno { get; set; }

        public byte? pmg_alfaydalanilan5746_grupno { get; set; }

        public byte? pmg_alfaydalanilan5225_grupno { get; set; }

        public byte? pmg_alisvhisgeliri_grupno { get; set; }

        public byte? pmg_otobes_grupno { get; set; }

        public byte? pmg_brcnorkaz1cns_grupno { get; set; }

        public byte? pmg_brcnorkaz2cns_grupno { get; set; }

        public byte? pmg_brcnorkaz3cns_grupno { get; set; }

        public byte? pmg_brcnorkaz4cns_grupno { get; set; }

        public byte? pmg_brcnorkaz5cns_grupno { get; set; }

        public byte? pmg_brcnorkaz6cns_grupno { get; set; }

        public byte? pmg_brcekkaz1cns_grupno { get; set; }

        public byte? pmg_brcekkaz2cns_grupno { get; set; }

        public byte? pmg_brcekkaz3cns_grupno { get; set; }

        public byte? pmg_brcekkaz4cns_grupno { get; set; }

        public byte? pmg_brcekkaz5cns_grupno { get; set; }

        public byte? pmg_brcekkaz6cns_grupno { get; set; }

        public byte? pmg_brcekkaz7cns_grupno { get; set; }

        public byte? pmg_brcekkaz8cns_grupno { get; set; }

        public byte? pmg_brcekkaz9cns_grupno { get; set; }

        public byte? pmg_brcekkaz10cns_grupno { get; set; }

        public byte? pmg_brcekkaz11cns_grupno { get; set; }

        public byte? pmg_brcsosyrd1cns_grupno { get; set; }

        public byte? pmg_brcsosyrd2cns_grupno { get; set; }

        public byte? pmg_brcsosyrd3cns_grupno { get; set; }

        public byte? pmg_brcsosyrd4cns_grupno { get; set; }

        public byte? pmg_brcsosyrd5cns_grupno { get; set; }

        public byte? pmg_brcsosyrd6cns_grupno { get; set; }

        public byte? pmg_brcsosyrd7cns_grupno { get; set; }

        public byte? pmg_brcsosyrd8cns_grupno { get; set; }

        public byte? pmg_brcsosyrd9cns_grupno { get; set; }

        public byte? pmg_brcsosyrd10cns_grupno { get; set; }

        public byte? pmg_brcsosyrd11cns_grupno { get; set; }

        public byte? pmg_brcsosyrd12cns_grupno { get; set; }

        public byte? pmg_brcsosyrd13cns_grupno { get; set; }

        public byte? pmg_brcsosyrd14cns_grupno { get; set; }

        public byte? pmg_brcsosyrd15cns_grupno { get; set; }

        public byte? pmg_brcsosyrd16cns_grupno { get; set; }

        public byte? pmg_brcsosyrd17cns_grupno { get; set; }

        public byte? pmg_brcsosyrd18cns_grupno { get; set; }

        public byte? pmg_brcsosyrd19cns_grupno { get; set; }

        public byte? pmg_brcsosyrd20cns_grupno { get; set; }

        public byte? pmg_brcsosyrd21cns_grupno { get; set; }

        public byte? pmg_brcsosyrd22cns_grupno { get; set; }

        public byte? pmg_brcsosyrd23cns_grupno { get; set; }

        public byte? pmg_brcsosyrd24cns_grupno { get; set; }

        public byte? pmg_brcsosyrd25cns_grupno { get; set; }

        public byte? pmg_brcsosyrd26cns_grupno { get; set; }

        public byte? pmg_brcsosyrd27cns_grupno { get; set; }

        public byte? pmg_brcsosyrd28cns_grupno { get; set; }

        public byte? pmg_brcsosyrd29cns_grupno { get; set; }

        public byte? pmg_brcsosyrd30cns_grupno { get; set; }

        public byte? pmg_brcsosyrd31cns_grupno { get; set; }

        public byte? pmg_brcsosyrd32cns_grupno { get; set; }

        public byte? pmg_brcsskisvgdcns_grupno { get; set; }

        public byte? pmg_brcztasisvgdcns_grupno { get; set; }

        public byte? pmg_brcemkisvgdcns_grupno { get; set; }

        public byte? pmg_brcvakkesgdcns_grupno { get; set; }

        public byte? pmg_brcyuvfarkcns_grupno { get; set; }

        public byte? pmg_brcissigisvgcns_grupno { get; set; }

        public byte? pmg_brcneteeklenen5746_grupno { get; set; }

        public byte? pmg_brcneteeklenen5225_grupno { get; set; }

        public bool? pmg_ticari { get; set; }

        public byte? pmg_ozelalacakcaricins1 { get; set; }

        public byte? pmg_ozelalacakcaricins2 { get; set; }

        public byte? pmg_ozelalacakcaricins3 { get; set; }

        public byte? pmg_ozelalacakcaricins4 { get; set; }

        public byte? pmg_ozelalacakcaricins5 { get; set; }

        public byte? pmg_ozelalacakcaricins6 { get; set; }

        public byte? pmg_ozelalacakcaricins7 { get; set; }

        public byte? pmg_ozelalacakcaricins8 { get; set; }

        public byte? pmg_ozelalacakcaricins9 { get; set; }

        public byte? pmg_ozelalacakcaricins10 { get; set; }

        public byte? pmg_ozelalacakcaricins11 { get; set; }

        public byte? pmg_ozelalacakcaricins12 { get; set; }

        public byte? pmg_ozelalacakcaricins13 { get; set; }

        public byte? pmg_ozelalacakcaricins14 { get; set; }

        public byte? pmg_ozelalacakcaricins15 { get; set; }

        public byte? pmg_ozelalacakcaricins16 { get; set; }

        public byte? pmg_ozelalacakcaricins17 { get; set; }

        public byte? pmg_ozelalacakcaricins18 { get; set; }

        public byte? pmg_ozelalacakcaricins19 { get; set; }

        public byte? pmg_ozelalacakcaricins20 { get; set; }

        public byte? pmg_ozelalacakcaricins21 { get; set; }

        public byte? pmg_ozelalacakcaricins22 { get; set; }

        public byte? pmg_ozelalacakcaricins23 { get; set; }

        public byte? pmg_ozelalacakcaricins24 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod1 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod2 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod3 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod4 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod5 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod6 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod7 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod8 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod9 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod10 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod11 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod12 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod13 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod14 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod15 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod16 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod17 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod18 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod19 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod20 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod21 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod22 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod23 { get; set; }

        [StringLength(40)]
        public string pmg_ozelalacakkod24 { get; set; }

        public byte? pmg_ozelalacakcarigrup1 { get; set; }

        public byte? pmg_ozelalacakcarigrup2 { get; set; }

        public byte? pmg_ozelalacakcarigrup3 { get; set; }

        public byte? pmg_ozelalacakcarigrup4 { get; set; }

        public byte? pmg_ozelalacakcarigrup5 { get; set; }

        public byte? pmg_ozelalacakcarigrup6 { get; set; }

        public byte? pmg_ozelalacakcarigrup7 { get; set; }

        public byte? pmg_ozelalacakcarigrup8 { get; set; }

        public byte? pmg_ozelalacakcarigrup9 { get; set; }

        public byte? pmg_ozelalacakcarigrup10 { get; set; }

        public byte? pmg_ozelalacakcarigrup11 { get; set; }

        public byte? pmg_ozelalacakcarigrup12 { get; set; }

        public byte? pmg_ozelalacakcarigrup13 { get; set; }

        public byte? pmg_ozelalacakcarigrup14 { get; set; }

        public byte? pmg_ozelalacakcarigrup15 { get; set; }

        public byte? pmg_ozelalacakcarigrup16 { get; set; }

        public byte? pmg_ozelalacakcarigrup17 { get; set; }

        public byte? pmg_ozelalacakcarigrup18 { get; set; }

        public byte? pmg_ozelalacakcarigrup19 { get; set; }

        public byte? pmg_ozelalacakcarigrup20 { get; set; }

        public byte? pmg_ozelalacakcarigrup21 { get; set; }

        public byte? pmg_ozelalacakcarigrup22 { get; set; }

        public byte? pmg_ozelalacakcarigrup23 { get; set; }

        public byte? pmg_ozelalacakcarigrup24 { get; set; }
    }
}
