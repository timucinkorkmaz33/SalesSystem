namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PERSONEL_AVANS_TALEPLERI
    {
        [Key]
        public int pat_RECno { get; set; }

        public short pat_RECid_DBCno { get; set; }

        public int pat_RECid_RECno { get; set; }

        public int? pat_SpecRECno { get; set; }

        public bool? pat_iptal { get; set; }

        public short? pat_fileid { get; set; }

        public bool? pat_hidden { get; set; }

        public bool? pat_kilitli { get; set; }

        public bool? pat_degisti { get; set; }

        public int? pat_checksum { get; set; }

        public short? pat_create_user { get; set; }

        public DateTime? pat_create_date { get; set; }

        public short? pat_lastup_user { get; set; }

        public DateTime? pat_lastup_date { get; set; }

        [StringLength(4)]
        public string pat_special1 { get; set; }

        [StringLength(4)]
        public string pat_special2 { get; set; }

        [StringLength(4)]
        public string pat_special3 { get; set; }

        [StringLength(25)]
        public string pat_personelkod { get; set; }

        public int? pat_maliyil { get; set; }

        public int? pat_satirno { get; set; }

        public byte? pat_avansayi { get; set; }

        public double? pat_avanstutari { get; set; }

        [StringLength(50)]
        public string pat_aciklamasi { get; set; }

        public byte? pat_durum { get; set; }

        public byte? pat_carihar_evraktip { get; set; }

        [StringLength(6)]
        public string pat_carihar_evrakseri { get; set; }

        public int? pat_carihar_evraksira { get; set; }
    }
}
