namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IHRACAT_DOSYALARI
    {
        [Key]
        public int ihr_RECno { get; set; }

        public short ihr_RECid_DBCno { get; set; }

        public int ihr_RECid_RECno { get; set; }

        public int? ihr_SpecRecNo { get; set; }

        public bool? ihr_iptal { get; set; }

        public short? ihr_fileid { get; set; }

        public bool? ihr_hidden { get; set; }

        public bool? ihr_kilitli { get; set; }

        public bool? ihr_degisti { get; set; }

        public int? ihr_checksum { get; set; }

        public short? ihr_create_user { get; set; }

        public DateTime? ihr_create_date { get; set; }

        public short? ihr_lastup_user { get; set; }

        public DateTime? ihr_lastup_date { get; set; }

        [StringLength(4)]
        public string ihr_special1 { get; set; }

        [StringLength(4)]
        public string ihr_special2 { get; set; }

        [StringLength(4)]
        public string ihr_special3 { get; set; }

        public int? ihr_firmano { get; set; }

        public int? ihr_subeno { get; set; }

        [StringLength(25)]
        public string ihr_kodu { get; set; }

        [StringLength(40)]
        public string ihr_ismi { get; set; }

        [StringLength(25)]
        public string ihr_Satici { get; set; }

        public byte? ihr_UlkeTipi { get; set; }

        [StringLength(4)]
        public string ihr_UlkeKodu { get; set; }

        [StringLength(4)]
        public string ihr_GumrukKodu { get; set; }

        public byte? ihr_TeslimSekli { get; set; }

        public byte? ihr_OdemeSekli { get; set; }

        public byte? ihr_carigrupno { get; set; }

        public byte? ihr_DovizCinsi { get; set; }

        [StringLength(25)]
        public string ihr_AraciBanka { get; set; }

        public DateTime? ihr_GCB_Tarihi { get; set; }

        [StringLength(30)]
        public string ihr_GCB_No { get; set; }

        public byte? ihr_Tasima { get; set; }

        [StringLength(20)]
        public string ihr_VasitaNo { get; set; }

        [StringLength(25)]
        public string ihr_Nakliyeci { get; set; }

        [StringLength(25)]
        public string ihr_GumrukMusaviri { get; set; }

        public DateTime? ihr_Intac_Tarihi { get; set; }

        public byte? ihr_Cikis_UlkeTipi { get; set; }

        [StringLength(4)]
        public string ihr_Cikis_ulkekodu { get; set; }

        public byte? ihr_Mense_UlkeTipi { get; set; }

        [StringLength(4)]
        public string ihr_Mense_ulkekodu { get; set; }

        [StringLength(25)]
        public string ihr_Araci_CariKodu { get; set; }

        [StringLength(25)]
        public string ihr_Akreditif { get; set; }
    }
}
