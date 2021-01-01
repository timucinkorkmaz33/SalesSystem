namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ISLETME_HESAP_PLANI
    {
        [Key]
        public int dinm_RECno { get; set; }

        public short dinm_RECid_DBCno { get; set; }

        public int dinm_RECid_RECno { get; set; }

        public int? dinm_SpecRECno { get; set; }

        public bool? dinm_iptal { get; set; }

        public short? dinm_fileid { get; set; }

        public bool? dinm_hidden { get; set; }

        public bool? dinm_kilitli { get; set; }

        public bool? dinm_degisti { get; set; }

        public int? dinm_checksum { get; set; }

        public short? dinm_create_user { get; set; }

        public DateTime? dinm_create_date { get; set; }

        public short? dinm_lastup_user { get; set; }

        public DateTime? dinm_lastup_date { get; set; }

        [StringLength(4)]
        public string dinm_special1 { get; set; }

        [StringLength(4)]
        public string dinm_special2 { get; set; }

        [StringLength(4)]
        public string dinm_special3 { get; set; }

        [StringLength(25)]
        public string dinm_hesap_kod { get; set; }

        [StringLength(90)]
        public string dinm_hesap_isim1 { get; set; }

        [StringLength(90)]
        public string dinm_hesap_isim2 { get; set; }

        public byte? dinm_doviz_cinsi { get; set; }

        public bool? dinm_kurfarki_fl { get; set; }

        public byte? dinm_sorum_merk { get; set; }

        public DateTime? dinm_kilittarihi { get; set; }

        public byte? dinm_hes_dav_bicimi { get; set; }

        public byte? dinm_Hhtip { get; set; }

        public bool? dinm_HhVtip_fl { get; set; }

        public byte? dinm_HhVergi { get; set; }

        public byte? dinm_HhAsgKarGrubu { get; set; }

        public byte? dinm_HHtop_per { get; set; }

        public double? dinm_Hhiademeblag { get; set; }

        public byte? dinm_HVergiHesaplama { get; set; }

        public bool? dinm_miktar_oto_fl { get; set; }
    }
}
