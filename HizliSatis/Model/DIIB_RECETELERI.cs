namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DIIB_RECETELERI
    {
        [Key]
        public int DiibRe_RECNo { get; set; }

        public short DiibRe_RECid_DBCno { get; set; }

        public int DiibRe_RECid_RECno { get; set; }

        public int? DiibRe_SpecRECno { get; set; }

        public bool? DiibRe_iptal { get; set; }

        public short? DiibRe_fileid { get; set; }

        public bool? DiibRe_hidden { get; set; }

        public bool? DiibRe_kilitli { get; set; }

        public bool? DiibRe_degisti { get; set; }

        public int? DiibRe_checksum { get; set; }

        public short? DiibRe_create_user { get; set; }

        public DateTime? DiibRe_create_date { get; set; }

        public short? DiibRe_lastup_user { get; set; }

        public DateTime? DiibRe_lastup_date { get; set; }

        [StringLength(4)]
        public string DiibRe_special1 { get; set; }

        [StringLength(4)]
        public string DiibRe_special2 { get; set; }

        [StringLength(4)]
        public string DiibRe_special3 { get; set; }

        [StringLength(25)]
        public string DiibRe_diibnosu { get; set; }

        [StringLength(25)]
        public string DiibRe_Satirno { get; set; }

        public short? DiibRe_Sira { get; set; }

        public double? DiibRe_Anamiktar { get; set; }

        public double? DiibRe_ithstok1kulmiktar { get; set; }

        public double? DiibRe_ithstok1kulmiktar2 { get; set; }

        public double? DiibRe_ithstok1fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok1aciklama { get; set; }

        public double? DiibRe_ithstok2kulmiktar { get; set; }

        public double? DiibRe_ithstok2kulmiktar2 { get; set; }

        public double? DiibRe_ithstok2fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok2aciklama { get; set; }

        public double? DiibRe_ithstok3kulmiktar { get; set; }

        public double? DiibRe_ithstok3kulmiktar2 { get; set; }

        public double? DiibRe_ithstok3fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok3aciklama { get; set; }

        public double? DiibRe_ithstok4kulmiktar { get; set; }

        public double? DiibRe_ithstok4kulmiktar2 { get; set; }

        public double? DiibRe_ithstok4fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok4aciklama { get; set; }

        public double? DiibRe_ithstok5kulmiktar { get; set; }

        public double? DiibRe_ithstok5kulmiktar2 { get; set; }

        public double? DiibRe_ithstok5fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok5aciklama { get; set; }

        public double? DiibRe_ithstok6kulmiktar { get; set; }

        public double? DiibRe_ithstok6kulmiktar2 { get; set; }

        public double? DiibRe_ithstok6fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok6aciklama { get; set; }

        public double? DiibRe_ithstok7kulmiktar { get; set; }

        public double? DiibRe_ithstok7kulmiktar2 { get; set; }

        public double? DiibRe_ithstok7fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok7aciklama { get; set; }

        public double? DiibRe_ithstok8kulmiktar { get; set; }

        public double? DiibRe_ithstok8kulmiktar2 { get; set; }

        public double? DiibRe_ithstok8fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok8aciklama { get; set; }

        public double? DiibRe_ithstok9kulmiktar { get; set; }

        public double? DiibRe_ithstok9kulmiktar2 { get; set; }

        public double? DiibRe_ithstok9fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok9aciklama { get; set; }

        public double? DiibRe_ithstok10kulmiktar { get; set; }

        public double? DiibRe_ithstok10kulmiktar2 { get; set; }

        public double? DiibRe_ithstok10fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok10aciklama { get; set; }

        public double? DiibRe_ithstok11kulmiktar { get; set; }

        public double? DiibRe_ithstok11kulmiktar2 { get; set; }

        public double? DiibRe_ithstok11fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok11aciklama { get; set; }

        public double? DiibRe_ithstok12kulmiktar { get; set; }

        public double? DiibRe_ithstok12kulmiktar2 { get; set; }

        public double? DiibRe_ithstok12fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok12aciklama { get; set; }

        public double? DiibRe_ithstok13kulmiktar { get; set; }

        public double? DiibRe_ithstok13kulmiktar2 { get; set; }

        public double? DiibRe_ithstok13fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok13aciklama { get; set; }

        public double? DiibRe_ithstok14kulmiktar { get; set; }

        public double? DiibRe_ithstok14kulmiktar2 { get; set; }

        public double? DiibRe_ithstok14fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok14aciklama { get; set; }

        public double? DiibRe_ithstok15kulmiktar { get; set; }

        public double? DiibRe_ithstok15kulmiktar2 { get; set; }

        public double? DiibRe_ithstok15fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok15aciklama { get; set; }

        public double? DiibRe_ithstok16kulmiktar { get; set; }

        public double? DiibRe_ithstok16kulmiktar2 { get; set; }

        public double? DiibRe_ithstok16fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok16aciklama { get; set; }

        public double? DiibRe_ithstok17kulmiktar { get; set; }

        public double? DiibRe_ithstok17kulmiktar2 { get; set; }

        public double? DiibRe_ithstok17fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok17aciklama { get; set; }

        public double? DiibRe_ithstok18kulmiktar { get; set; }

        public double? DiibRe_ithstok18kulmiktar2 { get; set; }

        public double? DiibRe_ithstok18fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok18aciklama { get; set; }

        public double? DiibRe_ithstok19kulmiktar { get; set; }

        public double? DiibRe_ithstok19kulmiktar2 { get; set; }

        public double? DiibRe_ithstok19fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok19aciklama { get; set; }

        public double? DiibRe_ithstok20kulmiktar { get; set; }

        public double? DiibRe_ithstok20kulmiktar2 { get; set; }

        public double? DiibRe_ithstok20fireyuzdesi { get; set; }

        [StringLength(50)]
        public string DiibRe_ithstok20aciklama { get; set; }
    }
}
