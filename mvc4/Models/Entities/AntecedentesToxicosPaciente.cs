using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class AntecedentesToxicosPaciente {
		public ToxicoViewModel ToObject(){
			Mapper.CreateMap<AntecedentesToxicosPaciente, ToxicoViewModel>();
			return Mapper.Map<AntecedentesToxicosPaciente, ToxicoViewModel>(this);
		}
	}
}