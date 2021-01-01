namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISTASYON_SAYAC_HAREKETLERI
    {
        [Key]
        public int sh_RECNo { get; set; }

        public short sh_RECid_DBCno { get; set; }

        public int sh_RECid_RECno { get; set; }

        public int? sh_SpecRECno { get; set; }

        public bool? sh_iptal { get; set; }

        public short? sh_fileid { get; set; }

        public bool? sh_hidden { get; set; }

        public bool? sh_kilitli { get; set; }

        public bool? sh_degisti { get; set; }

        public int? sh_checksum { get; set; }

        public short? sh_create_user { get; set; }

        public DateTime? sh_create_date { get; set; }

        public short? sh_lastup_user { get; set; }

        public DateTime? sh_lastup_date { get; set; }

        [StringLength(4)]
        public string sh_special1 { get; set; }

        [StringLength(4)]
        public string sh_special2 { get; set; }

        [StringLength(4)]
        public string sh_special3 { get; set; }

        public int? sh_firma_no { get; set; }

        public int? sh_sube_no { get; set; }

        [StringLength(25)]
        public string sh_kodu { get; set; }

        public double? sh_acilis { get; set; }

        public double? sh_kapanis { get; set; }

        public double? sh_aktarma { get; set; }

        public double? sh_birimfiyati { get; set; }

        public DateTime? sh_vardiyatarihi { get; set; }

        public byte? sh_vardiyano { get; set; }
    }
}
