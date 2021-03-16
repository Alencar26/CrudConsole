using System;
using System.Collections.Generic;
using Dio.Series.Entities.Interfaces;

namespace Dio.Series.Entities
{
    class SerieRepository : IRepository<TvSeries>
    {
        private List<TvSeries> seriesList = new List<TvSeries>();

        public void Create(TvSeries entity)
        {
            seriesList.Add(entity);
        }

        public void Update(int id, TvSeries entity)
        {
            seriesList[id] = entity;
        }

        public void Delete(int id)
        {
            seriesList[id].isDeleted();
            // seriesList.RemoveAll(x => x.Equals(id));
        }

        public List<TvSeries> List()
        {
            return seriesList;
        }

        public int NextId()
        {
            return seriesList.Count;
        }

        public TvSeries ReturnById(int id)
        {
            return seriesList[id];
        }
    }
}
