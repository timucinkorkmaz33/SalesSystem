namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BAKIM_PDI_TANIMLARI
    {
        [Key]
        public int bpdi_RECno { get; set; }

        public short bpdi_RECid_DBCno { get; set; }

        public int bpdi_RECid_RECno { get; set; }

        public int? bpdi_SpecRECno { get; set; }

        public bool? bpdi_iptal { get; set; }

        public short? bpdi_fileid { get; set; }

        public bool? bpdi_hidden { get; set; }

        public bool? bpdi_kilitli { get; set; }

        public bool? bpdi_degisti { get; set; }

        public int? bpdi_checksum { get; set; }

        public short? bpdi_create_user { get; set; }

        public DateTime? bpdi_create_date { get; set; }

        public short? bpdi_lastup_user { get; set; }

        public DateTime? bpdi_lastup_date { get; set; }

        [StringLength(4)]
        public string bpdi_special1 { get; set; }

        [StringLength(4)]
        public string bpdi_special2 { get; set; }

        [StringLength(4)]
        public string bpdi_special3 { get; set; }

        [StringLength(25)]
        public string bpdi_kodu { get; set; }

        public DateTime? bpdi_kontrol_tarihi { get; set; }

        [StringLength(25)]
        public string bpdi_stok_kodu { get; set; }

        [StringLength(25)]
        public string bpdi_cihaz_seri { get; set; }

        public int? bpdi_sayac { get; set; }

        [StringLength(25)]
        public string bpdi_gidecegi_cari { get; set; }

        [StringLength(25)]
        public string bpdi_perskodu { get; set; }

        public byte? bpdi_kontrol_sonucu { get; set; }

        [StringLength(60)]
        public string bpdi_aciklama1 { get; set; }

        [StringLength(60)]
        public string bpdi_aciklama2 { get; set; }
    }
}
