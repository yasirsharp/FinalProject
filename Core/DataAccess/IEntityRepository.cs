using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

//İsim Uzayı
namespace Core.DataAccess
{
    /*Generic Constraint*/
    //class     : referans tip 
    //IEntity   : IEntity 
    //new()     : newlenebilir olmalı.
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}