namespace HizliSatis.model2
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STOK_SATIS_FIYAT_LISTELERI
    {
        [Key]
        public int sfiyat_RECno { get; set; }

        public short sfiyat_RECid_DBCno { get; set; }

        public int sfiyat_RECid_RECno { get; set; }

        public int? sfiyat_SpecRECno { get; set; }

        public bool? sfiyat_iptal { get; set; }

        public short? sfiyat_fileid { get; set; }

        public bool? sfiyat_hidden { get; set; }

        public bool? sfiyat_kilitli { get; set; }

        public bool? sfiyat_degisti { get; set; }

        public int? sfiyat_checksum { get; set; }

        public short? sfiyat_create_user { get; set; }

        public DateTime? sfiyat_create_date { get; set; }

        public short? sfiyat_lastup_user { get; set; }

        public DateTime? sfiyat_lastup_date { get; set; }

        [StringLength(4)]
        public string sfiyat_special1 { get; set; }

        [StringLength(4)]
        public string sfiyat_special2 { get; set; }

        [StringLength(4)]
        public string sfiyat_special3 { get; set; }

        [StringLength(25)]
        public string sfiyat_stokkod { get; set; }

        public int? sfiyat_listesirano { get; set; }

        public int? sfiyat_deposirano { get; set; }

        public int? sfiyat_odemeplan { get; set; }

        public double? sfiyat_fiyati { get; set; }

        public byte? sfiyat_doviz { get; set; }

        [StringLength(4)]
        public string sfiyat_iskontokod { get; set; }

        public byte? sfiyat_deg_nedeni { get; set; }

        public double? sfiyat_primyuzdesi { get; set; }

        [StringLength(4)]
        public string sfiyat_kampanyakod { get; set; }
    }
}
