namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class POS_SOZLESME_TANIMLARI
    {
        [Key]
        public int psz_RECno { get; set; }

        public short psz_RECid_DBCno { get; set; }

        public int psz_RECid_RECno { get; set; }

        public int? psz_SpecRECNo { get; set; }

        public bool? psz_iptal { get; set; }

        public short? psz_fileid { get; set; }

        public bool? psz_hidden { get; set; }

        public bool? psz_kilitli { get; set; }

        public bool? psz_degisti { get; set; }

        public int? psz_CheckSum { get; set; }

        public short? psz_create_user { get; set; }

        public DateTime? psz_create_date { get; set; }

        public short? psz_lastup_user { get; set; }

        public DateTime? psz_lastup_date { get; set; }

        [StringLength(4)]
        public string psz_special1 { get; set; }

        [StringLength(4)]
        public string psz_special2 { get; set; }

        [StringLength(4)]
        public string psz_special3 { get; set; }

        [StringLength(25)]
        public string psz_uye_isyeri_no { get; set; }

        [StringLength(50)]
        public string psz_uye_isyeri_adi { get; set; }

        [StringLength(25)]
        public string psz_banka_kodu { get; set; }

        [StringLength(25)]
        public string psz_sor_merk_kodu { get; set; }

        [StringLength(25)]
        public string psz_proje_kodu { get; set; }

        public byte? psz_kart_sahip_tipi1 { get; set; }

        public short? psz_taksit_sayisi1 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi1 { get; set; }

        public short? psz_valor_gunu1 { get; set; }

        public double? psz_komisyon_orani1 { get; set; }

        public double? psz_odul_katkisi_orani1 { get; set; }

        public double? psz_erken_odeme_faiz_orani1 { get; set; }

        public double? psz_diger_komisyon_orani1 { get; set; }

        public byte? psz_kart_sahip_tipi2 { get; set; }

        public short? psz_taksit_sayisi2 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi2 { get; set; }

        public short? psz_valor_gunu2 { get; set; }

        public double? psz_komisyon_orani2 { get; set; }

        public double? psz_odul_katkisi_orani2 { get; set; }

        public double? psz_erken_odeme_faiz_orani2 { get; set; }

        public double? psz_diger_komisyon_orani2 { get; set; }

        public byte? psz_kart_sahip_tipi3 { get; set; }

        public short? psz_taksit_sayisi3 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi3 { get; set; }

        public short? psz_valor_gunu3 { get; set; }

        public double? psz_komisyon_orani3 { get; set; }

        public double? psz_odul_katkisi_orani3 { get; set; }

        public double? psz_erken_odeme_faiz_orani3 { get; set; }

        public double? psz_diger_komisyon_orani3 { get; set; }

        public byte? psz_kart_sahip_tipi4 { get; set; }

        public short? psz_taksit_sayisi4 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi4 { get; set; }

        public short? psz_valor_gunu4 { get; set; }

        public double? psz_komisyon_orani4 { get; set; }

        public double? psz_odul_katkisi_orani4 { get; set; }

        public double? psz_erken_odeme_faiz_orani4 { get; set; }

        public double? psz_diger_komisyon_orani4 { get; set; }

        public byte? psz_kart_sahip_tipi5 { get; set; }

        public short? psz_taksit_sayisi5 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi5 { get; set; }

        public short? psz_valor_gunu5 { get; set; }

        public double? psz_komisyon_orani5 { get; set; }

        public double? psz_odul_katkisi_orani5 { get; set; }

        public double? psz_erken_odeme_faiz_orani5 { get; set; }

        public double? psz_diger_komisyon_orani5 { get; set; }

        public byte? psz_kart_sahip_tipi6 { get; set; }

        public short? psz_taksit_sayisi6 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi6 { get; set; }

        public short? psz_valor_gunu6 { get; set; }

        public double? psz_komisyon_orani6 { get; set; }

        public double? psz_odul_katkisi_orani6 { get; set; }

        public double? psz_erken_odeme_faiz_orani6 { get; set; }

        public double? psz_diger_komisyon_orani6 { get; set; }

        public byte? psz_kart_sahip_tipi7 { get; set; }

        public short? psz_taksit_sayisi7 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi7 { get; set; }

        public short? psz_valor_gunu7 { get; set; }

        public double? psz_komisyon_orani7 { get; set; }

        public double? psz_odul_katkisi_orani7 { get; set; }

        public double? psz_erken_odeme_faiz_orani7 { get; set; }

        public double? psz_diger_komisyon_orani7 { get; set; }

        public byte? psz_kart_sahip_tipi8 { get; set; }

        public short? psz_taksit_sayisi8 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi8 { get; set; }

        public short? psz_valor_gunu8 { get; set; }

        public double? psz_komisyon_orani8 { get; set; }

        public double? psz_odul_katkisi_orani8 { get; set; }

        public double? psz_erken_odeme_faiz_orani8 { get; set; }

        public double? psz_diger_komisyon_orani8 { get; set; }

        public byte? psz_kart_sahip_tipi9 { get; set; }

        public short? psz_taksit_sayisi9 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi9 { get; set; }

        public short? psz_valor_gunu9 { get; set; }

        public double? psz_komisyon_orani9 { get; set; }

        public double? psz_odul_katkisi_orani9 { get; set; }

        public double? psz_erken_odeme_faiz_orani9 { get; set; }

        public double? psz_diger_komisyon_orani9 { get; set; }

        public byte? psz_kart_sahip_tipi10 { get; set; }

        public short? psz_taksit_sayisi10 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi10 { get; set; }

        public short? psz_valor_gunu10 { get; set; }

        public double? psz_komisyon_orani10 { get; set; }

        public double? psz_odul_katkisi_orani10 { get; set; }

        public double? psz_erken_odeme_faiz_orani10 { get; set; }

        public double? psz_diger_komisyon_orani10 { get; set; }

        public byte? psz_kart_sahip_tipi11 { get; set; }

        public short? psz_taksit_sayisi11 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi11 { get; set; }

        public short? psz_valor_gunu11 { get; set; }

        public double? psz_komisyon_orani11 { get; set; }

        public double? psz_odul_katkisi_orani11 { get; set; }

        public double? psz_erken_odeme_faiz_orani11 { get; set; }

        public double? psz_diger_komisyon_orani11 { get; set; }

        public byte? psz_kart_sahip_tipi12 { get; set; }

        public short? psz_taksit_sayisi12 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi12 { get; set; }

        public short? psz_valor_gunu12 { get; set; }

        public double? psz_komisyon_orani12 { get; set; }

        public double? psz_odul_katkisi_orani12 { get; set; }

        public double? psz_erken_odeme_faiz_orani12 { get; set; }

        public double? psz_diger_komisyon_orani12 { get; set; }

        public byte? psz_kart_sahip_tipi13 { get; set; }

        public short? psz_taksit_sayisi13 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi13 { get; set; }

        public short? psz_valor_gunu13 { get; set; }

        public double? psz_komisyon_orani13 { get; set; }

        public double? psz_odul_katkisi_orani13 { get; set; }

        public double? psz_erken_odeme_faiz_orani13 { get; set; }

        public double? psz_diger_komisyon_orani13 { get; set; }

        public byte? psz_kart_sahip_tipi14 { get; set; }

        public short? psz_taksit_sayisi14 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi14 { get; set; }

        public short? psz_valor_gunu14 { get; set; }

        public double? psz_komisyon_orani14 { get; set; }

        public double? psz_odul_katkisi_orani14 { get; set; }

        public double? psz_erken_odeme_faiz_orani14 { get; set; }

        public double? psz_diger_komisyon_orani14 { get; set; }

        public byte? psz_kart_sahip_tipi15 { get; set; }

        public short? psz_taksit_sayisi15 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi15 { get; set; }

        public short? psz_valor_gunu15 { get; set; }

        public double? psz_komisyon_orani15 { get; set; }

        public double? psz_odul_katkisi_orani15 { get; set; }

        public double? psz_erken_odeme_faiz_orani15 { get; set; }

        public double? psz_diger_komisyon_orani15 { get; set; }

        public byte? psz_kart_sahip_tipi16 { get; set; }

        public short? psz_taksit_sayisi16 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi16 { get; set; }

        public short? psz_valor_gunu16 { get; set; }

        public double? psz_komisyon_orani16 { get; set; }

        public double? psz_odul_katkisi_orani16 { get; set; }

        public double? psz_erken_odeme_faiz_orani16 { get; set; }

        public double? psz_diger_komisyon_orani16 { get; set; }

        public byte? psz_kart_sahip_tipi17 { get; set; }

        public short? psz_taksit_sayisi17 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi17 { get; set; }

        public short? psz_valor_gunu17 { get; set; }

        public double? psz_komisyon_orani17 { get; set; }

        public double? psz_odul_katkisi_orani17 { get; set; }

        public double? psz_erken_odeme_faiz_orani17 { get; set; }

        public double? psz_diger_komisyon_orani17 { get; set; }

        public byte? psz_kart_sahip_tipi18 { get; set; }

        public short? psz_taksit_sayisi18 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi18 { get; set; }

        public short? psz_valor_gunu18 { get; set; }

        public double? psz_komisyon_orani18 { get; set; }

        public double? psz_odul_katkisi_orani18 { get; set; }

        public double? psz_erken_odeme_faiz_orani18 { get; set; }

        public double? psz_diger_komisyon_orani18 { get; set; }

        public byte? psz_kart_sahip_tipi19 { get; set; }

        public short? psz_taksit_sayisi19 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi19 { get; set; }

        public short? psz_valor_gunu19 { get; set; }

        public double? psz_komisyon_orani19 { get; set; }

        public double? psz_odul_katkisi_orani19 { get; set; }

        public double? psz_erken_odeme_faiz_orani19 { get; set; }

        public double? psz_diger_komisyon_orani19 { get; set; }

        public byte? psz_kart_sahip_tipi20 { get; set; }

        public short? psz_taksit_sayisi20 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi20 { get; set; }

        public short? psz_valor_gunu20 { get; set; }

        public double? psz_komisyon_orani20 { get; set; }

        public double? psz_odul_katkisi_orani20 { get; set; }

        public double? psz_erken_odeme_faiz_orani20 { get; set; }

        public double? psz_diger_komisyon_orani20 { get; set; }

        public byte? psz_kart_sahip_tipi21 { get; set; }

        public short? psz_taksit_sayisi21 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi21 { get; set; }

        public short? psz_valor_gunu21 { get; set; }

        public double? psz_komisyon_orani21 { get; set; }

        public double? psz_odul_katkisi_orani21 { get; set; }

        public double? psz_erken_odeme_faiz_orani21 { get; set; }

        public double? psz_diger_komisyon_orani21 { get; set; }

        public byte? psz_kart_sahip_tipi22 { get; set; }

        public short? psz_taksit_sayisi22 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi22 { get; set; }

        public short? psz_valor_gunu22 { get; set; }

        public double? psz_komisyon_orani22 { get; set; }

        public double? psz_odul_katkisi_orani22 { get; set; }

        public double? psz_erken_odeme_faiz_orani22 { get; set; }

        public double? psz_diger_komisyon_orani22 { get; set; }

        public byte? psz_kart_sahip_tipi23 { get; set; }

        public short? psz_taksit_sayisi23 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi23 { get; set; }

        public short? psz_valor_gunu23 { get; set; }

        public double? psz_komisyon_orani23 { get; set; }

        public double? psz_odul_katkisi_orani23 { get; set; }

        public double? psz_erken_odeme_faiz_orani23 { get; set; }

        public double? psz_diger_komisyon_orani23 { get; set; }

        public byte? psz_kart_sahip_tipi24 { get; set; }

        public short? psz_taksit_sayisi24 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi24 { get; set; }

        public short? psz_valor_gunu24 { get; set; }

        public double? psz_komisyon_orani24 { get; set; }

        public double? psz_odul_katkisi_orani24 { get; set; }

        public double? psz_erken_odeme_faiz_orani24 { get; set; }

        public double? psz_diger_komisyon_orani24 { get; set; }

        public byte? psz_kart_sahip_tipi25 { get; set; }

        public short? psz_taksit_sayisi25 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi25 { get; set; }

        public short? psz_valor_gunu25 { get; set; }

        public double? psz_komisyon_orani25 { get; set; }

        public double? psz_odul_katkisi_orani25 { get; set; }

        public double? psz_erken_odeme_faiz_orani25 { get; set; }

        public double? psz_diger_komisyon_orani25 { get; set; }

        public byte? psz_kart_sahip_tipi26 { get; set; }

        public short? psz_taksit_sayisi26 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi26 { get; set; }

        public short? psz_valor_gunu26 { get; set; }

        public double? psz_komisyon_orani26 { get; set; }

        public double? psz_odul_katkisi_orani26 { get; set; }

        public double? psz_erken_odeme_faiz_orani26 { get; set; }

        public double? psz_diger_komisyon_orani26 { get; set; }

        public byte? psz_kart_sahip_tipi27 { get; set; }

        public short? psz_taksit_sayisi27 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi27 { get; set; }

        public short? psz_valor_gunu27 { get; set; }

        public double? psz_komisyon_orani27 { get; set; }

        public double? psz_odul_katkisi_orani27 { get; set; }

        public double? psz_erken_odeme_faiz_orani27 { get; set; }

        public double? psz_diger_komisyon_orani27 { get; set; }

        public byte? psz_kart_sahip_tipi28 { get; set; }

        public short? psz_taksit_sayisi28 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi28 { get; set; }

        public short? psz_valor_gunu28 { get; set; }

        public double? psz_komisyon_orani28 { get; set; }

        public double? psz_odul_katkisi_orani28 { get; set; }

        public double? psz_erken_odeme_faiz_orani28 { get; set; }

        public double? psz_diger_komisyon_orani28 { get; set; }

        public byte? psz_kart_sahip_tipi29 { get; set; }

        public short? psz_taksit_sayisi29 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi29 { get; set; }

        public short? psz_valor_gunu29 { get; set; }

        public double? psz_komisyon_orani29 { get; set; }

        public double? psz_odul_katkisi_orani29 { get; set; }

        public double? psz_erken_odeme_faiz_orani29 { get; set; }

        public double? psz_diger_komisyon_orani29 { get; set; }

        public byte? psz_kart_sahip_tipi30 { get; set; }

        public short? psz_taksit_sayisi30 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi30 { get; set; }

        public short? psz_valor_gunu30 { get; set; }

        public double? psz_komisyon_orani30 { get; set; }

        public double? psz_odul_katkisi_orani30 { get; set; }

        public double? psz_erken_odeme_faiz_orani30 { get; set; }

        public double? psz_diger_komisyon_orani30 { get; set; }

        public byte? psz_kart_sahip_tipi31 { get; set; }

        public short? psz_taksit_sayisi31 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi31 { get; set; }

        public short? psz_valor_gunu31 { get; set; }

        public double? psz_komisyon_orani31 { get; set; }

        public double? psz_odul_katkisi_orani31 { get; set; }

        public double? psz_erken_odeme_faiz_orani31 { get; set; }

        public double? psz_diger_komisyon_orani31 { get; set; }

        public byte? psz_kart_sahip_tipi32 { get; set; }

        public short? psz_taksit_sayisi32 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi32 { get; set; }

        public short? psz_valor_gunu32 { get; set; }

        public double? psz_komisyon_orani32 { get; set; }

        public double? psz_odul_katkisi_orani32 { get; set; }

        public double? psz_erken_odeme_faiz_orani32 { get; set; }

        public double? psz_diger_komisyon_orani32 { get; set; }

        public byte? psz_kart_sahip_tipi33 { get; set; }

        public short? psz_taksit_sayisi33 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi33 { get; set; }

        public short? psz_valor_gunu33 { get; set; }

        public double? psz_komisyon_orani33 { get; set; }

        public double? psz_odul_katkisi_orani33 { get; set; }

        public double? psz_erken_odeme_faiz_orani33 { get; set; }

        public double? psz_diger_komisyon_orani33 { get; set; }

        public byte? psz_kart_sahip_tipi34 { get; set; }

        public short? psz_taksit_sayisi34 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi34 { get; set; }

        public short? psz_valor_gunu34 { get; set; }

        public double? psz_komisyon_orani34 { get; set; }

        public double? psz_odul_katkisi_orani34 { get; set; }

        public double? psz_erken_odeme_faiz_orani34 { get; set; }

        public double? psz_diger_komisyon_orani34 { get; set; }

        public byte? psz_kart_sahip_tipi35 { get; set; }

        public short? psz_taksit_sayisi35 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi35 { get; set; }

        public short? psz_valor_gunu35 { get; set; }

        public double? psz_komisyon_orani35 { get; set; }

        public double? psz_odul_katkisi_orani35 { get; set; }

        public double? psz_erken_odeme_faiz_orani35 { get; set; }

        public double? psz_diger_komisyon_orani35 { get; set; }

        public byte? psz_kart_sahip_tipi36 { get; set; }

        public short? psz_taksit_sayisi36 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi36 { get; set; }

        public short? psz_valor_gunu36 { get; set; }

        public double? psz_komisyon_orani36 { get; set; }

        public double? psz_odul_katkisi_orani36 { get; set; }

        public double? psz_erken_odeme_faiz_orani36 { get; set; }

        public double? psz_diger_komisyon_orani36 { get; set; }

        public byte? psz_kart_sahip_tipi37 { get; set; }

        public short? psz_taksit_sayisi37 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi37 { get; set; }

        public short? psz_valor_gunu37 { get; set; }

        public double? psz_komisyon_orani37 { get; set; }

        public double? psz_odul_katkisi_orani37 { get; set; }

        public double? psz_erken_odeme_faiz_orani37 { get; set; }

        public double? psz_diger_komisyon_orani37 { get; set; }

        public byte? psz_kart_sahip_tipi38 { get; set; }

        public short? psz_taksit_sayisi38 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi38 { get; set; }

        public short? psz_valor_gunu38 { get; set; }

        public double? psz_komisyon_orani38 { get; set; }

        public double? psz_odul_katkisi_orani38 { get; set; }

        public double? psz_erken_odeme_faiz_orani38 { get; set; }

        public double? psz_diger_komisyon_orani38 { get; set; }

        public byte? psz_kart_sahip_tipi39 { get; set; }

        public short? psz_taksit_sayisi39 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi39 { get; set; }

        public short? psz_valor_gunu39 { get; set; }

        public double? psz_komisyon_orani39 { get; set; }

        public double? psz_odul_katkisi_orani39 { get; set; }

        public double? psz_erken_odeme_faiz_orani39 { get; set; }

        public double? psz_diger_komisyon_orani39 { get; set; }

        public byte? psz_kart_sahip_tipi40 { get; set; }

        public short? psz_taksit_sayisi40 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi40 { get; set; }

        public short? psz_valor_gunu40 { get; set; }

        public double? psz_komisyon_orani40 { get; set; }

        public double? psz_odul_katkisi_orani40 { get; set; }

        public double? psz_erken_odeme_faiz_orani40 { get; set; }

        public double? psz_diger_komisyon_orani40 { get; set; }

        public byte? psz_kart_sahip_tipi41 { get; set; }

        public short? psz_taksit_sayisi41 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi41 { get; set; }

        public short? psz_valor_gunu41 { get; set; }

        public double? psz_komisyon_orani41 { get; set; }

        public double? psz_odul_katkisi_orani41 { get; set; }

        public double? psz_erken_odeme_faiz_orani41 { get; set; }

        public double? psz_diger_komisyon_orani41 { get; set; }

        public byte? psz_kart_sahip_tipi42 { get; set; }

        public short? psz_taksit_sayisi42 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi42 { get; set; }

        public short? psz_valor_gunu42 { get; set; }

        public double? psz_komisyon_orani42 { get; set; }

        public double? psz_odul_katkisi_orani42 { get; set; }

        public double? psz_erken_odeme_faiz_orani42 { get; set; }

        public double? psz_diger_komisyon_orani42 { get; set; }

        public byte? psz_kart_sahip_tipi43 { get; set; }

        public short? psz_taksit_sayisi43 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi43 { get; set; }

        public short? psz_valor_gunu43 { get; set; }

        public double? psz_komisyon_orani43 { get; set; }

        public double? psz_odul_katkisi_orani43 { get; set; }

        public double? psz_erken_odeme_faiz_orani43 { get; set; }

        public double? psz_diger_komisyon_orani43 { get; set; }

        public byte? psz_kart_sahip_tipi44 { get; set; }

        public short? psz_taksit_sayisi44 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi44 { get; set; }

        public short? psz_valor_gunu44 { get; set; }

        public double? psz_komisyon_orani44 { get; set; }

        public double? psz_odul_katkisi_orani44 { get; set; }

        public double? psz_erken_odeme_faiz_orani44 { get; set; }

        public double? psz_diger_komisyon_orani44 { get; set; }

        public byte? psz_kart_sahip_tipi45 { get; set; }

        public short? psz_taksit_sayisi45 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi45 { get; set; }

        public short? psz_valor_gunu45 { get; set; }

        public double? psz_komisyon_orani45 { get; set; }

        public double? psz_odul_katkisi_orani45 { get; set; }

        public double? psz_erken_odeme_faiz_orani45 { get; set; }

        public double? psz_diger_komisyon_orani45 { get; set; }

        public byte? psz_kart_sahip_tipi46 { get; set; }

        public short? psz_taksit_sayisi46 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi46 { get; set; }

        public short? psz_valor_gunu46 { get; set; }

        public double? psz_komisyon_orani46 { get; set; }

        public double? psz_odul_katkisi_orani46 { get; set; }

        public double? psz_erken_odeme_faiz_orani46 { get; set; }

        public double? psz_diger_komisyon_orani46 { get; set; }

        public byte? psz_kart_sahip_tipi47 { get; set; }

        public short? psz_taksit_sayisi47 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi47 { get; set; }

        public short? psz_valor_gunu47 { get; set; }

        public double? psz_komisyon_orani47 { get; set; }

        public double? psz_odul_katkisi_orani47 { get; set; }

        public double? psz_erken_odeme_faiz_orani47 { get; set; }

        public double? psz_diger_komisyon_orani47 { get; set; }

        public byte? psz_kart_sahip_tipi48 { get; set; }

        public short? psz_taksit_sayisi48 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi48 { get; set; }

        public short? psz_valor_gunu48 { get; set; }

        public double? psz_komisyon_orani48 { get; set; }

        public double? psz_odul_katkisi_orani48 { get; set; }

        public double? psz_erken_odeme_faiz_orani48 { get; set; }

        public double? psz_diger_komisyon_orani48 { get; set; }

        public byte? psz_kart_sahip_tipi49 { get; set; }

        public short? psz_taksit_sayisi49 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi49 { get; set; }

        public short? psz_valor_gunu49 { get; set; }

        public double? psz_komisyon_orani49 { get; set; }

        public double? psz_odul_katkisi_orani49 { get; set; }

        public double? psz_erken_odeme_faiz_orani49 { get; set; }

        public double? psz_diger_komisyon_orani49 { get; set; }

        public byte? psz_kart_sahip_tipi50 { get; set; }

        public short? psz_taksit_sayisi50 { get; set; }

        public short? psz_firmaya_odeme_taksit_sayisi50 { get; set; }

        public short? psz_valor_gunu50 { get; set; }

        public double? psz_komisyon_orani50 { get; set; }

        public double? psz_odul_katkisi_orani50 { get; set; }

        public double? psz_erken_odeme_faiz_orani50 { get; set; }

        public double? psz_diger_komisyon_orani50 { get; set; }

        public byte? psz_taksit_valor_durumu { get; set; }

        public byte? psz_servis_komisyon_kesinti_durumu { get; set; }

        public byte? psz_odul_katkisi_kesinti_durumu { get; set; }
    }
}
