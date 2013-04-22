using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class AntecedentesSocioeconómicos {
		public SocioEconomicoViewModel ToObject(){
			Mapper.CreateMap<AntecedentesSocioeconómicos, SocioEconomicoViewModel>();
			return Mapper.Map<AntecedentesSocioeconómicos, SocioEconomicoViewModel>(this);
		}
	}
}