namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BEDEN_HAREKETLERI
    {
        [Key]
        public int BdnHar_RECno { get; set; }

        public short BdnHar_RECid_DBCno { get; set; }

        public int BdnHar_RECid_RECno { get; set; }

        public int? BdnHar_Spec_Rec_no { get; set; }

        public bool? BdnHar_iptal { get; set; }

        public short? BdnHar_fileid { get; set; }

        public bool? BdnHar_hidden { get; set; }

        public bool? BdnHar_kilitli { get; set; }

        public bool? BdnHar_degisti { get; set; }

        public int? BdnHar_checksum { get; set; }

        public short? BdnHar_create_user { get; set; }

        public DateTime? BdnHar_create_date { get; set; }

        public short? BdnHar_lastup_user { get; set; }

        public DateTime? BdnHar_lastup_date { get; set; }

        [StringLength(4)]
        public string BdnHar_special1 { get; set; }

        [StringLength(4)]
        public string BdnHar_special2 { get; set; }

        [StringLength(4)]
        public string BdnHar_special3 { get; set; }

        public byte? BdnHar_Tipi { get; set; }

        public short? BdnHar_DRECid_DBCno { get; set; }

        public int? BdnHar_DRECid_RECno { get; set; }

        public short? BdnHar_BedenNo { get; set; }

        public double? BdnHar_HarGor { get; set; }

        public double? BdnHar_KnsIsGor { get; set; }

        public double? BdnHar_KnsFat { get; set; }

        public double? BdnHar_TesMik { get; set; }

        public double? BdnHar_rezervasyon_miktari { get; set; }

        public double? BdnHar_rezerveden_teslim_edilen { get; set; }
    }
}
