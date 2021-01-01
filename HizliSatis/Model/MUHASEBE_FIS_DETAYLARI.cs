namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MUHASEBE_FIS_DETAYLARI
    {
        [Key]
        public int mfd_RECno { get; set; }

        public short mfd_RECid_DBCno { get; set; }

        public int mfd_RECid_RECno { get; set; }

        public int? mfd_SpecRECno { get; set; }

        public bool? mfd_iptal { get; set; }

        public short? mfd_fileid { get; set; }

        public bool? mfd_hidden { get; set; }

        public bool? mfd_kilitli { get; set; }

        public bool? mfd_degisti { get; set; }

        public int? mfd_checksum { get; set; }

        public short? mfd_create_user { get; set; }

        public DateTime? mfd_create_date { get; set; }

        public short? mfd_lastup_user { get; set; }

        public DateTime? mfd_lastup_date { get; set; }

        [StringLength(4)]
        public string mfd_special1 { get; set; }

        [StringLength(4)]
        public string mfd_special2 { get; set; }

        [StringLength(4)]
        public string mfd_special3 { get; set; }

        public byte? mfd_ticari_tip { get; set; }

        public byte? mfd_evraktip { get; set; }

        [StringLength(6)]
        public string mfd_evrak_seri { get; set; }

        public int? mfd_evrak_sira { get; set; }

        [StringLength(120)]
        public string mfd_cariunvan { get; set; }

        [StringLength(50)]
        public string mfd_carivergidaireadi { get; set; }

        [StringLength(15)]
        public string mfd_carivergidaireno { get; set; }

        public double? mfd_bsbakonututar { get; set; }

        public byte? mfd_bsbatabii { get; set; }

        [StringLength(4)]
        public string mfd_cariulkekodno { get; set; }

        public DateTime? mfd_belgetarihi { get; set; }

        public byte? mfd_tutarnereden { get; set; }

        public byte? mfd_caritipi { get; set; }

        [StringLength(25)]
        public string mfd_carikodu { get; set; }

        [StringLength(25)]
        public string mfd_carimuhkodu { get; set; }

        [StringLength(20)]
        public string mfd_belgeno { get; set; }

        public byte? mfd_kdvid { get; set; }

        public double? mfd_kdvtutar { get; set; }

        [StringLength(25)]
        public string mfd_malhizmetkodu { get; set; }

        [StringLength(120)]
        public string mfd_malhizmetcinsi { get; set; }

        public double? mfd_malhizmetmiktari { get; set; }

        [StringLength(10)]
        public string mfd_malhizmetbirim { get; set; }

        [StringLength(30)]
        public string mfd_ggb_gcb_no { get; set; }

        [StringLength(50)]
        public string mfd_aracivergidaireadi { get; set; }

        [StringLength(15)]
        public string mfd_aracivergidaireno { get; set; }

        [StringLength(4)]
        public string mfd_eximulkekodu { get; set; }

        public double? mfd_bsbakonuufrstutar { get; set; }

        [StringLength(127)]
        public string mfd_aciklama { get; set; }

        public double? mfd_caritutar { get; set; }

        public byte? mfd_kisaevraktipi { get; set; }

        public byte? mfd_satistipi { get; set; }

        public byte? mfd_alistipi { get; set; }

        public byte? mfd_tahtedtipi { get; set; }

        [StringLength(50)]
        public string mfd_digerevrakadi { get; set; }

        public byte? mfd_evraktur { get; set; }
    }
}
