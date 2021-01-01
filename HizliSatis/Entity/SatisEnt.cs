namespace HizliSatis.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SatisEnt : DbContext
    {
        public SatisEnt()
            : base("name=SatisEnt")
        {
        }

        public virtual DbSet<CariSepet> CariSepet { get; set; }
        public virtual DbSet<KullaniciBilgileri> KullaniciBilgileri { get; set; }
        public virtual DbSet<RolTanimlari> RolTanimlari { get; set; }
        public virtual DbSet<Sepet> Sepet { get; set; }
        public virtual DbSet<ButonKisayolBilgileri> ButonKisayolBilgileri { get; set; }
        public virtual DbSet<Ayarlar> Ayarlar { get; set; }
        public virtual DbSet<Evrak_Bilgisi> Evrak_Bilgisi { get; set; }

        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<Tahsilat> Tahsilat { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
