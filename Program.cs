using System.Diagnostics;

namespace soru
{
    internal class Program


    //        kullanıcıya kac personel oldugunu sor , verilen cevaptan sonra her porsonel adını sor         ve diziye ekle türkce olarak kodu yaz
    //
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç personel olduğunu girin: ");
            int personelSayisi = Convert.ToInt32(Console.ReadLine());

            string[] personelAdlari = new string[personelSayisi];

            int i = 0;
            while (i < personelSayisi)
            {
                Console.Write($"Personel {i + 1} adını girin: ");
                string personelAdi = Console.ReadLine();
                personelAdlari[i] = personelAdi;
                i++;
            }

            Console.WriteLine("\nGirilen personel adları:");
            foreach (var ad in personelAdlari)
            {
                Console.WriteLine(ad);

            }
                }
    }
}

