using System;
using System.Collections.Generic;
using System.Text;

namespace Dio.Series.Entities
{
    public abstract class BaseEntity
    {
        protected int Id;

        protected BaseEntity(int id)
        {
            Id = id;
        }
    }
}
