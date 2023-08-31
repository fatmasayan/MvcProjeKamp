using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        //metodu burda oluştur Generik reepositoride metodun içini doldur

        //burada butun sınıflar için tek bir yapı kullanmak için oluşturulur
        List<T> List();

        void Insert(T p);

        T Get(Expression<Func<T, bool>> filter); //tek deger döndürmek içinkullanılır

        void Delete(T p);

        void Update(T p);

        List<T> List(Expression<Func<T, bool>> filter); //komple bir liste döndürür

        //buraya yeni bir öge ekledik mesela 
        //bu bir şartlı listeleme burdaadı sadece ali olan kişileri getir mesel
        //diger butun interfacelere kalıtsal olarak eklenir

    }
}
