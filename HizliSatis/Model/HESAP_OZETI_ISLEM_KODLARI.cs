namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class HESAP_OZETI_ISLEM_KODLARI
    {
        [Key]
        public int ehoz_RECno { get; set; }

        public short ehoz_RECid_DBCno { get; set; }

        public int ehoz_RECid_RECno { get; set; }

        public int? ehoz_SpecRECno { get; set; }

        public bool? ehoz_iptal { get; set; }

        public short? ehoz_fileid { get; set; }

        public bool? ehoz_hidden { get; set; }

        public bool? ehoz_kilitli { get; set; }

        public bool? ehoz_degisti { get; set; }

        public int? ehoz_checksum { get; set; }

        public short? ehoz_create_user { get; set; }

        public DateTime? ehoz_create_date { get; set; }

        public short? ehoz_lastup_user { get; set; }

        public DateTime? ehoz_lastup_date { get; set; }

        [StringLength(4)]
        public string ehoz_special1 { get; set; }

        [StringLength(4)]
        public string ehoz_special2 { get; set; }

        [StringLength(4)]
        public string ehoz_special3 { get; set; }

        public byte? ehoz_bankahesapcinsi { get; set; }

        [StringLength(25)]
        public string ehoz_bankahesapkodu { get; set; }

        public int? ehoz_satirno { get; set; }

        [StringLength(50)]
        public string ehoz_islemkodu { get; set; }

        [StringLength(50)]
        public string ehoz_islemaciklamasi { get; set; }

        public byte? ehoz_karsihesapcinsi { get; set; }

        [StringLength(25)]
        public string ehoz_karsihesapkodu { get; set; }

        public byte? ehoz_karsihesapgrupno { get; set; }

        public byte? ehoz_evraktipi { get; set; }

        public byte? ehoz_stfonpntr { get; set; }

        [StringLength(6)]
        public string ehoz_evrakseri { get; set; }

        [StringLength(25)]
        public string ehoz_faturacirocarikodu { get; set; }

        [StringLength(25)]
        public string ehoz_srmmrk { get; set; }

        [StringLength(25)]
        public string ehoz_proje { get; set; }

        public byte? ehoz_mfis_kisaevraktipi { get; set; }

        public byte? ehoz_mfis_satistipi { get; set; }

        public byte? ehoz_mfis_alistipi { get; set; }

        public byte? ehoz_mfis_tahtedtipi { get; set; }

        [StringLength(50)]
        public string ehoz_mfis_digerevrakadi { get; set; }

        [StringLength(25)]
        public string ehoz_satici_kodu { get; set; }
    }
}
