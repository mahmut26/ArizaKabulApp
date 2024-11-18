using DataLayer.Database;
using Domain.DatabaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DBMetot : IDBMetotlar
    {
        public Guid CihazKaydet(CihazKayit cihazKayit)
        {
            using (var context = new DBContext())
            {
               cihazKayit.Id = Guid.NewGuid();

               context.cihazs.AddAsync(cihazKayit);

               context.SaveChangesAsync();

               var deger = cihazKayit.Id; 

               return deger;

            }
        }

        public string KayitGetir(string Email)
        {
            using (var context = new DBContext())
            {

                var a = context.cihazs.FirstOrDefault(x => x.Email == Email);

                if (a != null)
                {
                    return a.Id.ToString();
                }
                else
                {
                    return "Nesne bulunamadı";

                }
            }
        }
    }
}
