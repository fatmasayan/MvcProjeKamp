using BusniessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositroies;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusniessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {

        ICategoryDal _categoryDal; //file oluşturduk
        private EfCategoryDal efCategoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal; 
        }

        public CategoryManager(EfCategoryDal efCategoryDal)
        {
            this.efCategoryDal = efCategoryDal;
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Insert(category); //ekleme işlemi çalışır kontroller yapılmalaı validatiyon kurallar
        }

        //public void CategoryDelete(Category category)
        //{
        //    _categoryDal.Delete(category); //ıdye eşit olan categoryi komple silecek
        //}

        //public void CategoryUpdate(Category category)
        //{
        //    _categoryDal.Update(category);
        //}

        public Category GetByID(int id)
        {
           return _categoryDal.Get(x => x.CategoryID == id); //iden gelen degre eşit olup olmadıgını
        }

        public List<Category> GetList()
        {
            return _categoryDal.List(); //HATA /////////////////efCategoryDal
        }

    }

}
 