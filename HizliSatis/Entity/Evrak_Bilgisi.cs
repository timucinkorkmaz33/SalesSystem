using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HizliSatis.Entity
{
    [Table("Evrak_Bilgisi")]
    public class Evrak_Bilgisi
    {
        public int Id { get; set; }
        public int? Sira_No { get; set; }
        public DateTime? Tarih { get; set; }
    }
}
