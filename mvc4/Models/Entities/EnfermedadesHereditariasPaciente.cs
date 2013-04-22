using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class EnfermedadesHereditariasPaciente {
		public EnfermedadHereditariaViewModel ToObject(){
			Mapper.CreateMap<EnfermedadesHereditariasPaciente, EnfermedadHereditariaViewModel>();
			return Mapper.Map<EnfermedadesHereditariasPaciente, EnfermedadHereditariaViewModel>(this);
		}
	}
}