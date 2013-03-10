using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Procedimientos {
		public DescripcionViewModel ToObject()
		{
			Mapper.CreateMap<Procedimientos, DescripcionViewModel>();
			return Mapper.Map<Procedimientos, DescripcionViewModel>(this);
		}
	}
}