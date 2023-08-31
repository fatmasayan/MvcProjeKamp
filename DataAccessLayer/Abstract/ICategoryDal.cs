using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal:IRepository<Category>
    {

        //CRUD operatorlerını birir metod olarak tanımlanacak
        //Type Name() -> metod olusturmak

        //listeleme <listelenecek olan entity>
        //List<Writer> List();

        //void Insert(Writer p); //ekleme işlemini gerçekleitrirken parametre olarak category s ınızdan al
    
        //void Update(Writer p);

        //void Delete(Writer p);

        //gidip yeni sınıf oluşturup bu metodların görevlerini yazıcaz oraya
    
        //örnek olarak kalsın 

    }
}
