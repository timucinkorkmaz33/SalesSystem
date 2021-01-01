namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UFRS_SOZLESMELERI
    {
        [Key]
        public int usoz_RECno { get; set; }

        public short usoz_RECid_DBCno { get; set; }

        public int usoz_RECid_RECno { get; set; }

        public int? usoz_SpecRECno { get; set; }

        public bool? usoz_iptal { get; set; }

        public short? usoz_fileid { get; set; }

        public bool? usoz_hidden { get; set; }

        public bool? usoz_kilitli { get; set; }

        public bool? usoz_degisti { get; set; }

        public int? usoz_checksum { get; set; }

        public short? usoz_create_user { get; set; }

        public DateTime? usoz_create_date { get; set; }

        public short? usoz_lastup_user { get; set; }

        public DateTime? usoz_lastup_date { get; set; }

        [StringLength(4)]
        public string usoz_special1 { get; set; }

        [StringLength(4)]
        public string usoz_special2 { get; set; }

        [StringLength(4)]
        public string usoz_special3 { get; set; }

        public byte? usoz_siptip { get; set; }

        public byte? usoz_sipcins { get; set; }

        [StringLength(6)]
        public string usoz_sipevrakseri { get; set; }

        public int? usoz_sipevraksira { get; set; }

        [StringLength(127)]
        public string usoz_aciklama { get; set; }

        public DateTime? usoz_siptarih { get; set; }

        [StringLength(25)]
        public string usoz_sipcarikodu { get; set; }

        public byte? usoz_sipcarigrupno { get; set; }

        public double? usoz_faizorani { get; set; }

        public int? usoz_odemeplani { get; set; }

        public double? usoz_toplamtutar { get; set; }

        public byte? usoz_dovizcinsi { get; set; }

        public byte? usoz_sozlesmetipi { get; set; }

        public byte? usoz_mulkiyetnereden { get; set; }

        public byte? usoz_vadenereden { get; set; }

        public DateTime? usoz_mulkiyettarihi { get; set; }
    }
}
