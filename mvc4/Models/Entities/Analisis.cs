using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Analisis {
		public AnalisisViewModel ToObject()
		{
			Mapper.CreateMap<Analisis, AnalisisViewModel>();
			return Mapper.Map<Analisis, AnalisisViewModel>(this);
		}
	}
}