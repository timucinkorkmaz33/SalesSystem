namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAKINA_HAREKETLERI
    {
        [Key]
        public int mkh_RECno { get; set; }

        public short mkh_RECid_DBCno { get; set; }

        public int mkh_RECid_RECno { get; set; }

        public int? mkh_SpecRECno { get; set; }

        public bool? mkh_iptal { get; set; }

        public short? mkh_fileid { get; set; }

        public bool? mkh_hidden { get; set; }

        public bool? mkh_kilitli { get; set; }

        public bool? mkh_degisti { get; set; }

        public int? mkh_checksum { get; set; }

        public short? mkh_create_user { get; set; }

        public DateTime? mkh_create_date { get; set; }

        public short? mkh_lastup_user { get; set; }

        public DateTime? mkh_lastup_date { get; set; }

        [StringLength(4)]
        public string mkh_special1 { get; set; }

        [StringLength(4)]
        public string mkh_special2 { get; set; }

        [StringLength(4)]
        public string mkh_special3 { get; set; }

        [StringLength(6)]
        public string mkh_Evrno_seri { get; set; }

        public int? mkh_Evrno_Sira { get; set; }

        public int? mkh_Satir_no { get; set; }

        [StringLength(25)]
        public string mkh_mak_kodu { get; set; }

        [StringLength(25)]
        public string mkh_Mak_srn_kodu { get; set; }

        public DateTime? mkh_Durma_zaman { get; set; }

        public DateTime? mkh_Kalkma_zaman { get; set; }

        [StringLength(50)]
        public string mkh_Aciklama { get; set; }

        [StringLength(25)]
        public string mkh_Yetkiliop { get; set; }

        [StringLength(25)]
        public string mkh_Bakimelm { get; set; }
    }
}
