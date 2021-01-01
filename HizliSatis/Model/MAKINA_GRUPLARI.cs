namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MAKINA_GRUPLARI
    {
        [Key]
        public int makg_RECno { get; set; }

        public short makg_RECid_DBCno { get; set; }

        public int makg_RECid_RECno { get; set; }

        public int? makg_SpecRECno { get; set; }

        public bool? makg_iptal { get; set; }

        public short? makg_fileid { get; set; }

        public bool? makg_hidden { get; set; }

        public bool? makg_kilitli { get; set; }

        public bool? makg_degisti { get; set; }

        public int? makg_checksum { get; set; }

        public short? makg_create_user { get; set; }

        public DateTime? makg_create_date { get; set; }

        public short? makg_lastup_user { get; set; }

        public DateTime? makg_lastup_date { get; set; }

        [StringLength(4)]
        public string makg_special1 { get; set; }

        [StringLength(4)]
        public string makg_special2 { get; set; }

        [StringLength(4)]
        public string makg_special3 { get; set; }

        [StringLength(25)]
        public string makg_kodu { get; set; }

        [StringLength(90)]
        public string makg_aciklama { get; set; }
    }
}
