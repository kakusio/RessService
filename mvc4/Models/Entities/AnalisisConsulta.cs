using System.Linq;
using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class AnalisisConsulta {
		public AnalisisConsultaViewModel AnalisisPendientes()
		{
			return ResultadoAnalisisConsulta.Any() ? null : ToObject();
		}

		public AnalisisConsultaViewModel ToObject(){
			Mapper.CreateMap<AnalisisConsulta, AnalisisConsultaViewModel>();
			return Mapper.Map<AnalisisConsulta, AnalisisConsultaViewModel>(this);
		}
	}
}