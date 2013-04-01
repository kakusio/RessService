using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using mvc4.Models.Entities;

namespace mvc4.Controllers
{

	public class AnalisisController : Controller
	{
		public ActionResult Get()
		{
			List<Analisis> analisis;
			using (var entities = new Medics())
			{
				analisis = entities.Analisis.ToList();
			}
			var AnalisisView = analisis.Select( x=> x.ToObject());
			return Json(AnalisisView, JsonRequestBehavior.AllowGet);
		}
	}
}