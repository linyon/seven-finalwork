using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MemberController : Controller
    {
        private string title;
        public string Tilte
        {
            get
            {

                return title;
            }
            set
            {
                if (value.Length > 50)
                    this.title = value.Substring(0, 50);
                this.title = value;
            }
        }
        public int Age { get; set; }




        public MemberController()
        {


        }
        public MemberController(string id):this()
        {
            var t = this.title;
        }


        // GET: Member
        public ActionResult MemberIndex(string id)
        {
            var items = new List<string>();
            items.Add("1");

            var itemWhere= new List<string>();
            for (int i = 0; i < items.Count; i++)
            {
                var item = items[i];
                if (item == "1")
                    itemWhere.Add(item);
            }

            itemWhere = items.Where(x => x == "1").ToList();

            







            return View();
        }
        public ActionResult Create()
        {
           // var ctrl = new MemberController();
            
           // ctrl.Tilte = "123";
           // var t = ctrl.Tilte;

            return View();
        }
        public ActionResult Edit()
        {



            return View();
        }
        public ActionResult Download()
        {
            string filename = "D:\\1014\\105-1軟體工程\\分組名單.txt";
            return File(filename, "application/pdf");
           // return View();
            //return this.File()
        }
    }
}