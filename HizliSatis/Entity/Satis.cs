using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Entity
{
    [Table("Satis")]
    public partial class Satis
    {
        public int Id { get; set; }
        [StringLength(25)]
        public string sat_musteri_kod { get; set; }
        [StringLength(25)]
        public string sat_stok_kod { get; set; }
        [StringLength(50)]
        public string sat_b_fiyat { get; set; }
    
        public double? sat_miktar { get; set; }

        public double? sat_tutar { get; set; }
       
        public double? sat_toplam { get; set; }
        public double? sat_vergi3 { get; set; }
        public double? sat_vergi4 { get; set; }
        public decimal sat_vergi { get; set; }
      
        public double? sat_vergi_tutar { get; set; }
     
        public string sat_urun_adi { get; set; }
        [StringLength(50)]
        public string sat_barkod_no { get; set; }
        [StringLength(50)]
        public string sat_evrak_seri { get; set; }
      
        public int sat_evrak_sira { get; set; }
      
        public DateTime sat_tarih { get; set; }
      
        public int sat_durum { get; set; }
        [StringLength(50)]
        public string sat_depo { get; set; }
        [StringLength(25)]
        public string sat_plasiyer_kod { get; set; }
        [StringLength(25)]
        public string sat_srm_merkezi { get; set; }
        
        public decimal sat_cinsi { get; set; }
        public int sat_satirno { get; set; }
        public double? sat_IndirimMiktari { get; set; }
        public double? sat_satirindirim { get; set; }
    }
}
