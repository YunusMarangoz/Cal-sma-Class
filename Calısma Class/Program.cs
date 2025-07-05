namespace Calısma_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sınıflar!");
            Arac arac = new Arac("Opel", "Corsa", 2025);
            arac.AlısFiyat = 400000;
            arac.SatisFiyat = 450000;
            arac.MaxindirimTutar = 25000;
            arac.FiyatAta(430000);
            arac.BilgileriGoruntule();
        }
    }
}
