using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle_NotIdealCode;
class ParaGonderici
{
    public void Gonder(int tutar)
    {
        //Garanti garanti = new();
        //garanti.HesapNo = "...";
        //garanti.ParaGonder(tutar);
        Halkban halkban = new();
        halkban.GonderilecekHesapNo("123");
        halkban.Gonder(tutar);
    }
}

class Garanti
{
    public string HesapNo { get; set; }
    public void ParaGonder(int tutar)
    {
        //...
    }
}
class Halkban
{
    string _hesapNo;
    public void GonderilecekHesapNo(string hesapNo)
    {
        //...
    }
    public void Gonder(int tutar)
    {
        //...
    }
}