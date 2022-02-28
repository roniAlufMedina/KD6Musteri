using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KD6Müşteri.Models;

namespace KD6Müşteri.Controllers
{
    public class CustomerController : Controller
    {
        [Route("müsteriliste")]
        [Route("müsteri/liste")]
        [Route("customer/index")]
        //  /customer/index
        // GET: CustomerController
        public ActionResult Index()
        {
            //MüşteriFabrikası.Fabrika
            return View(MüşteriFabrikası.Fabrika.MüşteriListesi);
        }
        //***SLUG 

        //*catchall bundan sonra yazılan herşey parametre text
        //? soru işareti optional buyüzden default girilmeli
        //[Route("müsteridetay/{MüşteriKodu?:int:range(1,100)}/{tarih:DateTime}/{müşteriAdı:maxlength(100)}")]
        // GET: CustomerController/Details/5
        [HttpGet]
        public ActionResult Details(int? MüşteriKodu )
        {
            Customer aranan;
            if (MüşteriKodu != null)
            {
                //Customer aranan =  MüşteriFabrikası.Fabrika.MüşteriListesi.Where<Customer>(a => a.ID == MüşteriKodu).SingleOrDefault<Customer>();
                //Customer aranan = MüşteriFabrikası.Fabrika.MüşteriListesi.FirstOrDefault<Customer>(a => a.ID == MüşteriKodu);
                aranan = MüşteriFabrikası.Fabrika.MüşteriListesi.Find(a => a.ID == MüşteriKodu);
            }
            else {
                aranan = MüşteriFabrikası.Fabrika.MüşteriListesi.FirstOrDefault<Customer>();
            }
            return View(aranan);
        }

        [Route("yenimüsteri")]
        // GET: CustomerController/Create
        //Yeni girş Ekranı Açılsın
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Customer() {Phone =new Phone() } );
        }

        [Route("/yenimüsteri/{extra}")]
        // POST: CustomerController/Create/6/23.2.22
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer yeni ,DateTime extra)
        {

            try
            {
                MüşteriFabrikası.Fabrika.MüşteriListesi.Add(yeni);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
