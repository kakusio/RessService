using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Toxicos {
		public DescripcionViewModel ToObject()
		{
			Mapper.CreateMap<Toxicos, DescripcionViewModel>();
			return Mapper.Map<Toxicos, DescripcionViewModel>(this);
		}
	}
}