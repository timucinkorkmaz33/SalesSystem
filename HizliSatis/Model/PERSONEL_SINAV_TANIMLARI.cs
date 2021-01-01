namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_SINAV_TANIMLARI
    {
        [Key]
        public int snv_RECno { get; set; }

        public short snv_RECid_DBCno { get; set; }

        public int snv_RECid_RECno { get; set; }

        public int? snv_SpecRECno { get; set; }

        public bool? snv_iptal { get; set; }

        public short? snv_fileid { get; set; }

        public bool? snv_hidden { get; set; }

        public bool? snv_kilitli { get; set; }

        public bool? snv_degisti { get; set; }

        public int? snv_checksum { get; set; }

        public short? snv_create_user { get; set; }

        public DateTime? snv_create_date { get; set; }

        public short? snv_lastup_user { get; set; }

        public DateTime? snv_lastup_date { get; set; }

        [StringLength(4)]
        public string snv_special1 { get; set; }

        [StringLength(4)]
        public string snv_special2 { get; set; }

        [StringLength(4)]
        public string snv_special3 { get; set; }

        [StringLength(25)]
        public string snv_kodu { get; set; }

        [StringLength(40)]
        public string snv_adi { get; set; }

        public double? snv_maxpuan { get; set; }

        public byte? snv_tipi { get; set; }

        public byte? snv_kapsam { get; set; }

        [StringLength(25)]
        public string snv_nitelik { get; set; }

        public int? snvt_suresi { get; set; }
    }
}
