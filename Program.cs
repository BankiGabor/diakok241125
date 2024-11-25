using diakok241125;
using System;

public enum Szakirany
{
    Info,
    Elektro,
    Rendesz
}

class Program
{

    static Random random = new Random();

    static string[] neveListaja = { "Kiss Péter", "Nagy Anna", "Tóth László", "Horváth Zoltán", "Szabó Erika" };
    static string[] tantargyListaja = { "Matematika", "Fizika", "Informatika", "Kémia", "Biológia" };

    static void Main()
    {
        Iskola iskola = new Iskola();

        for (int i = 0; i < 30; i++)
        {
            string neve = neveListaja[random.Next(neveListaja.Length)];
            Szakirany szak = (Szakirany)random.Next(0, 3);
            double atlag = Math.Round(random.NextDouble() * (5.0 - 1.0) + 1.0, 1);
            int eletkora = random.Next(14, 21);

            List<string> tantargyak = new List<string>();
            int tantargyCount = random.Next(1, 3);

            for (int j = 0; j < tantargyCount; j++)
            {
                string tantargy = tantargyListaja[random.Next(tantargyListaja.Length)];
                if (!tantargyak.Contains(tantargy))
                {
                    tantargyak.Add(tantargy);
                }
            }

            Diakok diak = new Diakok(neve, eletkora, szak, atlag, tantargyak);
            iskola.AddDiak(diak);
        }

        Console.WriteLine("Iskola létszáma: " + iskola.Letszam);
        Console.WriteLine("Iskola átlag életkora: " + Math.Round(iskola.AtlagEletkor, 2));

        foreach (var diak in iskola.Diakok)
        {
            Console.WriteLine(diak);
        }
    }
}
