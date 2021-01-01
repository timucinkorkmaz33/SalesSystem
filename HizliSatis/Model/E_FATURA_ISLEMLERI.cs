namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class E_FATURA_ISLEMLERI
    {
        [Key]
        public int efi_RECno { get; set; }

        public short efi_RECid_DBCno { get; set; }

        public int efi_RECid_RECno { get; set; }

        public int? efi_SpecRECno { get; set; }

        public bool? efi_iptal { get; set; }

        public short? efi_fileid { get; set; }

        public bool? efi_hidden { get; set; }

        public bool? efi_kilitli { get; set; }

        public bool? efi_degisti { get; set; }

        public int? efi_checksum { get; set; }

        public short? efi_create_user { get; set; }

        public DateTime? efi_create_date { get; set; }

        public short? efi_lastup_user { get; set; }

        public DateTime? efi_lastup_date { get; set; }

        [StringLength(4)]
        public string efi_special1 { get; set; }

        [StringLength(4)]
        public string efi_special2 { get; set; }

        [StringLength(4)]
        public string efi_special3 { get; set; }

        public byte? efi_tip { get; set; }

        [StringLength(6)]
        public string efi_evrakno_seri { get; set; }

        public int? efi_evrakno_sira { get; set; }

        public byte? efi_evrak_tipi { get; set; }

        [StringLength(40)]
        public string efi_gib_seri_sira { get; set; }

        [StringLength(40)]
        public string efi_uuid { get; set; }

        public bool? efi_onaylandi_fl { get; set; }

        public short? efi_OnaylayanKulNo { get; set; }

        public DateTime? efi_onaylama_tarihi { get; set; }

        public byte? efi_islem_tipi { get; set; }

        public int? efi_yazdirma_sayisi { get; set; }

        public bool? efi_fpgonderildi_fl { get; set; }
    }
}
