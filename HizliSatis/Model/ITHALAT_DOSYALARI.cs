namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ITHALAT_DOSYALARI
    {
        [Key]
        public int ith_RECno { get; set; }

        public short ith_RECid_DBCno { get; set; }

        public int ith_RECid_RECno { get; set; }

        public int? ith_SpecRecNo { get; set; }

        public bool? ith_iptal { get; set; }

        public short? ith_fileid { get; set; }

        public bool? ith_hidden { get; set; }

        public bool? ith_kilitli { get; set; }

        public bool? ith_degisti { get; set; }

        public int? ith_checksum { get; set; }

        public short? ith_create_user { get; set; }

        public DateTime? ith_create_date { get; set; }

        public short? ith_lastup_user { get; set; }

        public DateTime? ith_lastup_date { get; set; }

        [StringLength(4)]
        public string ith_special1 { get; set; }

        [StringLength(4)]
        public string ith_special2 { get; set; }

        [StringLength(4)]
        public string ith_special3 { get; set; }

        public int? ith_firmano { get; set; }

        public int? ith_subeno { get; set; }

        [StringLength(25)]
        public string ith_kodu { get; set; }

        [StringLength(40)]
        public string ith_ismi { get; set; }

        [StringLength(25)]
        public string ith_satici { get; set; }

        public byte? ith_ulketipi { get; set; }

        [StringLength(4)]
        public string ith_ulkekodu { get; set; }

        [StringLength(4)]
        public string ith_gumrukkodu { get; set; }

        public byte? ith_teslimsekli { get; set; }

        public byte? ith_odemesekli { get; set; }

        public byte? ith_carigrupno { get; set; }

        public byte? ith_dovizcinsi { get; set; }

        [StringLength(25)]
        public string ith_Araci_Banka { get; set; }

        public DateTime? ith_GGB_tarihi { get; set; }

        [StringLength(30)]
        public string ith_GGB_no { get; set; }

        public byte? ith_tasimasekli { get; set; }

        [StringLength(20)]
        public string ith_vasitano { get; set; }

        [StringLength(25)]
        public string ith_nakliyeci { get; set; }

        [StringLength(25)]
        public string ith_gumrukmusaviri { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_1 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_2 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_3 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_4 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_5 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_6 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_7 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_8 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_9 { get; set; }

        [StringLength(40)]
        public string ith_MuhKodu_10 { get; set; }

        public byte? ith_MalDagitimSekli1 { get; set; }

        public byte? ith_MalDagitimSekli2 { get; set; }

        public byte? ith_MalDagitimSekli3 { get; set; }

        public byte? ith_MalDagitimSekli4 { get; set; }

        public byte? ith_MalDagitimSekli5 { get; set; }

        public byte? ith_MalDagitimSekli6 { get; set; }

        public byte? ith_MalDagitimSekli7 { get; set; }

        public byte? ith_MalDagitimSekli8 { get; set; }

        public byte? ith_MalDagitimSekli9 { get; set; }

        public byte? ith_MalDagitimSek10 { get; set; }

        [StringLength(25)]
        public string ith_MuhGrupKodu { get; set; }

        [StringLength(40)]
        public string ith_MalBedeliMuhKodu { get; set; }

        public byte? ith_Mense_ulketipi { get; set; }

        [StringLength(4)]
        public string ith_Mense_ulkekodu { get; set; }

        [StringLength(25)]
        public string ith_Araci_CariKodu { get; set; }

        [StringLength(25)]
        public string ith_Akreditif { get; set; }

        public bool? ith_kilitli_fl { get; set; }
    }
}
