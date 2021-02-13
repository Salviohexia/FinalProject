using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class,IEntity,new()                                          //generic constraint-jenerik kısıt   // class : referans tip olabilir
    {                                                                                                          //new() : new'lenebilir olmalı kısıtı
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
