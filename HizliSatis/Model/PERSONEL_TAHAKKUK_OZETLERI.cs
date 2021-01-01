namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_TAHAKKUK_OZETLERI
    {
        [Key]
        public int pro_RECno { get; set; }

        public short pro_RECid_DBCno { get; set; }

        public int pro_RECid_RECno { get; set; }

        public int? pro_SpecRECno { get; set; }

        public bool? pro_iptal { get; set; }

        public short? pro_fileid { get; set; }

        public bool? pro_hidden { get; set; }

        public bool? pro_kilitli { get; set; }

        public bool? pro_degisti { get; set; }

        public int? pro_checksum { get; set; }

        public short? pro_create_user { get; set; }

        public DateTime? pro_create_date { get; set; }

        public short? pro_lastup_user { get; set; }

        public DateTime? pro_lastup_date { get; set; }

        [StringLength(4)]
        public string pro_special1 { get; set; }

        [StringLength(4)]
        public string pro_special2 { get; set; }

        [StringLength(4)]
        public string pro_special3 { get; set; }

        [StringLength(25)]
        public string pro_kodozet { get; set; }

        public short? pro_ozetyili { get; set; }

        public short? pro_Ponceodkfayi { get; set; }

        public double? pro_kumvergimat { get; set; }

        public double? pro_borcu { get; set; }

        public double? pro_borcutaksit { get; set; }

        public double? pro_icra { get; set; }

        public double? pro_icrataksit { get; set; }

        public double? pro_kredi { get; set; }

        public double? pro_kreditaksit { get; set; }

        public double? pro_tersbakiye { get; set; }

        public double? pro_yuvarlamafarki { get; set; }

        public double? pro_gec_yil_kummatra { get; set; }

        public double? pro_gec_yil_vergi { get; set; }

        public double? pro_evrak_tutari { get; set; }

        public double? pro_top_vergi_iadesi { get; set; }

        public double? pro_kumvergi { get; set; }

        public double? pro_kfgeneltoplam { get; set; }

        public double? pro_tt_genel_toplam { get; set; }

        public short? pro_aylik_sskgun1 { get; set; }

        public double? pro_aylik_sskkaz1 { get; set; }

        public double? pro_aylik_ssk1 { get; set; }

        public double? pro_aylik_gvmatrah1 { get; set; }

        public double? pro_aylik_gv1 { get; set; }

        public double? pro_aylik_dvmatrah1 { get; set; }

        public double? pro_aylik_dv1 { get; set; }

        public double? pro_aylik_konutfn1 { get; set; }

        public double? pro_aylik_kaz1 { get; set; }

        public double? pro_aylik_ekkaz1 { get; set; }

        public double? pro_aylik_sosyardim1 { get; set; }

        public double? pro_aylik_kesinti1 { get; set; }

        public double? pro_aylik_netto1 { get; set; }

        public double? pro_aylik_v_iade1 { get; set; }

        public double? pro_aylik_sosyrdkid1 { get; set; }

        public double? pro_aylik_issigmat1 { get; set; }

        public double? pro_aylik_issigper1 { get; set; }

        public double? pro_aylik_issigisv1 { get; set; }

        public double? pro_aylik_issig1 { get; set; }

        public double? pro_aylik_sskisv1 { get; set; }

        public double? pro_aylik_asgarigecind1 { get; set; }

        public double? pro_sonrayadevirsskmatrahi1 { get; set; }

        public double? pro_gecenaylardankullanilanssk1 { get; set; }

        public double? pro_bagkurprimi1 { get; set; }

        public short? pro_aylik_sskgun2 { get; set; }

        public double? pro_aylik_sskkaz2 { get; set; }

        public double? pro_aylik_ssk2 { get; set; }

        public double? pro_aylik_gvmatrah2 { get; set; }

        public double? pro_aylik_gv2 { get; set; }

        public double? pro_aylik_dvmatrah2 { get; set; }

        public double? pro_aylik_dv2 { get; set; }

        public double? pro_aylik_konutfn2 { get; set; }

        public double? pro_aylik_kaz2 { get; set; }

        public double? pro_aylik_ekkaz2 { get; set; }

        public double? pro_aylik_sosyardim2 { get; set; }

        public double? pro_aylik_kesinti2 { get; set; }

        public double? pro_aylik_netto2 { get; set; }

        public double? pro_aylik_v_iade2 { get; set; }

        public double? pro_aylik_sosyrdkid2 { get; set; }

        public double? pro_aylik_issigmat2 { get; set; }

        public double? pro_aylik_issigper2 { get; set; }

        public double? pro_aylik_issigisv2 { get; set; }

        public double? pro_aylik_issig2 { get; set; }

        public double? pro_aylik_sskisv2 { get; set; }

        public double? pro_aylik_asgarigecind2 { get; set; }

        public double? pro_sonrayadevirsskmatrahi2 { get; set; }

        public double? pro_gecenaylardankullanilanssk2 { get; set; }

        public double? pro_bagkurprimi2 { get; set; }

        public short? pro_aylik_sskgun3 { get; set; }

        public double? pro_aylik_sskkaz3 { get; set; }

        public double? pro_aylik_ssk3 { get; set; }

        public double? pro_aylik_gvmatrah3 { get; set; }

        public double? pro_aylik_gv3 { get; set; }

        public double? pro_aylik_dvmatrah3 { get; set; }

        public double? pro_aylik_dv3 { get; set; }

        public double? pro_aylik_konutfn3 { get; set; }

        public double? pro_aylik_kaz3 { get; set; }

        public double? pro_aylik_ekkaz3 { get; set; }

        public double? pro_aylik_sosyardim3 { get; set; }

        public double? pro_aylik_kesinti3 { get; set; }

        public double? pro_aylik_netto3 { get; set; }

        public double? pro_aylik_v_iade3 { get; set; }

        public double? pro_aylik_sosyrdkid3 { get; set; }

        public double? pro_aylik_issigmat3 { get; set; }

        public double? pro_aylik_issigper3 { get; set; }

        public double? pro_aylik_issigisv3 { get; set; }

        public double? pro_aylik_issig3 { get; set; }

        public double? pro_aylik_sskisv3 { get; set; }

        public double? pro_aylik_asgarigecind3 { get; set; }

        public double? pro_sonrayadevirsskmatrahi3 { get; set; }

        public double? pro_gecenaylardankullanilanssk3 { get; set; }

        public double? pro_bagkurprimi3 { get; set; }

        public short? pro_aylik_sskgun4 { get; set; }

        public double? pro_aylik_sskkaz4 { get; set; }

        public double? pro_aylik_ssk4 { get; set; }

        public double? pro_aylik_gvmatrah4 { get; set; }

        public double? pro_aylik_gv4 { get; set; }

        public double? pro_aylik_dvmatrah4 { get; set; }

        public double? pro_aylik_dv4 { get; set; }

        public double? pro_aylik_konutfn4 { get; set; }

        public double? pro_aylik_kaz4 { get; set; }

        public double? pro_aylik_ekkaz4 { get; set; }

        public double? pro_aylik_sosyardim4 { get; set; }

        public double? pro_aylik_kesinti4 { get; set; }

        public double? pro_aylik_netto4 { get; set; }

        public double? pro_aylik_v_iade4 { get; set; }

        public double? pro_aylik_sosyrdkid4 { get; set; }

        public double? pro_aylik_issigmat4 { get; set; }

        public double? pro_aylik_issigper4 { get; set; }

        public double? pro_aylik_issigisv4 { get; set; }

        public double? pro_aylik_issig4 { get; set; }

        public double? pro_aylik_sskisv4 { get; set; }

        public double? pro_aylik_asgarigecind4 { get; set; }

        public double? pro_sonrayadevirsskmatrahi4 { get; set; }

        public double? pro_gecenaylardankullanilanssk4 { get; set; }

        public double? pro_bagkurprimi4 { get; set; }

        public short? pro_aylik_sskgun5 { get; set; }

        public double? pro_aylik_sskkaz5 { get; set; }

        public double? pro_aylik_ssk5 { get; set; }

        public double? pro_aylik_gvmatrah5 { get; set; }

        public double? pro_aylik_gv5 { get; set; }

        public double? pro_aylik_dvmatrah5 { get; set; }

        public double? pro_aylik_dv5 { get; set; }

        public double? pro_aylik_konutfn5 { get; set; }

        public double? pro_aylik_kaz5 { get; set; }

        public double? pro_aylik_ekkaz5 { get; set; }

        public double? pro_aylik_sosyardim5 { get; set; }

        public double? pro_aylik_kesinti5 { get; set; }

        public double? pro_aylik_netto5 { get; set; }

        public double? pro_aylik_v_iade5 { get; set; }

        public double? pro_aylik_sosyrdkid5 { get; set; }

        public double? pro_aylik_issigmat5 { get; set; }

        public double? pro_aylik_issigper5 { get; set; }

        public double? pro_aylik_issigisv5 { get; set; }

        public double? pro_aylik_issig5 { get; set; }

        public double? pro_aylik_sskisv5 { get; set; }

        public double? pro_aylik_asgarigecind5 { get; set; }

        public double? pro_sonrayadevirsskmatrahi5 { get; set; }

        public double? pro_gecenaylardankullanilanssk5 { get; set; }

        public double? pro_bagkurprimi5 { get; set; }

        public short? pro_aylik_sskgun6 { get; set; }

        public double? pro_aylik_sskkaz6 { get; set; }

        public double? pro_aylik_ssk6 { get; set; }

        public double? pro_aylik_gvmatrah6 { get; set; }

        public double? pro_aylik_gv6 { get; set; }

        public double? pro_aylik_dvmatrah6 { get; set; }

        public double? pro_aylik_dv6 { get; set; }

        public double? pro_aylik_konutfn6 { get; set; }

        public double? pro_aylik_kaz6 { get; set; }

        public double? pro_aylik_ekkaz6 { get; set; }

        public double? pro_aylik_sosyardim6 { get; set; }

        public double? pro_aylik_kesinti6 { get; set; }

        public double? pro_aylik_netto6 { get; set; }

        public double? pro_aylik_v_iade6 { get; set; }

        public double? pro_aylik_sosyrdkid6 { get; set; }

        public double? pro_aylik_issigmat6 { get; set; }

        public double? pro_aylik_issigper6 { get; set; }

        public double? pro_aylik_issigisv6 { get; set; }

        public double? pro_aylik_issig6 { get; set; }

        public double? pro_aylik_sskisv6 { get; set; }

        public double? pro_aylik_asgarigecind6 { get; set; }

        public double? pro_sonrayadevirsskmatrahi6 { get; set; }

        public double? pro_gecenaylardankullanilanssk6 { get; set; }

        public double? pro_bagkurprimi6 { get; set; }

        public short? pro_aylik_sskgun7 { get; set; }

        public double? pro_aylik_sskkaz7 { get; set; }

        public double? pro_aylik_ssk7 { get; set; }

        public double? pro_aylik_gvmatrah7 { get; set; }

        public double? pro_aylik_gv7 { get; set; }

        public double? pro_aylik_dvmatrah7 { get; set; }

        public double? pro_aylik_dv7 { get; set; }

        public double? pro_aylik_konutfn7 { get; set; }

        public double? pro_aylik_kaz7 { get; set; }

        public double? pro_aylik_ekkaz7 { get; set; }

        public double? pro_aylik_sosyardim7 { get; set; }

        public double? pro_aylik_kesinti7 { get; set; }

        public double? pro_aylik_netto7 { get; set; }

        public double? pro_aylik_v_iade7 { get; set; }

        public double? pro_aylik_sosyrdkid7 { get; set; }

        public double? pro_aylik_issigmat7 { get; set; }

        public double? pro_aylik_issigper7 { get; set; }

        public double? pro_aylik_issigisv7 { get; set; }

        public double? pro_aylik_issig7 { get; set; }

        public double? pro_aylik_sskisv7 { get; set; }

        public double? pro_aylik_asgarigecind7 { get; set; }

        public double? pro_sonrayadevirsskmatrahi7 { get; set; }

        public double? pro_gecenaylardankullanilanssk7 { get; set; }

        public double? pro_bagkurprimi7 { get; set; }

        public short? pro_aylik_sskgun8 { get; set; }

        public double? pro_aylik_sskkaz8 { get; set; }

        public double? pro_aylik_ssk8 { get; set; }

        public double? pro_aylik_gvmatrah8 { get; set; }

        public double? pro_aylik_gv8 { get; set; }

        public double? pro_aylik_dvmatrah8 { get; set; }

        public double? pro_aylik_dv8 { get; set; }

        public double? pro_aylik_konutfn8 { get; set; }

        public double? pro_aylik_kaz8 { get; set; }

        public double? pro_aylik_ekkaz8 { get; set; }

        public double? pro_aylik_sosyardim8 { get; set; }

        public double? pro_aylik_kesinti8 { get; set; }

        public double? pro_aylik_netto8 { get; set; }

        public double? pro_aylik_v_iade8 { get; set; }

        public double? pro_aylik_sosyrdkid8 { get; set; }

        public double? pro_aylik_issigmat8 { get; set; }

        public double? pro_aylik_issigper8 { get; set; }

        public double? pro_aylik_issigisv8 { get; set; }

        public double? pro_aylik_issig8 { get; set; }

        public double? pro_aylik_sskisv8 { get; set; }

        public double? pro_aylik_asgarigecind8 { get; set; }

        public double? pro_sonrayadevirsskmatrahi8 { get; set; }

        public double? pro_gecenaylardankullanilanssk8 { get; set; }

        public double? pro_bagkurprimi8 { get; set; }

        public short? pro_aylik_sskgun9 { get; set; }

        public double? pro_aylik_sskkaz9 { get; set; }

        public double? pro_aylik_ssk9 { get; set; }

        public double? pro_aylik_gvmatrah9 { get; set; }

        public double? pro_aylik_gv9 { get; set; }

        public double? pro_aylik_dvmatrah9 { get; set; }

        public double? pro_aylik_dv9 { get; set; }

        public double? pro_aylik_konutfn9 { get; set; }

        public double? pro_aylik_kaz9 { get; set; }

        public double? pro_aylik_ekkaz9 { get; set; }

        public double? pro_aylik_sosyardim9 { get; set; }

        public double? pro_aylik_kesinti9 { get; set; }

        public double? pro_aylik_netto9 { get; set; }

        public double? pro_aylik_v_iade9 { get; set; }

        public double? pro_aylik_sosyrdkid9 { get; set; }

        public double? pro_aylik_issigmat9 { get; set; }

        public double? pro_aylik_issigper9 { get; set; }

        public double? pro_aylik_issigisv9 { get; set; }

        public double? pro_aylik_issig9 { get; set; }

        public double? pro_aylik_sskisv9 { get; set; }

        public double? pro_aylik_asgarigecind9 { get; set; }

        public double? pro_sonrayadevirsskmatrahi9 { get; set; }

        public double? pro_gecenaylardankullanilanssk9 { get; set; }

        public double? pro_bagkurprimi9 { get; set; }

        public short? pro_aylik_sskgun10 { get; set; }

        public double? pro_aylik_sskkaz10 { get; set; }

        public double? pro_aylik_ssk10 { get; set; }

        public double? pro_aylik_gvmatrah10 { get; set; }

        public double? pro_aylik_gv10 { get; set; }

        public double? pro_aylik_dvmatrah10 { get; set; }

        public double? pro_aylik_dv10 { get; set; }

        public double? pro_aylik_konutfn10 { get; set; }

        public double? pro_aylik_kaz10 { get; set; }

        public double? pro_aylik_ekkaz10 { get; set; }

        public double? pro_aylik_sosyrd10 { get; set; }

        public double? pro_aylik_kesinti10 { get; set; }

        public double? pro_aylik_netto10 { get; set; }

        public double? pro_aylik_v_iade10 { get; set; }

        public double? pro_aylik_syrdkid10 { get; set; }

        public double? pro_aylik_issigmat10 { get; set; }

        public double? pro_aylik_issigper10 { get; set; }

        public double? pro_aylik_issigisv10 { get; set; }

        public double? pro_aylik_issig10 { get; set; }

        public double? pro_aylik_sskisv10 { get; set; }

        public double? pro_aylik_asgarigecind10 { get; set; }

        public double? pro_sonrayadevirsskmatrahi10 { get; set; }

        public double? pro_gecenaylardankullanilanssk10 { get; set; }

        public double? pro_bagkurprimi10 { get; set; }

        public short? pro_aylik_sskgun11 { get; set; }

        public double? pro_aylik_sskkaz11 { get; set; }

        public double? pro_aylik_ssk11 { get; set; }

        public double? pro_aylik_gvmatrah11 { get; set; }

        public double? pro_aylik_gv11 { get; set; }

        public double? pro_aylik_dvmatrah11 { get; set; }

        public double? pro_aylik_dv11 { get; set; }

        public double? pro_aylik_konutfn11 { get; set; }

        public double? pro_aylik_kaz11 { get; set; }

        public double? pro_aylik_ekkaz11 { get; set; }

        public double? pro_aylik_sosyrd11 { get; set; }

        public double? pro_aylik_kesinti11 { get; set; }

        public double? pro_aylik_netto11 { get; set; }

        public double? pro_aylik_v_iade11 { get; set; }

        public double? pro_aylik_syrdkid11 { get; set; }

        public double? pro_aylik_issigmat11 { get; set; }

        public double? pro_aylik_issigper11 { get; set; }

        public double? pro_aylik_issigisv11 { get; set; }

        public double? pro_aylik_issig11 { get; set; }

        public double? pro_aylik_sskisv11 { get; set; }

        public double? pro_aylik_asgarigecind11 { get; set; }

        public double? pro_sonrayadevirsskmatrahi11 { get; set; }

        public double? pro_gecenaylardankullanilanssk11 { get; set; }

        public double? pro_bagkurprimi11 { get; set; }

        public short? pro_aylik_sskgun12 { get; set; }

        public double? pro_aylik_sskkaz12 { get; set; }

        public double? pro_aylik_ssk12 { get; set; }

        public double? pro_aylik_gvmatrah12 { get; set; }

        public double? pro_aylik_gv12 { get; set; }

        public double? pro_aylik_dvmatrah12 { get; set; }

        public double? pro_aylik_dv12 { get; set; }

        public double? pro_aylik_konutfn12 { get; set; }

        public double? pro_aylik_kaz12 { get; set; }

        public double? pro_aylik_ekkaz12 { get; set; }

        public double? pro_aylik_sosyrd12 { get; set; }

        public double? pro_aylik_kesinti12 { get; set; }

        public double? pro_aylik_netto12 { get; set; }

        public double? pro_aylik_v_iade12 { get; set; }

        public double? pro_aylik_syrdkid12 { get; set; }

        public double? pro_aylik_issigmat12 { get; set; }

        public double? pro_aylik_issigper12 { get; set; }

        public double? pro_aylik_issigisv12 { get; set; }

        public double? pro_aylik_issig12 { get; set; }

        public double? pro_aylik_sskisv12 { get; set; }

        public double? pro_aylik_asgarigecind12 { get; set; }

        public double? pro_sonrayadevirsskmatrahi12 { get; set; }

        public double? pro_gecenaylardankullanilanssk12 { get; set; }

        public double? pro_bagkurprimi12 { get; set; }

        public DateTime? pro_onceki_hakedis { get; set; }

        public DateTime? pro_izin_hakedis { get; set; }

        public double? pro_evrak_top { get; set; }

        public double? pro_ikramiye { get; set; }

        public double? pro_brut { get; set; }

        public double? pro_gec_yil_kum { get; set; }

        public double? pro_gec_yil_sonvergi { get; set; }

        public double? pro_digersig_isveren { get; set; }

        public double? pro_digersig_isveren2 { get; set; }

        public double? pro_digersig_isveren3 { get; set; }

        public double? pro_digersig_isveren4 { get; set; }

        public double? pro_digersig_isveren5 { get; set; }

        public double? pro_digersig_isveren6 { get; set; }

        public double? pro_digersig_isveren7 { get; set; }

        public double? pro_digersig_isveren8 { get; set; }

        public double? pro_digersig_isveren9 { get; set; }

        public double? pro_digersig_isveren10 { get; set; }

        public double? pro_digersig_isveren11 { get; set; }

        public double? pro_digersig_isveren12 { get; set; }

        public double? pro_digersig_calisan { get; set; }

        public double? pro_digersig_calisan2 { get; set; }

        public double? pro_digersig_calisan3 { get; set; }

        public double? pro_digersig_calisan4 { get; set; }

        public double? pro_digersig_calisan5 { get; set; }

        public double? pro_digersig_calisan6 { get; set; }

        public double? pro_digersig_calisan7 { get; set; }

        public double? pro_digersig_calisan8 { get; set; }

        public double? pro_digersig_calisan9 { get; set; }

        public double? pro_digersig_calisan10 { get; set; }

        public double? pro_digersig_calisan11 { get; set; }

        public double? pro_digersig_calisan12 { get; set; }

        public double? pro_bireyselsig_isveren { get; set; }

        public double? pro_bireyselsig_isveren2 { get; set; }

        public double? pro_bireyselsig_isveren3 { get; set; }

        public double? pro_bireyselsig_isveren4 { get; set; }

        public double? pro_bireyselsig_isveren5 { get; set; }

        public double? pro_bireyselsig_isveren6 { get; set; }

        public double? pro_bireyselsig_isveren7 { get; set; }

        public double? pro_bireyselsig_isveren8 { get; set; }

        public double? pro_bireyselsig_isveren9 { get; set; }

        public double? pro_bireyselsig_isveren10 { get; set; }

        public double? pro_bireyselsig_isveren11 { get; set; }

        public double? pro_bireyselsig_isveren12 { get; set; }

        public double? pro_bireyselsig_calisan { get; set; }

        public double? pro_bireyselsig_calisan2 { get; set; }

        public double? pro_bireyselsig_calisan3 { get; set; }

        public double? pro_bireyselsig_calisan4 { get; set; }

        public double? pro_bireyselsig_calisan5 { get; set; }

        public double? pro_bireyselsig_calisan6 { get; set; }

        public double? pro_bireyselsig_calisan7 { get; set; }

        public double? pro_bireyselsig_calisan8 { get; set; }

        public double? pro_bireyselsig_calisan9 { get; set; }

        public double? pro_bireyselsig_calisan10 { get; set; }

        public double? pro_bireyselsig_calisan11 { get; set; }

        public double? pro_bireyselsig_calisan12 { get; set; }

        public double? pro_devirdigsigorta_isveren { get; set; }

        public double? pro_devirdigsigorta_calisan { get; set; }

        public double? pro_devirbireysig_isveren { get; set; }

        public double? pro_devirbireysig_calisan { get; set; }

        public bool? pro_police_tarihi_yeni_fl { get; set; }

        public double? pro_PTTFDvrTutar { get; set; }

        public DateTime? pro_PTTFDvrTar { get; set; }

        public double? pro_PissigDvrTutar { get; set; }

        public DateTime? pro_PissigDvrTar { get; set; }

        public short? pro_viziteSayac { get; set; }

        public double? pro_dig_kesinti1 { get; set; }

        public double? pro_dig_taksit1 { get; set; }

        public double? pro_dig_kesinti2 { get; set; }

        public double? pro_dig_taksit2 { get; set; }

        public double? pro_dig_kesinti3 { get; set; }

        public double? pro_dig_taksit3 { get; set; }

        public double? pro_dig_kesinti4 { get; set; }

        public double? pro_dig_taksit4 { get; set; }

        public double? pro_dig_kesinti5 { get; set; }

        public double? pro_dig_taksit5 { get; set; }

        public double? pro_dig_kesinti6 { get; set; }

        public double? pro_dig_taksit6 { get; set; }

        public double? pro_per_ayni_odeme { get; set; }

        public bool? pro_per_ayni_odeme_var_fl { get; set; }

        public double? pro_per_asker_borc { get; set; }

        public double? pro_per_asker_borc_taksit { get; set; }

        public bool? pro_asker_kendisi_ode_fl { get; set; }

        public short? pro_gecyil_devir_izin { get; set; }

        public short? pro_devreden_sinyority_gunu { get; set; }

        public short? pro_devreden_izin_parasi_gunu { get; set; }

        public short? pro_ufrs_izin_gunu_hakki { get; set; }

        public double? pro_ufrs_izin_ucreti { get; set; }

        public double? pro_ufrs_kidem_tazminati { get; set; }

        public double? pro_sgkpriminetabiikazanc1 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc1 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim1 { get; set; }

        public double? pro_sgkpriminetabiikazanc2 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc2 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim2 { get; set; }

        public double? pro_sgkpriminetabiikazanc3 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc3 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim3 { get; set; }

        public double? pro_sgkpriminetabiikazanc4 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc4 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim4 { get; set; }

        public double? pro_sgkpriminetabiikazanc5 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc5 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim5 { get; set; }

        public double? pro_sgkpriminetabiikazanc6 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc6 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim6 { get; set; }

        public double? pro_sgkpriminetabiikazanc7 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc7 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim7 { get; set; }

        public double? pro_sgkpriminetabiikazanc8 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc8 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim8 { get; set; }

        public double? pro_sgkpriminetabiikazanc9 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc9 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim9 { get; set; }

        public double? pro_sgkpriminetabiikazanc10 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc10 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim10 { get; set; }

        public double? pro_sgkpriminetabiikazanc11 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc11 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim11 { get; set; }

        public double? pro_sgkpriminetabiikazanc12 { get; set; }

        public double? pro_sgkpriminetabiiekkazanc12 { get; set; }

        public double? pro_sgkpriminetabiisosyalyardim12 { get; set; }

        public double? pro_hayatsig_isveren1 { get; set; }

        public double? pro_hayatsig_isveren2 { get; set; }

        public double? pro_hayatsig_isveren3 { get; set; }

        public double? pro_hayatsig_isveren4 { get; set; }

        public double? pro_hayatsig_isveren5 { get; set; }

        public double? pro_hayatsig_isveren6 { get; set; }

        public double? pro_hayatsig_isveren7 { get; set; }

        public double? pro_hayatsig_isveren8 { get; set; }

        public double? pro_hayatsig_isveren9 { get; set; }

        public double? pro_hayatsig_isveren10 { get; set; }

        public double? pro_hayatsig_isveren11 { get; set; }

        public double? pro_hayatsig_isveren12 { get; set; }

        public double? pro_hayatsig_calisan1 { get; set; }

        public double? pro_hayatsig_calisan2 { get; set; }

        public double? pro_hayatsig_calisan3 { get; set; }

        public double? pro_hayatsig_calisan4 { get; set; }

        public double? pro_hayatsig_calisan5 { get; set; }

        public double? pro_hayatsig_calisan6 { get; set; }

        public double? pro_hayatsig_calisan7 { get; set; }

        public double? pro_hayatsig_calisan8 { get; set; }

        public double? pro_hayatsig_calisan9 { get; set; }

        public double? pro_hayatsig_calisan10 { get; set; }

        public double? pro_hayatsig_calisan11 { get; set; }

        public double? pro_hayatsig_calisan12 { get; set; }

        public double? pro_devirhayatsigorta_isveren { get; set; }

        public double? pro_devirhayatsigorta_calisan { get; set; }

        public double? pro_otobes1 { get; set; }

        public double? pro_otobes2 { get; set; }

        public double? pro_otobes3 { get; set; }

        public double? pro_otobes4 { get; set; }

        public double? pro_otobes5 { get; set; }

        public double? pro_otobes6 { get; set; }

        public double? pro_otobes7 { get; set; }

        public double? pro_otobes8 { get; set; }

        public double? pro_otobes9 { get; set; }

        public double? pro_otobes10 { get; set; }

        public double? pro_otobes11 { get; set; }

        public double? pro_otobes12 { get; set; }
    }
}
