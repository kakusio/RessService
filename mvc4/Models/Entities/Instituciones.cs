using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Instituciones
	{
		public Instituciones GetDefaultInstitucion(int user_number, int IdProvincia)
		{
			return new Instituciones
			       	{
			       		Nombre = "Fake Nombre" + user_number,
			       		Direccion = "Fake Direccion " + user_number,
			       		Telefono = 8092441919 + user_number,
			       		Tipo = "Fake Tipo" + user_number,
			       		idProvincia = IdProvincia
			       	};
		}
		
		public InstitucionesViewModel ToObject(){
			Mapper.CreateMap<Instituciones, InstitucionesViewModel>();
			return Mapper.Map<Instituciones, InstitucionesViewModel>(this);
		}
	}
}