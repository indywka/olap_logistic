using System;
using System.Collections.Generic;
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
        }  //детали по заказу (что заказно)  + добавить фио, назв. товара.. тс...


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

    }
}
