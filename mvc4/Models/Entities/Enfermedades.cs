using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Enfermedades {
		public DescripcionViewModel ToObject()
		{
			Mapper.CreateMap<Enfermedades, DescripcionViewModel>();
			return Mapper.Map<Enfermedades, DescripcionViewModel>(this);
		}
	}
}