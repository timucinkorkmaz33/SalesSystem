namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CIHAZ_HAREKETLERI
    {
        [Key]
        public int ChHar_RECno { get; set; }

        public short ChHar_RECid_DBCno { get; set; }

        public int ChHar_RECid_RECno { get; set; }

        public int? ChHar_Spec_Rec_no { get; set; }

        public bool? ChHar_iptal { get; set; }

        public short? ChHar_fileid { get; set; }

        public bool? ChHar_hidden { get; set; }

        public bool? ChHar_kilitli { get; set; }

        public bool? ChHar_degisti { get; set; }

        public int? ChHar_checksum { get; set; }

        public short? ChHar_create_user { get; set; }

        public DateTime? ChHar_create_date { get; set; }

        public short? ChHar_lastup_user { get; set; }

        public DateTime? ChHar_lastup_date { get; set; }

        [StringLength(4)]
        public string ChHar_special1 { get; set; }

        [StringLength(4)]
        public string ChHar_special2 { get; set; }

        [StringLength(4)]
        public string ChHar_special3 { get; set; }

        [StringLength(25)]
        public string ChHar_SeriNo { get; set; }

        [StringLength(25)]
        public string ChHar_StokKodu { get; set; }

        public byte? ChHar_master_tablo { get; set; }

        public short? ChHar_master_dbcno { get; set; }

        public int? ChHar_master_recno { get; set; }

        public bool? ChHar_rezerve_fl { get; set; }
    }
}
