namespace HizliSatis.model2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BARKOD_TANIMLARI> BARKOD_TANIMLARI { get; set; }
        public virtual DbSet<STOKLAR> STOKLAR { get; set; }
        public virtual DbSet<STOK_SATIS_FIYAT_LISTELERI> STOK_SATIS_FIYAT_LISTELERI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
