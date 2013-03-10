using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using mvc4.Models.Entities;
using mvc4.Models.EntitiesEditCreate;
using mvc4.Models.EntitiesView;

namespace mvc4.Controllers
{
	public class PersonasController : Controller
	{
		public JsonResult Get()
		{
			List<Personas> personas;
			using (var entities = new Medics())
			{
				personas = entities.Personas.ToList();
			}
			var personasView = personas.Select(x => x.ToObject());
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public JsonResult GetDetails(Guid id)
		{
			Personas persona;
			using (var entities = new Medics())
			{
				persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
			}
			if (persona == null) return Json("Id no valido", JsonRequestBehavior.AllowGet);
			
			var personasView = persona.ToObject();
			return Json(personasView, JsonRequestBehavior.AllowGet);
		}

		public JsonResult GetHistorial(Guid id)
		{
			Personas persona;
			using (var entities = new Medics())
			{
				persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return Json("Id no valido", JsonRequestBehavior.AllowGet);
				
				var historial = persona.HistorialMedico();
				return Json(historial, JsonRequestBehavior.AllowGet);
			}
		}

		public string AddPariente([FromUri] Guid idPersona, [FromUri] Guid idPariente)
		{
			using (var entities = new Medics())
			{
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == idPersona);
				var pariente = entities.Personas.FirstOrDefault(x => x.idPersona == idPariente);

				if (persona == null || pariente == null)return "Error con los Id.";
				try
				{
					persona.Personas2.Add(pariente);
					pariente.Personas2.Add(persona);
					entities.SaveChanges();
				}
				catch (Exception e)
				{
					return e.Message;
				}
				
			}
			return "Se a agregado un familiar.";
		}

		public JsonResult GetPersona ([FromUri] string Username)
		{
			Guid Id;
			using (var entities = new Medics())
			{
				var personas = entities.Personas.FirstOrDefault(x => x.Username == Username);
				if (personas == null)
					return  Json("Username no valido", JsonRequestBehavior.AllowGet);
				Id = personas.idPersona;
			}
			var json = GetMedico(Id);
			if (Equals(json.Data, "Id no valido"))
			{
				json = GetDetails(Id);
			}
			return json;
		}

		public JsonResult GetMedico([FromUri] Guid idMedico)
		{
			Medicos medico;
			using (var entities = new Medics())
			{
				medico = entities.Medicos.FirstOrDefault(x => x.idPersona == idMedico);
			}
			if (medico != null)
			{
				var medicoView = medico.ToObject();
				return Json(medicoView, JsonRequestBehavior.AllowGet);
			}
			return Json("Id no valido", JsonRequestBehavior.AllowGet);

		}

		public string AddPaciente([FromUri] Guid idMedico, [FromUri] Guid idPaciente)
		{
			using (var entities = new Medics())
			{
				var medico = entities.Medicos.FirstOrDefault(x => x.idPersona == idMedico);
				var paciente = entities.Personas.FirstOrDefault(x => x.idPersona == idPaciente);

				if (medico == null || paciente == null) return "Error con los Id";
				try
				{
					medico.Personas1.Add(paciente);
					entities.SaveChanges();
				}
				catch (Exception e)
				{
					return e.Message;
				}
			}
			return "Se a agregado un paciente.";
		}

		public string Post([FromUri] PersonasEditCreateModel persona)
		{
			Mapper.CreateMap <PersonasEditCreateModel, Personas>();
			var personas = Mapper.Map<PersonasEditCreateModel, Personas>(persona);

			using (var entities = new Medics())
			{
				try
				{
					entities.AddToPersonas(personas);
					entities.SaveChanges();
				}
				catch (Exception e)
				{
					return e.Message;
				}
			}
			return "You have Create the entity persona where Name = " + persona.Nombres;
		}

		public string Put(Guid id, [FromUri] PersonasEditModel persona)
		{
			using (var entities = new Medics())
			{
				var oldPersona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (oldPersona == null) return "Error para identificar la persona.";
				try
				{
					oldPersona.Update(persona);
					entities.SaveChanges();
				}
				catch (Exception e)
				{
					return e.Message;
				}
			}
			return "You have edit the entity persona where Id = " + id;
		}

		public string Delete(Guid id)
		{
			using (var entities = new Medics())
			{
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == id);
				if (persona == null) return "Error para borrar, persona no encontrada.";
				try
				{
					entities.Personas.DeleteObject(persona);
					entities.SaveChanges();
				}
				catch (Exception e)
				{
					return e.Message;
				}
			}
			return "You have delete the entity persona where Id = " + id;
		}
	}
}