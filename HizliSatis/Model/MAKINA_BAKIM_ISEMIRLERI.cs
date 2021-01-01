namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAKINA_BAKIM_ISEMIRLERI
    {
        [Key]
        public int makisem_RECno { get; set; }

        public short makisem_RECid_DBCno { get; set; }

        public int makisem_RECid_RECno { get; set; }

        public int? makisem_SpecRecno { get; set; }

        public bool? makisem_iptal { get; set; }

        public short? makisem_fileid { get; set; }

        public bool? makisem_hidden { get; set; }

        public bool? makisem_kilitli { get; set; }

        public bool? makisem_degisti { get; set; }

        public int? makisem_checksum { get; set; }

        public short? makisem_create_user { get; set; }

        public DateTime? makisem_create_date { get; set; }

        public short? makisem_lastup_user { get; set; }

        public DateTime? makisem_lastup_date { get; set; }

        [StringLength(4)]
        public string makisem_special1 { get; set; }

        [StringLength(4)]
        public string makisem_special2 { get; set; }

        [StringLength(4)]
        public string makisem_special3 { get; set; }

        [StringLength(25)]
        public string makisem_kod { get; set; }

        [StringLength(90)]
        public string makisem_isim { get; set; }

        [StringLength(70)]
        public string makisem_aciklama { get; set; }

        [StringLength(25)]
        public string makisem_makina_kod { get; set; }

        [StringLength(25)]
        public string makisem_sorun_kod { get; set; }

        [StringLength(25)]
        public string makisem_acan_per { get; set; }

        public DateTime? makisem_bas_zaman { get; set; }

        [StringLength(25)]
        public string makisem_kapatan_per { get; set; }

        public DateTime? makisem_bit_zaman { get; set; }

        public byte? makisem_durumu { get; set; }

        [StringLength(120)]
        public string makisem_aciklama1 { get; set; }

        [StringLength(120)]
        public string makisem_aciklama2 { get; set; }

        [StringLength(120)]
        public string makisem_aciklama3 { get; set; }
    }
}
