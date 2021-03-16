using System;
using System.Collections.Generic;
using System.Text;
using Dio.Series.Entities.Enums;

namespace Dio.Series.Entities
{
    public class TvSeries : BaseEntity
    {
        public Genre Genre { get; private set; }
        private string Title;
        public string Description { get; private set; }
        public int Year { get; private set; }
        public bool Deleted { get; private set; }

        public TvSeries(int id, Genre genre, string title, string description, int year) : base(id)
        {
            Genre = genre;
            Title = title;
            Description = description;
            Year = year;
            Deleted = false;
        }

        public string ReturnTitle()
        {
            return Title;
        }

        public int ReturnId()
        {
            return Id;
        }

        public void isDeleted()
        {
            Deleted = true;
        }

        public override string ToString()
        {
            return $"Gênero: {Genre}\n" +
                   $"Título: {Title}\n" +
                   $"Descrição: {Description}\n" +
                   $"Ano de Início: {Year}\n" +
                   $"Excluído: {Deleted}";
        }
    }
}
