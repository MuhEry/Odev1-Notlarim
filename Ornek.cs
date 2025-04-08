using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string sayilar = "sayilar.txt";
        string polindrom = "polindrom.txt";
        string diger = "diger.txt";
        Random uret = new Random();
        using (StreamWriter sayiYaz = new StreamWriter(sayilar))
        {
            for (int i = 1; i < 1000; i++)
            {
                sayiYaz.WriteLine(uret.Next(1,1000));
            }
        }
        using (StreamReader sayiOku = new StreamReader(sayilar))
        using (StreamWriter polYaz = new StreamWriter(polindrom))
        using (StreamWriter digerYaz = new StreamWriter(diger))
        {
            string satir;
            while ((satir = sayiOku.ReadLine()) != null)
            {
                char[] sayi = satir.ToCharArray();
                Array.Reverse(sayi);
                string ters = new string(sayi);
                if(Convert.ToInt32(satir)== Convert.ToInt32(ters))
                {
                    polYaz.WriteLine(satir);
                }
                else
                {
                    digerYaz.WriteLine(satir);
                }
            }
        }

    }
}