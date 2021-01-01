namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ETIKETBAS
    {
        [Key]
        public int Etkb_RECno { get; set; }

        public short Etkb_RECid_DBCno { get; set; }

        public int Etkb_RECid_RECno { get; set; }

        public int? Etkb_SpecRECno { get; set; }

        public bool? Etkb_iptal { get; set; }

        public short? Etkb_fileid { get; set; }

        public bool? Etkb_hidden { get; set; }

        public bool? Etkb_kilitli { get; set; }

        public bool? Etkb_degisti { get; set; }

        public int? Etkb_checksum { get; set; }

        public short? Etkb_create_user { get; set; }

        public DateTime? Etkb_create_date { get; set; }

        public short? Etkb_lastup_user { get; set; }

        public DateTime? Etkb_lastup_date { get; set; }

        [StringLength(4)]
        public string Etkb_special1 { get; set; }

        [StringLength(4)]
        public string Etkb_special2 { get; set; }

        [StringLength(4)]
        public string Etkb_special3 { get; set; }

        [StringLength(6)]
        public string Etkb_evrakno_seri { get; set; }

        public int? Etkb_evrakno_sira { get; set; }

        public DateTime? Etkb_evrak_tarihi { get; set; }

        [StringLength(40)]
        public string Etkb_aciklama { get; set; }

        public int? Etkb_satirno { get; set; }

        [StringLength(20)]
        public string Etkb_belge_no { get; set; }

        public DateTime? Etkb_belge_tarih { get; set; }

        public byte? Etkb_EtiketTip { get; set; }

        public byte? Etkb_BasimTipi { get; set; }

        public short? Etkb_BasimAdet { get; set; }

        public int? Etkb_DepoNo { get; set; }

        [StringLength(25)]
        public string Etkb_StokKodu { get; set; }

        public int? Etkb_RenkNo { get; set; }

        public int? Etkb_BedenNo { get; set; }

        [StringLength(25)]
        public string Etkb_Barkodu { get; set; }

        public short? Etkb_BasilacakMiktar { get; set; }
    }
}
