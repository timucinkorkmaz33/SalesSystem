namespace HizliSatis.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KREDI_SOZLESMESI_TANIMLARI
    {
        [Key]
        public int krsoz_RECno { get; set; }

        public short krsoz_RECid_DBCno { get; set; }

        public int krsoz_RECid_RECno { get; set; }

        public int? krsoz_Spec_Rec_no { get; set; }

        public bool? krsoz_iptal { get; set; }

        public short? krsoz_fileid { get; set; }

        public bool? krsoz_hidden { get; set; }

        public bool? krsoz_kilitli { get; set; }

        public bool? krsoz_degisti { get; set; }

        public int? krsoz_checksum { get; set; }

        public short? krsoz_create_user { get; set; }

        public DateTime? krsoz_create_date { get; set; }

        public short? krsoz_lastup_user { get; set; }

        public DateTime? krsoz_lastup_date { get; set; }

        [StringLength(4)]
        public string krsoz_special1 { get; set; }

        [StringLength(4)]
        public string krsoz_special2 { get; set; }

        [StringLength(4)]
        public string krsoz_special3 { get; set; }

        [StringLength(25)]
        public string krsoz_kodu { get; set; }

        [StringLength(50)]
        public string krsoz_aciklama { get; set; }

        public int? krsoz_firmano { get; set; }

        public int? krsoz_subeno { get; set; }

        [StringLength(25)]
        public string krsoz_sozbankakodu { get; set; }

        public byte? krsoz_dovizcinsi { get; set; }

        public byte? krsoz_tipi { get; set; }

        public DateTime? krsoz_kullanimtarihi { get; set; }

        public double? krsoz_kreditutari { get; set; }

        public byte? krsoz_taksittipi { get; set; }

        public short? krsoz_taksitaraligi { get; set; }

        public short? krsoz_taksitsayisi { get; set; }

        public byte? krsoz_faiztipi { get; set; }

        public double? krsoz_faizorani { get; set; }

        public double? krsoz_bmsvorani { get; set; }

        public double? krsoz_kkdforani { get; set; }

        public double? krsoz_alinanucret { get; set; }

        [StringLength(40)]
        public string krsoz_anaparamuhkodu { get; set; }

        [StringLength(40)]
        public string krsoz_uvanaparamuhkodu { get; set; }

        [StringLength(40)]
        public string krsoz_kvtahakkukkodu { get; set; }

        [StringLength(40)]
        public string krsoz_uvtahakkukkodu { get; set; }

        [StringLength(40)]
        public string krsoz_faizmuhkodu { get; set; }

        [StringLength(40)]
        public string krsoz_bsmvmuhkodu { get; set; }

        [StringLength(40)]
        public string krsoz_kkdfmuhkodu { get; set; }

        [StringLength(40)]
        public string krsoz_ucretmuhkodu { get; set; }

        public double? krsoz_faiztutari { get; set; }

        public byte? krsoz_giderhesaptipi { get; set; }

        public byte? krsoz_gidertahakkuktipi { get; set; }

        [StringLength(25)]
        public string krsoz_dagitimanahtari { get; set; }

        public DateTime? krsoz_kapanistarihi { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi1 { get; set; }

        public double? krsoz_ftfaizorani1 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi2 { get; set; }

        public double? krsoz_ftfaizorani2 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi3 { get; set; }

        public double? krsoz_ftfaizorani3 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi4 { get; set; }

        public double? krsoz_ftfaizorani4 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi5 { get; set; }

        public double? krsoz_ftfaizorani5 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi6 { get; set; }

        public double? krsoz_ftfaizorani6 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi7 { get; set; }

        public double? krsoz_ftfaizorani7 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi8 { get; set; }

        public double? krsoz_ftfaizorani8 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi9 { get; set; }

        public double? krsoz_ftfaizorani9 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi10 { get; set; }

        public double? krsoz_ftfaizorani10 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi11 { get; set; }

        public double? krsoz_ftfaizorani11 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi12 { get; set; }

        public double? krsoz_ftfaizorani12 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi13 { get; set; }

        public double? krsoz_ftfaizorani13 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi14 { get; set; }

        public double? krsoz_ftfaizorani14 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi15 { get; set; }

        public double? krsoz_ftfaizorani15 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi16 { get; set; }

        public double? krsoz_ftfaizorani16 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi17 { get; set; }

        public double? krsoz_ftfaizorani17 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi18 { get; set; }

        public double? krsoz_ftfaizorani18 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi19 { get; set; }

        public double? krsoz_ftfaizorani19 { get; set; }

        public DateTime? krsoz_ftgecerliliktarihi20 { get; set; }

        public double? krsoz_ftfaizorani20 { get; set; }
    }
}
