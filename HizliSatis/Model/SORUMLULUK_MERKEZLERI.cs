namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SORUMLULUK_MERKEZLERI
    {
        [Key]
        public int som_RECno { get; set; }

        public short som_RECid_DBCno { get; set; }

        public int som_RECid_RECno { get; set; }

        public int? som_SpecRECno { get; set; }

        public bool? som_iptal { get; set; }

        public short? som_fileid { get; set; }

        public bool? som_hidden { get; set; }

        public bool? som_kilitli { get; set; }

        public bool? som_degisti { get; set; }

        public int? som_checksum { get; set; }

        public short? som_create_user { get; set; }

        public DateTime? som_create_date { get; set; }

        public short? som_lastup_user { get; set; }

        public DateTime? som_lastup_date { get; set; }

        [StringLength(4)]
        public string som_special1 { get; set; }

        [StringLength(4)]
        public string som_special2 { get; set; }

        [StringLength(4)]
        public string som_special3 { get; set; }

        [StringLength(25)]
        public string som_kod { get; set; }

        [StringLength(40)]
        public string som_isim { get; set; }

        public bool? som_DogrudanUrtSrmMrk { get; set; }

        public byte? som_MasrafNereyeYuklenecek { get; set; }

        [StringLength(25)]
        public string som_DagAnahKodu { get; set; }

        [StringLength(10)]
        public string som_MuhArtikeli { get; set; }

        public byte? som_MaliyetDagitimSekli { get; set; }

        public byte? som_MaliyetDagitimKaynak { get; set; }

        public byte? som_tipi { get; set; }

        public int? som_satis_fiyat_liste_no { get; set; }
    }
}
