namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAKIM_SARFIYATLARI
    {
        [Key]
        public int bsrf_RECno { get; set; }

        public short bsrf_RECid_DBCno { get; set; }

        public int bsrf_RECid_RECno { get; set; }

        public int? bsrf_Spec_Rec_no { get; set; }

        public bool? bsrf_iptal { get; set; }

        public short? bsrf_fileid { get; set; }

        public bool? bsrf_hidden { get; set; }

        public bool? bsrf_kilitli { get; set; }

        public bool? bsrf_degisti { get; set; }

        public int? bsrf_checksum { get; set; }

        public short? bsrf_create_user { get; set; }

        public DateTime? bsrf_create_date { get; set; }

        public short? bsrf_lastup_user { get; set; }

        public DateTime? bsrf_lastup_date { get; set; }

        [StringLength(4)]
        public string bsrf_special1 { get; set; }

        [StringLength(4)]
        public string bsrf_special2 { get; set; }

        [StringLength(4)]
        public string bsrf_special3 { get; set; }

        public int? bsrf_firmano { get; set; }

        public int? bsrf_subeno { get; set; }

        public DateTime? bsrf_evraktarihi { get; set; }

        [StringLength(6)]
        public string bsrf_evrakseri { get; set; }

        public int? bsrf_evraksira { get; set; }

        public int? bsrf_evraksatir { get; set; }

        [StringLength(20)]
        public string bsrf_belgeno { get; set; }

        public DateTime? bsrf_belge_tarih { get; set; }

        [StringLength(25)]
        public string bsrf_isemri { get; set; }

        [StringLength(25)]
        public string bsrf_StokKodu { get; set; }

        public double? bsrf_Miktar { get; set; }

        public byte? bsrf_birim_pntr { get; set; }

        [StringLength(40)]
        public string bsrf_aciklama { get; set; }

        [StringLength(25)]
        public string bsrf_proje { get; set; }

        [StringLength(25)]
        public string bsrf_srmmrkkodu { get; set; }
    }
}
