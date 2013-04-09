using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using mvc4.Models.Entities;
using mvc4.Models.EntitiesView;
using mvc4.Models.IEnumerables;

namespace mvc4.Controllers
{

	public class InstitucionesController : Controller
	{
		
		public JsonResult Get(){
			List<Instituciones> instituciones;
			using (var entities = new Medics()) instituciones = entities.Instituciones.ToList();

			var personasView = instituciones.Select(x => x.ToObject());
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public JsonResult GetDetails(int id){
			Instituciones instituciones;
			using (var entities = new Medics()){
				instituciones = entities.Instituciones.FirstOrDefault(x => x.IdInstitucion== id);
			}
			if (instituciones == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
			
			var personasView = instituciones.ToObject();
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public string PutResultadoAnalisis([FromUri] ResultadoAnalisisConsultaViewModel resultado){
			Mapper.CreateMap <ResultadoAnalisisConsultaViewModel, ResultadoAnalisisConsulta>();
			var resultados = Mapper.Map<ResultadoAnalisisConsultaViewModel, ResultadoAnalisisConsulta>(resultado);
			resultados.FechaRealizado = DateTime.Now;
			using (var entities = new Medics()){
				try{
					entities.AddToResultadoAnalisisConsulta(resultados);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.CreacionCorrecta.Value;
		}
	}
}