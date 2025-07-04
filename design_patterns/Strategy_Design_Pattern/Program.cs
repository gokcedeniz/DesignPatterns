using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IOdemeYontemi
{
    void Odeme(float ucret);
}

public class NakitOdeme : IOdemeYontemi
{
    public void Odeme(float ucret)
    {
        Console.WriteLine("Nakit ödeme alındı.");
    }
}

public class KartlaOdeme : IOdemeYontemi
{
    public void Odeme (float ucret)
    {
        Console.WriteLine("Kartla ödeme alındı.");
    }
}

public class HavaleİleOdeme: IOdemeYontemi
{
    public void Odeme (float ucret)
    {
        Console.WriteLine("Havale ile ödeme alındı.");
    }
}

public class OdemeAlici
{
    private IOdemeYontemi _odemeyontemi;

    public OdemeAlici(IOdemeYontemi odemeyontemi)
    {
        _odemeyontemi = odemeyontemi;
    }

    public void OdemeYap(float ucret)
    {
        _odemeyontemi.Odeme(ucret);
    }
    public void YontemDegistir(IOdemeYontemi yeniYontem)
    {
        _odemeyontemi = yeniYontem;
    }
}
namespace Strategy_Design_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OdemeAlici kasa = new OdemeAlici(new NakitOdeme());
            kasa.OdemeYap(100);  // Nakit ödeme alındı.

            kasa.YontemDegistir(new KartlaOdeme());
            kasa.OdemeYap(250);  // Kartla ödeme alındı.

            kasa.YontemDegistir(new HavaleİleOdeme());
            kasa.OdemeYap(350);  // Havale ile ödeme alındı.

            Console.ReadLine();
        }
    }
}
