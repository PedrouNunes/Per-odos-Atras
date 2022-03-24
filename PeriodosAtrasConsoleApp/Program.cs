using System;

namespace PeriodosAtrasConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite uma data: ");
            string data = Console.ReadLine();

            DateTime dataDoDia = Convert.ToDateTime(data);

            TimeSpan diasDeDiferenca = DateTime.Now - dataDoDia;

            double segundos = diasDeDiferenca.TotalSeconds;
            double horas = diasDeDiferenca.TotalHours;
            double minutos = diasDeDiferenca.TotalMinutes;
            double dias = diasDeDiferenca.TotalDays;
         



            Console.WriteLine("dias: " + dias + ", horas: " + horas + ", minutos: " + minutos + ", segundos: " + segundos);


        }
    }
}
