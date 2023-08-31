using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Abstract
{
    public interface ICategoryService
    {
        //listeleme metodu çağır fulendvalidationa balgıcam
        List<Category> GetList();
        void CategoryAdd(Category category);
        Category GetByID(int id); //silme işlemnide  kullanmak için spesifikleştiroyruz
        //void CategoryDelete(Category category);
       // void CategoryUpdate(Category category);
    }
}