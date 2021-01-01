namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class URETIM_OPERASYON_CALISANLARI
    {
        [Key]
        public int opc_RECno { get; set; }

        public short opc_RECid_DBCno { get; set; }

        public int opc_RECid_RECno { get; set; }

        public int? opc_SpecRECNo { get; set; }

        public bool? opc_iptal { get; set; }

        public short? opc_fileid { get; set; }

        public bool? opc_hidden { get; set; }

        public bool? opc_kilitli { get; set; }

        public bool? opc_degisti { get; set; }

        public int? opc_CheckSum { get; set; }

        public short? opc_create_user { get; set; }

        public DateTime? opc_create_date { get; set; }

        public short? opc_lastup_user { get; set; }

        public DateTime? opc_lastup_date { get; set; }

        [StringLength(4)]
        public string opc_special1 { get; set; }

        [StringLength(4)]
        public string opc_special2 { get; set; }

        [StringLength(4)]
        public string opc_special3 { get; set; }

        public short? opc_OpTamamRecID_DBCno { get; set; }

        public int? opc_OpTamamRecID_RECno { get; set; }

        [StringLength(25)]
        public string opc_PersonelKodu { get; set; }

        public int? opc_CalistigiSure { get; set; }
    }
}
