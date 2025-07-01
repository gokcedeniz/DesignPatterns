using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//creational patterns: singleton
//default constructor is private
using System;

public class Counter
{
  
    private static Counter _instance;

    //Sayaç değişkeni
    private static int _count = 0;

    // constructor private olmalı
    private Counter() { }

    //Singleton'a dışarıdan erişim için static property
    public static Counter Instance
    {
        get
        {
            // Eğer nesne daha önce oluşturulmadıysa oluştur
            if (_instance == null)
                _instance = new Counter();

            // Aynı nesneyi döndür
            return _instance;
        }
    }

    //Sayacı artıran metot
    public void Increment()
    {
        _count++;
    }

    //Sayacın değerini döndürür
    public int GetCount()
    {
        return _count;
    }
}

namespace design_pattern_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Console.WriteLine("Başlangıç sayısı: " + Counter.Instance.GetCount());

            //Sayacı artır
            Counter.Instance.Increment();
            Counter.Instance.Increment();

            Console.WriteLine("Artış sonrası: " + Counter.Instance.GetCount());

            // Tekrar başka yerden erişim
            var c = Counter.Instance;
            c.Increment();

            Console.WriteLine("Son değer: " + c.GetCount()); 
        }
    }
}

