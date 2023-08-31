using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositroies
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        //önemli kontstraktırkullanılcak  objeye deger atamsı atamak için t ye karşılık gelen sınıf bulmak lazım
        Context c =new Context();
       
        DbSet<T> _object;
        
        public GenericRepository()
        {
            _object = c.Set<T>(); //dışarıdan gelen  T değerini objecte atadık
            //deger ataması
        }

        public void Delete(T p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter); //sadece bir deger dondurmak için kullanılan
        }

        public void Insert(T p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
           return _object.Where(filter).ToList();
        }

        //public void Update(T p)
        //{
        //    c.SaveChanges();
        //}

        //public static implicit operator GenericRepository<T>(GenericRepository<Category> v)
        //{
        //    throw new NotImplementedException();
        //}
    }
 
}
