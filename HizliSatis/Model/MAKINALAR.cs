namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MAKINALAR")]
    public partial class MAKINALAR
    {
        [Key]
        public int mak_RECno { get; set; }

        public short mak_RECid_DBCno { get; set; }

        public int mak_RECid_RECno { get; set; }

        public int? mak_SpecRecno { get; set; }

        public bool? mak_iptal { get; set; }

        public short? mak_fileid { get; set; }

        public bool? mak_hidden { get; set; }

        public bool? mak_kilitli { get; set; }

        public bool? mak_degisti { get; set; }

        public int? mak_checksum { get; set; }

        public short? mak_create_user { get; set; }

        public DateTime? mak_create_date { get; set; }

        public short? mak_lastup_user { get; set; }

        public DateTime? mak_lastup_date { get; set; }

        [StringLength(4)]
        public string mak_special1 { get; set; }

        [StringLength(4)]
        public string mak_special2 { get; set; }

        [StringLength(4)]
        public string mak_special3 { get; set; }

        [StringLength(25)]
        public string mak_kod { get; set; }

        [StringLength(40)]
        public string mak_ozel_isim { get; set; }

        [StringLength(25)]
        public string mak_grup_kod { get; set; }

        public DateTime? mak_altar { get; set; }

        public double? mak_fiat { get; set; }

        public double? mak_bakim { get; set; }

        public DateTime? mak_sonbakim_tarih { get; set; }

        public short? mak_bakim_sure { get; set; }

        public bool? mak_ariza { get; set; }

        public double? mak_mesgul_sure { get; set; }

        public double? mak_topcal_sure { get; set; }

        [StringLength(25)]
        public string mak_servis_kod { get; set; }

        [StringLength(25)]
        public string mak_atik_kod { get; set; }

        public double? mak_masraf { get; set; }

        public short? mak_son_reserv { get; set; }

        public double? mak_bek_sure { get; set; }

        [StringLength(127)]
        public string mak_aciklama { get; set; }
    }
}
