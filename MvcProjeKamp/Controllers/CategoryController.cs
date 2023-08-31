using BusniessLayer.Concrete;
using BusniessLayer.ValidationRules;
using DataAccessLayer.EntityFrameWork;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKamp.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()
        {
            var categoryvalues = cm.GetList(); //bisnues layerdeki sınıfı cagır 
            return View(categoryvalues); ///değişkenş atamış olugumuz degerler viw ile gelicek
        }

        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost] //sayfa birşey yaptıgım zaman çalışcak sayfa yuklendşgi zaman çalışması için get denir
        public ActionResult AddCategory(Category p)
        {
            // cm.CategoryAddBL(p);//post kullanılmazsa sayfa yuklenir yuklenmez burası çalışıyor otomatik boş şekild edolduruyor
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p); 
            if (results.IsValid)
            {
                cm.CategoryAdd(p); //koşulların konrtolü
                return RedirectToAction("GetCategoryList");
            }
            else 
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("GetCategoryList"); //ekleme işlemi gerçekleştirdiktn sonra tanımlamış oldugum metoda yonlendir
        }

        //[HttpGet]
        //public ActionResult EditCategory(int id)
        //{
        //    var categoryvalue = cm.GetByID(id);
        //    return View(categoryvalue);
        //}

    }
}