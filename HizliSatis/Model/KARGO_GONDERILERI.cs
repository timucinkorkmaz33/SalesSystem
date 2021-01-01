namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KARGO_GONDERILERI
    {
        [Key]
        public int kargo_RECno { get; set; }

        public short kargo_RECid_DBCno { get; set; }

        public int kargo_RECid_RECno { get; set; }

        public int? kargo_Spec_Rec_no { get; set; }

        public bool? kargo_iptal { get; set; }

        public short? kargo_fileid { get; set; }

        public bool? kargo_hidden { get; set; }

        public bool? kargo_kilitli { get; set; }

        public bool? kargo_degisti { get; set; }

        public int? kargo_checksum { get; set; }

        public short? kargo_create_user { get; set; }

        public DateTime? kargo_create_date { get; set; }

        public short? kargo_lastup_user { get; set; }

        public DateTime? kargo_lastup_date { get; set; }

        [StringLength(4)]
        public string kargo_special1 { get; set; }

        [StringLength(4)]
        public string kargo_special2 { get; set; }

        [StringLength(4)]
        public string kargo_special3 { get; set; }

        public byte? kargo_sirkettipi { get; set; }

        public DateTime? kargo_gonderitarihi { get; set; }

        [StringLength(25)]
        public string kargo_alicikodu { get; set; }

        public int? kargo_aliciadresno { get; set; }

        public int? kargo_varisdepono { get; set; }

        public int? kargo_evraktabloid { get; set; }

        public byte? kargo_evraktipi { get; set; }

        public byte? kargo_evrakcinsi { get; set; }

        [StringLength(6)]
        public string kargo_evraknoseri { get; set; }

        public int? kargo_evraknosira { get; set; }

        [StringLength(20)]
        public string kargo_evrakbelgeno { get; set; }

        public int? kargo_evrakrecnosu { get; set; }

        public double? kargo_kargoadedi { get; set; }

        public double? kargo_evrakbedeli { get; set; }

        public byte? kargo_evrtahsilattipi { get; set; }

        [StringLength(50)]
        public string kargo_ozelalan { get; set; }

        public byte? kargo_gonderiakibeti { get; set; }

        public byte? kargo_gonderitipi { get; set; }

        public byte? kargo_gonderiyikimodeyecek { get; set; }

        public int? kargo_mastergonderino { get; set; }
    }
}
