using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AKM.Models;

namespace AKM.Controllers
{
    public class StatisticsController : Controller
    {
        private readonly ApplicationDbContext db;
        public StatisticsController()
        {

            db = new ApplicationDbContext();
        }

        // GET: Statistics
        public ActionResult Index()
        {
            var moviesToGener = (from m in db.Movies
                           join r in db.Rentals on m.Id equals r.Movie.Id
                           select m).ToList();
            var Items1 = moviesToGener.GroupBy(l => l.Id).Select(cl => new
            {
                name = cl.First().Name,
                quan = cl.Sum(x => 1)
            }).ToList();


            var membershipTypesToCustomers = (from o in db.Customers
                        join s in db.MembershipTypes
                        on o.MembershipType equals s
                        select new
                        {
                            name = s.Name,
                            quantity = o.Id
                        }).ToList();
            var Items2 = membershipTypesToCustomers.GroupBy(l => l.name)
                .Select(cl => new
                {
                    name = cl.First().name,
                    quan = cl.Sum(c => 1)
                }).ToList();



            List<string> namesOfItems1 = new List<string>();
            List<int> quantityOfItems1 = new List<int>();
            List<string> namesOfItems2 = new List<string>();
            List<int> quantityOfItems2 = new List<int>();
            foreach (var i in Items1)
            {
                namesOfItems1.Add(i.name);
                quantityOfItems1.Add(i.quan);
            }
            foreach (var s in Items2)
            {
                namesOfItems2.Add(s.name);
                quantityOfItems2.Add(s.quan);
            }
            ViewBag.namesOfItems1 = namesOfItems1;
            ViewBag.quantityOfItems1 = quantityOfItems1;
            ViewBag.namesOfItems2 = namesOfItems2;
            ViewBag.quantityOfItems2 = quantityOfItems2;
            return View();
        }
    }
}