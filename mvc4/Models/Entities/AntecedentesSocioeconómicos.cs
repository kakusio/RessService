using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class AntecedentesSocioecon�micos {
		public SocioEconomicoViewModel ToObject(){
			Mapper.CreateMap<AntecedentesSocioecon�micos, SocioEconomicoViewModel>();
			return Mapper.Map<AntecedentesSocioecon�micos, SocioEconomicoViewModel>(this);
		}
	}
}