//1. feladat: Készítsen konzolos alkalmazást a következő feladatok megoldására, amelynek projektjét Toto néven mentse el!
namespace Toto
{
    internal class Program
    {
        static List<TotoData> dataList = new();
        static void Main(string[] args)
        {
            string[] inputs = File.ReadAllLines("toto.txt");
            for (int i = 1; i < inputs.Length; i++)
            {
                TotoData data = new TotoData(inputs[i]);
                dataList.Add(data);
            }
            //3. feladat: Határozza meg és írja ki a képernyőre, hány forduló adatai találhatók a forrásállományban!
            Console.WriteLine($"3. feladat: Fordulók száma: {dataList.Count}");

            //4. feladat: Számolja meg és írja ki a képernyőre a telitalálatos szelvények számát!
            double sum = 0;
            for (int i = 0; i < dataList.Count; i++)
            {
                sum += dataList[i].T13p1;
            }
            Console.WriteLine($"4. feladat: Telilatálatos szelvények száma: {sum}db");

            /*5. feladat: Számítsa ki, mekkora volt a „telitalálatos” (T13p1>0 vagy Ny13p1>0) fordulók során 
                a telitalálatos szelvényekre kifizetett nyereményösszegek átlaga!Egy fordulóban a
                nyereményösszeget a T13p1* Ny13p1 kifejezéssel számolja!Ügyeljen rá, hogy
                a telitalálatos fordulók során a telitalálatos szelvényekre kifizetett nyereményösszegek
                összege nem fér el egy 32 bites egész változóban.Az átlagot egész számra kerekítve
                jelenítse meg!*/
            List<double> items = new();
            for (int i = 0; i < dataList.Count; i++)
            {
                double temp = dataList[i].T13p1 * dataList[i].Ny13p1;
                if (dataList[i].T13p1 > 0)
                {
                    items.Add(temp);
                }
            }
            double avg = items.Sum() / dataList.Count;
            Console.WriteLine($"5. feladat: Átlag: {Math.Round(avg, 0)} Ft");

            /*6. feladat: Írja ki annak a két fordulónak az adatait a minta szerint, ahol a legnagyobb és a legkisebb 
                volt az egy telitalálatos szelvény után fizetett nyeremény!Feltételezheti, hogy nem
                alakult ki holtverseny a két szélsőértéknél és nem fordult olyan elő, hogy a telitalálatos
                szelvény után ne fizettek volna nyereményt!*/
            int max = 0;
            int min = 0;
            for (int i = 1; i < dataList.Count; i++)
            {
                if (dataList[max].Ny13p1 < dataList[i].Ny13p1)
                {
                    max = i;
                }
                if (dataList[min].T13p1 == 0)
                {
                    min = i;
                }
                else if (dataList[min].Ny13p1 > dataList[i].Ny13p1 && dataList[i].T13p1 != 0)
                {
                    min = i;
                }
            }
            Console.WriteLine($"6. feladat: " +
                $"\n\tLegnagyobb: " +
                $"\n\tÉv: {dataList[max].Ev}" +
                $"\n\tHét: {dataList[max].Het}." +
                $"\n\tForduló: {dataList[max].Fordulo}." +
                $"\n\tTelitalálat: {dataList[max].T13p1} db" +
                $"\n\tNyeremény: {max} Ft" +
                $"\n\tEredmények: {dataList[max].Eredmenyek}" +
                $"\n\n\tLegkisebb: " +
                $"\n\tÉv: {dataList[min].Ev}" +
                $"\n\tHét: {dataList[min].Het}." +
                $"\n\tForduló: {dataList[min].Fordulo}." +
                $"\n\tTelitalálat: {dataList[min].T13p1} db" +
                $"\n\tNyeremény: {min} Ft" +
                $"\n\tEredmények: {dataList[min].Eredmenyek}");

            /*8. feladat: Az EredmenyElemzo osztály példányainak alkalmazásával döntse el, hogy volt-e 
                olyan forduló, ahol a 13 + 1 mérkőzés eredménye nem tartalmazott döntetlent! A keresést
                ne folytassa, ha a választ meg tudja adni! A megállapítását írja a képernyőre!*/
            bool draw = false;
            for (int i = 0; i < dataList.Count; i++)
            {
                EredmenyElemzo search = new EredmenyElemzo(dataList[i].Eredmenyek);
                if (search.NemvoltDontetlenMerkozes == true)
                {
                    draw = true;
                }
            }
            if (draw)
            {
                Console.WriteLine("8. feladat: Volt dönteltlen nélküli forduló!");
            }
            else
            {
                Console.WriteLine("8. feladat: Nem volt dönteltlen nélküli forduló!");
            }

            Console.ReadKey();
        }
    }
}
