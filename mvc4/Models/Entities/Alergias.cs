using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Alergias {
		public AlergiaViewModel ToObject()
		{
			Mapper.CreateMap<Alergias, AlergiaViewModel>();
			return Mapper.Map<Alergias, AlergiaViewModel>(this);
		}
	}
}