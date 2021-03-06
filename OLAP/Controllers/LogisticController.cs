﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OLAP.Models;


namespace OLAP.Controllers
{
    public class LogisticController : Controller
    {
        //
        // GET: /managment/


        managmentEntities entities = new managmentEntities();
        managmentEntities context2 = new managmentEntities();// для фио клиента

        public ActionResult Managment()
        {

            return View(model: entities.Заказы.ToList());
        }


        public ActionResult DetailsOrder(int? ЗаказID)
        {
            if (ЗаказID == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }

            var OrderedGoods = entities.ЗаказаноТоваров.ToArray();

            List<ЗаказаноТоваров> lst1 = new List<ЗаказаноТоваров>();

            foreach (var item in OrderedGoods)
            {
                if (ЗаказID == item.ЗаказID)
                {
                    lst1.Add(item);
                }
            }

            if (lst1 == null)
            {
                return HttpNotFound();
            }
            return View(lst1);
        }  //детали по заказу (что заказно)


        public ActionResult AddOrder() { return View(); }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddOrder([Bind(Include = "СрокПоставки, ДатаЗаказа, КлиентID, МестоНазначения, СостояниеID, " +
               "ДатаДоставки, ТрСредствоID, ВодительID")]Заказы заказы)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    entities.Заказы.Add(заказы);
                    entities.SaveChanges();
                    return RedirectToAction("Managment");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View(заказы);
        }



        public ActionResult AddGoodInOrder() //добавление товара в заказ
        {

            return View();

        }

        public ActionResult ChangeGoodInOrder() //изменение товара в заказ
        {

            return View();

        }

        public ActionResult DeleteGoodInOrder() //удаление товара из заказ
        {

            return View();

        }





        public ActionResult
            ClientsControl() //Управление клиентами
        {

            return View(model: entities.Клиенты.ToList());

        }
               

        public ActionResult
        DriversControl() //Управление водителями 
        {

            return View(model: entities.Водители.ToList());

        }

        public ActionResult
             VihecleControl() //Управление транспортными средставами 
        {

            return View(model: entities.ТранспортноеСредство.ToList());

        }


        public ActionResult
            WarehouseControl() //Управление складом
        {

            return View(model: entities.СкладТоваров.ToList());

        }




    }
}
