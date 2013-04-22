using System.Linq;
using AutoMapper;
using mvc4.Models.EntitiesView;

namespace mvc4.Models.Entities
{
	public partial class Medicos
	{
		public Medicos GetDefaultMedico(int IdPersona)
		{
			return new Medicos
			       	{
			       		idMedico = IdPersona
			       	};
		}
		public MedicosViewModel ToObject(){
			var personas = Personas.ToObject();
			var institucionesNombre = Instituciones.Select(x => x.Nombre).ToList();
			var especialidadesDescripcion = Especialidades.Select(x => x.Descripcion).ToList();
			return new MedicosViewModel( personas, institucionesNombre, especialidadesDescripcion);
		}
	}
}