using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositroies;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFrameWork
{
    //katmanlar içierisinedki sınıfları birbiriyle iletişime geçiriyorum
    public class EfCategoryDal:GenericRepository<Category>,ICategoryDal
    {
         
    }
}
