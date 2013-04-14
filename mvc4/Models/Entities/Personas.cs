using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using mvc4.Models.EntitiesEditCreate;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities{
	public partial class Personas{
		public Personas(){
			idPersona = Guid.NewGuid();
		}

		public void Update(PersonasEditModel newPersona){
			Mapper.CreateMap<PersonasEditModel, Personas>();
			Mapper.Map(newPersona, this);
		}

		public PersonasViewModel ToObject(){
			Mapper.CreateMap<Personas, PersonasViewModel>();
			return Mapper.Map<Personas, PersonasViewModel>(this);
		}

		public HistorialMedicoViewModel HistorialMedico(){
			var diagnosticoViewModels = Diagnostico.Select(x => x.ToObject());
			return new HistorialMedicoViewModel{
			       		DatosPersonales = ToObject(),
			       		Toxicos = Toxicos.Select(x => x.ToObject()).ToList(),
			       		Alergias = diagnosticoViewModels.SelectMany(x => x.AlergiasDiagnostico).ToList(),
			       		Procedimientos = DetallesProcedimientos.Select(x => x.ToObject()).ToList(),
			       		Enfermedades = diagnosticoViewModels.SelectMany(x => x.EnfermedadesDiagnostico).ToList(),
			       		EnfermedadesHereditarias = Enfermedades.Select(x => x.ToObject()).ToList()
			       	};
		}
		public IEnumerable<AnalisisConsultaViewModel> AnalisisPendientes(){
			var resultado = new List<AnalisisConsultaViewModel>();
			Consultas.Select(x => x.AnalisisPendientes()).ToList().Each(models =>			    {
			        if (models != null) resultado.AddRange(models);
			    });
			return resultado;
		}
	}
}