namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_DEVAM_KONTROL
    {
        [Key]
        public int pdk_RECno { get; set; }

        public short pdk_RECid_DBCno { get; set; }

        public int pdk_RECid_RECno { get; set; }

        public int? pdk_SpecRECno { get; set; }

        public bool? pdk_iptal { get; set; }

        public short? pdk_fileid { get; set; }

        public bool? pdk_hidden { get; set; }

        public bool? pdk_kilitli { get; set; }

        public bool? pdk_degisti { get; set; }

        public int? pdk_checksum { get; set; }

        public short? pdk_create_user { get; set; }

        public DateTime? pdk_create_date { get; set; }

        public short? pdk_lastup_user { get; set; }

        public DateTime? pdk_lastup_date { get; set; }

        [StringLength(4)]
        public string pdk_special1 { get; set; }

        [StringLength(4)]
        public string pdk_special2 { get; set; }

        [StringLength(4)]
        public string pdk_special3 { get; set; }

        [StringLength(25)]
        public string pdk_kod { get; set; }

        public DateTime? pdk_zaman { get; set; }

        public byte? pdk_tip { get; set; }

        [StringLength(4)]
        public string pdk_takvimkodu { get; set; }

        [StringLength(25)]
        public string pdk_vardiyakodu { get; set; }

        public byte? pdk_vardiyano { get; set; }

        [StringLength(25)]
        public string pdk_projekodu { get; set; }

        [StringLength(25)]
        public string pdk_sormerkodu { get; set; }

        [StringLength(25)]
        public string pdk_nedenkodu { get; set; }

        [StringLength(25)]
        public string pdk_ismerkezikodu { get; set; }
    }
}
