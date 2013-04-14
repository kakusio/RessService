using System;
using System.Collections.Generic;

namespace mvc4.Models.EntitiesView
{
	public class HistorialMedicoViewModel{
		public PersonasViewModel DatosPersonales { get; set; }

		public List<DescripcionViewModel> Toxicos { get; set; }
		public List<AlergiaViewModel> Alergias { get; set; }
		public List<DescripcionComentViewModel> Procedimientos { get; set; }
		public List<DescripcionComentViewModel> Enfermedades { get; set; }
		public List<DescripcionViewModel> EnfermedadesHereditarias { get; set; }
	}
}