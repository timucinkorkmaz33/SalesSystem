namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CARI_HAREKETLER_SATIS_MALIYETLERI
    {
        [Key]
        public int stmly_RECno { get; set; }

        public short stmly_RECid_DBCno { get; set; }

        public int stmly_RECid_RECno { get; set; }

        public int? stmly_SpecRECno { get; set; }

        public bool? stmly_iptal { get; set; }

        public short? stmly_fileid { get; set; }

        public bool? stmly_hidden { get; set; }

        public bool? stmly_kilitli { get; set; }

        public bool? stmly_degisti { get; set; }

        public int? stmly_checksum { get; set; }

        public short? stmly_create_user { get; set; }

        public DateTime? stmly_create_date { get; set; }

        public short? stmly_lastup_user { get; set; }

        public DateTime? stmly_lastup_date { get; set; }

        [StringLength(4)]
        public string stmly_special1 { get; set; }

        [StringLength(4)]
        public string stmly_special2 { get; set; }

        [StringLength(4)]
        public string stmly_special3 { get; set; }

        public short? stmly_chrecid_dbcno { get; set; }

        public int? stmly_chrecid_recno { get; set; }

        public double? stmly_uretim_ana { get; set; }

        public double? stmly_uretim_alt { get; set; }

        public double? stmly_arastirmagelistirme_750_ana { get; set; }

        public double? stmly_arastirmagelistirme_750_alt { get; set; }

        public double? stmly_pazarlamasatis_760_ana { get; set; }

        public double? stmly_pazarlamasatis_760_alt { get; set; }

        public double? stmly_genelyonetim_770_ana { get; set; }

        public double? stmly_genelyonetim_770_alt { get; set; }

        public double? stmly_finansman_780_ana { get; set; }

        public double? stmly_finansman_780_alt { get; set; }

        public double? stmly_diger_ana { get; set; }

        public double? stmly_diger_alt { get; set; }
    }
}
