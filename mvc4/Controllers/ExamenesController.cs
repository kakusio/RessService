using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using mvc4.Models.Entities;
using mvc4.Models.EntitiesEditCreate;
using mvc4.Models.IEnumerables;

namespace mvc4.Controllers
{
	public class ExamenesController : Controller
	{
		public ActionResult Get(){
			List<Examenes> examenes;
			using (var entities = new Medics()){
				examenes = entities.Examenes.ToList();
			}
			var ExamenesView = examenes.Select(x => x.ToObject());
			return Json(ExamenesView, JsonRequestBehavior.AllowGet);
		}

		public ActionResult GetDetails(Guid id){
			List<Examenes> examenes;
			using (var entities = new Medics()){
				examenes = entities.Examenes.Where(x => x.IdPersona == id).ToList();
			}
			var ExamenesView = examenes.Select(x => x.ToObject());
			return Json(ExamenesView, JsonRequestBehavior.AllowGet);
		}

		public string Post([FromUri] ExamenesEditCreateModel examenes){
			examenes.Fecha = DateTime.Now;
			Mapper.CreateMap<ExamenesEditCreateModel, Examenes>();
			var examen = Mapper.Map<ExamenesEditCreateModel, Examenes>(examenes);
			using (var entities = new Medics()){
				try{
					entities.AddToExamenes(examen);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.CreacionCorrecta.Value;
		}

		public string Put(Guid id, [FromUri] ExamenesEditCreateModel Examene){
			using (var entities = new Medics()){
				try{
					var oldExamene = entities.Examenes.FirstOrDefault( x => x.IdPersona == id && x.idAnalisis == Examene.idAnalisis && x.Fecha == Examene.Fecha);
					if (oldExamene != null) oldExamene.Update(Examene);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.EdicionCorrecta.Value;
		}

		public string Delete(Guid id, [FromUri] ExamenesEditCreateModel Examene){
			using (var entities = new Medics()){
				try{
					var oldExamene =
						entities.Examenes.FirstOrDefault(
							x => x.IdPersona == id && x.idAnalisis == Examene.idAnalisis && x.Fecha == Examene.Fecha);
					entities.Examenes.DeleteObject(oldExamene);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.EliminacionCorrecta.Value;
		}
	}
}