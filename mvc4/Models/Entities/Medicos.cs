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
		public MedicosViewModel ToObject()
		{
			using (var entities = new Medics())
			{
				var persona = entities.Personas.FirstOrDefault(x => x.idPersona == idPersona);
				if (persona != null)
				{
					var personas = persona.ToObject();
					return new MedicosViewModel( personas);
				}
			}
			return null;
		}
	}
}