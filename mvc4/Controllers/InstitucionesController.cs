using System;
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