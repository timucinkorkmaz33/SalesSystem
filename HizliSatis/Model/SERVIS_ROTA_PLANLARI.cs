namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SERVIS_ROTA_PLANLARI
    {
        [Key]
        public int srpl_RECno { get; set; }

        public short srpl_RECid_DBCno { get; set; }

        public int srpl_RECid_RECno { get; set; }

        public int? srpl_SpecRECNo { get; set; }

        public bool? srpl_iptal { get; set; }

        public short? srpl_fileid { get; set; }

        public bool? srpl_hidden { get; set; }

        public bool? srpl_kilitli { get; set; }

        public bool? srpl_degisti { get; set; }

        public int? srpl_CheckSum { get; set; }

        public short? srpl_create_user { get; set; }

        public DateTime? srpl_create_date { get; set; }

        public short? srpl_lastup_user { get; set; }

        public DateTime? srpl_lastup_date { get; set; }

        [StringLength(4)]
        public string srpl_special1 { get; set; }

        [StringLength(4)]
        public string srpl_special2 { get; set; }

        [StringLength(4)]
        public string srpl_special3 { get; set; }

        [StringLength(25)]
        public string srpl_isemri_kodu { get; set; }

        public int? srpl_satirno { get; set; }

        [StringLength(25)]
        public string srpl_operasyon_kodu { get; set; }

        [StringLength(25)]
        public string srpl_atanan_ekip { get; set; }

        public int? srpl_planlanan_sure { get; set; }

        public int? srpl_tamamlanan_sure { get; set; }

        public double? srpl_planlanan_miktar { get; set; }

        public double? srpl_tutar { get; set; }

        public DateTime? srpl_planlanan_baslama_tarihi { get; set; }

        [StringLength(80)]
        public string srpl_aciklama { get; set; }

        public bool? srpl_garanti_dahili_fl { get; set; }

        public bool? srpl_onaylandi_fl { get; set; }

        public bool? srpl_kapandi_fl { get; set; }

        public double? srpl_iskonto { get; set; }
    }
}
