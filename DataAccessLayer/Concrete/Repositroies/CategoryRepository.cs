using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repostroies
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Writer> _object;


        public void Delete(Writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
            //throw new NotImplementedException();

        }

        public void Delete(Category p)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Writer p)
        {
            _object.Add(p);
            c.SaveChanges(); //burda tanımlanmış olan entityframeworkkde klasilk adonette ne kullanıolır ?
            //hata göndermez cunku voidthrow new NotImplementedException();
        }

        public void Insert(Category p)
        {
            throw new NotImplementedException();
        }

        public List<Writer> List()
        {

            return _object.ToList();
           //bunu silecez geriye deger dondurez isek hata verir throw new NotImplementedException();
        }

        public List<Writer> List(Expression<Func<Writer, bool>> filter)
        {
            throw new NotImplementedException();
        } //yeni eklenen ınterface ozelligini implemet eder buraga getirirlir 

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Writer p)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            throw new NotImplementedException();
        }

        List<Category> IRepository<Category>.List()
        {
            throw new NotImplementedException();
        }
        //tolist ad removve


    }
}
