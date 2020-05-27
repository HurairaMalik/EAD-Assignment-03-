using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCCRUD.Models;

namespace MVCCRUD.Controllers
{
    public class FoodController : Controller
    {
       
        public ActionResult AddFood()
        {
            Food obj = new Food();
            return View("AddFood",obj);
        }
        [HttpPost]
        public ActionResult AddFood(Food obj)
        {
            MvcCrudEntities contex = new MvcCrudEntities();
            contex.customers.Add(new customer() { id=obj.id,name = obj.name, category=obj.category,price=obj.price });
            contex.SaveChanges();
           
            return View("AddFood", obj);
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowRecords()
        {
            MvcCrudEntities contex = new MvcCrudEntities();
            var showRecords=contex.customers.ToList();
            return View("ShowRecords",showRecords);
        }

        public ActionResult EditRecord(int cid)
        {
           MvcCrudEntities contex = new MvcCrudEntities();
           var editRecords = (from item in contex.customers
                              where item.id == cid
                              select item).First();
           return View("EditRecord", editRecords);
        }

        [HttpPost]
        public ActionResult EditRecord(customer obj)
        {
            MvcCrudEntities contex = new MvcCrudEntities();
            var editRecords = (from item in contex.customers
                               where item.id == obj.id
                               select item).First();
            editRecords.name = obj.name;
            editRecords.category = obj.category;
            editRecords.price = obj.price;
            contex.SaveChanges();

            var Records = contex.customers.ToList();
            return View("ShowRecords", Records);
        }







	}
}