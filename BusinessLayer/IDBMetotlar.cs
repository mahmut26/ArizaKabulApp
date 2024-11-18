using Domain.DatabaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLayer
{
    public interface IDBMetotlar
    {
        Guid CihazKaydet(CihazKayit cihazKayit);
        string KayitGetir(string Email);

    }
}
