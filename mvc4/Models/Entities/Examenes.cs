using System;
using AutoMapper;
using mvc4.Models.EntitiesEditCreate;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Examenes {

		public Examenes GetDefaultExamene(Guid idAnalisys, Guid idPersona)
		{
			return new Examenes{
				idAnalisis = idAnalisys,
				IdPersona = idPersona,
				Fecha = DateTime.Now
			};
			
		}

		public void Update(ExamenesEditCreateModel newPersona)
		{
			Mapper.CreateMap<ExamenesEditCreateModel, Examenes>();
			Mapper.Map(newPersona,this);
		}

		public ExamenesViewModel ToObject()
		{
			Mapper.CreateMap<Examenes, ExamenesViewModel>();
			return Mapper.Map<Examenes, ExamenesViewModel>(this);
		}
	}
}