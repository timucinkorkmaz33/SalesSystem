namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVM_SAYAC_HAREKETLERI
    {
        [Key]
        public int Avmsh_RECNo { get; set; }

        public short Avmsh_RECid_DBCno { get; set; }

        public int Avmsh_RECid_RECno { get; set; }

        public int? Avmsh_SpecRECno { get; set; }

        public bool? Avmsh_iptal { get; set; }

        public short? Avmsh_fileid { get; set; }

        public bool? Avmsh_hidden { get; set; }

        public bool? Avmsh_kilitli { get; set; }

        public bool? Avmsh_degisti { get; set; }

        public int? Avmsh_checksum { get; set; }

        public short? Avmsh_create_user { get; set; }

        public DateTime? Avmsh_create_date { get; set; }

        public short? Avmsh_lastup_user { get; set; }

        public DateTime? Avmsh_lastup_date { get; set; }

        [StringLength(4)]
        public string Avmsh_special1 { get; set; }

        [StringLength(4)]
        public string Avmsh_special2 { get; set; }

        [StringLength(4)]
        public string Avmsh_special3 { get; set; }

        public byte? Avmsh_turu { get; set; }

        public int? Avmsh_firma_no { get; set; }

        public int? Avmsh_sube_no { get; set; }

        public DateTime? Avmsh_tarihi { get; set; }

        [StringLength(6)]
        public string Avmsh_evrakno_seri { get; set; }

        public int? Avmsh_evrakno_sira { get; set; }

        public int? Avmsh_satirno { get; set; }

        [StringLength(20)]
        public string Avmsh_belge_no { get; set; }

        public DateTime? Avmsh_belge_tarih { get; set; }

        [StringLength(25)]
        public string Avmsh_sayackodu { get; set; }

        public double? Avmsh_sonokuma { get; set; }

        public short? Avmsh_fat_recid_dbcno { get; set; }

        public int? Avmsh_fat_recid_recno { get; set; }

        [StringLength(40)]
        public string Avmsh_aciklama { get; set; }

        public short? Avmsh_kaltut_fat_recid_dbcno { get; set; }

        public int? Avmsh_kaltut_fat_recid_recno { get; set; }

        public short? Avmsh_merkez_sayac_recid_dbcno { get; set; }

        public int? Avmsh_merkez_sayac_recid_recno { get; set; }

        public short? Avmsh_yansitma_dekont_recid_dbcno { get; set; }

        public int? Avmsh_yansitma_dekont_recid_recno { get; set; }

        public double? Avmsh_kayipyuzdesi { get; set; }
    }
}
