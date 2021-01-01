namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_WORKDATAFILE_O
    {
        [Key]
        [Column(Order = 0)]
        public Guid SessionID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int po_RECno { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short po_RECid_DBCno { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int po_RECid_RECno { get; set; }

        public int? po_SpecRECno { get; set; }

        public bool? po_iptal { get; set; }

        public short? po_fileid { get; set; }

        public bool? po_hidden { get; set; }

        public bool? po_kilitli { get; set; }

        public bool? po_degisti { get; set; }

        public int? po_checksum { get; set; }

        public short? po_create_user { get; set; }

        public DateTime? po_create_date { get; set; }

        public short? po_lastup_user { get; set; }

        public DateTime? po_lastup_date { get; set; }

        [StringLength(4)]
        public string po_special1 { get; set; }

        [StringLength(4)]
        public string po_special2 { get; set; }

        [StringLength(4)]
        public string po_special3 { get; set; }

        public int? po_firmano { get; set; }

        public int? po_subeno { get; set; }

        [StringLength(4)]
        public string po_KasaKodu { get; set; }

        public int? po_BelgeNo { get; set; }

        [StringLength(6)]
        public string po_KasiyerKodu { get; set; }

        public DateTime? po_BelgeTarihi { get; set; }

        public double? po_BelgeToplam { get; set; }

        public double? po_VerMtrh0 { get; set; }

        public double? po_VerMtrh1 { get; set; }

        public double? po_VerMtrh2 { get; set; }

        public double? po_VerMtrh3 { get; set; }

        public double? po_VerMtrh4 { get; set; }

        public double? po_VerMtrh5 { get; set; }

        public double? po_VerMtrh6 { get; set; }

        public double? po_VerMtrh7 { get; set; }

        public double? po_VerMtrh8 { get; set; }

        public double? po_VerMtrh9 { get; set; }

        public double? po_VerMtrh10 { get; set; }

        public double? po_Vergi1 { get; set; }

        public double? po_Vergi2 { get; set; }

        public double? po_Vergi3 { get; set; }

        public double? po_Vergi4 { get; set; }

        public double? po_Vergi5 { get; set; }

        public double? po_Vergi6 { get; set; }

        public double? po_Vergi7 { get; set; }

        public double? po_Vergi8 { get; set; }

        public double? po_Vergi9 { get; set; }

        public double? po_Vergi10 { get; set; }

        public byte? po_Fisfatura { get; set; }

        public byte? po_Pozisyon { get; set; }

        [StringLength(25)]
        public string po_CariKodu { get; set; }

        public double? po_Yuvarlama { get; set; }

        public double? po_Odm_AnaDtut1 { get; set; }

        public double? po_Odm_OrjDtut1 { get; set; }

        public double? po_Odm_AnaDtut2 { get; set; }

        public double? po_Odm_OrjDtut2 { get; set; }

        public double? po_Odm_AnaDtut3 { get; set; }

        public double? po_Odm_OrjDtut3 { get; set; }

        public double? po_Odm_AnaDtut4 { get; set; }

        public double? po_Odm_OrjDtut4 { get; set; }

        public double? po_Odm_AnaDtut5 { get; set; }

        public double? po_Odm_OrjDtut5 { get; set; }

        public double? po_Odm_AnaDtut6 { get; set; }

        public double? po_Odm_OrjDtut6 { get; set; }

        public double? po_Odm_AnaDtut7 { get; set; }

        public double? po_Odm_OrjDtut7 { get; set; }

        public double? po_Odm_AnaDtut8 { get; set; }

        public double? po_Odm_OrjDtut8 { get; set; }

        public double? po_Odm_AnaDtut9 { get; set; }

        public double? po_Odm_OrjDtut9 { get; set; }

        public double? po_Odm_AnaDtut10 { get; set; }

        public double? po_Odm_OrjDtut10 { get; set; }

        public double? po_Odm_AnaDtut11 { get; set; }

        public double? po_Odm_OrjDtut11 { get; set; }

        public double? po_Odm_AnaDtut12 { get; set; }

        public double? po_Odm_OrjDtut12 { get; set; }

        public double? po_Odm_AnaDtut13 { get; set; }

        public double? po_Odm_OrjDtut13 { get; set; }

        public double? po_Odm_AnaDtut14 { get; set; }

        public double? po_Odm_OrjDtut14 { get; set; }

        public double? po_Odm_AnaDtut15 { get; set; }

        public double? po_Odm_OrjDtut15 { get; set; }

        public double? po_Odm_AnaDtut16 { get; set; }

        public double? po_Odm_OrjDtut16 { get; set; }

        public double? po_Odm_AnaDtut17 { get; set; }

        public double? po_Odm_OrjDtut17 { get; set; }

        public double? po_Odm_AnaDtut18 { get; set; }

        public double? po_Odm_OrjDtut18 { get; set; }

        public double? po_Odm_AnaDtut19 { get; set; }

        public double? po_Odm_OrjDtut19 { get; set; }

        public double? po_Odm_AnaDtut20 { get; set; }

        public double? po_Odm_OrjDtut20 { get; set; }

        public double? po_Odm_AnaDtut21 { get; set; }

        public double? po_Odm_OrjDtut21 { get; set; }

        public double? po_Odm_AnaDtut22 { get; set; }

        public double? po_Odm_OrjDtut22 { get; set; }

        public double? po_Odm_AnaDtut23 { get; set; }

        public double? po_Odm_OrjDtut23 { get; set; }

        public double? po_Odm_AnaDtut24 { get; set; }

        public double? po_Odm_OrjDtut24 { get; set; }

        public double? po_Odm_AnaDtut25 { get; set; }

        public double? po_Odm_OrjDtut25 { get; set; }

        public double? po_Odm_AnaDtut26 { get; set; }

        public double? po_Odm_OrjDtut26 { get; set; }

        public double? po_Odm_AnaDtut27 { get; set; }

        public double? po_Odm_OrjDtut27 { get; set; }

        public double? po_Odm_AnaDtut28 { get; set; }

        public double? po_Odm_OrjDtut28 { get; set; }

        public double? po_Odm_AnaDtut29 { get; set; }

        public double? po_Odm_OrjDtut29 { get; set; }

        public double? po_Odm_AnaDtut30 { get; set; }

        public double? po_Odm_OrjDtut30 { get; set; }

        public double? po_Odm_AnaDtut31 { get; set; }

        public double? po_Odm_OrjDtut31 { get; set; }

        public double? po_Odm_AnaDtut32 { get; set; }

        public double? po_Odm_OrjDtut32 { get; set; }

        public double? po_Odm_AnaDtut33 { get; set; }

        public double? po_Odm_OrjDtut33 { get; set; }

        public double? po_Odm_AnaDtut34 { get; set; }

        public double? po_Odm_OrjDtut34 { get; set; }

        public double? po_Odm_AnaDtut35 { get; set; }

        public double? po_Odm_OrjDtut35 { get; set; }

        public double? po_Odm_AnaDtut36 { get; set; }

        public double? po_Odm_OrjDtut36 { get; set; }

        public double? po_Odm_AnaDtut37 { get; set; }

        public double? po_Odm_OrjDtut37 { get; set; }

        public double? po_Odm_AnaDtut38 { get; set; }

        public double? po_Odm_OrjDtut38 { get; set; }

        public double? po_Odm_AnaDtut39 { get; set; }

        public double? po_Odm_OrjDtut39 { get; set; }

        public double? po_Odm_AnaDtut40 { get; set; }

        public double? po_Odm_OrjDtut40 { get; set; }

        public double? po_Odm_AnaDtut41 { get; set; }

        public double? po_Odm_OrjDtut41 { get; set; }

        public double? po_Odm_AnaDtut42 { get; set; }

        public double? po_Odm_OrjDtut42 { get; set; }

        public double? po_Odm_AnaDtut43 { get; set; }

        public double? po_Odm_OrjDtut43 { get; set; }

        public double? po_Odm_AnaDtut44 { get; set; }

        public double? po_Odm_OrjDtut44 { get; set; }

        public double? po_Odm_AnaDtut45 { get; set; }

        public double? po_Odm_OrjDtut45 { get; set; }

        public double? po_Odm_AnaDtut46 { get; set; }

        public double? po_Odm_OrjDtut46 { get; set; }

        public double? po_Odm_AnaDtut47 { get; set; }

        public double? po_Odm_OrjDtut47 { get; set; }

        public double? po_Odm_AnaDtut48 { get; set; }

        public double? po_Odm_OrjDtut48 { get; set; }

        public double? po_Odm_AnaDtut49 { get; set; }

        public double? po_Odm_OrjDtut49 { get; set; }

        public double? po_Odm_AnaDtut50 { get; set; }

        public double? po_Odm_OrjDtut50 { get; set; }

        public byte? po_Vadeler_OdemeTipi1 { get; set; }

        public DateTime? po_Vadeler_vade1 { get; set; }

        public double? po_Vadeler_Tutar1 { get; set; }

        public byte? po_Vadeler_OdemeTipi2 { get; set; }

        public DateTime? po_Vadeler_vade2 { get; set; }

        public double? po_Vadeler_Tutar2 { get; set; }

        public byte? po_Vadeler_OdemeTipi3 { get; set; }

        public DateTime? po_Vadeler_vade3 { get; set; }

        public double? po_Vadeler_Tutar3 { get; set; }

        public byte? po_Vadeler_OdemeTipi4 { get; set; }

        public DateTime? po_Vadeler_vade4 { get; set; }

        public double? po_Vadeler_Tutar4 { get; set; }

        public byte? po_Vadeler_OdemeTipi5 { get; set; }

        public DateTime? po_Vadeler_vade5 { get; set; }

        public double? po_Vadeler_Tutar5 { get; set; }

        public byte? po_Vadeler_OdemeTipi6 { get; set; }

        public DateTime? po_Vadeler_vade6 { get; set; }

        public double? po_Vadeler_Tutar6 { get; set; }

        public byte? po_Vadeler_OdemeTipi7 { get; set; }

        public DateTime? po_Vadeler_vade7 { get; set; }

        public double? po_Vadeler_Tutar7 { get; set; }

        public byte? po_Vadeler_OdemeTipi8 { get; set; }

        public DateTime? po_Vadeler_vade8 { get; set; }

        public double? po_Vadeler_Tutar8 { get; set; }

        public byte? po_Vadeler_OdemeTipi9 { get; set; }

        public DateTime? po_Vadeler_vade9 { get; set; }

        public double? po_Vadeler_Tutar9 { get; set; }

        public byte? po_Vadeler_OdemeTipi10 { get; set; }

        public DateTime? po_Vadeler_vade10 { get; set; }

        public double? po_Vadeler_Tutar10 { get; set; }

        public byte? po_Vadeler_OdemeTipi11 { get; set; }

        public DateTime? po_Vadeler_vade11 { get; set; }

        public double? po_Vadeler_Tutar11 { get; set; }

        public byte? po_Vadeler_OdemeTipi12 { get; set; }

        public DateTime? po_Vadeler_vade12 { get; set; }

        public double? po_Vadeler_Tutar12 { get; set; }

        public byte? po_Vadeler_OdemeTipi13 { get; set; }

        public DateTime? po_Vadeler_vade13 { get; set; }

        public double? po_Vadeler_Tutar13 { get; set; }

        public byte? po_Vadeler_OdemeTipi14 { get; set; }

        public DateTime? po_Vadeler_vade14 { get; set; }

        public double? po_Vadeler_Tutar14 { get; set; }

        public byte? po_Vadeler_OdemeTipi15 { get; set; }

        public DateTime? po_Vadeler_vade15 { get; set; }

        public double? po_Vadeler_Tutar15 { get; set; }

        public byte? po_Vadeler_OdemeTipi16 { get; set; }

        public DateTime? po_Vadeler_vade16 { get; set; }

        public double? po_Vadeler_Tutar16 { get; set; }

        public byte? po_Vadeler_OdemeTipi17 { get; set; }

        public DateTime? po_Vadeler_vade17 { get; set; }

        public double? po_Vadeler_Tutar17 { get; set; }

        public byte? po_Vadeler_OdemeTipi18 { get; set; }

        public DateTime? po_Vadeler_vade18 { get; set; }

        public double? po_Vadeler_Tutar18 { get; set; }

        public byte? po_Vadeler_OdemeTipi19 { get; set; }

        public DateTime? po_Vadeler_vade19 { get; set; }

        public double? po_Vadeler_Tutar19 { get; set; }

        public byte? po_Vadeler_OdemeTipi20 { get; set; }

        public DateTime? po_Vadeler_vade20 { get; set; }

        public double? po_Vadeler_Tutar20 { get; set; }

        public byte? po_Vadeler_OdemeTipi21 { get; set; }

        public DateTime? po_Vadeler_vade21 { get; set; }

        public double? po_Vadeler_Tutar21 { get; set; }

        public byte? po_Vadeler_OdemeTipi22 { get; set; }

        public DateTime? po_Vadeler_vade22 { get; set; }

        public double? po_Vadeler_Tutar22 { get; set; }

        public byte? po_Vadeler_OdemeTipi23 { get; set; }

        public DateTime? po_Vadeler_vade23 { get; set; }

        public double? po_Vadeler_Tutar23 { get; set; }

        public byte? po_Vadeler_OdemeTipi24 { get; set; }

        public DateTime? po_Vadeler_vade24 { get; set; }

        public double? po_Vadeler_Tutar24 { get; set; }

        public byte? po_Vadeler_OdemeTipi25 { get; set; }

        public DateTime? po_Vadeler_vade25 { get; set; }

        public double? po_Vadeler_Tutar25 { get; set; }

        public byte? po_Vadeler_OdemeTipi26 { get; set; }

        public DateTime? po_Vadeler_vade26 { get; set; }

        public double? po_Vadeler_Tutar26 { get; set; }

        public byte? po_Vadeler_OdemeTipi27 { get; set; }

        public DateTime? po_Vadeler_vade27 { get; set; }

        public double? po_Vadeler_Tutar27 { get; set; }

        public byte? po_Vadeler_OdemeTipi28 { get; set; }

        public DateTime? po_Vadeler_vade28 { get; set; }

        public double? po_Vadeler_Tutar28 { get; set; }

        public byte? po_Vadeler_OdemeTipi29 { get; set; }

        public DateTime? po_Vadeler_vade29 { get; set; }

        public double? po_Vadeler_Tutar29 { get; set; }

        public byte? po_Vadeler_OdemeTipi30 { get; set; }

        public DateTime? po_Vadeler_vade30 { get; set; }

        public double? po_Vadeler_Tutar30 { get; set; }

        public byte? po_Vadeler_OdemeTipi31 { get; set; }

        public DateTime? po_Vadeler_vade31 { get; set; }

        public double? po_Vadeler_Tutar31 { get; set; }

        public byte? po_Vadeler_OdemeTipi32 { get; set; }

        public DateTime? po_Vadeler_vade32 { get; set; }

        public double? po_Vadeler_Tutar32 { get; set; }

        public byte? po_Vadeler_OdemeTipi33 { get; set; }

        public DateTime? po_Vadeler_vade33 { get; set; }

        public double? po_Vadeler_Tutar33 { get; set; }

        public byte? po_Vadeler_OdemeTipi34 { get; set; }

        public DateTime? po_Vadeler_vade34 { get; set; }

        public double? po_Vadeler_Tutar34 { get; set; }

        public byte? po_Vadeler_OdemeTipi35 { get; set; }

        public DateTime? po_Vadeler_vade35 { get; set; }

        public double? po_Vadeler_Tutar35 { get; set; }

        public byte? po_Vadeler_OdemeTipi36 { get; set; }

        public DateTime? po_Vadeler_vade36 { get; set; }

        public double? po_Vadeler_Tutar36 { get; set; }

        public bool? po_Tks_Satis { get; set; }

        public double? po_Tks_Satis_Tutar { get; set; }

        public byte? po_Odm_TaksitTipi1 { get; set; }

        public byte? po_Odm_TaksitTipi2 { get; set; }

        public byte? po_Odm_TaksitTipi3 { get; set; }

        public byte? po_Odm_TaksitTipi4 { get; set; }

        public byte? po_Odm_TaksitTipi5 { get; set; }

        public byte? po_Odm_TaksitTipi6 { get; set; }

        public byte? po_Odm_TaksitTipi7 { get; set; }

        public byte? po_Odm_TaksitTipi8 { get; set; }

        public byte? po_Odm_TaksitTipi9 { get; set; }

        public byte? po_Odm_TaksitTipi10 { get; set; }

        public byte? po_Odm_TaksitTipi11 { get; set; }

        public byte? po_Odm_TaksitTipi12 { get; set; }

        public byte? po_Odm_TaksitTipi13 { get; set; }

        public byte? po_Odm_TaksitTipi14 { get; set; }

        public byte? po_Odm_TaksitTipi15 { get; set; }

        public byte? po_Odm_TaksitTipi16 { get; set; }

        public byte? po_Odm_TaksitTipi17 { get; set; }

        public byte? po_Odm_TaksitTipi18 { get; set; }

        public byte? po_Odm_TaksitTipi19 { get; set; }

        public byte? po_Odm_TaksitTipi20 { get; set; }

        public byte? po_Odm_TaksitTipi21 { get; set; }

        public byte? po_Odm_TaksitTipi22 { get; set; }

        public byte? po_Odm_TaksitTipi23 { get; set; }

        public byte? po_Odm_TaksitTipi24 { get; set; }

        public byte? po_Odm_TaksitTipi25 { get; set; }

        public byte? po_Odm_TaksitTipi26 { get; set; }

        public byte? po_Odm_TaksitTipi27 { get; set; }

        public byte? po_Odm_TaksitTipi28 { get; set; }

        public byte? po_Odm_TaksitTipi29 { get; set; }

        public byte? po_Odm_TaksitTipi30 { get; set; }

        public byte? po_Odm_TaksitTipi31 { get; set; }

        public byte? po_Odm_TaksitTipi32 { get; set; }

        public byte? po_Odm_TaksitTipi33 { get; set; }

        public byte? po_Odm_TaksitTipi34 { get; set; }

        public byte? po_Odm_TaksitTipi35 { get; set; }

        public byte? po_Odm_TaksitTipi36 { get; set; }

        public byte? po_Odm_TaksitTipi37 { get; set; }

        public byte? po_Odm_TaksitTipi38 { get; set; }

        public byte? po_Odm_TaksitTipi39 { get; set; }

        public byte? po_Odm_TaksitTipi40 { get; set; }

        public byte? po_Odm_TaksitTipi41 { get; set; }

        public byte? po_Odm_TaksitTipi42 { get; set; }

        public byte? po_Odm_TaksitTipi43 { get; set; }

        public byte? po_Odm_TaksitTipi44 { get; set; }

        public byte? po_Odm_TaksitTipi45 { get; set; }

        public byte? po_Odm_TaksitTipi46 { get; set; }

        public byte? po_Odm_TaksitTipi47 { get; set; }

        public byte? po_Odm_TaksitTipi48 { get; set; }

        public byte? po_Odm_TaksitTipi49 { get; set; }

        public byte? po_Odm_TaksitTipi50 { get; set; }

        public byte? po_OdemeNo1 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu1 { get; set; }

        public double? po_ProvizyonTutari1 { get; set; }

        public byte? po_OdemeNo2 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu2 { get; set; }

        public double? po_ProvizyonTutari2 { get; set; }

        public byte? po_OdemeNo3 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu3 { get; set; }

        public double? po_ProvizyonTutari3 { get; set; }

        public byte? po_OdemeNo4 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu4 { get; set; }

        public double? po_ProvizyonTutari4 { get; set; }

        public byte? po_OdemeNo5 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu5 { get; set; }

        public double? po_ProvizyonTutari5 { get; set; }

        public byte? po_OdemeNo6 { get; set; }

        [StringLength(10)]
        public string po_ProvizyonKodu6 { get; set; }

        public double? po_ProvizyonTutari6 { get; set; }

        [StringLength(6)]
        public string po_Tahsilat_evrakno_seri { get; set; }

        public int? po_Tahsilat_evrakno_sira { get; set; }

        public double? po_Tahsilat_Tutari { get; set; }

        public byte? po_ParaUstuOdemeTipi { get; set; }

        public double? po_ParaUstuAnaDtut { get; set; }

        public double? po_ParaUstuOrjDtut { get; set; }
    }
}
