namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BARKOD_ETIKET_TANIMLARI
    {
        [Key]
        public int BEP_RECno { get; set; }

        public short BEP_RECid_DBCno { get; set; }

        public int BEP_RECid_RECno { get; set; }

        public int? BEP_Spec_Rec_no { get; set; }

        public bool? BEP_iptal { get; set; }

        public short? BEP_fileid { get; set; }

        public bool? BEP_hidden { get; set; }

        public bool? BEP_kilitli { get; set; }

        public bool? BEP_degisti { get; set; }

        public int? BEP_checksum { get; set; }

        public short? BEP_create_user { get; set; }

        public DateTime? BEP_create_date { get; set; }

        public short? BEP_lastup_user { get; set; }

        public DateTime? BEP_lastup_date { get; set; }

        [StringLength(4)]
        public string BEP_special1 { get; set; }

        [StringLength(4)]
        public string BEP_special2 { get; set; }

        [StringLength(4)]
        public string BEP_special3 { get; set; }

        public int? BEP_No { get; set; }

        [StringLength(20)]
        public string BEP_Aciklama { get; set; }

        public byte? BEP_EtiketYolAdi { get; set; }

        public short? BEP_BasimAdedi { get; set; }

        [StringLength(12)]
        public string BEP_DisProgram { get; set; }

        [StringLength(15)]
        public string BEP_DisProgramParam { get; set; }

        [StringLength(40)]
        public string BEP_EAN13_DosyaAdi { get; set; }

        [StringLength(40)]
        public string BEP_EAN8_DosyaAdi { get; set; }

        [StringLength(40)]
        public string BEP_Ascii_DosyaAdi { get; set; }

        [StringLength(40)]
        public string BEP_UPCA_DosyaAdi { get; set; }

        [StringLength(40)]
        public string BEP_UPCE_DosyaAdi { get; set; }

        [StringLength(40)]
        public string BEP_Code39_DosyaAdi { get; set; }

        public bool? BEP_KarakterCevir_fl { get; set; }

        public byte? BEP_BasimBeklemeSuresi { get; set; }

        public bool? BEP_YTLCevir_fl { get; set; }

        [StringLength(25)]
        public string BEP_DosyaAdi { get; set; }
    }
}
