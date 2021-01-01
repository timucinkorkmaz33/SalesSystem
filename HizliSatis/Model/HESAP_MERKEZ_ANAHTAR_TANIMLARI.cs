namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HESAP_MERKEZ_ANAHTAR_TANIMLARI
    {
        [Key]
        public int hma_RECno { get; set; }

        public short hma_RECid_DBCno { get; set; }

        public int hma_RECid_RECno { get; set; }

        public int? hma_SpecRECNo { get; set; }

        public bool? hma_iptal { get; set; }

        public short? hma_fileid { get; set; }

        public bool? hma_hidden { get; set; }

        public bool? hma_kilitli { get; set; }

        public bool? hma_degisti { get; set; }

        public int? hma_CheckSum { get; set; }

        public short? hma_create_user { get; set; }

        public DateTime? hma_create_date { get; set; }

        public short? hma_lastup_user { get; set; }

        public DateTime? hma_lastup_date { get; set; }

        [StringLength(4)]
        public string hma_special1 { get; set; }

        [StringLength(4)]
        public string hma_special2 { get; set; }

        [StringLength(4)]
        public string hma_special3 { get; set; }

        [StringLength(25)]
        public string hma_hesap_kodu { get; set; }

        [StringLength(25)]
        public string hma_sor_merk_kodu { get; set; }

        [StringLength(25)]
        public string hma_dag_anah_kodu { get; set; }

        public byte? hma_maliyet_dagitim_sekli { get; set; }
    }
}
