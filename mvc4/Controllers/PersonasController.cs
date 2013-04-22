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
	public class PersonasController : Controller{
		public JsonResult Get(){
			List<Personas> personas;
			using (var entities = new Medics()) personas = entities.Personas.ToList();

			var personasView = personas.Select(x => x.ToObject());
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public JsonResult GetDetails(Guid id){
			Personas persona;
			using (var entities = new Medics()){
				persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
			}
			if (persona == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
			
			var personasView = persona.ToObject();
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public JsonResult GetHistorial(Guid id){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
				
				var historial = persona.HistorialMedico();
				return Json(historial, JsonRequestBehavior.AllowGet);
			}
		}

		public JsonResult GetAnalisisPendientes(Guid id){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
				var analisis_pendientes = persona.AnalisisPendientes();
				return Json(analisis_pendientes, JsonRequestBehavior.AllowGet);
			}
		}

		public JsonResult GetPacientes(Guid id){
			using (var entities = new Medics()){
				var medico = entities.Medicos.FirstOrDefault(x => x.idPersona == id);
				if (medico == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
				
				var personas = medico.Personas1.Select(x => x.ToObject()).ToList();
				return Json(personas, JsonRequestBehavior.AllowGet);
			}
		}

		public JsonResult GetMedicos(Guid id){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
				
				var historial = persona.Medicos1.Select(x => x.ToObject()).ToList();
				return Json(historial, JsonRequestBehavior.AllowGet);
			}
		}

		public string AddPariente([FromUri] Guid idPersona, [FromUri] Guid idPariente){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == idPersona);
				var pariente = entities.Personas.FirstOrDefault(x => x.idPersona == idPariente);

				if (persona == null || pariente == null) return Notificaciones.ErrorUsuario.Value;
				try{
					persona.Personas2.Add(pariente);
					pariente.Personas2.Add(persona);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
				
			}
			return Notificaciones.AgregacionCorrecta.Value;
		}

		public JsonResult GetPersona ([FromUri] string Username){
			Guid id;
			using (var entities = new Medics()){
				var personas = entities.Personas.FirstOrDefault(x => x.Username == Username);
				if (personas == null) return  Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
				id = personas.idPersona;
			}
			var json = GetMedico(id);
			if (Equals(json.Data, Notificaciones.ErrorUsuario.Value)) json = GetDetails(id);
			return json;
		}

		public JsonResult GetMedico([FromUri] Guid idMedico){
			using (var entities = new Medics()){
				var medico = entities.Medicos.FirstOrDefault(x => x.idPersona == idMedico);
				if (medico != null) return Json(medico.ToObject(), JsonRequestBehavior.AllowGet);
			}
			return Json(Notificaciones.ErrorUsuario.Value, JsonRequestBehavior.AllowGet);
		}

		public string AddPaciente([FromUri] Guid idMedico, [FromUri] Guid idPaciente){
			using (var entities = new Medics()){
				var medico = entities.Medicos.FirstOrDefault(x => x.idPersona == idMedico);
				var paciente = entities.Personas.FirstOrDefault(x => x.idPersona == idPaciente);

				if (medico == null || paciente == null) return Notificaciones.ErrorUsuario.Value;
				try{
					medico.Personas1.Add(paciente);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.AgregacionCorrecta.Value;
		}

		public string Post([FromUri] PersonasEditCreateModel persona){
			Mapper.CreateMap <PersonasEditCreateModel, Personas>();
			var personas = Mapper.Map<PersonasEditCreateModel, Personas>(persona);

			using (var entities = new Medics()){
				try{
					entities.AddToPersonas(personas);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.CreacionCorrecta.Value;
		}

		public string Put(Guid id, [FromUri] PersonasEditModel persona){
			using (var entities = new Medics()){
				var oldPersona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (oldPersona == null) return Notificaciones.ErrorUsuario.Value;
				try{
					oldPersona.Update(persona);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.EdicionCorrecta.Value;
		}

		public string Delete(Guid id){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return Notificaciones.ErrorUsuario.Value;
				try{
					entities.Personas.DeleteObject(persona);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.EliminacionCorrecta.Value;
		}

		public string DeleteMedico([FromUri] Guid id, [FromUri] Guid idMedico){
			using (var entities = new Medics()){
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				var medico = entities.Medicos.FirstOrDefault(x => x.idPersona == idMedico);

				if (medico == null || persona == null) return Notificaciones.ErrorUsuario.Value;
				try{
					persona.Medicos1.Remove(medico);
					entities.SaveChanges();
				}
				catch (Exception e){
					return e.Message;
				}
			}
			return Notificaciones.RemovidoCorrecta.Value;
		}
	}
}