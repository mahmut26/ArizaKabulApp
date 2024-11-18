using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DatabaseClass
{
    public class CihazKayit
    {
        [Key] 
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string CihazAdi { get; set; }
        public string Email { get; set; }

    }
}
