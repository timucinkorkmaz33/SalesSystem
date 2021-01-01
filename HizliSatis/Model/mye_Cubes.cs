namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mye_Cubes
    {
        [Key]
        public int cube_id { get; set; }

        public short? cube_create_user { get; set; }

        public DateTime? cube_create_date { get; set; }

        public short? cube_lastup_user { get; set; }

        public DateTime? cube_lastup_date { get; set; }

        public short? cube_lastrun_user { get; set; }

        public DateTime? cube_lastrun_date { get; set; }

        public int? cube_lastrun_duration { get; set; }

        [StringLength(60)]
        public string cube_name { get; set; }

        public byte? cube_group { get; set; }

        [StringLength(1000)]
        public string cube_desc { get; set; }

        public bool? cube_hidden { get; set; }

        public bool? cube_locked { get; set; }

        [StringLength(255)]
        public string cube_filename { get; set; }

        public byte? cube_dateType { get; set; }

        public DateTime? cube_firstdate { get; set; }

        public DateTime? cube_lastdate { get; set; }

        public int? cube_dateN { get; set; }

        [StringLength(1000)]
        public string cube_firmastr { get; set; }

        public int? cube_maliyil { get; set; }

        public byte? cube_autorunpattern { get; set; }

        public int? cube_autorunperiod { get; set; }

        public DateTime? cube_autoruntime { get; set; }

        public int? cube_autorunselection { get; set; }

        [StringLength(1000)]
        public string cube_otherDBs { get; set; }

        public string cube_query { get; set; }
    }
}
