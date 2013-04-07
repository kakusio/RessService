using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class ResultadoAnalisisConsulta {
		public ResultadoAnalisisConsultaViewModel ToObject(){
			Mapper.CreateMap<ResultadoAnalisisConsulta, ResultadoAnalisisConsultaViewModel>();
			return Mapper.Map<ResultadoAnalisisConsulta, ResultadoAnalisisConsultaViewModel>(this);
		}
	}
}