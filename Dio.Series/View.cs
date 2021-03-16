using System;
using Dio.Series.Entities;
using System.Collections.Generic;
using System.Text;
using Dio.Series.Entities.Enums;

namespace Dio.Series
{
    static class View
    {
        public static string Menu()
        {
            Console.WriteLine("\n" +
                "DIO Séries a seu dispor!!!\n" +
                "Informe a opção desejada: \n" +
                "\n" +
                "1 - Listar séries\n" +
                "2 - Inserir nova série\n" +
                "3 - Atualizar série\n" +
                "4 - Excluir série\n" +
                "5 - Visualizar série\n" +
                "C - Limpar Tela\n" +
                "X - Sair\n");

            Console.Write("Sua resposta: ");
            return Console.ReadLine().ToUpper();
        }

        public static void ListTvSeries(SerieRepository repo)
        {

            Console.WriteLine("Listar Séries\n");

            var list = repo.List();

            if (list.Count == 0)
            {
                Console.WriteLine("Nunhuma série cadastrada.");
                return;
            }

            foreach (var serie in list)
            {
                ConsoleColor defaultColor = Console.ForegroundColor;

                if (serie.Deleted == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"#ID {serie.ReturnId()}: - {serie.ReturnTitle()} - Excluído");
                }
                else
                {
                    Console.ForegroundColor = defaultColor;
                    Console.WriteLine($"#ID {serie.ReturnId()}: - {serie.ReturnTitle()}");
                }

                Console.ForegroundColor = defaultColor;

            }
        }

        public static void InsertTvSerie(SerieRepository repo)
        {
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int genreInput = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string titleInput = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int yearInput = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string descriptionInput = Console.ReadLine();

            TvSeries newTvSerie = new TvSeries(repo.NextId(), (Genre)genreInput, titleInput, descriptionInput, yearInput);

            repo.Create(newTvSerie);
        }

        public static void UpdateTvSerie(SerieRepository repo)
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genre), i)}");
            }

            Console.Write("Digite o genêro entre as opções acima: ");
            int genreInput = int.Parse(Console.ReadLine());

            Console.Write("Digite o título da série: ");
            string titleInput = Console.ReadLine();

            Console.Write("Digite o ano de início da série: ");
            int yearInput = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da série: ");
            string descriptionInput = Console.ReadLine();

            TvSeries updateTvSerie = new TvSeries(id, (Genre)genreInput, titleInput, descriptionInput, yearInput);

            repo.Update(id, updateTvSerie);
        }

        public static void DeleteTvSerie(SerieRepository repo)
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            repo.Delete(id);
        }

        public static void ViewSeries(SerieRepository repo)
        {
            Console.Write("Digite o ID da série: ");
            int id = int.Parse(Console.ReadLine());

            var serie = repo.ReturnById(id);

            Console.WriteLine(serie);
        }
    }
}
