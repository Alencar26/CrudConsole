using System;
using Dio.Series.Entities;
using Dio.Series.Entities.Enums;

namespace Dio.Series
{
    class Program
    {
        static SerieRepository repo = new SerieRepository();

        static void Main(string[] args)
        {
            string optionUser = View.Menu();

            while (optionUser.ToUpper() != "X")
            {
                switch (optionUser)
                {
                    case "1":
                       View.ListTvSeries(repo);
                        break;
                    case "2":
                        View.InsertTvSerie(repo);
                        break;
                    case "3":
                        View.UpdateTvSerie(repo);
                        break;
                    case "4":
                        View.DeleteTvSerie(repo);
                        break;
                    case "5":
                        View.ViewSeries(repo);
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
                optionUser = View.Menu();
            }
        }
    }
}
