using System;
using System.Collections.Generic;

namespace mvc4.Models.EntitiesView
{
	public class HistorialMedicoViewModel
	{
		public Guid idPersona{ get; set; }
		public string Nombres { get; set; }
		public string Apellidos { get; set; }
		public List<DescripcionViewModel> AntecedentesToxicos { get; set; }
		public List<AlergiaViewModel> AntecedentesAlergico { get; set; }
		public List<DescripcionViewModel> AntecedentesProcedimientos { get; set; }
		public List<DescripcionViewModel> AntecedentesEnfermedades { get; set; }
		public List<DescripcionViewModel> EnfermedadesHereditarias { get; set; }
	}
}