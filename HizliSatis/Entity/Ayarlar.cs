using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Entity
{
    [Table("Ayarlar")]
    public class Ayarlar
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Nakit_Seri_No { get; set; }
        [StringLength(50)]
        public string Depo_Kodu { get; set; }
        [StringLength(50)]
        public string Cari_Kodu { get; set; }
        public DateTime Kurulum_Tarihi { get; set; }
        
        [StringLength(50)]
        public string Plasiyer_Kodu { get; set; }
        [StringLength(50)]
        public string Sifre { get; set; }
        [StringLength(50)]
        public string Kasa_Seri { get; set; }

        [StringLength(50)]
        public string Nakit_Kasa_Kodu { get; set; }
        [StringLength(50)]
        public string KKart_Kasa_Kodu { get; set; }
        [StringLength(50)]
        public string KKart_Kasa_Aciklama { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil1_Kodu { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil1_Aciklama { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil2_Kodu { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil2_Aciklama { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil3_Kodu { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil3_Aciklama { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil4_Kodu { get; set; }
        [StringLength(50)]
        public string Odeme_Sekil4_Aciklama { get; set; }


    }
}
